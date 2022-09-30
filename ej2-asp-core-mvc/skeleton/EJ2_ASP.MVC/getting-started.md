---
layout: post
title: Getting Started with ##Platform_Name## Skeleton Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Skeleton control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Skeleton Control

This section briefly explains about how to include `ASP.NET MVC Skeleton` control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Skeleton control

Now, add the Syncfusion ASP.NET MVC Skeleton control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Notifications;

<div class="col-sm-6">
    <h5>Circle</h5>
    @Html.EJS().Skeleton("skeletonCircleSmall").Shape(SkeletonType.Circle).Width("3rem").Render()
    @Html.EJS().Skeleton("skeletonCircleMedium").Shape(SkeletonType.Circle).Width("48px").Render()
    @Html.EJS().Skeleton("skeletonCircleLarge").Shape(SkeletonType.Circle).Width("64px").Render()
    @Html.EJS().Skeleton("skeletonCircleLarger").Shape(SkeletonType.Circle).Width("80px").Render()
</div>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Skeleton control will be rendered in the default web browser.

![ASP.NET MVC Skeleton Control](images/skeleton-control.png)

## Shapes

The Skeleton control has the following different type of shapes.

* Circle
* Square
* Text
* Rectangle

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Notifications;

<div class="row skeleton-default">
    <div class="col-sm-6">
        <h5>Circle</h5>
        @Html.EJS().Skeleton("skeletonCircleSmall").Shape(SkeletonType.Circle).Width("3rem").Render()
        @Html.EJS().Skeleton("skeletonCircleMedium").Shape(SkeletonType.Circle).Width("48px").Render()
        @Html.EJS().Skeleton("skeletonCircleLarge").Shape(SkeletonType.Circle).Width("64px").Render()
        @Html.EJS().Skeleton("skeletonCircleLarger").Shape(SkeletonType.Circle).Width("80px").Render()
    </div>
    <div class="col-sm-6">
        <h5>Square</h5>
        @Html.EJS().Skeleton("skeletonSquareSmall").Shape(SkeletonType.Square).Width("3rem").Render()
        @Html.EJS().Skeleton("skeletonSquareMedium").Shape(SkeletonType.Square).Width("48px").Render()
        @Html.EJS().Skeleton("skeletonSquareLarge").Shape(SkeletonType.Square).Width("64px").Render()
        @Html.EJS().Skeleton("skeletonSquareLarger").Shape(SkeletonType.Square).Width("80px").Render()
    </div>
</div>
<div class="row skeleton-default">
    <div class="col-sm-6">
        <h5>Text</h5>
        @Html.EJS().Skeleton("skeletonText").Shape(SkeletonType.Text).Width("100%").Height("15px").Render()
        @Html.EJS().Skeleton("skeletonTextMedium").Width("30%").Height("15px").Render()
        <br />
        @Html.EJS().Skeleton("skeletonTextSmall").Width("15%").Height("15px").Render()
        <br />
        @Html.EJS().Skeleton("skeletonTextMedium1").Width("60%").Height("15px").Render()
        <br />
        @Html.EJS().Skeleton("skeletonTextSmall1").Width("15%").Height("15px").Render()
    </div>
    <div class="col-sm-6">
        <h5>Rectangle</h5>
        @Html.EJS().Skeleton("skeletonRectangle").Shape(SkeletonType.Rectangle).Width("100%").Height("100px").Render()
        @Html.EJS().Skeleton("skeletonRectangleMedium").Shape(SkeletonType.Rectangle).Width("20%").Height("35px").Render()
        @Html.EJS().Skeleton("skeletonRectangleMediumRight").Shape(SkeletonType.Rectangle).Width("20%").Height("35px").Render()
    </div>
</div>

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Skelton Shapes](images/skeleton-skimmer-effects.png)