---
layout: post
title: Getting Started with ##Platform_Name## Skeleton Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Skeleton control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Skeleton Control

This section briefly explains about how to include `ASP.NET Core Skeleton` control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Skeleton Control

Now, add the Syncfusion ASP.NET Core Skeleton tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div class="col-sm-6">
    <h5>Circle</h5>
    <ejs-skeleton id="skeletonCircleSmall" shape="Circle" width="3rem"></ejs-skeleton>
    <ejs-skeleton id="skeletonCircleMedium" shape="Circle" width="48px"></ejs-skeleton>
    <ejs-skeleton id="skeletonCircleLarge" shape="Circle" width="64px"></ejs-skeleton>
    <ejs-skeleton id="skeletonCircleLarger" shape="Circle" width="80px"></ejs-skeleton>
</div>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Skeleton control will be rendered in the default web browser.

![ASP.NET Core Skeleton Control](images/skeleton-control.png)

## Skeleton Types

The Skeleton control has the following different type of shapes.

* Circle
* Square
* Text
* Rectangle

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div class="row skeleton-default">
    <div class="col-sm-6">
        <h5>Circle</h5>
        <ejs-skeleton id="skeletonCircleSmall" shape="Circle" width="3rem"></ejs-skeleton>
        <ejs-skeleton id="skeletonCircleMedium" shape="Circle" width="48px"></ejs-skeleton>
        <ejs-skeleton id="skeletonCircleLarge" shape="Circle" width="64px"></ejs-skeleton>
        <ejs-skeleton id="skeletonCircleLarger" shape="Circle" width="80px"></ejs-skeleton>
    </div>
    <div class="col-sm-6">
        <h5>Square</h5>
        <ejs-skeleton id="skeletonSquareSmall" shape="Square" width="3rem"></ejs-skeleton>
        <ejs-skeleton id="skeletonSquareMedium" shape="Square" width="48px"></ejs-skeleton>
        <ejs-skeleton id="skeletonSquareLarge" shape="Square" width="64px"></ejs-skeleton>
        <ejs-skeleton id="skeletonSquareLarger" shape="Square" width="80px"></ejs-skeleton>
    </div>
</div>
<div class="row skeleton-default">
    <div class="col-sm-6">
        <h5>Text</h5>
        <ejs-skeleton id="skeletonText" shape="Text" width="100%" height="15px"></ejs-skeleton>
        <ejs-skeleton id="skeletonTextMedium" width="30%" height="15px"></ejs-skeleton>
        <br />
        <ejs-skeleton id="skeletonTextSmall" width="15%" height="15px"></ejs-skeleton>
        <br />
        <ejs-skeleton id="skeletonTextMedium1" width="60%" height="15px"></ejs-skeleton>
        <br />
        <ejs-skeleton id="skeletonTextSmall1" width="15%" height="15px"></ejs-skeleton>
    </div>
    <div class="col-sm-6">
        <h5>Rectangle</h5>
        <ejs-skeleton id="skeletonRectangle" shape="Rectangle" width="100%" height="100px"></ejs-skeleton>
        <ejs-skeleton id="skeletonRectangleMedium" shape="Rectangle" width="20%" height="35px"></ejs-skeleton>
        <ejs-skeleton style="float:right" id="skeletonRectangleMediumRight" shape="Rectangle" width="20%" height="35px"></ejs-skeleton>
    </div>
</div>

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Skelton Shapes](images/skeleton-skimmer-effects.png)