---
layout: post
title:  "Java / .NET interop - Windows Service hosting a Java .jar"
date:   2015-08-05 14:56:37
quote:  "When life gives you lemonade, make lemons. Life'll be all like 'what?!' —   Phil Dunphy [Phil’s-osophy]"
categories: C#, Java, Spring, Java .NET interop
---
### // SPLIT INTO 3 POSTS
1. SETUP SPRING
2. SETUP JAVAPROCESS HOST WINDOWS SERVICE
3. CONSUME WEB SERVICE FROM WINDOWS SERVICE

I recently got a requirement to integrate with a Java API. 
I've worked with Java before and [natch](http://www.urbandictionary.com/define.php?term=natch), the requirement came my way.

# Considerations

* This is a .NET shop and [Maven](https://maven.apache.org/) / [Gradle]() / [Spring](https://spring.io/) / [IntelliJ](https://www.jetbrains.com/idea/) are foreign concepts. <sup>(The company firewall wouldn't let me trough to the Maven repo, nor was there an internal repo that I could find.)</sup>
* Thus, in order to ensure the solution is maintainable by all, most of the logic needed to reside in the .NET space and the least amount of Java should be written.
* The Java API needs to be hosted regardless of any user being logged, it needs to run as a background process (like a [daemon](https://en.wikipedia.org/wiki/Daemon_(computing)) in a Unix environment). <sup>(java.exe -jar on a console was thus not an option)</sup>
* The interaction with Java should be seamless/abstracted away if possible.
* Reduce coupling between the Java API and the .NET code, i.e. no [jni4net](http://jni4net.com/) that would require intricate knowledge of the API's internals as well as require both the Java API to emit to .NET, and vice versa.<sup>(which would require the API to implement jni4net, which is another unwanted dependency, and would be just for this implementation)</sup>

# Drawing lines

[![Design]({{ site.url }}/assets/DesignJavaHost.svg "Courtesy of https://www.draw.io/")](https://www.draw.io/)
 
Taking all of this under consideration:

* Wrap the Java API in a SOAP service.
  
  _This enables seamless, loosely coupled integration between the .NET application which can then just consume the service like any other SOAP based web service._

* Write as little Java as possible through exposing the relevant Java API functionality as vanilla as possible as operations in the Web Service.
  
  _Any orchestration logic such as polling should reside in the .NET application where anyone can maintain it._

* Wrap the SOAP Service (that wraps the Java API) in a Windows Service.
  
  _That serves the web service as a background operation which means it is not tied to any user sessions. A windows service has the additional capability of being configured to starting automatically on the occasional server reboot as well as run under credentials specific to the operation._

# Steps:

* Either grab the Spring Repo and build it to produce your Jar that hosts the service or just clone this [repo]() and install the service with an already built service jar. 
	
# Pre-requisites
1. Java SDK installation
2. Maven/Gradle Installation
3. MS Visual Studio
4. Clone the folling two repo's:
* [spring ws](https://github.com/apdekock/gs-producing-web-service)
* [Windows service host](https://github.com/apdekock/Java.NETWindowsService)

OR 
* clone the [Windows service host](https://github.com/apdekock/Java.NETWindowsService) repo only as it includes the Java Jar and the executable for the Console app consuming the service.

# Prep
	
* For the purposes of this post lets use a pre-existing Spring web service, I  opted for the spring getting started guide sample: ["Producing a SOAP web service"](http://spring.io/guides/gs/producing-web-service/) which is at this [GitHub repo](https://github.com/spring-guides/gs-producing-web-service).

* I forked the [GitHub repo](https://github.com/spring-guides/gs-producing-web-service.git) and added logging (_showing the EndPoint called and the Request Country_) for the purposes of this post as well as a batch file to run it as a stand alone service. That you can find [here](https://github.com/apdekock/gs-producing-web-service). 

* I opened the project in [IntelliJ](https://www.jetbrains.com/idea/) and ran a [Maven](https://maven.apache.org/) Clean Install to produce my Jar _(gs-producing-web-service-0.1.0.jar)_ to be hosted in the Windows Service.

![intelliJ_build_maven]({{ site.url }}/assets/java_net_post/maven_build_spring_sample.png "Maven Clean Install Spring Sample")

* Execute the _run.bat_ file to run the Spring Web Service in a console application which hosts the web service at http://localhost:8080/ws <sup>(Why dont we just do this? - Because as soon as we close the console the process stops and our service dissapears. Hence, the windows service)</sup> A console shoudl appear as below with spring telling us what's going on.

![Spring Test]({{ site.url }}/assets/java_net_post/running_spring_service.png "Spring WS running")

* Once the service is running you can test it. I used SOAP UI. You will see the added logging come into play when we make service calls, I called the service 4 times, 3 with "Spain" as the request country and once with "France".
	
![Spring Test SOAP UI]({{ site.url }}/assets/java_net_post/running_spring_service_soapUI.png "Spring WS running test")

# Hosting the Java API

Running the **_run.bat_**  is essentially starting up the JVM and running our test web service. When the Windows Service executes a Process it is doing exactly that. It generates a host process executing what we provide it with.

* Create a windows service. I'm using the vanilla Windows Service C# project template from MS Visual Studio 2013.
	
![Create Windows Service]({{ site.url }}/assets/java_net_post/create_windows_service.png "Windows Service Vanilla Template c#")

If you had a look at the run.bat file - you'll see we are replicating that command line syntax as a background process managed from the Windows Service.
I.E. Mapping the operations of start and stop of the service to the start and stop of the process.
We add some logging and instead of writing it to the console where it will be lost we write it to a log file. (alternatively you could log to the event log).

The Windows Service basically starts up the JVM with the arguments provided and has some additional functionality around logging. The process needs to report to the Windows Service what's going on - this is how we can log the Spring WS messages to the Windows Service log.

Below is the project structure which I'll briefly discuss. Feel free to have a look around in the code - for now - I'll just pick pertinent snippets to discuss some of the fine points I have encountered.
![Project Structure]({{ site.url }}/assets/java_net_post/project_structure.png "Windows Service Project Structure") 

The logging mechanism employed in this project is NLog with the file target configured.

* The **[JavaWindowsService.cs]** is the main class in our solution, it is the one instantiated by **[Program.cs]** when the service starts up. It inherits from ServiceBase and  overrides two methods, the _OnStart()_ and _OnStop()_ where the logic required to run and stop the Java API needs to be incorporated.

The _OnStart()_ method retrieves the start arguments from the app.config AppSettings section.

{% highlight C# %}
protected override void OnStart(string[] args)
{
	var processStartArguments = GetArgsFromConfig();
	_logger.Info("Starting with args: {0}", processStartArguments);
	try
	{
		var javaProcess = new JavaProcess(processStartArguments);
		javaProcess.OnMessage += OnMessage;
		javaProcess.OnExit += OnExited;
		_javaProcessId = javaProcess.Start();
	}
	catch (Exception exception)
	{
		_logger.Error(exception);
		throw;
	}
}
{% endhighlight %}

It takes all the app settings as arguments in order - regardless of key name. So first entry is first argument. _**arg0**_ then _**arg1**_ then _**charlie123**_ etc...

{% highlight XML %}
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
  </startup>
  <appSettings>
    <add key="arg0" value="-jar" />
    <add key="arg1" value="C:\ws\complete\target\gs-producing-web-service-0.1.0.jar" />
  </appSettings>
  <system.web>
    <membership defaultProvider="ClientAuthenticationMembershipProvider">
      <providers>
        <add name="ClientAuthenticationMembershipProvider"
             type="System.Web.ClientServices.Providers.ClientFormsAuthenticationMembershipProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
             serviceUri="" />
      </providers>
    </membership>
    <roleManager defaultProvider="ClientRoleProvider" enabled="true">
      <providers>
        <add name="ClientRoleProvider" type="System.Web.ClientServices.Providers.ClientRoleProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
             serviceUri="" cacheTimeout="86400" />
      </providers>
    </roleManager>
  </system.web>
</configuration>
{% endhighlight %}

Then it instantiates a **[JavaProcess]** and assigns handlers to the events the process emits. After which the process is started and returns the process ID required to keep tabs on our running process. WRT error handling - if an exception occurs we log it and then **throw;** again because we do not want the service to start up in a faulted state.

The _OnMessage()_ and _OnExited()_ event handlers simply log messages with the appropriate prefix.

{% highlight C# %}
private void OnMessage(string message)
{
	_logger.Info("JVM: {0}", message);
}

private void OnExited(int exitCode)
{
	_logger.Error("Java process stopped, exit code:" + exitCode);
}
{% endhighlight %}

The _OnStop()_ delegates to the _StopProcess()_ method which employs the static processById field to retrieve the process and issue a _Kill()_ command.
The _WaitForExit()_ method prevents the service from reporting the stopped state prematurely, and waits for the **[JavaProcess]** to shut down before assuming the stopped state.

{% highlight C# %}
protected override void OnStop()
{
	_logger.Info("Stop");
	try
	{
		StopProcess();
	}
	catch (Exception exception)
	{
		_logger.Error(exception);
	}
}

private void StopProcess()
{
	var processById = Process.GetProcessById(_javaProcessId);
	processById.Kill();
	processById.WaitForExit();
}
{% endhighlight %}

# .NET JavaProcess

This heading is misleading, I'll keep it anyway.
There are two public events that emits messages, _OnMessage_ and _OnExit_, pretty self explanatory, but the code will follow.
The **[JavaProcess]** has a constructor for passing the start arguments to the underlying JVM **Java.exe** process.
We build up the **ProcessStartInfo** which will be employed in starting the process.

* The **[JavaProcess]** relies on the %JAVA_HOME% environment variable in order to locate the Java installation on the machine.
  * The ProcessStartInfo parameters:
	* _UseShellExecute = false_ allows the redirection the input, output, and error streams from the process.
	* _CreateNoWindow = true_ prevents another console form opening (this is a background task).
	* _RedirectStandardError = true_ redirect error messages to _**ErrorDataReceived**_ event subscribers.
	* _RedirectStandardOutput = true_ redirect error messages to _**OutputDataReceived**_ event subscribers.
	* _RedirectStandardInput = true_ don't accept input from other than the _StandardInput_ property (not used).
	
{% highlight C# %}
public class JavaProcess
{
	private readonly ProcessStartInfo _startInfo;

	public event Action<string> OnMessage;
	public event Action<int> OnExit;

	public JavaProcess(string processStartArguments)
	{
		var javaPath = GetJavaPath(Environment.GetEnvironmentVariable("JAVA_HOME"));

		_startInfo = new ProcessStartInfo(javaPath, processStartArguments)
		{
			UseShellExecute = false,
			CreateNoWindow = true,
			RedirectStandardError = true,
			RedirectStandardOutput = true,
			RedirectStandardInput = true
		};
	}
	...
}
{% endhighlight %}

The only place a **[JavaException]** is thrown is in the _GetJavaPath(...)_ method. If you have installed the JAVA runtime, either you don't have the environment variable set or the environment variable path is incorrectly set.

{% highlight C# %}
private string GetJavaPath(string javaHomePathEnvironmentVariable)
{
	var javaPath = string.Format(@"{0}\bin\java.exe", javaHomePathEnvironmentVariable);

	if (string.IsNullOrWhiteSpace(javaHomePathEnvironmentVariable))
	{
		throw new JavaException(
			"Error: JAVA_HOME is set to an invalid directory. JAVA_HOME = '%JAVA_HOME%' Please set the JAVA_HOME variable in your environment to match the location of your Java installation.");
	}
	if (!File.Exists(javaPath))
	{
		throw new JavaException(
			"Error: Please confirm you have a valid Java installation. And please set the JAVA_HOME = '%JAVA_HOME%' variable in your environment to match the location of your Java installation. ");
	}

	return javaPath;
}
{% endhighlight %}

The _Start()_ command issued to the **[JavaProcess]** from the Windows Service _OnStart()_ instantiates a new **Process** with the **ProcessStartInfo** created in the constructor.
The  _OutputDataReceived_ and _ErrorDataReceived_ events are subscribed to with the _RaiseMessageEvent_ event handler as in this case no distinction should be made between the two types of messages, both are reported the same from a JavaService perspective as an internal error to the process being hosted does not necessarily mean a fatal exception and should not affect the Host process.

{% highlight C# %}
private void RaiseMessageEvent(object sender, DataReceivedEventArgs e)
{
	if (OnMessage != null) OnMessage(e.Data);
}		
{% endhighlight %}

The _Exited_ event is subscribed to again form the exposed _OnExit_ event handler to inform the service that the process has stopped. At present this is just logged in the Windows Service but some fault tolerance, a restart or some recovery mechanism could be incorporated here.

{% highlight C# %}
public int Start()
{
	var process = new Process { StartInfo = _startInfo };

	process.OutputDataReceived += RaiseMessageEvent;
	process.ErrorDataReceived += RaiseMessageEvent;
	process.Exited += (sender, e) =>
	{
		if (OnExit != null) OnExit(process.ExitCode);
	};

	process.Start();

	process.BeginOutputReadLine();
	process.BeginErrorReadLine();

	return process.Id;
}
{% endhighlight %}

The process is started and the _BeginOutputReadLine()_ and _BeginErrorReadLine()_ statements are required to start redirecting the output and error streams to the subscribed event handlers. The process ID is returned to the caller for later use, such as issuing a stop command.

# Consuming the service

Now we add a service reference to our .NET application that needs to use the Java API.

* Run the spring ws _**run.bat**_ file - to get the service up and running - to auto generate our proxy classes for the .NET app.

![Spring WS Reference]({{ site.url }}/assets/java_net_post/running_spring_service.png "Spring WS running reference")

* Create a console application.

![New Console Application Template]({{ site.url }}/assets/java_net_post/new_console.png "New Console Application Template")

* Replace the Program Class code with the below snippet.
{% highlight C# %}
using System;
using ConsoleApplication.JavaAPIEndPoint;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a country");
            while (true)
            {
                var readLine = Console.ReadLine();
                if (readLine != null && readLine.ToLower() == "exit") break;

                using (CountriesPortClient client = new CountriesPortClient())
                {
                    try
                    {
                        var getCountryResponse = client.getCountry(new getCountryRequest() { name = readLine });
                        Console.WriteLine(getCountryResponse.country.capital);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
{% endhighlight %}

* Add Service reference to console application using the http://localhost:8080/ws/countries.wsdl EndPoint. 
Right click on the project and click add service reference.

![Add Service Reference]({{ site.url }}/assets/java_net_post/addServiceReference.png "Add Service Reference")
 
![Add Service Reference Console]({{ site.url }}/assets/java_net_post/console_add_service.png "Reference EndPoint")
 
* Run the console app and type in a country: "Spain"
![.NET Console Application consuming Java API]({{ site.url }}/assets/java_net_post/running_spring_service_consumingService.png "Consuming Java API")

* Stop the _**run.bat**_ process and close the .NET Console Application.

# Installing the service 

* Install the Windows Service and start it.

	sc create ......

* Start the .NET Console Application and retest that the Java API is being consumed.

# Improvements

* Right now it can host only one process - a static field is used to keep the process id reference. Looking at something like a Dictionary to keep track of instances spawned of a process hosted could allow multiple JavaProcesses  to run on service start up.
* Logging seems pretty vanilla and introducing post sharp or another AOP Framework to implement the cross-cutting aspect could be beneficial - especially as the project grows. (The logging Advice could point to NLog, I'll post this some other time.)
* Fault tolerance / some sort of auto detection and auto recovery should the JavaProcess fails could also be introduced. Such as when down - restart / attempt this for three tries.

# Alternative

I did some research and found an awesome library in [Tanuki Software's Java Service Wrapper](http://wrapper.tanukisoftware.com/). It looks like an awesome tool with alot of [features](http://wrapper.tanukisoftware.com/doc/english/product-features.html) and will be able to provide the same functionality as this project with a few added benefits. 

## Moral:

So what can we take from Phil's infinite wisdom?

  * "When life gives you lemonade, make lemons. Life’ll be all like ‘what?!’" —   Phil Dunphy [Phil’s-osophy]"
 
    **_Reading the help documentation helps..._**