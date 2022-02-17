---
layout: post
title: Multiple Panes in ##Platform_Name## Chart Component
description: Learn here all about Multiple Panes in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Multiple Panes
publishingplatform: ##Platform_Name##
documentation: ug
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



For spanning the vertical axis along multiple row, you can use [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartRow.html) property of an axis.

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

To split the chart area horizontally into number of columns, use [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the chart.

* You can allocate space for each column by using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Width)
property. The given width can be either in percentage or in pixel.
* To associate a horizontal axis to a particular column, specify its index to
[`ColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of the axis.
* To customize each column’s bottom line, use [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html#Syncfusion_EJ2_Charts_ChartColumn_Border) property.

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



For spanning the horizontal axis along multiple column, you can use [`Span`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartColumn.html) property of an axis.

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


