---
layout: post
title: Multiple Panes in ##Platform_Name## Chart Component
description: Learn here all about Multiple Panes in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Multiple Panes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple Panes

The chart area can be divided into multiple panes by defining rows and columns using the [`Rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) and [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) collections. This feature is useful for displaying multiple related datasets within the same chart container while maintaining clear visual separation.

## Rows

To split the chart area vertically into multiple rows, use the [`Rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the chart.

- Space for each row can be allocated by using the [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html#Syncfusion_EJ2_Charts_ChartRow_Height) property. The value can be specified either in pixels or as a percentage.
- To associate a vertical axis with a specific row, assign the corresponding index using the [`RowIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the axis.
- To customize the bottom line of each row, use the [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row.cs" %}
{% include code-snippet/chart/axis/multiple-panes/row/row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row.cs" %}
{% include code-snippet/chart/axis/multiple-panes/row/row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



To span a vertical axis across multiple rows, use the [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/row-span/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-span.cs" %}
{% include code-snippet/chart/axis/multiple-panes/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/row-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-span.cs" %}
{% include code-snippet/chart/axis/multiple-panes/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Columns

To split the chart area horizontally into multiple columns, use the [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the chart.

- Space for each column can be allocated using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Width) property. The width can be specified either in pixels or as a percentage.
- To associate a horizontal axis with a specific column, assign the corresponding index using the [`ColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the axis.
- To customize the bottom line of each column, use the [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Border) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/axis/multiple-panes/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/axis/multiple-panes/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



To span a horizontal axis across multiple columns, use the [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/column-span/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-span.cs" %}
{% include code-snippet/chart/axis/multiple-panes/column-span/column-span.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/multiple-panes/column-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-span.cs" %}
{% include code-snippet/chart/axis/multiple-panes/column-span/column-span.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


