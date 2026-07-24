---
layout: post
title: Getting Started with ##Platform_Name## HeatMapChart Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## HeatMapChart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: HeatMap Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core HeatMap Chart Control

This section briefly explains how to include the [ASP.NET Core HeatMap Chart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

This section briefly explains how to include the [ASP.NET Core HeatMapChart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) control in your ASP.NET Core application using Visual Studio.

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add [ASP.NET Core HeatMap Chart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.HeatMap](https://www.nuget.org/packages/Syncfusion.AspNetCore.HeatMap/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can run the following command in the **Package Manager Console**.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.HeatMap -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.HeatMap` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.HeatMap

{% endhighlight %}
{% endtabs %}

## Add script resources

Include the [script reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.HeatMap/scripts/sf-heatmap.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core HeatMapChart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core HeatMapChart tag helper to the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-heatmap id="heatmap"></ejs-heatmap>

{% endhighlight %}
{% endtabs %}

## Populate HeatMap with data

Populate the HeatMap with a two-dimensional array of numbers as shown below.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/data/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core HeatMapChart control will be rendered in the default web browser.

![ASP.NET Core HeatMap Chart with Data](images/heatmap-with-data.webp)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/HeatMap/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Troubleshooting

If the HeatMapChart does not render or you run into build/runtime issues, try the following:

* **HeatMapChart is not visible on the page** — Ensure the `ejs-scripts` tag helper is registered at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml`. Missing this registration prevents Syncfusion client-side scripts from initializing the control.
* **Cells render with no data** — Confirm the data passed to the `dataSource` is a valid two-dimensional array and that the array's first-level index represents the y-axis (row) and the second-level index represents the x-axis (column).
* **Axis labels do not appear** — Verify the `xAxis` and `yAxis` child elements are configured with the `labels` collection.
* **Build error: `TagHelper is not registered`** — Verify that `~/Pages/_ViewImports.cshtml` contains `@addTagHelper *, Syncfusion.EJ2` and rebuild the solution.
* **NuGet restore failures** — Confirm the project targets a supported .NET version and that the NuGet feed is reachable. Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic.

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
