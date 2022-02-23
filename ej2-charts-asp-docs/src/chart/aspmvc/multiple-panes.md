---
title: " Chart Multiple-panes | ASP.NET MVC "

component: "Chart"

description: "Chart can be divided multiple rows and columns. Axes are rendering based on row index or column index in pane."
---

# Multiple Panes

Chart area can be divided into multiple panes using [`Rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) and
[`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html).

## Rows

To split the chart area vertically into number of rows, use [`Rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the chart.

* You can allocate space for each row by using the [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html#Syncfusion_EJ2_Charts_ChartRow_Height)
property. The value can be either in percentage or in pixel.
* To associate a vertical axis to a particular row, specify its index to
[`RowIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the axis.
* To customize each row’s bottom line, use [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property.

{% aspTab template="chart/axis/multiple-panes/row", sourceFiles="row.cs" %}

{% endaspTab %}

For spanning the vertical axis along multiple row, you can use [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of an axis.

{% aspTab template="chart/axis/multiple-panes/row-span", sourceFiles="row-span.cs" %}

{% endaspTab %}

## Columns

To split the chart area horizontally into number of columns, use [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the chart.

* You can allocate space for each column by using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Width)
property. The given width can be either in percentage or in pixel.
* To associate a horizontal axis to a particular column, specify its index to
[`ColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the axis.
* To customize each column’s bottom line, use [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Border) property.

{% aspTab template="chart/axis/multiple-panes/column", sourceFiles="column.cs" %}

{% endaspTab %}

For spanning the horizontal axis along multiple column, you can use [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of an axis.

{% aspTab template="chart/axis/multiple-panes/column-span", sourceFiles="column-span.cs" %}

{% endaspTab %}
