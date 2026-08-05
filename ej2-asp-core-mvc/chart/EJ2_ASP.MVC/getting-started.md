---
layout: post
title: Getting Started with ##Platform_Name## Chart Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC Chart Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts) control to your ASP.NET MVC application using Visual Studio.
> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup>, CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetmvc/documentation/ai-coding-assistant/overview)


## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC Application with HTML Helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet Package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Namespace

Add the **Syncfusion.EJ2** namespace reference in the `Web.config` file available in the `Views` folder.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />

</namespaces>

{% endhighlight %}
{% endtabs %}

## Add Script Resources

Add the script reference inside the `<head>` element of the `~/Views/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

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

## Add the ASP.NET MVC Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Chart control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().Chart("container").Render()

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Chart control will be rendered in the default web browser.

![ASP.NET MVC Chart Control](how-to/images/chart.png)

## Render a Chart with Data

To render a column chart with data, define a data source and bind it to the chart series using the [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource), [`XName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName), and [`YName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName) properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
    var chartData = new List<object>
    {
        new { Month = "Jan", Sales = 35 },
        new { Month = "Feb", Sales = 28 },
        new { Month = "Mar", Sales = 34 },
        new { Month = "Apr", Sales = 32 },
        new { Month = "May", Sales = 40 }
    };
}

@Html.EJS().Chart("container").PrimaryXAxis(px => px
    .ValueType(Syncfusion.EJ2.Charts.ValueType.Category)
).Series(series =>
{
    series.DataSource(chartData)
        .XName("Month")
        .YName("Sales")
        .Type(Syncfusion.EJ2.Charts.ChartSeriesType.Column)
        .Add();
}).Render()

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Chart Control with Data](how-to/images/chart-data.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Chart/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## See Also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC using HTML Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)