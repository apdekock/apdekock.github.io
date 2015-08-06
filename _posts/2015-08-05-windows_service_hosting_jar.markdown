---
layout: post
title:  "Java / .NET interop - Windows Service hosting a Java .jar"
date:   2015-08-05 14:56:37
quote:  "When life gives you lemonade, make lemons. Life'll be all like 'what?!' —   Phil Dunphy [Phil’s-osophy]"
categories: C#, Java, Spring, Java .NET interop
---

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
	Either grab the Spring Repo and build it to produce your Jar that hosts the service or just clone this [repo]() and install the service with an already built service jar. 
	
# Pre-requisites
	1. Java SDK installation
	2. Maven/Gradle Installation
	3. MS Visual Studio
	4. Clone the folling two repo's:
		* [spring ws](https://github.com/apdekock/gs-producing-web-service)
		* [Windows service host](https://github.com/apdekock/Java.NETWindowsService)
# Prep
	
	* For the purposes of this post lets use a pre-existing Spring web service, I  opted for the spring getting started guide sample: ["Producing a SOAP web service"](http://spring.io/guides/gs/producing-web-service/) which is at this [GitHub repo](https://github.com/spring-guides/gs-producing-web-service).
	
	* I forked the [GitHub repo](https://github.com/spring-guides/gs-producing-web-service.git) and added logging (_showing the EndPoint called and the Request Country_) for the purposes of this post as well as a batch file to run it as a stand alone service. That you can find [here](https://github.com/apdekock/gs-producing-web-service). 
	
	* I opened the project in [IntelliJ](https://www.jetbrains.com/idea/) and ran a [Maven](https://maven.apache.org/) Clean Install to produce my Jar _(gs-producing-web-service-0.1.0.jar)_ to be hosted in the Windows Service.
	
	![intelliJ_build_maven]({{ site.url }}/assets/java_net_post/maven_build_spring_sample.png "Maven Clean Install Spring Sample")

	* Execute the _*run.bat*_ file to run the Spring Web Service in a console application which hosts the web service at http://localhost:8080/ws <sup>(Why dont we just do this? - Because as soon as we close the console the process stops and our service dissapears. Hence, the windows service)</sup> A console shoudl appear as below with spring telling us what's going on.
	
	![Spring Test]({{ site.url }}/assets/java_net_post/running_spring_service.png "Spring WS running")
	
	* Once the service is running you can test it. I used SOAP UI. You will see the added logging come into play when we make service calls, I called the service 4 times, 3 with "Spain" as the request country and once with "France".
	
	![Spring Test SOAP UI]({{ site.url }}/assets/java_net_post/running_spring_service_soapUI.png "Spring WS running test")

# Hosting the Java API

	Running the _*run.bat*_  is essentially starting up the JVM and running our test web service. When the Windows Service executes a Process it is doing exactly that. It generates a host process executing what we provide it with.
  
	* Create a windows service. I'm using the vanilla Windows Service C# project template from MS Visual Studio 2013.
	
	![Create Windows Service]({{ site.url }}/assets/java_net_post/create_windows_service.png "Windows Service Vanilla Template c#")
	
	The Windows Service basically starts up the JVM with the arguments provided and has some additional functionality around logging. The process needs to report to the Windows Service what's going on - this is how we can log the Spring WS messages to the Windows Service log.
  
 # Important
 
  It relies on your Java installation path - needs to be set
	 %JAVA_HOME%
	* 
  
# Alternative

I did some research and found an awesome library in [Tanuki Software's Java Service Wrapper](http://wrapper.tanukisoftware.com/). It looks like an awesome tool with alot of [features](http://wrapper.tanukisoftware.com/doc/english/product-features.html) and will be able to provide the same functionality as this project with a few added benefits. 

## Moral:

So what can we take from Phil's infinite wisdom?

  * "When life gives you lemonade, make lemons. Life’ll be all like ‘what?!’" —   Phil Dunphy [Phil’s-osophy]"
 
    **_Reading the help documentation helps..._**