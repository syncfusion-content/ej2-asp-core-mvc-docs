---
title: "Getting started"
component: "Heatmap"
description: "This section describes on how to visualize a two-dimensional data by enabling the basic features in heatmap"
---

# Getting Started

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Create ASP.NET MVC Application with default template project in Visual Studio.

![Default Template](./images/default-template-mvc.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo-mvc.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 3:** Add `Syncfusion.EJ2` namespace reference in `Web.config`

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

```cs
<system.web>
    <compilation>
      <assemblies>
        <add assembly="Syncfusion.EJ2"/>
      </assemblies>
    </compilation>
  </system.web>
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page `_Layout.cshtml`.

```html
<head>
  @* Syncfusion Essential JS 2 Styles *@
  <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

  @* Syncfusion Essential JS 2 Scripts *@
  <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>

```

**Step 5:** Adding Script Manager in layout page `_Layout.cshtml`.

```cs
@Html.EJS().ScriptManager()
```

**Step 6:**

Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the heatmap.

```cs

@using Syncfusion.EJ2;
@Html.EJS().HeatMap("container").Render()

```

## Populate heat map with data

This section explains how to populate the following two-dimensional array data to the heat map.

{% aspTab template="heatmap/getting-started/data", sourceFiles="data.cs" %}

{% endaspTab %}

## Enable axis labels

You can add axis labels to the heat map and format those labels using the [`xAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~XAxis.html) and [`yAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~YAxis.html) properties. Axis labels provide additional information about the data points populated in the heat map.

{% aspTab template="heatmap/getting-started/axis", sourceFiles="axis.cs" %}

{% endaspTab %}

## Add heat map title

Add a title using the [`titleSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TitleSettings.html) property to the heat map to provide quick information to the user about the data populated in the heat map.

{% aspTab template="heatmap/getting-started/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Enable legend

Use a legend for the heat map in the [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~LegendSettings.html) object by setting the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Visible.html) property to true.

{% aspTab template="heatmap/getting-started/legend", sourceFiles="legend.cs" %}

{% endaspTab %}

## Add data label

Add data labels to improve the readability of the heat map. This can be achieved by setting the [`showLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~ShowLabel.html) property to true in the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) object.

{% aspTab template="heatmap/getting-started/label", sourceFiles="label.cs" %}

{% endaspTab %}

## Add custom cell palette

The default palette settings of the heat map cells can be customized by using the [`paletteSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~PaletteSettings.html) property.
Using the [`palette`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette.html) property in `paletteSettings` object, you can change the color set for the cells. You can change the color mode of the cells to fixed or gradient mode using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property.

{% aspTab template="heatmap/getting-started/palette", sourceFiles="palette.cs" %}

{% endaspTab %}

## Enable tooltip

The tooltip is used when you cannot display information by using the data labels due to space constraints. You can enable the tooltip by setting the [`showTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~ShowTooltip.html) property to `true`.

{% aspTab template="heatmap/getting-started/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}