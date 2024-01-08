---
layout: post
title: Axis Labels in ##Platform_Name## 3D Chart Component
description: Learn here all about Axis Labels in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis labels in ##Platform_Name## 3D Chart Component

Axis labels are the labels that are positioned adjacent to the y-axis and beneath the x-axis. It provides descriptive information about the axis.

## Smart axis labels

When the axis labels overlap with each other, [`LabelIntersectAction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_LabelIntersectAction) property in the axis can be used to place them smartly.

When setting `LabelIntersectAction` as `Hide`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide.cs" %}
{% include code-snippet/3d-chart/series/axis/hide/hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide.cs" %}
{% include code-snippet/3d-chart/series/axis/hide/hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



When setting `LabelIntersectAction` as `Rotate45`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/rotate45/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate45.cs" %}
{% include code-snippet/3d-chart/series/axis/rotate45/rotate45.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/rotate45/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate45.cs" %}
{% include code-snippet/3d-chart/series/axis/rotate45/rotate45.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



When setting `LabelIntersectAction` as `Rotate90`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/rotate90/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate90.cs" %}
{% include code-snippet/3d-chart/series/axis/rotate90/rotate90.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/rotate90/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate90.cs" %}
{% include code-snippet/3d-chart/series/axis/rotate90/rotate90.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Edge label placement

Labels with long text at the edges of an axis may appear partially in the chart. To avoid this,
use [`EdgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_EdgeLabelPlacement) property in axis, which moves the label inside the chart area for better appearance or hides it.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/3d-chart/series/axis/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/3d-chart/series/axis/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Maximum labels

The labels will be rendered based on the count in the [`MaximumLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_MaximumLabels) property per 100 pixel. If the range (minimum, maximum, interval) and maximumLabels are set, then the priority goes to range. If the range is not set, then it gives priority to maximumLabels property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/maximumlabels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Maximumlabels.cs" %}
{% include code-snippet/3d-chart/series/axis/maximumlabels/maximumlabels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/maximumlabels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Maximumlabels.cs" %}
{% include code-snippet/3d-chart/series/axis/maximumlabels/maximumlabels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}