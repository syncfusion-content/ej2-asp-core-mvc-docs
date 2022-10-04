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

This section briefly explains about how to include [ASP.NET Core Maps](https://www.syncfusion.com/aspnet-core-ui-controls/maps) component in your ASP.NET Core application using Visual Studio.

{% youtube "https://www.youtube.com/watch?v=kwE6ikF7QYQ" %}

## Prerequisites

[System requirements for ASP.NET Core components](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core components are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core components in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core components. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core components styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core components scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
    ....
    ....
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Maps component

Now, add the Syncfusion ASP.NET Core Maps tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps;
<ejs-maps id="maps">
</ejs-maps>

{% endhighlight %}
{% endtabs %}

## Render shapes from GeoJSON data

Elements in the Maps will be rendered in the layers. So, add a layer to the Maps by using the [`Layers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.Maps.html#Syncfusion_EJ2_Maps_Maps_Layers) property. Now bind the GeoJSON data to the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps
@{
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="mapUSData">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Maps component will be rendered in the default web browser.

![ASP.NET Core Maps Component](images/maps-control.png)

> Only if [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) is provided, map layers will render.

## Bind data source to map

The following properties in layers are used for binding the data source to the map.

* [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource)
* [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath)
* [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath)

The [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property takes set of key/value pair as input. For example, a list of objects can be provided as input. This data is further used in a tooltip, data label, legend and color mapping.

The [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property is used to reference the key in data source. Whereas, the [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) property is used to reference the column name in [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) to identify the shape. Both properties are related to each other. When the values of the [`ShapeDataPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeDataPath) property in the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_DataSource) property and the value of [`ShapePropertyPath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapePropertyPath) in the [`ShapeData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLayer.html#Syncfusion_EJ2_Maps_MapsLayer_ShapeData) property match, then the associated object from the data source is bound to the corresponding shape.

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

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps;

@{
    var propertyPath = new[] { "name" };
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
    string allText1 = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/electiondata.json");
    var electionData = JsonConvert.DeserializeObject(allText1);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer dataSource="electionData" shapeData="mapUSData" shapeDataPath="Country" shapePropertyPath="name">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

## Apply color mapping

The color mapping feature supports customization of shape colors based on the underlying value of shape received from the bound data. To apply the color to the shapes, specify the field name from the data source to the  [`ColorValuePath`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsShapeSettings.html#Syncfusion_EJ2_Maps_MapsShapeSettings_ColorValuePath) property of [`MapsShapeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsShapeSettings.html) class.

Specify the color and value in the [`MapsColorMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsColorMapping.html) property. Here **"#D84444"** is specified for **Permanent** countries and **"#316DB5"** is specified for **Non-Permanent** countries.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Newtonsoft.Json
@using Syncfusion.EJ2.Maps;

@{
    var propertyPath = new[] { "name" };
    var colormapping = new List<Syncfusion.EJ2.Maps.MapsColorMapping> {
        new  MapsColorMapping{ Color = "#EDB46F", Value= "Permanent"  },
        new MapsColorMapping { Color= "#F1931B", Value = "Non-Permanent" }
    };
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
    string allText1 = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/electiondata.json");
    var electionData = JsonConvert.DeserializeObject(allText1);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer dataSource="electionData" shapeData="mapUSData" shapeDataPath="Country" shapePropertyPath="propertyPath">
            <e-layersettings-shapesettings colorValuePath="Membership" fill="#E5E5E5" colorMapping="colormapping"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Maps with Color Mapping](images/maps-color-mapping.png)

> Refer the value of the data source for **electionData.json** [here](#bind-data-source-to-map).

## Add title to Maps

The title can be added to the Maps using the [`MapsTitleSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTitleSettings.html) class to provide information to the user about the shapes rendered in the Maps.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps
@using Newtonsoft.Json
@{
    var titleStyle = new MapsFont
    {
        Size = "10px",
        Color = "red",
        FontFamily = "Sans-serif"
    };
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-titlesettings text="Maps component" textStyle="titleStyle"></e-maps-titlesettings>
    <e-maps-layers>
        <e-maps-layer shapeData="mapUSData">
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Maps with Title](images/maps-title.png)

## Enable legend

Legend can be added to the Maps to summarize the data bound to the map. To enable legend for the Maps, set the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html#Syncfusion_EJ2_Maps_MapsLegendSettings_Visible) property of [`MapsLegendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsLegendSettings.html) class to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps;
@{
    var propertyPath = new[] { "name" };
    var colormapping = new List<Syncfusion.EJ2.Maps.MapsColorMapping> {
        new  MapsColorMapping{ Color = "#EDB46F",Value= "Permanent"  },
        new MapsColorMapping { Color= "#F1931B", Value = "Non-Permanent" }
    };
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
    string allText1 = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/electiondata.json");
    var electionData = JsonConvert.DeserializeObject(allText1);
}

<ejs-maps id="maps">
    <e-maps-legendsettings visible="true" position="Top"></e-maps-legendsettings>
    <e-maps-layers>
        <e-maps-layer dataSource="electionData" shapeData="mapUSData" shapeDataPath="Country" shapePropertyPath="propertyPath">
            <e-layersettings-shapesettings colorValuePath="Membership" fill="#E5E5E5" colorMapping="colormapping"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Maps with Legend](images/maps-legend.png)

> Refer the value of the data source for **electionData.json** [here](#bind-data-source-to-map).

## Add data label

The data labels can be added to the Maps to show additional information of the shapes in the Maps. This can be achieved by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html#Syncfusion_EJ2_Maps_MapsDataLabelSettings_Visible) property to **true** in the [`MapsDataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsDataLabelSettings.html) class.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps
@using Newtonsoft.Json

@{
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="mapUSData">
            <e-layersettings-datalabelsettings visible="true" labelPath="name" smartLabelMode="@Syncfusion.EJ2.Maps.SmartLabelMode.Trim"></e-layersettings-datalabelsettings>
            <e-layersettings-shapesettings autofill="true"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Maps with DataLabel](images/maps-datalabel.png)

## Enable tooltip

When the data labels can't display the information due to space constraints, the tooltip is used. The tooltip can be enabled by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTooltipSettings.html#Syncfusion_EJ2_Maps_MapsTooltipSettings_Visible) property of the [`MapsTooltipSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsTooltipSettings.html) class to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2.Maps
@using Newtonsoft.Json

@{
    string allText = System.IO.File.ReadAllText("wwwroot/scripts/MapsData/WorldMap.json");
    var mapUSData=JsonConvert.DeserializeObject(allText);
}

<ejs-maps id="maps">
    <e-maps-layers>
        <e-maps-layer shapeData="mapUSData">
            <e-layersettings-datalabelsettings visible="true" labelPath="name" smartLabelMode="@Syncfusion.EJ2.Maps.SmartLabelMode.Trim">
            </e-layersettings-datalabelsettings>
            <e-layersettings-tooltipsettings visible="true" valuePath="name"></e-layersettings-tooltipsettings>
            <e-layersettings-shapesettings autofill="true"></e-layersettings-shapesettings>
        </e-maps-layer>
    </e-maps-layers>
</ejs-maps>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Maps with Tooltip](images/maps-tooltip.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Maps/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)