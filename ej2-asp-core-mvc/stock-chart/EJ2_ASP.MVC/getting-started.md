---
layout: post
title: Getting Started with ##Platform_Name## Stock Chart Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Stock Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with the ASP.NET MVC Stock Chart Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Stock Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/stock-chart) control to your ASP.NET MVC application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC Application with HTML Helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet Package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Namespace

Add the **Syncfusion.EJ2** namespace reference in the `Web.config` file available in the `Views` folder.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add Stylesheet and Script Resources

Add the stylesheet and script references inside the `<head>` element of the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Refer to the [Themes](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) topic to learn different ways, such as CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator), to refer to styles in an ASP.NET MVC application and achieve the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls.

N> Refer to the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `EJS().ScriptManager()` at the end of the `<body>` element in the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET MVC Stock Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Stock Chart control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@(Html.EJS().StockChart("container").Series(series =>
{
    series.Add();
}).Render())

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Stock Chart control will be rendered in the default web browser.

![ASP.NET MVC Stock Chart Control](images/stockchart-control.png)


## Populate the Stock Chart with Data

This section explains how to populate the ASP.NET MVC Stock Chart using data defined in an external JavaScript file.

Add a series object to the chart by using the [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Series) property, and then set the JSON data from the JavaScript file to the [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_DataSource) property.

Since the data contains DateTime values, set the [`valueType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) property of the horizontal axis to `DateTime`. By default, the axis `valueType` is `Double`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/populateData/razor %}
{% endhighlight %}
{% highlight cshtml tabtitle="financial-data.js" %}
{% include code-snippet/stock-chart/financial-data.js %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stock Chart with Data](images/stockchart.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/StockChart/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## See Also

* [ASP.NET MVC Stock Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/stock-chart) feature tour page for its feature representations
* [ASP.NET MVC Stock Chart example](https://ej2.syncfusion.com/aspnetmvc/StockChart/Default#/material) to learn how to present and manipulate data.
