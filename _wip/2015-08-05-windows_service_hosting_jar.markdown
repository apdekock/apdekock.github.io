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

* This is a .NET shop and [Maven](https://maven.apache.org/) / [Ant](http://ant.apache.org/) / [Spring](https://spring.io/) / [IntelliJ](https://www.jetbrains.com/idea/) are foreign concepts. <sup>(The company firewall wouldn't let me trough to the Maven repo, nor was there an internal repo that I could find.)</sup>
* Thus, in order to ensure the solution is maintainable by all, most of the logic needed to reside in the .NET space and the least amount of Java should be written.
* The Java API needs to be hosted regardless of any user being logged, it needs to run as a background process (like a [daemon](https://en.wikipedia.org/wiki/Daemon_(computing)) in a Unix environment). <sup>(java.exe -jar on a console was thus not an option)</sup>
* The interaction with Java should be seamless/abstracted away if possible.
* Reduce coupling between the Java API and the .NET code, i.e. no [jni4net](http://jni4net.com/) that would require intricate knowledge of the API's internals as well as require both the Java API to emit to .NET, and vice versa.<sup>(which would require the API to implement jni4net, which is another unwanted dependency, and would be just for this implementation)</sup>

# Drawing lines

[![alt text]({{ site.url }}/assets/DesignJavaHost.svg "Courtesy of https://www.draw.io/")](https://www.draw.io/)
 
Taking all of this under consideration:

* Wrap the Java API in a SOAP service.
  
  _This enables seamless, loosely coupled integration between the .NET application which can then just consume the service like any other SOAP based web service._

* Write as little Java as possible through exposing the relevant Java API functionality as vanilla as possible as operations in the Web Service.
  
  _Any orchestration logic such as polling should reside in the .NET application where anyone can maintain it._

* Wrap the SOAP Service (that wraps the Java API) in a Windows Service.
  
  _That serves the web service as a background operation which means it is not tied to any user sessions. A windows service has the additional capability of being configured to starting automatically on the occasional server reboot as well as run under credentials specific to the operation._

# Code


  
# Alternative

I did some research and found an awesome library in [Tanuki Software's Java Service Wrapper](http://wrapper.tanukisoftware.com/). It looks like an awesome tool with alot of [features](http://wrapper.tanukisoftware.com/doc/english/product-features.html) and will be able to provide the same functionality as this project with a few added benefits. 

## Moral:

So what can we take from Phil's infinite wisdom?

  * "When life gives you lemonade, make lemons. Life’ll be all like ‘what?!’" —   Phil Dunphy [Phil’s-osophy]"
 
    **_Reading the help documentation helps..._**