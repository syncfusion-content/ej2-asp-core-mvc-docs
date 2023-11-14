---
layout: post
title: Getting Started with ##Platform_Name## using HTML and Tag Helpers | Syncfusion
description: Checkout and learn about building ##Platform_Name## Core MVC application with Accordion control using HTML  and Tag helper in Visual Studio.
platform: ej2-asp-core-mvc
control: common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core MVC using HTML and Tag Helpers

This article guides you in building an ASP.NET Core MVC app with an `Accordion` control using HTML and Tag helpers in Visual Studio. Choose any `HTML` or `Tag` Helper to create the Accordion in your ASP.NET Core MVC app.

## Prerequisites

[System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core MVC application

 * [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio#create-a-web-app)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core namespace and Tag Helpers

Open `~/Views/_ViewImports.cshtml` file and add the `Syncfusion.EJ2` namespace or `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight c# tabtitle="Tag Helpers" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% highlight c# tabtitle="HTML Helpers" hl_lines="3" %}

@using WebApplication1
@using WebApplication1.Models
@using Syncfusion.EJ2
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="HTML & Tag Helpers" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core MVC  application, and to have the expected appearance for Syncfusion ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core MVC application.

Also, register the script manager at the end of `<body>` in the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="Tag Helpers" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% highlight cshtml tabtitle="HTML Helpers" %}

<body>
    ...
    <!-- Syncfusion Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Accordion control

Now, add the Syncfusion ASP.NET Core Accordion control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Tag Helpers" %}
{% include code-snippet/accordion/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/accordion/getting-started/data/data.cs %}
{% endhighlight %}
{% highlight razor tabtitle="HTML Helpers" %}
{% include code-snippet/accordion/getting-started/data/razor %}
{% endhighlight %}
{% endtabs %}
{% tabs %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the app. Then, the Syncfusion ASP.NET Core Accordion control will be rendered in the default web browser.

![ASP.NET MVC Accordion Control](images/accordion-control.PNG)