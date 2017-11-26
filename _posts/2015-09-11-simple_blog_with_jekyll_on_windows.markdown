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

{% highlight xml %}
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

# What is Jekyll?

![alt text]({{ site.url }}/assets/jekyll/jekyllSite.png)

> [Jekyll](https://jekyllrb.com/) is a simple, user friendly static site generator powered by Ruby, and is also the engine behind GitHub Pages. It takes a template directory containing raw text files, runs it through Markdown (Liquid or Textile) converters, and generates a complete ready-to-publish static website. - [http://mashable.com/2014/08/28/static-website-generators/](http://mashable.com/2014/08/28/static-website-generators/)

For more information check out the [Jekyll Github repo](https://github.com/jekyll/jekyll).

# What is GitHub pages?

> Websites for you and your projects. - [https://pages.github.com/](https://pages.github.com/)

This [blog](http://apdekock.github.io) is hosted in Github pages.

Instructions for [using Jekyll with GitHub Pages](https://help.github.com/articles/using-jekyll-with-pages/) 

# Not so [vanilla](https://en.wikipedia.org/wiki/Vanilla_Ice)

I needed to disable the _**highlighter**_ in the *_config.yml* to get it working locally. I could enable it when pushing to GitHub pages.

For syntax highlighting I installed [rouge](https://github.com/jneen/rouge) locally, that is the reason for step [2] in the *"Quick-start Instructions for jekyll"* which replaces the vanilla *_config.yml* with one that uses the appropriate highlighter setting.

Works **both** **locally** and on **GitHub pages** *but* obviously **no syntax highlighting**:
{% highlight xml %}
highlighter: none
{% endhighlight %}

Works **locally** after "_**jekyll install rouge**_":
{% highlight xml %}
highlighter: rouge
{% endhighlight %}

Works on **GitHub pages**:
{% highlight xml %}
highlighter: pygments
{% endhighlight %}

Complete **_config.yml**:
{% highlight xml %}
# Site settings
title: Your awesome title
email: your-email@domain.com
description: > # this means to ignore newlines until "baseurl:"
  Write an awesome description for your new site here. You can edit this
  line in _config.yml. It will appear in your document head meta (for
  Google search results) and in your feed.xml site description.
baseurl: "" # the subpath of your site, e.g. /blog/
url: "http://yourdomain.com" # the base hostname & protocol for your site
twitter_username: jekyllrb
github_username:  jekyll
highlighter: rouge
# Build settings
markdown: kramdown
{% endhighlight %}

# Versions

Granted, the versions in the [apdekock/jekyllWindows](https://github.com/apdekock/jekyllWindows) repo are not the most recent. However, they are fit for purpose as they are compatible with GitHub pages, as well as with my environment.

|OS:|
|:---|
|Windows 7 x64 Pro SP1|

|Ruby download:|
|:---|
|[rubyinstaller-2.0.0-p645-x64.exe](http://dl.bintray.com/oneclick/rubyinstaller/rubyinstaller-2.0.0-p645-x64.exe)|

|DevKit download:|
|:---|
|[DevKit-mingw64-64-4.7.2-20130224-1432-sfx.exe](http://dl.bintray.com/oneclick/rubyinstaller/DevKit-mingw64-64-4.7.2-20130224-1432-sfx.exe)|

##**Moral:**

  * “Why do I have to watch a French movie, I didn’t do anything wrong.” — Phil Dunphy
 
    **_Don't punish yourself, clone the repo._**