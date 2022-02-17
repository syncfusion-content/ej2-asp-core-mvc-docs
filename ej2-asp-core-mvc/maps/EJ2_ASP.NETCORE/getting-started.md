---
layout: post
title: Getting Started with ##Platform_Name## Maps Component
description: Checkout and learn about getting started with ##Platform_Name## Maps component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core

You can explore some useful features in the Maps component using the following video.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Prerequisites

To get started with an ASP.NET Core application, make sure you have the following software installed on your computer.

* Visual Studio 2017
* .NET Core 2.0 and above

## Setup ASP.NET Core application with Essential JS 2 for ASP.NET Core

The steps to create an ASP.NET Core application are as follows.

**Step 1:** Click **Create new project** in the **Start page** of Visual Studio 2017, and the popup window below will appear. Click the **OK** button after selecting the **ASP.NET Core Web Application** template. You can also change the name of the project.

![Core template](../maps/images/core-template.png)

**Step 2:** Following the above steps, the popup window below will appear. Select **Web Application(Model View Controller)** in this window. Now the project will be created successfully.

![Default template](../images/default-template.png)

**Step 3:** After you have created your project, use **NuGet Package Manager** to install the **Syncfusion.EJ2.AspNet.Core** package.

Open the **Manage NuGet packages**.

![Solution explorer](../images/solution-Explorer.png)

The **Syncfusion.EJ2.AspNet.Core** package should be installed in the application.

![Nuget demo](../maps/images/nuget-demo1.png)

This package will be included in the project automatically once the installation is complete.

> Since the **NewtonSoft.JSON** package is required by **Syncfusion.EJ2.AspNet.Core**, we must install **NewtonSoft.JSON** as a dependency.

**Step 4:** To import the **Syncfusion.EJ2** package, go to the **Views** folder and open the **_ViewImports.cshtml** file.

```cs
@addTagHelper *, Syncfusion.EJ2
```

**Step 4:** Add client-side resource through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or local [package](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page **_Layout.cshtml** which is located in the **Views/Shared** folder. Within the **head** tag, add the script reference like below.

```cs
@* Syncfusion Essential JS 2 Scripts *@
<script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
```

**Step 5:** Script manager should be added to the **_Layout.cshtml** layout page within the **body** tag, which is located in the **Views/Shared** folder.

```cs
<body>
    ....
    ....
    <!-- Syncfusion Essential JS 2 ScriptManager -->
    <ejs-scripts></ejs-scripts>
</body>
```

**Step 6:** To initialize the Maps, add the following code to your **Index.cshtml** view page, which is located in the **Views/Home** folder.

```html

@using Syncfusion.EJ2.Maps;
<ejs-maps id="maps">
</ejs-maps>

```

## Render shapes from GeoJSON data

This section explains how to bind GeoJSON data to the Maps.

```cs

public IActionResult Default()
{
    ViewBag.mapdata = GetUSMap();
    return View();
}
public object GetUSMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
    return JsonConvert.DeserializeObject(allText);
}

```

Elements in the Maps will be rendered in the layers. So, add a layer to the Maps by using the [`Layers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_Layers) property. Now bind the GeoJSON data to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property.

```html

@using Syncfusion.EJ2;
 <ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="ViewBag.usmap">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

> Only if [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) is provided, map layers will render.

## Bind data source to map

The following properties in layers are used for binding the data source to the map.

* [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource)
* [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath)
* [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath)

The [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property takes set of key/value pair as input. For example, a list of objects can be provided as input. This data is further used in a tooltip, data label, legend and color mapping.

The [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property is used to reference the key in dataSource. Whereas, the [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) property is used to reference the column name in [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) to identify the shape. Both properties are related to each other. When the values of the [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property in the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property and the value of [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) in the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property match, then the associated object from the data source is bound to the corresponding shape.

The JSON object **"electionData.json"** is used as data source in the below code.

```html
[
    { Country: 'China', Membership: 'Permanent' },
    { Country: 'France', Membership: 'Permanent' },
    { Country: 'Russia', Membership: 'Permanent' },
    { Country: 'United Kingdom', Membership: 'Permanent' },
    { Country: 'United States', Membership: 'Permanent' },
    { Country: 'Bolivia', Membership: 'Non-Permanent' },
    { Country: 'Eq. Guinea', Membership: 'Non-Permanent' },
    { Country: 'Ethiopia', Membership: 'Non-Permanent' },
    { Country: "Côte d'Ivoire", Membership: 'Permanent' },
    { Country: 'Kazakhstan', Membership: 'Non-Permanent' },
    { Country: 'Kuwait', Membership: 'Non-Permanent' },
    { Country: 'Netherlands', Membership: 'Non-Permanent' },
    { Country: 'Peru', Membership: 'Non-Permanent' },
    { Country: 'Poland', Membership: 'Non-Permanent' },
    { Country: 'Sweden', Membership: 'Non-Permanent' },
];

```

```cs

public IActionResult Default()
{
    ViewBag.usmap = GetUSMap();
    ViewBag.electiondata = GetData();
    return View();
}
public object GetUSMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
    return JsonConvert.DeserializeObject(allText);
}
public object GetData()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/electionData.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2;
 <ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer dataSource="ViewBag.electiondata" shapeData="ViewBag.usmap" shapeDataPath="State" shapePropertyPath="name">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

## Apply color mapping

The color mapping feature supports customization of shape colors based on the underlying value of shape received from the bound data. To apply the color to the shapes, specify the field name from the datasource to the  [`ColorValuePath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsShapeSettings.html#Syncfusion_EJ2_Maps_MapsShapeSettings_ColorValuePath) property of [`MapsShapeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsShapeSettings.html) class.

Specify the color and value in the [`MapsColorMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsColorMapping.html) property. Here **"#D84444"** is specified for **Permanent** countries and **"#316DB5"** is specified for **Non-Permanent** countries.

```cs

public IActionResult Default()
{
    ViewBag.worldmap = GetWorldMap();
    ViewBag.electiondata = GetData();
    return View();
}
public object GetWorldMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
    return JsonConvert.DeserializeObject(allText);
}
public object GetData()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/electionData.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2.Maps;

@{
    var propertyPath = new[] { "name" };
    var colormapping = new List<Syncfusion.EJ2.Maps.MapsColorMapping> {
        new  MapsColorMapping{ Color = "#EDB46F", Value= "Permanent"  },
        new MapsColorMapping { Color= "#F1931B", Value = "Non-Permanent" }
    };
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer dataSource="ViewBag.electiondata" shapeData="ViewBag.worldmap" shapeDataPath="Country" shapePropertyPath="propertyPath">
            <e-layersettings-shapesettings colorValuePath="Membership" fill="#E5E5E5" colorMapping="colormapping"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

> Refer the value of the data source for **electionData.json** [here](#bind-data-source-to-map).

## Add title to Maps

The title can be added to the Maps using the [`MapsTitleSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTitleSettings.html) class to provide information to the user about the shapes rendered in the Maps.

```cs

public IActionResult Default()
{
    ViewBag.usmap = GetUSMap();
    return View();
}
public object GetUSMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2.Maps;
@{
    var titleStyle = new MapsFont
    {
        Size = "10px",
        Color = "red",
        FontFamily = "Sans-serif"
    };
}

<ejs-maps id="maps">
    <e-maps-titlesettings text="Maps component" textStyle="titleStyle"></e-maps-titlesettings>
    <e-maps-layers>
        <e-maps-layer shapeData="ViewBag.usmap">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

## Enable legend

Legend can be added to the Maps to summarize the data bound to the map. To enable legend for the Maps, set the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [`MapsLegendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html) class to **true**.

```cs

public IActionResult Default()
{
    ViewBag.worldmap = GetWorldMap();
    ViewBag.electiondata = GetData();
    return View();
}
public object GetWorldMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/WorldMap.json");
    return JsonConvert.DeserializeObject(allText);
}
public object GetData()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/electionData.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2.Maps;
@{
    var propertyPath = new[] { "name" };
    var colormapping = new List<Syncfusion.EJ2.Maps.MapsColorMapping> {
        new  MapsColorMapping{ Color = "#EDB46F",Value= "Permanent"  },
        new MapsColorMapping { Color= "#F1931B", Value = "Non-Permanent" }
    };
}

<ejs-maps id="maps">
    <e-maps-legendsettings visible="true" position="Top"></e-maps-legendsettings>
    <e-maps-layers>
        <e-maps-layer dataSource="ViewBag.electiondata" shapeData="ViewBag.worldmap" shapeDataPath="Country" shapePropertyPath="propertyPath">
            <e-layersettings-shapesettings colorValuePath="Membership" fill="#E5E5E5" colorMapping="colormapping"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

> Refer the value of the data source for **electionData.json** [here](#bind-data-source-to-map).

## Add data label

The data labels can be added to the Maps to show additional information of the shapes in the Maps. This can be achieved by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Visible) property to **true** in the [`MapsDataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) class.

```cs

public IActionResult Default()
{
    ViewBag.usmap = GetUSMap();
    return View();
}
public object GetUSMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2.Maps;

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="ViewBag.usmap">
            <e-layersettings-datalabelsettings visible="true" labelPath="name" smartLabelMode="@Syncfusion.EJ2.Maps.SmartLabelMode.Trim"></e-layersettings-datalabelsettings>
            <e-layersettings-shapesettings autofill="true"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```

## Enable tooltip

When the data labels can't display the information due to space constraints, the tooltip is used. The tooltip can be enabled by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTooltipSettings.html#Syncfusion_EJ2_Maps_MapsTooltipSettings_Visible) property of the [`MapsTooltipSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTooltipSettings.html) class to **true**.

```cs

public IActionResult Default()
{
    ViewBag.usmap = GetUSMap();
    return View();
}
public object GetUSMap()
{
    string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/USA.json");
    return JsonConvert.DeserializeObject(allText);
}

```

```html

@using Syncfusion.EJ2.Maps;

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="ViewBag.usmap">
            <e-layersettings-datalabelsettings visible="true" labelPath="name" smartLabelMode="@Syncfusion.EJ2.Maps.SmartLabelMode.Trim">
            </e-layersettings-datalabelsettings>
            <e-layersettings-tooltipsettings visible="true" valuePath="name"></e-layersettings-tooltipsettings>
            <e-layersettings-shapesettings autofill="true"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

```
