---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Carousel Control
description: Check out and learn about getting started with ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Carousel Control

This section briefly explains how to include the [ASP.NET Core Carousel](https://www.syncfusion.com/aspnet-core-ui-controls/carousel) control in your ASP.NET Core Web App using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project).

## Install the required ASP.NET Core packages

To add [ASP.NET Core Carousel](https://www.syncfusion.com/aspnet-core-ui-controls/carousel) control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), then search and install [Syncfusion.AspNetCore.Navigations](https://www.nuget.org/packages/Syncfusion.AspNetCore.Navigations) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes). All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for more details.

Alternatively, you can install the same packages using the Package Manager Console with the following commands.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Navigations -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core tag helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Navigations` and `Syncfusion.AspNetCore.Base` tag helpers.

{% tabs %}
{% highlight C# tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Navigations
@addTagHelper *, Syncfusion.AspNetCore.Base

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from NuGet through [Static Web Assets](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#static-web-assets). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    ...
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    <script src="_content/Syncfusion.AspNetCore.Navigations/scripts/sf-carousel.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager (`<ejs-scripts>`) at the end of the `<body>` element as shown below.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Carousel control

Add the [ASP.NET Core Carousel](https://www.syncfusion.com/aspnet-core-ui-controls/carousel) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
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

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Carousel](https://www.syncfusion.com/aspnet-core-ui-controls/carousel) control will render in your default web browser.

![ASP.NET Core Carousel Control](images/core-carousel-control.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Carousel).

## See also

1. [Getting Started with ASP.NET Core in Visual Studio Mac](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/visual-studio-mac)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
