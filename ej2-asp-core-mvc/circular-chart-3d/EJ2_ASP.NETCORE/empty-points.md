---
layout: post
title: Empty points in ##Platform_Name## Circular Chart 3D Component
description: Learn here all about Empty points in Syncfusion ##Platform_Name## Circular Chart 3D component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Empty points
publishingplatform: ##Platform_Name##
documentation: ug
---


# Empty points in ##Platform_Name## Circular Chart 3D Component

The data points those uses the `null` or `undefined` as value are considered as empty points. The empty data points are ignored and not plotted in the Circular Chart 3D. You can customize those points, using the `EmptyPointSettings` property in series. The default mode of the empty point is `Gap`. Other supported modes are `Average`, `Drop` and `Zero`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/empty-points/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/circular-chart/pie-donut/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/empty-points/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/circular-chart/pie-donut/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Specific color for an empty point can be set by using the `Fill` property in `EmptyPointSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/empty-point-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-point-custom.cs" %}
{% include code-snippet/circular-chart/pie-donut/empty-point-custom/empty-point-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/empty-point-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-point-custom.cs" %}
{% include code-snippet/circular-chart/pie-donut/empty-point-custom/empty-point-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

