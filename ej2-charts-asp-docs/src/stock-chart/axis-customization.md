---
title: " Stock Chart Axis Customization | ASP.NET MVC "

component: "Stock Chart"

description: "Stock Chart axis contains different customization and types like axis crossing, multiple axis, inversed axis, tick and grid, title customizations"
---

# Axis Customization

<!-- markdownlint-disable MD034 -->

## Axis Crossing

An axis can be positioned in the chart area using [`crossesAt`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesAt) and [`crossesInAxis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesInAxis) properties. The [`crossesAt`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesAt)
property specifies the values (datetime, numeric, or logarithmic) at which the axis line has to be intersected
with the vertical axis or vice-versa, and the [`crossesInAxis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesInAxis) property specifies the axis name with which the
axis line has to be crossed.

{% aspTab template="stock-chart/axis/category/axis-cross", sourceFiles="axis-cross.cs" %}

{% endaspTab %}

## Title

You can add a title to the axis using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Title)property to provide quick
information to the user about the data plotted in the axis.Title style can be customized using [`titleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_TitleStyle) property of the axis.

{% aspTab template="stock-chart/axis/category/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Tick Lines Customization

You can customize the  `width`, `color` and `size` of the minor and major tick lines, using
[`majorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorTickLines) and
[`minorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorTickLines) properties in the axis.

{% aspTab template="stock-chart/axis/category/tick", sourceFiles="tick.cs" %}

{% endaspTab %}

## Grid Lines Customization

You can customize the `width`, `color` and `dashArray` of the minor and major grid lines,
using [`majorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorGridLines) and
[`minorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorGridLines) properties in the axis.

{% aspTab template="stock-chart/axis/category/grid", sourceFiles="grid.cs" %}

{% endaspTab %}

## Multiple Axis

In addition to primary X and Y axis, we can add n number of axis to the chart. Series can be associated with
this [`axis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartAxis.html), by mapping with axis's unique name.

{% aspTab template="stock-chart/axis/category/multiple", sourceFiles="multiple.cs" %}

{% endaspTab %}

## Inversed Axis

<!-- markdownlint-disable MD033 -->

When an axis is inversed, highest value of the axis comes closer to origin and vice versa. To place an axis in inversed manner set this property
 [`isInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_IsInversed) to true.

 {% aspTab template="stock-chart/axis/category/inversed", sourceFiles="inversed.cs" %}

{% endaspTab %}

## Opposed Position

<!-- markdownlint-disable MD012 -->
To place an axis opposite from its original position, set [`opposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_OpposedPosition)
property of the axis to true.
<!-- markdownlint-disable MD012 -->

{% aspTab template="stock-chart/axis/category/opposed", sourceFiles="opposed.cs" %}

{% endaspTab %}


