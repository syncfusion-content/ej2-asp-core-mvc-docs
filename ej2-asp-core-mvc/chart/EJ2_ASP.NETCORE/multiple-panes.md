---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Multiple Panes of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Multiple Panes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple Panes

Chart area can be divided into multiple panes using [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) and
[`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html).

## Rows

To split the chart area vertically into number of rows, use [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the chart.

* You can allocate space for each row by using the [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html#Syncfusion_EJ2_Charts_ChartRow_Height)
property. The value can be either in percentage or in pixel.
* To associate a vertical axis to a particular row, specify its index to
[`rowIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the axis.
* To customize each row’s bottom line, use [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property.

{% aspTab template="chart/axis/multiple-panes/row", sourceFiles="row.cs" %}

{% endaspTab %}

For spanning the vertical axis along multiple row, you can use [`span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of an axis.

{% aspTab template="chart/axis/multiple-panes/row-span", sourceFiles="row-span.cs" %}

{% endaspTab %}

## Columns

To split the chart area horizontally into number of columns, use [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the chart.

* You can allocate space for each column by using the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Width)
property. The given width can be either in percentage or in pixel.
* To associate a horizontal axis to a particular column, specify its index to
[`columnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the axis.
* To customize each column’s bottom line, use [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Border) property.

{% aspTab template="chart/axis/multiple-panes/column", sourceFiles="column.cs" %}

{% endaspTab %}

For spanning the horizontal axis along multiple column, you can use [`span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of an axis.

{% aspTab template="chart/axis/multiple-panes/column-span", sourceFiles="column-span.cs" %}

{% endaspTab %}
