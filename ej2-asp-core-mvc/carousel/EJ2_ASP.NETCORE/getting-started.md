---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Carousel Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Carousel Control

This section briefly explains about how to include [ASP.NET Core Carousel](https://www.syncfusion.com/aspnet-core-ui-controls/carousel) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper
Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Carousel Control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Carousel tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<div class="col-lg-12 control-section default-carousel-section">
    <div class="e-sample-resize-container carousel-sample">
        <ejs-carousel id="defaultCarousel" cssClass="default-carousel">
            <e-carousel-items>
                <e-carousel-item template="#templateItem1"></e-carousel-item>
                <e-carousel-item template="#templateItem2"></e-carousel-item>
                <e-carousel-item template="#templateItem3"></e-carousel-item>
                <e-carousel-item template="#templateItem4"></e-carousel-item>
                <e-carousel-item template="#templateItem5"></e-carousel-item>
            </e-carousel-items>
        </ejs-carousel>
    </div>
</div>

<style>
.default-carousel-section .carousel-sample {
    margin: 0 auto 2em;
    max-width: 500px;
    height: 300px;
}

.default-carousel .e-carousel-items .e-carousel-item .img-container {
    height: 100%;
}

.default-carousel .e-carousel-items .e-carousel-item .img-caption {
    bottom: 4em;
    color: #fff;
    font-size: 12pt;
    height: 2em;
    position: relative;
    padding: 0.3em 1em;
    text-align: center;
    width: 100%;
}
</style>

<script id="templateItem1" type="text/x-template">
    <figure class="img-container">
        <img src="https://ej2.syncfusion.com/aspnetcore/css/carousel/images/bridge.jpg" alt="bridge" style="height:100%; width: 100%" />
        <figcaption class="img-caption">Golden Gate Bridge, San Francisco</figcaption>
    </figure>
</script>

<script id="templateItem2" type="text/x-template">
    <figure class="img-container">
        <img src="https://ej2.syncfusion.com/aspnetcore/css/carousel/images/trees.jpg" alt="spring_trees" style="height:100%; width: 100%" />
        <figcaption class="img-caption">Spring Flower Trees</figcaption>
    </figure>
</script>

<script id="templateItem3" type="text/x-template">
    <figure class="img-container">
        <img src="https://ej2.syncfusion.com/aspnetcore/css/carousel/images/waterfall.jpg" alt="waterfall" style="height:100%; width: 100%" />
        <figcaption class="img-caption">Oddadalen Waterfalls, Norway</figcaption>
    </figure>
</script>

<script id="templateItem4" type="text/x-template">
    <figure class="img-container">
        <img src="https://ej2.syncfusion.com/aspnetcore/css/carousel/images/sea.jpg" alt="sea" style="height:100%; width: 100%" />
        <figcaption class="img-caption">Anse Source d'Argent, Seychelles</figcaption>
    </figure>
</script>

<script id="templateItem5" type="text/x-template">
    <figure class="img-container">
        <img src="https://ej2.syncfusion.com/aspnetcore/css/carousel/images/rocks.jpeg" alt="rocks" style="height:100%; width: 100%" />
        <figcaption class="img-caption">Stonehenge, England</figcaption>
    </figure>
</script>
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Carousel control will be rendered in the default web browser.

![ASP.NET Core Carousel Control](images/carousel-control.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Carousel/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
