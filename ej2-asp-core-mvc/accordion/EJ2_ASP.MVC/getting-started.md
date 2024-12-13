---
layout: post
title: Getting Started with ##Platform_Name## Accordion Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Accordion control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Accordion Control

This section briefly explains about how to include [ASP.NET MVC Accordion](https://www.syncfusion.com/aspnet-mvc-ui-controls/accordion) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it. Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add stylesheet and script resources

Here, the theme and script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

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

N> Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls. Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Accordion control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Accordion control in `~/Home/Index.cshtml` page.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/data/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Accordion control will be rendered in the default web browser.

![ASP.NET MVC Accordion Control](images/accordion-control.png)

## Render the Accordion using content template

You can bind any data in Accordion items, by simply using the content template property in ASP.NET Accordion. Accordion is already provided with the content template support and hence this support can be utilized to load the other HTML elements or as per your requirement.

In the below demo, the Accordion items are given with [Chart](../chart/getting-started), [Grid](../grid/getting-started-mvc), [Calender](../calendar/getting-started) as their content using the content template.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/contenttemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}

public ActionResult Index()
{
    List<LineChartData> chartData = new List<LineChartData>
    {
        new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
        new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
        new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
        new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
        new LineChartData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
        new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
        new LineChartData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
    };
    return View(chartData);
}
....
....
public class LineChartData
{
    public DateTime xValue;
    public double yValue;
    public double yValue1;
}

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Accordion with Content Template](images/accordion-template.png)

You can also render accordion without using `ContentTemplate` which can be referred [here](https://ej2.syncfusion.com/aspnetmvc/documentation/accordion/how-to/set-the-nested-accordion).

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Accordion/ASP.NET%20MVC%20Razor%20Examples).
