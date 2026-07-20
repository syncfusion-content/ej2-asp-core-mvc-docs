---
layout: post
title: Getting Started with ASP.NET Core Stock Chart Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Stock Chart control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Stock Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Stock Chart Control

This section explains how to add the [ASP.NET Core Stock Chart](https://www.syncfusion.com/aspnet-core-ui-controls/stock-chart) control to your application using Visual Studio or Visual Studio Code.

## Prerequisites

Refer to the [System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) before creating the application.

## Create an ASP.NET Core Web Application with Razor Pages

You can create an ASP.NET Core application using either of the following options:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

The following tabs walk through creating the project in **Visual Studio** or **Visual Studio Code**.

{% tabcontents %}

{% tabcontent Visual Studio %}

## Create an ASP.NET Core Razor Pages Project Using Visual Studio

1. Start **Visual Studio** and select **Create a new project**.

2. In the **Create a new project** window, choose **ASP.NET Core Web App (Razor Pages)** → **Next**.

3. In the **Configure your new project** dialog, specify the **project name** (and optionally change location/folder).

4. Click **Next**.

5. In the **Additional information** dialog:
* Select **.NET 10.0** or the latest supported .NET version.
* Ensure **Do not use top-level statements** is unchecked (the project should use top-level statements).

6. Click **Create**.

For alternative approaches to create the project, see [Create a new project in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/ide/create-new-project?view=visualstudio).

## Install ASP.NET Core Package in the Application

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET Core** controls in the application, open the NuGet Package Manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
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

To integrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart component, install the required [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet packages using the integrated terminal:

1. Navigate to the directory containing the **.csproj** file.
2. Run the following command to install the package:

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

The theme stylesheet and script can be referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    @* ASP.NET Core controls scripts *@
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Check out the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    @* ASP.NET Core Script Manager *@
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Stock Chart Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart tag helper to the `~/Pages/Index.cshtml` page. The following snippet renders an empty chart; the next section shows how to bind data to it.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@page
@model SyncfusionApp.Pages.IndexModel

<ejs-stockchart id="container">
    <e-stockchart-series-collection>
        <e-stockchart-series></e-stockchart-series>
    </e-stockchart-series-collection>
</ejs-stockchart>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application in Visual Studio. If you are using Visual Studio Code, run the following command in the terminal:

{% tabs %}
{% highlight bash tabtitle=".NET CLI" %}
dotnet run
{% endhighlight %}
{% endtabs %}

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Stock Chart control will be rendered in the default web browser.

![ASP.NET Core Stock Chart Control](images/stockchart-control.webp)

## Populate the Stock Chart with Data

The empty chart above can be replaced with a data-bound chart. This section explains how to populate the [ASP.NET Core Stock Chart](https://www.syncfusion.com/aspnet-core-ui-controls/stock-chart) using data defined in an external JavaScript file.

Create a file inside the `~/wwwroot/js` folder as `financial-data.js` and add the data shown below inside the file.

Add a series object to the chart by using the [`series`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) property, and then set the JSON data from the JavaScript file to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_DataSource) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/populateData/tagHelper %}
{% endhighlight %}
{% highlight js tabtitle="financial-data.js" %}
{% include code-snippet/stock-chart/financial-data.js %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stock Chart with Data](images/stockchart.webp)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/StockChart/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.

## Troubleshooting

If the Stock Chart control does not render as expected, check the following common issues:

* **Tag helpers are not recognized in `.cshtml`** — Ensure `@addTagHelper *, Syncfusion.EJ2` is present in `~/Pages/_ViewImports.cshtml` and that the `Syncfusion.EJ2.AspNet.Core` NuGet package is installed. Build the project so the tag helper assembly is discovered.
* **`Could not load file or assembly Syncfusion.EJ2`** — The NuGet package was not restored. Run `dotnet restore` (or restore packages in Visual Studio) and rebuild.
* **Chart renders without styles** — Confirm the Syncfusion theme stylesheet is referenced in `~/Pages/Shared/_Layout.cshtml`. See the [Themes](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) topic for the available CDN theme references.
* **Chart renders but shows no data** — Verify that the `financial-data.js` script is loaded before the chart's `load` event fires, and that the `dataSource`, `xName`, and `yName` on the `<e-stockchart-series>` match the property names in the data file exactly (case-sensitive).
* **Script-related runtime errors** — Ensure `<ejs-scripts></ejs-scripts>` is registered once at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml`, and that the CDN script version matches the installed NuGet package version.
* **License warning in the console** — Register the Syncfusion license key in `Program.cs` as described in [Register Syncfusion license key](https://ej2.syncfusion.com/aspnetcore/documentation/licensing/how-to-register-in-an-application).

## See Also

* [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
