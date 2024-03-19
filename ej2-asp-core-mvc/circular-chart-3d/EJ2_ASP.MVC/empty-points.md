---
layout: post
title: Empty points in ##Platform_Name## Syncfusion 3D Circular Chart Component
description: Learn here all about empty points in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Empty points
publishingplatform: ##Platform_Name##
documentation: ug
---


# Empty points in ##Platform_Name## 3D Circular Chart Component

Data points containing `null` or `undefined` values are considered empty points. These empty data points are ignored and not plotted in the 3D Circular Chart. You can customize the handling of empty points using the `EmptyPointSettings` property in the series. The default mode for empty points is `Gap`. Other supported modes include `Average`, `Drop`, and `Zero`.

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

A specific color for an empty point can be set by using the `Fill` property in `EmptyPointSettings`.

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

