---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Control
description: Check out and learn about getting started with ##Platform_Name## Sparkline control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Sparkline Control

This section briefly explains how to include the [ASP.NET Core Sparkline](https://www.syncfusion.com/aspnet-core-ui-controls/sparkline) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it. Alternatively, you can run the following command in the **Package Manager Console**.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add script resources

Here, script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Sparkline Control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Sparkline tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-sparkline id="sparkline">
</ejs-sparkline>

{% endhighlight %}
{% endtabs %}

## Bind data source to Sparkline

The [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.sparkline.html#Syncfusion_EJ2_Charts_Sparkline_DataSource) property is used for binding data to the Sparkline. Set the `xName` and `yName` properties to the field names from your data source that should be plotted.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SparklineData.cs" %}
public class SparklineData
{
    public string xval { get; set; }
    public double yval { get; set; }
    public static List<SparklineData> GetData()
    {
        List<SparklineData> data = new List<SparklineData>();
        data.Add(new SparklineData() { xval = "2005", yval = 20090440 });
        data.Add(new SparklineData() { xval = "2006", yval = 20264080 });
        data.Add(new SparklineData() { xval = "2007", yval = 20434180 });
        data.Add(new SparklineData() { xval = "2008", yval = 21007310 });
        data.Add(new SparklineData() { xval = "2009", yval = 21262640 });
        data.Add(new SparklineData() { xval = "2010", yval = 21515750 });
        data.Add(new SparklineData() { xval = "2011", yval = 21766710 });
        data.Add(new SparklineData() { xval = "2012", yval = 22015580 });
        data.Add(new SparklineData() { xval = "2013", yval = 22262500 });
        data.Add(new SparklineData() { xval = "2014", yval = 22507620 });
        return data;
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Sparkline control will be rendered in the default web browser.

![ASP.NET Core Sparkline Control](images/sparkline-control.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/SparkLine/ASP.NET%20Core%20Tag%20Helper%20Examples).


## Troubleshooting

If the Sparkline does not render or you run into build/runtime issues, try the following:

* **Sparkline is not visible on the page** — Ensure the `ejs-scripts` tag helper is registered at the end of `<body>` in `~/Pages/Shared/_Layout.cshtml`. Missing this registration prevents Syncfusion client-side scripts from initializing the control.
* **Sparkline renders with no data points** — Confirm that the data model exposes `xval` and `yval` properties and that the `xName`/`yName` values on the tag helper match the field names exactly.
* **Build error: `TagHelper is not registered`** — Verify that `~/Pages/_ViewImports.cshtml` contains `@addTagHelper *, Syncfusion.EJ2` and rebuild the solution.
* **NuGet restore failures** — Confirm the project targets a supported .NET version and that the NuGet feed is reachable. Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic.

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)