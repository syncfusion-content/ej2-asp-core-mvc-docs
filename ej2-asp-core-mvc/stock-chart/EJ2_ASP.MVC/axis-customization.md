---
layout: post
title: Axis Customization in ##Platform_Name## Stock Chart Component
description: Learn here all about Axis Customization in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Axis Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Customization

<!-- markdownlint-disable MD034 -->

## Axis Crossing

An axis can be positioned in the chart area using [`CrossesAt`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesAt) and [`CrossesInAxis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesInAxis) properties. The [`CrossesAt`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesAt)
property specifies the values (datetime, numeric, or logarithmic) at which the axis line has to be intersected
with the vertical axis or vice-versa, and the [`CrossesInAxis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_CrossesInAxis) property specifies the axis name with which the
axis line has to be crossed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/axis-cross/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-cross.cs" %}
{% include code-snippet/stock-chart/axis/category/axis-cross/axis-cross.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/axis-cross/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-cross.cs" %}
{% include code-snippet/stock-chart/axis/category/axis-cross/axis-cross.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Title

You can add a title to the axis using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Title)property to provide quick
information to the user about the data plotted in the axis.Title style can be customized using [`TitleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_TitleStyle) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/axis/category/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/stock-chart/axis/category/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tick Lines Customization

You can customize the  `Width`, `Color` and `Size` of the minor and major tick lines, using
[`MajorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorTickLines) and
[`MinorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorTickLines) properties in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/tick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/stock-chart/axis/category/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/tick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/stock-chart/axis/category/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grid Lines Customization

You can customize the `Width`, `Color` and `DashArray` of the minor and major grid lines,
using [`MajorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorGridLines) and
[`MinorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorGridLines) properties in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/stock-chart/axis/category/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/stock-chart/axis/category/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Axis

In addition to primary X and Y axis, we can add n number of axis to the chart. Series can be associated with
this [`Axis`] (https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartAxis.html), by mapping with axis's unique name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/stock-chart/axis/category/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/stock-chart/axis/category/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Inversed Axis

<!-- markdownlint-disable MD033 -->

When an axis is inversed, highest value of the axis comes closer to origin and vice versa. To place an axis in inversed manner set this property
 [`IsInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_IsInversed) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/stock-chart/axis/category/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/inversed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/stock-chart/axis/category/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opposed Position

<!-- markdownlint-disable MD012 -->
To place an axis opposite from its original position, set [`OpposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_OpposedPosition)
property of the axis to true.
<!-- markdownlint-disable MD012 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/stock-chart/axis/category/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/axis/category/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/stock-chart/axis/category/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




