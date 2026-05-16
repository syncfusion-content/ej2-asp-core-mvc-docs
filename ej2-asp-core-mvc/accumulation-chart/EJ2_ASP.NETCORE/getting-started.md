---
layout: post
title: Getting Started with ##Platform_Name## Accumulation Chart | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Accumulation Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Getting Started with ASP.NET Core Accumulation Chart Control

This section briefly explains how to add the [ASP.NET Core Accumulation Chart](https://www.syncfusion.com/aspnet-core-ui-controls/charts) control to your ASP.NET Core application using Visual Studio.

To get started quickly with the ASP.NET Core Accumulation Chart control, watch this video:

{% youtube "https://www.youtube.com/watch?v=RplZL-3B1G4&t=3s" %}

## Prerequisites

Refer to the [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) before creating the application.

## Create an ASP.NET Core Web Application with Razor Pages

You can create an ASP.NET Core application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install the ASP.NET Core NuGet Package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls to the application, open the NuGet Package Manager in Visual Studio by selecting **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**. Search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/), and then install it. Alternatively, you can use the following Package Manager command.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.AspNet.Core NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add Script Resources

Add the script reference inside the `<head>` element of the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Refer to the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `<ejs-scripts>` at the end of the `<body>` element in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Accumulation Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Accumulation Chart tag helper to the `~/Pages/Index.cshtml` page.

By default, a pie series is rendered when JSON data is assigned to the series using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_DataSource) property. Map the field names in the JSON data to the [`xName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_XName) and [`yName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_YName) properties of the series.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> on Windows or <kbd>⌘</kbd>+<kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Accumulation Chart control will be rendered in the default web browser.

![ASP.NET Core Accumulation Chart Control](images/accumulation-chart-component.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/AccumulationChart/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.

## See Also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
