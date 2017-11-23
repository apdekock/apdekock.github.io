---
layout: post 
title: "Scraping with Azure Functions and HTMLAgilityPack" 
date: 2017-11-23
quote: "If you get pulled over for speeding. Tell them your spouse has diarrhoea. — Phil Dunphy [Phil’s - osophy]"
categories: scraping, auto generating post, gitsharp, httpclient, httpAgilityPack, azure functions
---
This page shows the movement of prices on the [www.weSellCars.co.za](http://www.wesellcars.co.za) website.

## Update

This is an update / improvement on the previous scraping post, I also wanted to employ Azure functions and break up the app into dicrete well, functions, and Azure Functions "seemed" appropriate. A bit of a learning curve with the function app lifecycle and API but works great! I split the app into a scraping and a serving function app using MVC.

*I eventually implimented [HttpClient](https://msdn.microsoft.com/en-us/library/system.net.http.httpclient(v=vs.118).aspx) in conjunction with the HTMLAgilityPack in an Azure Functions App, much faster and less brittle.


## The List
<iframe frameborder="0" scrolling="no" onload="this.style.height = this.contentWindow.document.body.scrollHeight + 'px'" 
style="max-width: 100%; width=100%; border-width: 0px;
    vertical-align: middle;"	src="https://exposewesellcars.azurewebsites.net/api/ExposeHtml?code=Pb38/cyv8YxMMFR4VMKOcyHdun8gK7MafQq3lGQWppO9zkNTJv8/xA=="></iframe>

<script>
  function resizeIframe(obj) {
    obj.style.height = obj.contentWindow.document.body.scrollHeight + 'px';
  }
</script>