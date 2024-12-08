---
layout: post
title: Getting Started with ##Platform_Name## Badge Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Badge control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started Asp Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Badge Control

This section briefly explains about how to include [ASP.NET MVC Badge](https://www.syncfusion.com/aspnet-mvc-ui-controls/badge) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET web application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Add stylesheet

Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls.

## Add ASP.NET MVC Badge control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Badge control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/getting-started/mvc/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Badge control will be rendered in the default web browser.

![ASP.NET MVC Badge Control](images/badge.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Badge/ASP.NET%20MVC%20Razor%20Examples).

## See also

[Types of Badge](./types)