---
title: " Chart Selection | ASP.NET MVC "

component: "Chart"

description: "Strip Lines are vertical or horizontal lines used to highlight/mark a certain region on the plot area."
---

<!-- markdownlint-disable MD036 -->

# Selection

Chart provides selection support for the series and its data points on mouse click.

>When Mouse is clicked on the data points, the corresponding series legend will also be selected.

We have different type of selection mode for selecting the data. They are,

* None
* Point
* Series
* Cluster
* DragXY
* DragX
* DragY

## Point

 You can select a point, by setting `selectionMode` to point.

{% aspTab template="chart/user-interaction/selection/point-selection", sourceFiles="point-selection.cs" %}

{% endaspTab %}

## Series

 You can select a series, by setting `selectionMode` to series.

{% aspTab template="chart/user-interaction/selection/series-selection", sourceFiles="series-selection.cs" %}

{% endaspTab %}

## Cluster

You can select the points that corresponds to the same index in all the series, by setting `selectionMode` to
cluster.

{% aspTab template="chart/user-interaction/selection/cluster-selection", sourceFiles="cluster-selection.cs" %}

{% endaspTab %}

## Rectangular selection

**DragXY, DragX and DragY**

To fetch the collection of data under a particular region, you have to set `selectionMode` as `DragXY`.

* DragXY - Allows us to select data with respect to horizontal and vertical axis.
* DragX - Allows us to select data with respect to horizontal axis.
* DragY - Allows us to select data with respect to vertical axis.

The selected data’s are returned as an array collection in the [`dragComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_DragComplete)
event.

{% aspTab template="chart/user-interaction/selection/drag", sourceFiles="drag.cs" %}

{% endaspTab %}

## Selection type

You can select multiple points or series, by enabling the [`isMultiSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_IsMultiSelect) property.

{% aspTab template="chart/user-interaction/selection/selection-type", sourceFiles="selection-type.cs" %}

{% endaspTab %}

## Selection on load

You can able to select a point or series programmatically on a chart using
[`selectedDataIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SelectedDataIndexes)
property.

{% aspTab template="chart/user-interaction/selection/onload", sourceFiles="onload.cs" %}

{% endaspTab %}

## Selection through on legend

You can able to select a point or series through on legend using
[`toggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ToggleVisibility) property.

{% aspTab template="chart/user-interaction/selection/selection-legend", sourceFiles="selection-legend.cs" %}

{% endaspTab %}

## Customization for selection

You can apply custom style to selected points or series with [`selectionStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SelectionStyle)
property.

{% aspTab template="chart/user-interaction/selection/custom-selection", sourceFiles="custom-selection.cs" %}

{% endaspTab %}