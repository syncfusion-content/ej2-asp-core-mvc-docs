---
layout: post
title: Getting Started with ##Platform_Name## Stock Chart Control
description: Checkout and learn about getting started with ##Platform_Name## Stock Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with the  ASP.NET Core Stock Chart Control

This section explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET Core Stock Chart](https://www.syncfusion.com/aspnet-core-ui-controls/stock-chart) to your application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) before creating the application.

## Create an ASP.NET Core Web Application with Razor Pages

You can create an ASP.NET Core application using either of the following options:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

{% tabcontents %}

{% tabcontent Visual Studio %}

## Create an ASP.NET Core Razor Pages Project Using Visual Studio

1. Start **Visual Studio** and select **Create a new project**.

2. In the **Create a new project** window, choose **ASP.NET Core Web App (Razor Pages)** → **Next**.

3. In the **Configure your new project** dialog, specify the **project name** (and optionally change location/folder).

4. Click **Next**.

5. In the **Additional information** dialog:
* Select **.NET 10.0** or the latest supported .NET version.
* Ensure that **Do not use top-level statements** is unchecked.

6. Click **Create**.

For alternative approaches to create the project, see [Create a new project in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/create-new-project?view=visualstudio).

## Install ASP.NET Core Package in the Application

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET Core** controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and install it.

Alternatively, you can use the Package Manager Console by navigating to
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}


{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Create an ASP.NET Core Razor Pages Project Using Visual Studio Code

1. Install the latest **.NET SDK** that supports **.NET 10.0** or later.
2. Open **Visual Studio Code**.
3. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> to open the integrated terminal.
4. Run the following command to create the project:

{% tabs %}
{% highlight bash tabtitle=".NET CLI" %}

dotnet new webapp -o SyncfusionApp

{% endhighlight %}
{% endtabs %}

Then, open the project in a new Visual Studio Code window using the following command:

{% tabs %}
{% highlight bash tabtitle=".NET CLI" %}

code -r SyncfusionApp

{% endhighlight %}
{% endtabs %}

## Install ASP.NET Core Package in the Application

To integrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart control, install the required [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet packages using the integrated terminal:

1. Navigate to the directory containing the **.csproj** file.
2. Run the following commands to install the package:

{% tabs %}
{% highlight bash tabtitle=".NET CLI" %}

dotnet add package Syncfusion.EJ2.AspNet.Core --version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

{% endtabcontent %}

{% endtabcontents %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.AspNet.Core NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` Tag Helper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add Stylesheet and Script Resources

Add the stylesheet and script references inside the `<head>` element of the `~/Pages/Shared/_Layout.cshtml` file as follows.

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

N> Refer to the [Themes](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) topic to learn different ways, such as [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator), to refer to styles in an ASP.NET Core application and achieve the expected appearance for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls.

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

## Add the ASP.NET Core Stock Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart tag helper to the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-stockchart id="container">
    <e-stockchart-series-collection>
        <e-stockchart-series></e-stockchart-series>
    </e-stockchart-series-collection>
</ejs-stockchart>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application in
Visual Studio. If you are using Visual Studio Code, run the following command in the terminal:

{% tabs %}
{% highlight bash tabtitle=".NET CLI" %}
dotnet run
{% endhighlight %}
{% endtabs %}

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart control will be rendered in the default web browser.

![ASP.NET Core Stock Chart Control](images/stockchart-control.png)

## Populate the Stock Chart with Data

This section explains how to populate the ASP.NET Core Stock Chart using data defined in an external JavaScript file.

Add a series object to the chart by using the [`series`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) property, and then set the JSON data from the JavaScript file to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_DataSource) property.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/populateData/tagHelper %}
{% endhighlight %}
{% highlight cshtml tabtitle="financial-data.js" %}
{% include code-snippet/stock-chart/financial-data.js %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stock Chart with Data](images/stockchart.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/StockChart/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.
 
## See Also

* [ASP.NET Core Stock Chart](https://www.syncfusion.com/aspnet-core-ui-controls/stock-chart) feature tour page for its feature representations
* [ASP.NET Core Stock Chart example](https://ej2.syncfusion.com/aspnetcore/StockChart/Default#/material) to learn how to present and manipulate data.
