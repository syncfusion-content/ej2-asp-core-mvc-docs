---
layout: post
title: Gauge Annotations in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge Annotations in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge Annotations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Annotations

Annotations are used to mark a specific area of interest in the gauge with texts, shapes or images.

## Content

You can place any custom element on the axis area by assigning the id of the element to
[`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Content) property of [`annotation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/annotations/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotations.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/annotations/annotations.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/annotations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotations.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/annotations/annotations.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Position

Annotation can be placed around the axis by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Radius)
and [`angle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Angle) property.
For example, if the angle is 90 degree and the radius is 110%, then the annotation, will be placed at the right side of the axis.

Radius of the annotation takes value either in pixel or percentage. By setting value in percentage, annotation gets its position with respect to its axis radius.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Sub Gauge

As the annotation allows you to place any custom element, we can initialize a gauge to the element and can
be used to place that in another gauge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/subgauge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Subgauge.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/subgauge/subgauge.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-annotations/subgauge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Subgauge.cs" %}
{% include code-snippet/circulargauge/gauge-annotations/subgauge/subgauge.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Tooltip for Annotations](gauge-user-interaction/#tooltip-for-annotations)