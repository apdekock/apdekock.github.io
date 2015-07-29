---
layout: post
title:  "Java API hosted in Windows Service"
date:   2015-07-27 14:33:11
categories: C# / Spring
---
I recently had to integrate with a Java API from a .NET application. I did some research and found an awesome library in [Tanuki Software's Java Service Wrapper][tanuki].

I did a small POC with the community version but I wanted to have more control over the Windows Service and as the Java API needed to be exposed through a SOAP Web Service, I decided to see how I can go about writing my own Windows Service host capable of running my Java API wrapped inside a SOAP Web Service to expose the functionality to my C# .NET application.


# Reasoning behind the design:
- most of the logic needs to be maintained in the C# application as the client is a.NET shop.
- the web service can be consumed from practically anyone.
- the java application needs to run regardless of any users logged in (like a deamon - linux).

[tanuki]:      http://wrapper.tanukisoftware.com/
