---
layout: post
title: Getting Started with ##Platform_Name## AccumulationChart | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## AccumulationChart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Getting Started with ASP.NET MVC AccumulationChart Control

This section briefly explains about how to include [ASP.NET MVC AccumulationChart](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

N> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

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

## Add ASP.NET MVC AccumulationChart control

Now, add the Syncfusion ASP.NET MVC AccumulationChart control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@(Html.EJS().AccumulationChart("container").Render())

{% endhighlight %}
{% endtabs %}

**Pie Series**

By default, the pie series will be rendered when assigning the JSON data to the series using the [dataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_DataSource) property. Map the field names in the JSON data to the [xName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_XName) and [yName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_YName) properties of the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/initial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/initial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<PieChartData> chartData = new List<PieChartData>
    {
        new PieChartData { xValue = "Chrome", yValue = 37, text = "37%"},
        new PieChartData { xValue = "UC Browser", yValue = 17, text = "17%"},
        new PieChartData { xValue = "iPhone", yValue = 19, text = "19%"},
        new PieChartData { xValue = "Others", yValue = 4 , text = "4%"}
    };
    return View(chartData);
}
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC AccumulationChart control will be rendered in the default web browser.

![ASP.NET MVC AccumulationChart Control](images/accumulation-chart-component.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/AccumulationChart/ASP.NET%20MVC%20Razor%20Examples).