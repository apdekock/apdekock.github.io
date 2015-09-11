---
layout: post
title:  "Creating a simple blog with static site generator Jekyll on Windows"
date:   2015-09-11 22:00:00
quote:  "“Why do I have to watch a French movie, I didn’t do anything wrong.” — Phil Dunphy"
categories: Jekyll, Ruby, GitHub pages, Windows
---

## Easily and Quickly set up Jekyll in a Windows environment!

![alt text]({{ site.url }}/assets/jekyll/logo.png)

# Setup:
1. Clone this github repository: [**apdekock/jekyllWindows**](https://github.com/apdekock/jekyllWindows)

2. Run **cmd.bat** which will set up the relative paths and provide a console with jekyll instructions.

# Generate:

{% highlight markdown %}
Quick-start Instructions for jekyll:
	1. jekyll new my-awesome-site
	2. replace the config in my-awesome-site\_config.yml with 
	   the [relative path]_config.yml one.
	3. cd my-awesome-site
	4. jekyll serve
Now browse to http://localhost:4000
{% endhighlight %}

![alt text]({{ site.url }}/assets/jekyll/cmd.PNG)

Click-able link to see the site below [http://localhost:4000](http://localhost:4000).

![alt text]({{ site.url }}/assets/jekyll/site.PNG)

## Creating a simple blog

I wanted to create a simple blog and did some investigation. I stumbled onto [**Jekyll**](https://jekyllrb.com/) which comes highly recommended. 

I found an awesome step-by-step guide by _**Julian Thilo**_ [**http://jekyll-windows.juthilo.com/**](http://jekyll-windows.juthilo.com/) which allowed me to get set up. It's a bit of a mission though to set up in a **Windows** environment. 

Switching between laptops or reloading the OS and replicating these steps over and over seem excessive so I took it upon myself to create a plug-and-play version of the jekyll environment.
