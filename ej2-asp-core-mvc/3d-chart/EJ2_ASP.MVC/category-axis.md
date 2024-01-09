---
layout: post
title: Category axis in ##Platform_Name## 3D Chart Component
description: Learn here all about category axis in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Category Axis
publishingplatform: ##Platform_Name##
documentation: ug
---


# Category axis in ##Platform_Name## 3D Chart Component

The category axis is the horizontal axis of a 3D chart that shows text values rather than numerical values. Compared to the vertical axis, this axis has fewer labels. The following sample shows to render the 3D chart using category axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/3d-chart/series/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/3d-chart/series/axis/category/category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Labels placement

By default, category axis labels are placed between ticks in an axis. It can also be placed on ticks using the [`LabelPlacement`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_LabelPlacement) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/labelplacement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labelplacement.cs" %}
{% include code-snippet/3d-chart/series/axis/labelplacement/labelplacement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/labelplacement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labelplacement.cs" %}
{% include code-snippet/3d-chart/series/axis/labelplacement/labelplacement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Range

The range of the category axis can be customized using [`Minimum`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Minimum), [`Maximum`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Interval) properties of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/3d-chart/series/axis/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/3d-chart/series/axis/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Indexed category axis

The caategory axis can also be rendered based on the index values of the data source. This can be achieved by defining the [`IsIndexed`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_IsIndexed) property to **true** in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/index/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/3d-chart/series/axis/index/index.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/3d-chart/series/axis/index/index.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

