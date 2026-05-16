---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Maps Component | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET MVC Maps Component

This section briefly explains how to add the [ASP.NET MVC Maps](https://www.syncfusion.com/aspnet-mvc-ui-controls/maps-library) component to your ASP.NET MVC application using Visual Studio.

You can explore some useful features in the Maps component using the following video.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Prerequisites

You can create an ASP.NET MVC application using either of the following options:

Refer to the [System requirements for ASP.NET MVC components](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements) before creating the application.

## Create an ASP.NET MVC Application with HTML Helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/create-project)

## Install the ASP.NET MVC NuGet Package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls to the application, open the NuGet Package Manager in Visual Studio by selecting **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**. Search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5), and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in  [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.MVC5 NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add the Namespace

Add the **Syncfusion.EJ2** namespace reference in the `Web.config` file available in the `Views` folder.

```xml
<namespaces>
    <add namespace="Syncfusion.EJ2" />
</namespaces>
```

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

## Add the ASP.NET MVC Maps Component

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Maps component to the `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().Maps("container").Layers(layer =>
{
    layer.ShapeData(Model).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

Place the **WorldMap.json** file in the **App_Data** folder of the project. Read the content of the **WorldMap.json** file in the controller and assign the deserialized object to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property of the Maps component as shown below.

{% tabs %}
{% highlight c# tabtitle="HomeController.cs" %}

public ActionResult Index()
{
    return View(GetWorldMap());
}

public object GetWorldMap()
{
    string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
    return JsonConvert.DeserializeObject(allText, typeof(object));
}

{% endhighlight %}
{% endtabs %}

N> Map layers render only when `ShapeData` is provided [here](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487).

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> on (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> on (macOS) to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Maps component will be rendered in the default web browser.

![ASP.NET MVC - Essential JS2 Maps](../maps/images/aspnetmvc-maps.png)

## Bind a Data Source to the Map

The following layer properties are used to bind a data source to the map:

* [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource)
* [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath)
* [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath)

The [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property accepts a set of key/value pairs as input. For example, a list of objects can be provided as input. This data can be used in tooltips, data labels, legends, and color mapping.

The [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property is used to reference the key in the data source. The [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) property is used to reference the field name in [`ShapeData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) to identify the shape. When the value of the `ShapeDataPath` property in the `DataSource` property matches the value of the `ShapePropertyPath` property in the `ShapeData` property, the associated object from the data source is bound to the corresponding shape.

The following JSON data is used as the data source in the **electionData.json** file.

```json
[
    { "Country": "China", "Membership": "Permanent" },
    { "Country": "France", "Membership": "Permanent" },
    { "Country": "Russia", "Membership": "Permanent" },
    { "Country": "United Kingdom", "Membership": "Permanent" },
    { "Country": "United States", "Membership": "Permanent" },
    { "Country": "Bolivia", "Membership": "Non-Permanent" },
    { "Country": "Eq. Guinea", "Membership": "Non-Permanent" },
    { "Country": "Ethiopia", "Membership": "Non-Permanent" },
    { "Country": "Côte d'Ivoire", "Membership": "Permanent" },
    { "Country": "Kazakhstan", "Membership": "Non-Permanent" },
    { "Country": "Kuwait", "Membership": "Non-Permanent" },
    { "Country": "Netherlands", "Membership": "Non-Permanent" },
    { "Country": "Peru", "Membership": "Non-Permanent" },
    { "Country": "Poland", "Membership": "Non-Permanent" },
    { "Country": "Sweden", "Membership": "Non-Permanent" }
]
```

{% tabs %}
{% highlight c# tabtitle="HomeController.cs" %}

using Newtonsoft.Json;
using System.Web.Mvc;

public ActionResult Index()
{
    ViewBag.shapeData = GetWorldMap();
    ViewBag.electionData = GetElectionData();
    ViewBag.shapePropertyPath = new[] { "name" };

    return View();
}

public object GetWorldMap()
{
    string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
    return JsonConvert.DeserializeObject(allText, typeof(object));
}

public object GetElectionData()
{
    string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/electionData.json"));
    return JsonConvert.DeserializeObject(allText, typeof(object));
}

{% endhighlight %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps
@using Syncfusion.EJ2

@Html.EJS().Maps("container").Layers(layer =>
{
    layer.ShapeData(ViewBag.shapeData)
    .DataSource(ViewBag.electionData)
    .ShapeDataPath("Country")
    .ShapePropertyPath(ViewBag.shapePropertyPath)
    .Add();
}).Render()

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC - Essential JS2 Maps](../maps/images/mapsdata.png)

N> Refer to the data source values for **electionData.json** in the [Bind a Data Source to the Map](#bind-a-data-source-to-the-map) section.

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Map/ASP.NET%20MVC%20Razor%20Examples) to understand how this getting started example works.

## See Also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC using HTML Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-mvc-htmlhelper)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/aspnet-core-mvc-taghelper)
