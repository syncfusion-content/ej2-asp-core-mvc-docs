---
title: " Chart Axis Customization | ASP.NET MVC "

component: "Chart"

description: "Chart axis contains different customization and types like axis crossing, multiple axis, inversed axis, tick and grid, title customizations"
---

# Axis Customization

## Axis Crossing

An axis can be positioned in the chart area using `CrossesAt` and `CrossesInAxis` properties. The `CrossesAt`
property specifies the values (datetime, numeric, or logarithmic) at which the axis line has to be intersected
with the vertical axis or vice-versa, and the `CrossesInAxis` property specifies the axis name with which the
axis line has to be crossed.

{% aspTab template="chart/axis/category/axis-cross", sourceFiles="axis-cross.cs" %}

{% endaspTab %}

## Title

You can add a title to the axis using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Title) property to provide quick
information to the user about the data plotted in the axis.

{% aspTab template="chart/axis/category/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Tick Lines Customization

You can customize the  `Width`, `Color` and `Size` of the minor and major tick lines, using
[`MajorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorTickLines) and
[`MinorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorTickLines) properties in the axis.

{% aspTab template="chart/axis/category/tick", sourceFiles="tick.cs" %}

{% endaspTab %}

## Grid Lines Customization

You can customize the `Width`, `Color` and `DashArray` of the minor and major grid lines,
using [`MajorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorGridLines) and
[`MinorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorGridLines) properties in the axis.

{% aspTab template="chart/axis/category/grid", sourceFiles="grid.cs" %}

{% endaspTab %}

## Multiple Axis

In addition to primary X and Y axis, we can add n number of axis to the chart. Series can be associated with
this axis, by mapping with axis's unique name.

{% aspTab template="chart/axis/category/multiple", sourceFiles="multiple.cs" %}

{% endaspTab %}

## Inversed Axis

<!-- markdownlint-disable MD033 -->

When an axis is inversed, highest value of the axis comes closer to origin and vice versa. To place an axis in inversed manner set this property
 [`IsInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_IsInversed) to true.

 {% aspTab template="chart/axis/category/inversed", sourceFiles="inversed.cs" %}

{% endaspTab %}

## Opposed Position

<!-- markdownlint-disable MD012 -->
To place an axis opposite from its original position, set [`OpposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_OpposedPosition)
property of the axis to true.
<!-- markdownlint-disable MD012 -->

{% aspTab template="chart/axis/category/opposed", sourceFiles="opposed.cs" %}

{% endaspTab %}


