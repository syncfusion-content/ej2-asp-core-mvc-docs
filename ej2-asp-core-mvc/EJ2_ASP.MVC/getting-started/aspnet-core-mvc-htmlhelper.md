---
layout: post
title: Getting Started with ##Platform_Name## using HTML helpers | Syncfusion
description: Checkout and learn about building ##Platform_Name## MVC application with Calendar control using HTML helper in Visual Studio.
platform: ej2-asp-core-mvc
control: common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core MVC using HTML Helper

This article provides step-by-step instructions for building ASP.NET Core MVC application with Calendar control using HTML helper in Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core MVC application

 * [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

 * [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/VS2019-Extensions/create-project/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](../nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core components in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

N> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core namespace

Open `~/Views/_ViewImports.cshtml` file and add the `Syncfusion.EJ2` namespace.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" hl_lines="3" %}

@using WebApplication1
@using WebApplication1.Models
@using Syncfusion.EJ2
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

{% endhighlight %}
{% endtabs %}
    
## Add style sheet

Checkout the [Themes topic](../appearance/theme/) to learn different ways ([CDN](../common/adding-script-references), [NPM package](../common/adding-script-references#node-package-manager-npm), and [CRG](../common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
</head>
{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using [CDN](../common/adding-script-references) inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>
{% endhighlight %}
{% endtabs %}

## Register Syncfusion script manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<body>
    ...
    <!-- Syncfusion Script Manager -->
    @Html.EJS().ScriptManager()
</body>
{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Calendar control

Now, add the Syncfusion ASP.NET Core Calendar Html helper in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
<div>
   @Html.EJS().Calendar("calendar").Render()
</div>
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Calendar control will be rendered in the default web browser.

![ASP.NET Core MVC Calendar control using Html helper](images/aspnetcore-calendar.png)

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
