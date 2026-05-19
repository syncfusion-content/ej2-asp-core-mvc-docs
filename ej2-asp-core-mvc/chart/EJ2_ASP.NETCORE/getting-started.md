---
layout: post
title: Getting Started with ##Platform_Name## Chart Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Chart Control

This section briefly explains how to add the [ASP.NET Core Chart](https://www.syncfusion.com/aspnet-core-ui-controls/charts) control to your ASP.NET Core application using Visual Studio.

> **Ready to streamline your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core development?** Discover the full potential of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls with Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant. Effortlessly integrate, configure, and enhance your projects with intelligent, context-aware code suggestions, streamlined setups, and real-time insights—all seamlessly integrated into your preferred AI-powered IDEs like Visual Studio, Visual Studio Code, Cursor, Syncfusion<sup style="font-size:70%">&reg;</sup> CodeStudio and more. [Explore Syncfusion<sup style="font-size:70%">&reg;</sup> AI Coding Assistant](https://ej2.syncfusion.com/aspnetcore/documentation/ai-coding-assistant/overview)

To get started quickly with the ASP.NET Core Chart control, watch this video:

{% youtube "https://www.youtube.com/watch?v=Vll9DXQ7z4Q" %}

## Prerequisites

Refer to the [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) before creating the application.

## Create an ASP.NET Core Web Application with Razor Pages

You can create an ASP.NET Core application using either of the following options:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

{% tabcontents %}

{% tabcontent Visual Studio %}

## Create an ASP.NET Core Razor Pages project using Visual Studio:

1. Start **Visual Studio** and select **Create a new project**.

2. In the **Create a new project** window, choose **ASP.NET Core Web App (Razor Pages)** → **Next**.

3. In the **Configure your new project** dialog, specify the **project name** (and optionally change location/folder).

4. Click `Next`.

5. In the Additional information dialog:
* Select **.NET 10.0**.
* Verify: **Do not use top-level statements** is **unchecked**.

6. Click `Create`.

For alternative approaches to create the project, see [Create a new project in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/create-new-project?view=visualstudio).

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}


{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Create an ASP.NET Core Razor Pages project using Visual Studio Code:

* Install the latest **.NET SDK** that supports **.NET 10.0** or later.
* Open **Visual Studio Code**.
* Press **Ctrl + `** to open the integrated terminal.
* Run the following commands:

{% tabs %}
{% highlight C# tabtitle=".NET CLI" %}

dotnet new webapp -o SyncfusionApp

code -r SyncfusionApp

{% endhighlight %}
{% endtabs %}

## Install ASP.NET Core package in the application

To integrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core DataGrid component, install the required [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet packages using the integrated terminal:

1. Press **Ctrl + `** to open the integrated terminal in **Visual Studio Code**.
2. Navigate to the directory containing the **.csproj** file.
3. Run the following commands to install the packages:

* [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/)

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

dotnet add package Syncfusion.EJ2.AspNet.Core --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.AspNet.Core NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

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

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `<ejs-script>` at the end of the `<body>` element in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Chart tag helper to the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@page
<ejs-chart id="container"></ejs-chart>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> on (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> on (macOS) to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Chart control will be rendered in the default web browser.

![ASP.NET Core Chart Control](how-to/images/chart.png)

## Render a Chart with Data

To render a column chart, define a data source and bind it to the chart series using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource), [`xName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName), and [`yName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName) properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@page
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

<ejs-chart id="container" title="Monthly Sales">
    <e-chart-primaryxaxis valueType="Category"></e-chart-primaryxaxis>
    <e-series-collection>
        <e-series dataSource="chartData"
                  xName="Month"
                  yName="Sales"
                  type="Column">
        </e-series>
    </e-series-collection>
</ejs-chart>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Chart Control](how-to/images/chart-data.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Chart/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.

## See Also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)