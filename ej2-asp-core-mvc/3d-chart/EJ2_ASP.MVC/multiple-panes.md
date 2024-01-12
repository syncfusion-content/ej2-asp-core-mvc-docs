---
layout: post
title: Multiple panes in ##Platform_Name## 3D Chart Component
description: Learn here all about multiple panes in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Multiple Panes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple panes in ##Platform_Name## 3D Chart Component

The chart area can be divided into multiple panes using [`Rows`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Rows) and [`Columns`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Columns).

## Rows

To split the chart area vertically into number of rows, use [`Rows`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Rows) property of the 3D chart.

* The space for each row can be allocated by using the [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DRow.html#Syncfusion_EJ2_Charts_Chart3DRow_Height) property. The value can be either in percentage or in pixel.
* To associate a vertical axis to a particular row, specify its index to [`RowIndex`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_RowIndex) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row.cs" %}
{% include code-snippet/3d-chart/series/axis/row/row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row.cs" %}
{% include code-snippet/3d-chart/series/axis/row/row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For spanning the vertical axis along multiple rows, use [`Span`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Span) property of an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/row-span/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-span.cs" %}
{% include code-snippet/3d-chart/series/axis/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/row-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-span.cs" %}
{% include code-snippet/3d-chart/series/axis/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Columns

To split the chart area horizontally into number of columns, use [`Columns`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Columns) property of the 3D chart.

* The space for each column can be allocated by using the [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DColumn.html#Syncfusion_EJ2_Charts_Chart3DColumn_Width) property. The given width can be either in percentage or in pixel.
* To associate a horizontal axis to a particular column, specify its index to [`ColumnIndex`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_ColumnIndex) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/3d-chart/series/axis/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/3d-chart/series/axis/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For spanning the vertical axis along multiple column, you can use [`Span`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Span) property of an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/column-span/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-span.cs" %}
{% include code-snippet/3d-chart/series/axis/column-span/column-span.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/column-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-span.cs" %}
{% include code-snippet/3d-chart/series/axis/column-span/column-span.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


