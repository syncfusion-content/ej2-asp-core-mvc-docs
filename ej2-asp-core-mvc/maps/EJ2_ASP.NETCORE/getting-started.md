---
layout: post
title: Getting Started with Syncfusion ##Platform_Name## Maps Component
description: Checkout and learn about getting started with ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Maps Component

This section briefly explains how to add the [ASP.NET Core Maps](https://www.syncfusion.com/aspnet-core-ui-controls/maps) component to your ASP.NET Core application using Visual Studio.

To get started quickly with the ASP.NET Core Maps component, watch this video:

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Prerequisites

Refer to the [System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements) before creating the application.

## Create an ASP.NET Core Web Application with Razor Pages

You can create an ASP.NET Core application using either of the following options:

* [Create a project using Microsoft templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project)

## Install the ASP.NET Core NuGet Package

To add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls to the application, open the NuGet Package Manager in Visual Studio by selecting **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**. Search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/), and then install it. Alternatively, you can use the following Package Manager command.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). Refer to the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic to learn more about installing NuGet packages in various operating system environments. The Syncfusion.EJ2.AspNet.Core NuGet package depends on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating the Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

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

## Add the ASP.NET Core Maps Control

Add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Maps tag helper to the `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps

<ejs-maps id="maps">
</ejs-maps>

{% endhighlight %}
{% endtabs %}

## Render Shapes from GeoJSON Data

Elements in the Maps control are rendered in layers. Add a layer to the Maps control using the [`Layers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_Layers) property. Then, bind the GeoJSON data to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps

@{
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData = JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="mapUSData">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> on Windows or <kbd>⌘</kbd>+<kbd>F5</kbd> on macOS to run the application. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Maps component will be rendered in the default web browser.

![ASP.NET Core Maps Component](images/maps-control.png)

N> Map layers render only when [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) is provided. Refer to the [world map data values](https://www.syncfusion.com/downloads/support/directtrac/general/ze/WorldMap-637657487).

## Bind a Data Source to the Map

The following layer properties are used to bind a data source to the map:

* [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource)
* [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath)
* [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath)

The [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property accepts a set of key/value pairs as input. For example, a list of objects can be provided as input. This data can be used in tooltips, data labels, legends, and color mapping.

The [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property is used to reference the key in the data source. The [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) property is used to reference the field name in [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) to identify the shape. When the value of the `ShapeDataPath` property in the `DataSource` property matches the value of the `ShapePropertyPath` property in the `ShapeData` property, the associated object from the data source is bound to the corresponding shape.

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
{% highlight cshtml tabtitle="CSHTML" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps

@{
    var propertyPath = new[] { "name" };
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData = JsonConvert.DeserializeObject(allText);
    string allText1 = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/electiondata.json");
    var electionData = JsonConvert.DeserializeObject(allText1);
}

<ejs-maps id="maps">
    <e-maps - layers>
        <e-maps - layer dataSource="electionData" shapeData="mapUSData" shapeDataPath="Country"
                shapePropertyPath="propertyPath">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core - Essential JS2 Maps](../maps/images/mapsdata.png)

N> Refer to the data source values for **electionData.json** in the [Bind a Data Source to the Map](#bind-a-data-source-to-the-map) section.

N> Explore the sample on [GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Maps/ASP.NET%20Core%20Tag%20Helper%20Examples) to understand how this getting started example works.

## See Also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
