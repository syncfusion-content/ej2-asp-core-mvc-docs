---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Maps Component | Syncfusion
description: Check out and learn about getting started with ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with the ASP.NET MVC Maps Control

This section explains how to add the Syncfusion<sup style="font-size:70%">&reg;</sup> [ASP.NET MVC Maps](https://www.syncfusion.com/aspnet-mvc-ui-controls/maps-library) control to your ASP.NET MVC application using Visual Studio.

You can explore some useful features in the Maps control in the following video.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Prerequisites

Refer to the [System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC application with HTML helper

You can create an ASP.NET MVC application using either of the following options:

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> **ASP.NET MVC** controls in the application, open the NuGet Package Manager in Visual Studio by selecting (Tools → NuGet Package Manager → Manage NuGet Packages for Solution). Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and install it.

Alternatively, you can use the Package Manager Console by navigating to:
Tools → NuGet Package Manager → Package Manager Console, and then run the following command:

{% tabs %}
{% highlight bash tabtitle="Package Manager Console" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in  [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

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

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

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

## Add the ASP.NET MVC Maps Control

Place the **WorldMap.json** file in the **App_Data** folder of the project. You can download a sample `WorldMap.json` from the [Syncfusion samples download page](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487). The file should contain valid GeoJSON for the world map at country boundaries.

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Maps control to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().Maps("container").Layers(layer =>
{
    layer.ShapeData(Model).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

Read the content of the **WorldMap.json** file in the controller and assign the deserialized object to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property of the Maps control as shown below.

{% tabs %}
{% highlight c# tabtitle="HomeController.cs" %}

using System.Web.Mvc;
using Newtonsoft.Json;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(GetWorldMap());
    }

    public object GetWorldMap()
    {
        string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
        return JsonConvert.DeserializeObject(allText, typeof(object));
    }
}

{% endhighlight %}
{% endtabs %}

N> Map layers render only when `ShapeData` is provided. See the [Syncfusion samples download page](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487) for a sample `WorldMap.json` file.

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> on Windows or <kbd>⌘</kbd>+<kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Maps control will be rendered in the default web browser.

![ASP.NET MVC - Essential JS2 Maps](../maps/images/aspnetmvc-maps.png)

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Map/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## Troubleshooting

If the Maps control does not render as expected, review the following common issues and their resolutions.

* **"Unlicensed" watermark appears on the page** — The `Syncfusion.Licensing` package is installed but the license key has not been registered. Register the license key in `~/App_Start/FilterConfig.cs` (or `Program.cs`) and rebuild. See [Registering the Syncfusion license key](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register).

* **"Could not find file '~/App_Data/WorldMap.json'"** — The map data file has not been placed in the project. Download `WorldMap.json` from the [Syncfusion samples download page](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487), save it to `~/App_Data/WorldMap.json`, then rebuild and re-run.

* **"Could not load file or assembly 'Syncfusion.EJ2'"** — The NuGet package was not restored. Run `Update-Package -reinstall` in the Package Manager Console, or restore via Visual Studio (right-click solution → Restore NuGet Packages).

* **"Script Manager is not defined" or scripts run twice** — `@Html.EJS().ScriptManager()` was not added, or was added more than once. Ensure `ScriptManager` is registered exactly once at the end of `<body>` in `_Layout.cshtml`.

* **Map renders but countries are missing or distorted** — The `WorldMap.json` file is not valid GeoJSON. Validate it using a GeoJSON linter, or re-download a known-good sample.

* **"Newtonsoft.Json" reference error** — `JsonConvert` is used in the controller but the `Newtonsoft.Json` `using` directive is missing or the package is not installed. Install `Newtonsoft.Json` (≥ 12.0.2) via NuGet and add `using Newtonsoft.Json;` at the top of `HomeController.cs`.

## See also

* [Map layers in ASP.NET MVC ](https://ej2.syncfusion.com/aspnetmvc/documentation/maps/layers)
* [Markers in ASP.NET MVC Maps ](https://ej2.syncfusion.com/aspnetmvc/documentation/maps/markers)
* [Data labels in ASP.NET MVC Maps](https://ej2.syncfusion.com/aspnetmvc/documentation/maps/data-label)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)

