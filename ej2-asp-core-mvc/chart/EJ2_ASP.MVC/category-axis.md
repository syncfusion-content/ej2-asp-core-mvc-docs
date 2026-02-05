---
layout: post
title: Category Axis in ##Platform_Name## Chart Component
description: Learn here all about Category Axis in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Category Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Category Axis

<!-- markdownlint-disable MD036 -->

The category axis is used to represent string-based values instead of numeric values. It is commonly used for displaying discrete categories such as names, labels, or textual groupings along an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/axis/category/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/axis/category/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Labels Placement

<!-- markdownlint-disable MD036 -->

By default, category labels are positioned between the axis tick marks. They can also be aligned directly on the ticks by using the [`LabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelPlacement) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/chart/axis/category/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/chart/axis/category/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Range

The visible range of the category axis can be customized by using the [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum), and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) properties of the axis. These properties control the start value, end value, and spacing between category labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/category/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/chart/axis/category/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Indexed category axis

The category axis can also be rendered based on the index values of the data source. This behavior can be enabled by setting the `IsIndexed` property of the axis to **true**, which positions data points according to their index instead of their actual category values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/index/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/chart/axis/category/index/index.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/chart/axis/category/index/index.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

