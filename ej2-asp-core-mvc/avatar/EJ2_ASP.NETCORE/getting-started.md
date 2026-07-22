---
layout: post
title: Getting Started with ##Platform_Name## Avatar Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Avatar control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Avatar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Avatar Control

This section explains how to include [ASP.NET Core Avatar](https://www.syncfusion.com/aspnet-core-ui-controls/avatar) in your ASP.NET Core application using Visual Studio.

## Create ASP.NET Core web application with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Add stylesheet

The theme stylesheet is referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Avatar control

Add the [ASP.NET Core Avatar](https://www.syncfusion.com/aspnet-core-ui-controls/avatar) tag helper in **~/Pages/Index.cshtml** page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/getting-started/core/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Avatar](https://www.syncfusion.com/aspnet-core-ui-controls/avatar) control will render in your default web browser.

![ASP.NET Core Avatar Control](../images/avatar.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Avatar).

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [Types of Avatar](./types)
