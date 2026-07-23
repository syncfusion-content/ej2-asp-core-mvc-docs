---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Control | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Sparkline control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC Sparkline Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Sparkline](https://www.syncfusion.com/aspnet-mvc-ui-controls/sparkline) control to your ASP.NET MVC application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC application with HTML helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the namespace

Add the **Syncfusion.EJ2** namespace reference in the `Web.config` file available in the `Views` folder.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add script resources

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

## Add the ASP.NET MVC Sparkline control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sparkline control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<h2> Essential JS 2 for ASP.NET MVC Sparkline </h2>
@Html.EJS().Sparkline("spark").DataSource(Model).XName("xValue").YName("yValue").Height("100").Width("70").Render()

{% endhighlight %}
{% highlight cs tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(DataSource.GetData());
    }
}
public class DataSource
{
    public int x;
    public string xValue;
    public double yValue;
    public static List<DataSource> GetData()
    {
        List<DataSource> data1 = new List<DataSource>();
        data1.Add(new DataSource() { x = 0, xValue = "2005", yValue = 20090440 });
        data1.Add(new DataSource() { x = 1, xValue = "2006", yValue = 20264080 });
        data1.Add(new DataSource() { x = 2, xValue = "2007", yValue = 20434180 });
        data1.Add(new DataSource() { x = 3, xValue = "2008", yValue = 21007310 });
        data1.Add(new DataSource() { x = 4, xValue = "2009", yValue = 21262640 });
        data1.Add(new DataSource() { x = 5, xValue = "2010", yValue = 21515750 });
        data1.Add(new DataSource() { x = 6, xValue = "2011", yValue = 21766710 });
        data1.Add(new DataSource() { x = 7, xValue = "2012", yValue = 22015580 });
        data1.Add(new DataSource() { x = 8, xValue = "2013", yValue = 22262500 });
        data1.Add(new DataSource() { x = 9, xValue = "2014", yValue = 22507620 });
        return data1;
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sparkline control will be rendered in the default web browser.

![ASP.NET MVC Sparkline Control](images/sparkline.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Sparkline/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## Troubleshooting

If the Sparkline control does not render as expected, review the following common issues and their resolutions.

* **"Unlicensed" watermark appears on the page** — The `Syncfusion.Licensing` package is installed but the license key has not been registered. Register the license key in `~/App_Start/FilterConfig.cs` (or `Program.cs`) and rebuild. See [Registering the Syncfusion license key](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application).

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **"Could not load file or assembly 'Syncfusion.EJ2'"** — The NuGet package was not restored. Run `Update-Package -reinstall` in the Package Manager Console, or restore via Visual Studio (right-click solution → Restore NuGet Packages).

* **Chart renders but no data points appear** — The `XName` / `YName` values (`xValueue` / `yValue`) must match the property names in the data model exactly. Property names are case-sensitive.

* **"The model item passed is null"** — The view is decorated with `@model List<SparklineData>` and the controller is returning `null` (or the model is empty). Verify the `Index` action returns a populated list and the namespace in the view matches the model's namespace.

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires a specific `Newtonsoft.Json` version. Install a compatible `Newtonsoft.Json` version (≥ 12.0.2) via NuGet.

## See also

* [Sparkline Types in ASP.NET MVC](https://ej2.syncfusion.com/aspnetmvc/documentation/sparkline/sparkline-types)
* [Data Label in ASP.NET MVC Sparkline](https://ej2.syncfusion.com/aspnetmvc/documentation/sparkline/data-labels)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)
