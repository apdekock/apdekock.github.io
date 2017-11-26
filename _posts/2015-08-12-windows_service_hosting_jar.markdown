---
layout: post
title:  "Java / .NET interop - Windows Service hosting a Java .jar"
date:   2015-08-12 14:56:37
quote:  "When life gives you lemonade, make lemons. Life'll be all like 'what?!' —   Phil Dunphy [Phil’s-osophy]"
categories: C#, Java, Spring, Java .NET interop
---
## Intro

We recently received a requirement to integrate with a Java API.
I've worked with Java before and [natch](http://www.urbandictionary.com/define.php?term=natch), the requirement came my way.

## Considerations

* This is a .NET shop and [Maven](https://maven.apache.org/) / [Gradle](https://gradle.org/) / [Spring](https://spring.io/) / [IntelliJ](https://www.jetbrains.com/idea/) are foreign concepts (the company firewall wouldn't let me trough to the [Maven](https://maven.apache.org/) repo, nor was there an internal repo that I could find).  Thus, in order to ensure the solution is maintainable by anyone in the team, most of the logic needed to reside in the .NET space and the least amount of Java had to be written.

## Requirements

* The interaction with Java should be seamless.
* There should be minimal to no coupling between the Java API and the .NET code. This meant no [jni4net](http://jni4net.com/) that would require intricate knowledge of the API's internals and in addition it will require the Java API to emit to our .NET application, and vice versa.
	<sup>(The implementation of [jni4net](http://jni4net.com/) in the Java API was not an option anyway as it would require additional support from the writers of the API for my specific situation.)</sup>
* The Java API needs to be hosted regardless of any user being logged in, it needs to run as a background process (like a [Daemon](https://en.wikipedia.org/wiki/Daemon_(computing)) in a Unix environment).[^1]

[^1]:java.exe -jar on a console was thus not an option.
 
## The result of ruminating on the constraints

[![Design]({{ site.url }}/assets/java_net_post/DesignJavaHost.svg "Courtesy of https://www.draw.io/")](https://www.draw.io/)

* **Seamless, loosely coupled, highly cohesive integration between the .NET application and the Java API** by _**wrapping the Java API in a web service**_ that can then just be consumed like any other SOAP based web service.

* **Write as little Java as possible** by _**exposing the required Java API functionality as vanilla as possible in the web service**_. The code on the .NET side is then automatically created through the service proxy class generation tools in Visual Studio OR [Svcutil.exe](https://msdn.microsoft.com/en-us/library/aa347733(v=vs.110).aspx). _**Any orchestration logic such as polling should then reside in the .NET application code.**_

* **Run the Web Service (that wraps the Java API**[^2]**) as a background application** by wrapping it in a _**Windows Service**_. _The windows service hosts the web service as a background operation which means it is not tied to any user session._ A windows service has the additional capability of being configured to starting automatically on the occasional server reboot as well as run under elevated credentials specific to the operation.

[^2]:[..in the house that Jack built.](https://en.wikipedia.org/wiki/This_Is_the_House_That_Jack_Built)

## Pre-requisites
1. [Java SDK](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
2. [Maven](https://maven.apache.org/) (optionally [Gradle](https://gradle.org/))
3. [MS Visual Studio 2013](https://www.visualstudio.com/)
4. [Git](https://git-scm.com/)

## Paths

Either start with the **Getting started** section below...

**OR** 

...**clone this [Java.NETWindowsService repo](https://github.com/apdekock/Java.NETWindowsService)** with the pre-compiled _Spring Java SOAP service (that wraps the test Java API[^3])_ as well as the test _.NET console application[^4]_ that consumes the SOAP based web service **. Then install and start the compiled service and run the .NET console application executable[^5]**.
  
[^3]:[Repo location for Java API and batch file to run.](https://github.com/apdekock/Java.NETWindowsService/tree/master/Java.NETWindowsService/JavaAPI)
[^4]:[Repo location for .Net Console Application](https://github.com/apdekock/Java.NETWindowsService/tree/master/Java.NETWindowsService/.NETApp)
[^5]:see the **Quick Guide** section at the end.

## Getting started

For the purposes of this post I used a pre-existing Spring SOAP web service that I borrowed from the spring getting started guide: ["Producing a SOAP web service"](http://spring.io/guides/gs/producing-web-service/) which is at this [GitHub repo](https://github.com/spring-guides/gs-producing-web-service).

* I forked the [_"Producing a SOAP web service"_ GitHub repo](https://github.com/spring-guides/gs-producing-web-service.git) > [here](https://github.com/apdekock/gs-producing-web-service) and,
  - ...added **additional logging** (_for demonstration purposes that shows the Endpoint called and the Country parameter in the service request_).
  -  ...added a **run.bat** batch file to run the compiled sample jar as a stand alone service.
 
1. Clone the [_"Producing a SOAP web service"_ GitHub repo](https://github.com/apdekock/gs-producing-web-service) altered by me.

2. Open the project in [IntelliJ](https://www.jetbrains.com/idea/) and run a **mvn clean install** to produce a jar file _(gs-producing-web-service-0.1.0.jar) which will serve as both, the Java API being wrapped, and the web service that will be exposed from the Windows Service_.
![intelliJ_build_maven]({{ site.url }}/assets/java_net_post/maven_build_spring_sample.PNG "Maven clean install Spring Sample")

3. Execute the _**run.bat**_ file to run the Spring web service[^6] which is hosted at [http://localhost:8080/ws](http://localhost:8080/ws). 
A console should appear as below with Spring telling us what's going on.
![Spring Test]({{ site.url }}/assets/java_net_post/running_spring_service.PNG "Spring WS running")

4. Test the service once it is up and running. I used [SoapUI](http://www.soapui.org/) by SMARTBEAR[^7]. In the previous screen shot, you will see the additional logging come into play when a few service calls are made. I called the service 4 times, three times with "Spain" as the request country and once with "France".
![Spring Test SOAP UI]({{ site.url }}/assets/java_net_post/running_spring_service_soapUI.PNG "Spring WS running test")

[^6]:Why don't I just do this? - Because as soon as I close the console the process stops and our service disappears. Hence, the Windows Service.
[^7]:Adding the service to the project - Right click on **Projects** > **New SOAP Project** and in the _Initial  WSDL_ field paste: [http://localhost:8080/ws/countries.wsdl](http://localhost:8080/ws/countries.wsdl)

## Hosting the Java API as a Windows Service

Running the **_run.bat_** file in the console is essentially starting up the JVM and running our test web service (that wraps the Java API) that I want to consume from a .NET application. When the Windows Service executes a Process it is doing exactly that, only as a background process devoid of any dependency on a logged in user. <sup>(The windows service still needs to run under a user account though and defaults to local system account.)</sup>

This project replicates the command line execution of a Spring web service host as a background process, but managed from the Windows Service. The start and stop operations of the service are mapped to the start and stop of the hosted process. The project also ensures output is redirected from the hosted process into a logging mechanism to prevent the loss of feedback from the process that is hosted in the Windows Service. 

The logging mechanism employed in this project is: [NLog](http://nlog-project.org/), with a file target configured (alternatively you could log to the [EventLog](https://msdn.microsoft.com/en-us/library/system.diagnostics.eventlog(v=vs.110).aspx) under the Windows Service name).

# Solution overview
![ProjectStructure]({{ site.url }}/assets/java_net_post/project_structure.PNG "Windows Service Project Structure") 

# Windows Service
  
* I created a Windows Service using the vanilla Windows Service C# project template from MS Visual Studio 2013.
![Create Windows Service]({{ site.url }}/assets/java_net_post/create_windows_service.PNG "Windows Service Vanilla Template c#")

* The **[JavaWindowsService.cs]** is the main class in the solution. It is instantiated by **[Program.cs]** when the service starts up. It inherits from **[ServiceBase]** and overrides two methods, the _OnStart()_ and _OnStop()_, where the logic required to start and stop the Java API process needs to be incorporated.

* The _OnStart()_ method retrieves the start arguments from the _**app.config**_ _AppSettings_ section.
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
* A **[JavaProcess]** is instantiated and event handlers are assigned to the events that the process emits. The process is started and the process ID is returned to keep track of the process. _If an exception occurs it is logged and then re-thrown again --- **throw;**, because **I do not want the service to start up in a faulted state or lose the stack trace.**_

* _Config args_: All the app settings are used as arguments in order - regardless of key name. So first entry is first argument. _**arg0**_ then _**arg1**_ then _**charlie123**_ etc...
{% highlight XML %}
<?XML version="1.0" encoding="utf-8"?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
  </startup>
  <appSettings>
    <add key="arg0" value="-jar" />
    <add key="arg1" value="gs-producing-web-service-0.1.0.jar" />
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

* The _OnMessage()_ and _OnExited()_ event handlers simply log messages with the appropriate descriptive prefix.
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

* The _OnStop()_ method delegates to the _StopProcess()_ method which employs the static _[processById]_ field to retrieve a reference to the process. The reference is retrieved in order to issue _Kill()_ commands against.
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
{% endhighlight %}

* The _WaitForExit()_ method prevents the service from reporting the stopped state prematurely, and waits for the **[JavaProcess]** to shut down before entering a stopped state.
{% highlight C# %}
private void StopProcess()
{
    var processById = Process.GetProcessById(_javaProcessId);
    processById.Kill();
    processById.WaitForExit();
}
{% endhighlight %}

# .NET _**[JavaProcess.cs]**_

* There are two public events that emit output messages, _OnMessage_ and _OnExit_, pretty self explanatory, but the code will follow.

* The **[JavaProcess]** has a constructor for passing the start arguments to the underlying JVM **Java.exe** process.
  * The **[JavaProcess]** relies on the _%JAVA_HOME%_ environment variable in order to locate the Java installation on the machine.
    * The ProcessStartInfo parameters:
      * _UseShellExecute = false_ _**allows redirection**_ of the input, output, and error streams from the process.
      * _CreateNoWindow = true_ _**prevents another console**_ form opening.
      * _RedirectStandardError = true_ redirect error messages to _**ErrorDataReceived**_ event subscribers.
      * _RedirectStandardOutput = true_ redirect error messages to _**OutputDataReceived**_ event subscribers.
      * _RedirectStandardInput = true_ don't accept input from other than the _**StandardInput**_ property.<sup>(Not employed by this solution.)</sup>
	
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

* The only place a **[JavaException]** is thrown is in the _GetJavaPath(...)_ method. If you encounter a **[JavaException]**, _**and you have installed the JAVA runtime**_, either you don't have the environment variable set or the environment variable path is incorrectly set.

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

* The  _OutputDataReceived_ and _ErrorDataReceived_ events are subscribed to with the _RaiseMessageEvent_ event handler. In this case no distinction should be made between the two types of messages, both are reported the same[^8].
 
[^8]: An internal error to the process being hosted should not necessarily be interpreted as a fatal exception and should not affect the hosting process.

{% highlight C# %}
private void RaiseMessageEvent(object sender, DataReceivedEventArgs e)
{
    if (OnMessage != null) OnMessage(e.Data);
}		
{% endhighlight %}

* The _Exited_ event is subscribed to by the exposed _OnExit_ event handler to inform the service when the process has stopped. <sup>At present this is just logged in the Windows Service but some fault tolerance, a restart or some recovery mechanism could be incorporated here.</sup>

* From the _OnStart()_ method the Windows Service the _Start()_ command is issued to the **[JavaProcess]**. It instantiates a new **Process** with the **ProcessStartInfo** created in the constructor as the __startInfo_.

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

* Once the process is started the _BeginOutputReadLine()_ and _BeginErrorReadLine()_ statements are required to start redirecting the output and error streams to the subscribed event handlers.

## Consuming the API through the web service

# Create a console application
* Create a new vanilla C# console application.
![New Console Application Template]({{ site.url }}/assets/java_net_post/new_console.PNG "New Console Application Template")

Now add a service reference to the .NET application in order to consume the web service that wraps the Java API[^2].

* Run the _**run.bat**_ file from the altered ["Producing a SOAP web service"](https://github.com/apdekock/gs-producing-web-service) project - to get the service up and running.
![Spring WS Reference]({{ site.url }}/assets/java_net_post/running_spring_service.PNG "Spring WS running reference")

*  Right click on the _Project_ > _Add_ > _Service Reference..._ --- Add a service reference to the console application using the end point: [http://localhost:8080/ws/countries.wsdl](http://localhost:8080/ws/countries.wsdl).
![Add Service Reference]({{ site.url }}/assets/java_net_post/addServiceReference.PNG "Add Service Reference")
![Add Service Reference Console]({{ site.url }}/assets/java_net_post/console_add_service.PNG "Reference EndPoint")
 
* Replace the Program Class (in the _**[Program.cs]**_ file) code with the below snippet.
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

# Test 

* Run the console application and test the Java API by typing in a country like _Spain_.
![.NET Console Application consuming Java API]({{ site.url }}/assets/java_net_post/running_spring_service_consumingService.PNG "Consuming Java API")

* Stop the _**run.bat**_ process and close the .NET Console Application.

## Installing/Uninstalling the service 

# Install the Windows Service
  * I used the [sc.exe](https://technet.microsoft.com/en-us/library/cc990289.aspx)[^9] tool. Below is a simple version I employed to test this service (run from the _../bin/debug_ path). _**Important:** The space after the **=** sign is required!_
	* _**sc create testJavaWindowsService binpath= "Java.NETWindowsService.exe"**_
	  * The installed but stopped service should look like below.
	    ![Installed Windows Service]({{ site.url }}/assets/java_net_post/installedService.PNG "Installed Windows Service")

[^9]: Installing a Windows Service can be done either through the [installutil.exe](https://msdn.microsoft.com/en-us/library/sd8zc8ha(v=vs.110).aspx) that ships with the .NET framework or the [sc.exe](https://technet.microsoft.com/en-us/library/cc990289.aspx) utility that is native to, and naturally occurs in, the Windows habitat (from Vista and up).

# Uninstalling the Windows Service
  * It is not required to uninstall the Windows Service with each change you would like to deploy locally, however, it is advisable to stop the service, uninstall it, replace the altered assembly and re-install the service.
	1. _**sc stop testJavaWindowsService**_
	2. _**sc delete testJavaWindowsService**_
	3. replace the altered assembly
	4. _**sc create testJavaWindowsService binpath= "Java.NETWindowsService.exe"**_
	
## Testing it all together
  
# Start the service
  * You can start the service by pressing the _**[Play]**_ button (red rectangle in the _**Install the Windows Service**_ screen shot).
  
  OR
  
  * Start the service via another simple [sc.exe](https://technet.microsoft.com/en-us/library/cc990289.aspx) command.
    * _**sc start testJavaWindowsService**_

# Test	
  * Start the .NET Console Application and retest, much like the previous _**Test**_ section, but this time - testing that the Java API is correctly consumed when running the Spring web service (Java API wrapper) as a Windows Service.
    * Monitoring the hosted process **([JavaProcess])** passes along the messages, previously logged to the console, to the Windows Service that then employs [NLog](http://nlog-project.org/).	
      * I used BareTail to monitor the log files produced by [NLog](http://nlog-project.org/). The location & name of the log file is specified in the _NLog.config_ file: _${basedir}/logs/${shortdate}.log_.

![BareTail]({{ site.url }}/assets/java_net_post/baretail.PNG "BareTail [NLog](http://nlog-project.org/)")

# Additional parameters                                                                                                                            
  * _**start=** [auto]_ --- sets the service to start automatically on OS boot up.                                                                             
  * _**obj=** [useraccountname]_ --- sets the User Account under which the service should run - in certain cases elevated privileges might be required.      
  * _**password=** [useraccountpassword]_ --- sets the password for the User Account under which the service should run.                                     
  * _**depend=** [servicename]_ --- specifies a service that this one depends on,the API might need to wait for another service to startup first - like a database server that also runs as a service.    
  * _**displayname=** [pretty name]_ --- a more descriptive name for the windows service.                                                                            

## Improvements

* The Windows Service can host only one **[JavaProcess]** - a static field is used to keep reference to the running process ID.
* Logging seems pretty vanilla and introducing [PostSharp](https://www.postsharp.net/) or another [AOP](https://en.wikipedia.org/wiki/Aspect-oriented_programming) Framework to implement this cross-cutting concern could be beneficial - especially as the project grows. (The logging Advice could still point to [NLog](http://nlog-project.org/), I'll post this some other time.)
* Fault tolerance / some sort of auto recovery should the **[JavaProcess]** stop could also be introduced.

## Alternatives

* I did some research and found an awesome library in [Tanuki Software's Java Service Wrapper](http://wrapper.tanukisoftware.com/). It looks like an awesome tool with a lot of [features](http://wrapper.tanukisoftware.com/doc/english/product-features.html) and will be able to provide the same functionality as this project with a few added benefits.
* If you have the ability to alter both the Java and .NET code - [jni4net](http://jni4net.com/) is an option.

##**Moral:**

So what can we take from Phil's infinite wisdom?

  * "When life gives you lemonade, make lemons. Life’ll be all like ‘what?!’" —   Phil Dunphy [Phil’s-osophy]
 
    **_Shock and awe life[^10]..., and there are ways of making .NET and Java work together with vanilla mechanisms at your disposal, whilst still remaining loosely coupled and highly cohesive._**
	
[^10]:[Shock and awe](https://en.wikipedia.org/wiki/Shock_and_awe)

##**Quick Guide:** 
1. Clone [Java.NETWindowsService repo](https://github.com/apdekock/Java.NETWindowsService). 
2. Compile the solution.
3. Install and Start the compiled service.<sup> see the **Installing/Uninstalling the service** section on how to install the service.</sup> 
4. Run the _**ConsoleApplication.exe**_ executable located in the _.NETApp_ folder of the cloned repo.

##Footnotes