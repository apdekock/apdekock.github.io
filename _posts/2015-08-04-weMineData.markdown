---
layout: post 
title: "Scraping and GitSharp, and Spark lines" 
date: 2016-08-07
quote: "If you get pulled over for speeding. Tell them your spouse has diarrhoea. — Phil Dunphy [Phil’s - osophy]"
categories: scraping, auto generating post, gitsharp
---
This page is a daily re-generated post (last re-generated  **5/13/2017 4:58:39 PM**), that shows the movement of prices on the [www.weSellCars.co.za](http://www.wesellcars.co.za) website.

## Why?

This post is the culmination of some side projects I've been playing around with. Scraping, looking for a way to integrate with git through C# and a challenge to use this blog (which has no back-end or support for any server side scripting) to dynamically update a post. I realise that would best be accomplished through just making new posts but I opted for an altered post as this is a tech blog, and multiple posts about car prices would not be appropriate.

# Lessons learned

* [GitSharp](http://www.eqqon.com/index.php/GitSharp) is limited and I needed to grab the project from [github](https://github.com/henon/GitSharp) in order to use it.
    The NuGet package kept on complaining about a **repositoryformatversion** setting in config [Core] that it required even though it was present, it still complained. So, I downloaded the source to debug the issue but then I did not encounter it. Apart from that - gitsharp did not allow me to push - and it seems the project does not have a lot of contribution activity (not criticising, just stating. I should probably take this up and contribute, especially as I would like to employ git as a file store for an application. Levering off the already refined functions coudl be a win but more on that in another post).
* Scraping with Selenium is probably not the best way - rather employ [HttpClient](https://msdn.microsoft.com/en-us/library/system.net.http.httpclient(v=vs.118).aspx).
* For quick, easy and painless sparklines [jQuery Sparklines](http://omnipotent.net/jquery.sparkline/#s-about)
* No backend required, just a simple process running on a server, that commits to a repo (ghPages) gets the job done.

<ol>
</ol>
<script type="text/javascript"> $('.sparklines').sparkline('html'); </script>


