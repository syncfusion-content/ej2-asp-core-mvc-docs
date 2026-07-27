---
layout: post
title: Getting Started with ##Platform_Name## 3D Circular Chart | Syncfusion
description: Check out and learn about getting started with the ##Platform_Name## 3D Circular Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with the ASP.NET MVC 3D Circular Chart Control

This section briefly explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC 3D Circular Chart](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts) control to an ASP.NET MVC 5 (.NET Framework) application using Visual Studio.

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application. 

## Create an ASP.NET MVC application with HTML helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)
* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting **Tools → NuGet Package Manager → Manage NuGet Packages for Solution**. Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to **Tools → NuGet Package Manager → Package Manager Console**, and then run the following command:

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The `Syncfusion.EJ2.MVC5` NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) (≥ 12.0.2) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the namespace

Add the **Syncfusion.EJ2** namespace reference inside the `<system.web.webPages.razor>` → `<pages>` → `<namespaces>` element of the `~/Views/Web.config` file.

{% tabs %}
{% highlight xml tabtitle="~/Views/Web.config" %}

<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>

{% endhighlight %}
{% endtabs %}

## Add script resources

Add the script reference inside the `<head>` element of the `~/Views/Shared/_Layout.cshtml` file as follows. The reference loads the base `ej2.min.js` bundle, which contains the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC helper scripts.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Refer to the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in an ASP.NET MVC application.

## Register the Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Register the script manager `EJS().ScriptManager()` at the end of the `<body>` element in the `~/Views/Shared/_Layout.cshtml` file as follows. The Script Manager resolves and loads control-specific scripts automatically.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Build the 3D Circular Chart

This section walks through adding the 3D Circular Chart control to `~/Views/Home/Index.cshtml` and progressively binding data to it from `~/Controllers/HomeController.cs`.

### Step 1: Add the 3D Circular Chart control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC 3D Circular Chart control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().CircularChart3D("container").Render()

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The 3D Circular Chart control will be rendered as an empty placeholder in the default web browser.

![ASP.NET MVC 3D Circular Chart Control](images/circular-chart-3d.png)

### Step 2: Bind data with a Pie series

By default, a pie series is rendered when JSON data is assigned to the series using the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.CircularChart3DSeries.html#Syncfusion_EJ2_Charts_CircularChart3DSeries_DataSource) property. Map the field names in the JSON data to the [XName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.CircularChart3DSeries.html#Syncfusion_EJ2_Charts_CircularChart3DSeries_XName) and [YName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.CircularChart3DSeries.html#Syncfusion_EJ2_Charts_CircularChart3DSeries_YName) properties of the series.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<CircularChartData> circularData = new List<CircularChartData>
        {
            new CircularChartData { X = "Chrome", Y = 62.92 },
	        new CircularChartData { X = "Internet Explorer", Y = 6.12 },
	        new CircularChartData { X = "Opera", Y = 3.15 },
	        new CircularChartData { X = "Edge", Y = 5.5 },
	        new CircularChartData { X = "Safari", Y = 19.97 },
	        new CircularChartData { X = "Others", Y = 2.34 }
        };
        return View(circularData);
    }
}

public class CircularChartData
{
    public string X { get; set; }
    public double Y { get; set; }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd> + <kbd>F5</kbd> on Windows or <kbd>⌘</kbd> + <kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC 3D Circular Chart control will be rendered with the bound data in the default web browser.

![ASP.NET MVC 3D Circular Chart Control with Data](images/circular-chart-3d.png)

## Troubleshooting

If the 3D Circular Chart control does not render as expected, review the following common issues and their resolutions.

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **Chart renders but no slices appear** — `XName` / `YName` do not match the property names in the data source. Property names are case-sensitive; verify they match the model property names exactly (e.g., `X`, `Y`).

* **`CS0103: The name 'X' does not exist` or `CS0206` compile errors** — `CircularChartData` was declared with public *fields* (`public string X;`) and then initialized using object-initializer syntax that requires *properties*. Change the fields to auto-properties (`public string X { get; set; }`).

* **`Newtonsoft.Json` reference error after upgrade** — `Syncfusion.EJ2.MVC5` requires `Newtonsoft.Json` ≥ 12.0.2. Install a compatible version via NuGet.

## See also

* [Pie and doughnut series in ASP.NET MVC 3D Circular Chart](https://ej2.syncfusion.com/aspnetmvc/documentation/circular-chart-3d/pie-donut-chart)
* [Legend in ASP.NET MVC 3D Circular Chart](https://ej2.syncfusion.com/aspnetmvc/documentation/circular-chart-3d/legend)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)