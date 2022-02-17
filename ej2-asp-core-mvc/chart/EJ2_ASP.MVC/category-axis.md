---
layout: post
title: Category Axis in ##Platform_Name## Chart Component
description: Learn here all about Category Axis in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Category Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Category Axis

<!-- markdownlint-disable MD036 -->

Category axis are used to represent, the string values instead of numbers.

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

By default, category labels are placed between the ticks in an axis, this can also be placed on ticks
using [`LabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelPlacement) property.

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

Range of the category axis can be customized using [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum),
[`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of
the axis.

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

Category axis also can be rendered based on the index values of data source. This can be achieved by defining the
`IsIndexed` property to `true` in the axis.

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

