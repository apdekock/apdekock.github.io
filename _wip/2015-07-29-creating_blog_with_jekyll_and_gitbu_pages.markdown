---
layout: post
title:  "Creating a simple blog with static site generator Jekyll and GitHub pages"
date:   2015-07-27 14:33:11
quote:  ""
categories: Jekyll, Ruby, GitHub pages
---

## What is Jekyll?

## What is GitHub pages?

I followed this blog:[...][blogJekyll] 

...with the additional details as outlined below:


At the time of writing the following worked together well for a windows 7 64bit set up:
[rubyinstaller-2.0.0-p645-x64.exe][rubyinstaller-64]
[DevKit-mingw64-64-4.7.2-20130224-1432-sfx.exe][devkit-64]

I needed to disable Highlighter, as below, to get it working locally - and I could enable it when pushing to the gihub pages repo but locally i needed to install rouge:
Works on both **BUT** obviously no syntax highlighting:
highlighter: none
or
# highlighter: none

Work locally after *"jekyll install rouge"*:
highlighter: rouge
or
# highlighter: rouge

Work on github but not locally:
highlighter: pygments

[blogJekyll]
[devkit-64]
[rubyinstaller-64]