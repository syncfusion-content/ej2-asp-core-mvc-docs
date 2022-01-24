---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Selected Tab Styles of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Selected Tab Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize selected tab styles

You can customize the Tab style by overriding its header and active tab CSS classes. Define HTML string for adding animation and customizing the Tab header and pass it to [text](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabHeader~Text.html) property. Now you can override the style using custom CSS classes added to the Tab elements.

{% aspTab template="tab/customize", sourceFiles="customize.cs" %}

{% endaspTab %}

Output be like the below.

![Alt text](../images/tab.PNG)