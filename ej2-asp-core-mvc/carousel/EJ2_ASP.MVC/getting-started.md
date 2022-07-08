---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Carousel Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC Carousel Control

This section briefly explains about how to include [ASP.NET MVC Carousel](https://www.syncfusion.com/aspnet-mvc-ui-controls/carousel) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC Carousel control

Now, add the Syncfusion ASP.NET MVC Carousel control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<div class="col-lg-12 control-section default-carousel-section">
    <div class="e-sample-resize-container carousel-sample">
        @(Html.EJS().Carousel("defaultCarousel").CssClass("default-carousel")
            .Items(new List<CarouselItem> {
                new CarouselItem { Template = "#itemTemplate1"  },
                new CarouselItem { Template = "#itemTemplate2"  },
                new CarouselItem { Template = "#itemTemplate3"  },
                new CarouselItem { Template = "#itemTemplate4"  },
                new CarouselItem { Template = "#itemTemplate5"  }
            })
            .Render()
        )
    </div>
</div>
<script id="itemTemplate1" type="text/x-template">
    <figure class="img-container">
        <img src="@Url.Content("~/Content/carousel/images/bridge.jpg")" alt="bridge" style="height:100%; width: 100%;" />
        <figcaption class="img-caption">Golden Gate Bridge, San Francisco</figcaption>
    </figure>
</script>
<script id="itemTemplate2" type="text/x-template">
    <figure class="img-container">
        <img src="@Url.Content("~/Content/carousel/images/trees.jpg")" alt="spring_trees" style="height:100%; width: 100%;" />
        <figcaption class="img-caption">Spring Flower Trees</figcaption>
    </figure>
</script>
<script id="itemTemplate3" type="text/x-template">
    <figure class="img-container">
        <img src="@Url.Content("~/Content/carousel/images/waterfall.jpg")" alt="waterfall" style="height:100%; width: 100%;" />
        <figcaption class="img-caption">Oddadalen Waterfalls, Norway</figcaption>
    </figure>
</script>
<script id="itemTemplate4" type="text/x-template">
    <figure class="img-container">
        <img src="@Url.Content("~/Content/carousel/images/sea.jpg")" alt="sea" style="height:100%; width: 100%;" />
        <figcaption class="img-caption">Anse Source d'Argent, Seychelles</figcaption>
    </figure>
</script>
<script id="itemTemplate5" type="text/x-template">
    <figure class="img-container">
        <img src="@Url.Content("~/Content/carousel/images/rocks.jpeg")" alt="rocks" style="height:100%; width: 100%;" />
        <figcaption class="img-caption">Stonehenge, England</figcaption>
    </figure>
</script>

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

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Carousel control will be rendered in the default web browser.

![ASP.NET MVC Carousel Control](images/carousel-control.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Carousel/ASP.NET%20MVC%20Razor%20Examples).