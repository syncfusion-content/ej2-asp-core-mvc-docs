---
layout: post
title: Gauge Pointers in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge Pointers in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge Pointers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Pointers

Pointers are used to indicate values on the axis. Value of the pointer can be modified using the
[`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html#Syncfusion_EJ2_CircularGauge_CircularGaugePointer_Value) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/pointers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pointers.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/pointers/pointers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/pointers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pointers.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/pointers/pointers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Gauge supports 3 types of pointers such as `Needle`, `RangeBar` and `Marker`. You can choose any one of the pointer by using [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html#Syncfusion_EJ2_CircularGauge_CircularGaugePointer_Type) property.

## Needle Pointers

A needle pointer contains three parts, a needle, a cap / knob and a tail. The length of the needle can be
customized by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html#Syncfusion_EJ2_CircularGauge_CircularGaugePointer_Radius) property. The length of the tail can be
customized by using [`length`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property. The radius of the cap
can be customized by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) in cap object. The needle and tail
length takes value either in `percentage` or `pixel`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-pointers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Needle-pointers.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-pointers/needle-pointers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-pointers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Needle-pointers.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-pointers/needle-pointers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**Customization**

Needle color and width can be customized by using [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) and [`pointerWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property.
Cap and tails can be customized by using [`cap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) and
[`needleTail`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The appearance of the needle pointer can be customized by using [`NeedleStartWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html#Syncfusion_EJ2_CircularGauge_CircularGaugePointer_NeedleStartWidth) and [`NeedleEndWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html#Syncfusion_EJ2_CircularGauge_CircularGaugePointer_NeedleEndWidth).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Needle-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-customization/needle-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Needle-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/needle-customization/needle-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## RangeBar Pointer

RangeBar pointer is like ranges in an axis, that can be placed on gauge to mark the pointer value.
RangeBar starts from the beginning of the gauge and ends at the pointer value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebar-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangebar-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebar-pointer/rangebar-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebar-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangebar-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebar-pointer/rangebar-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization**

RangeBar can be customized in terms of color, border and thickness by using
[`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html), [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) and [`pointerWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/pointer-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/pointer-customization/pointer-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/pointer-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/pointer-customization/pointer-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rounded corner for range bar pointer

The start and end pointers of range bar in the circular gauge are rounded to form arc gauges.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebarroundedcorner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangebar-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebarroundedcorner/rangebar-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebarroundedcorner/razor%}
{% endhighlight %}
{% highlight c# tabtitle="Rangebar-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/rangebarroundedcorner/rangebar-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Marker Pointer

Different type of marker shape can be used to mark the pointer value in axis.  You can change the marker shape using [`markerShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property in pointer. Gauge supports the below marker shape.
* Circle
* Rectangle
* Triangle
* InvertedTriangle
* Diamond

We can use image instead of rendering marker shape to denote the pointer value. It can be achieved by setting [`markerShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) to Image and assigning  image path to [`imageUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) in pointer.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-pointer/marker-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-pointer/marker-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization**

The marker can be customized in terms of color, border, width and height by using
[`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html),
[`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html),
[`markerWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) and
[`markerHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property in
[`pointer`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-customization/marker-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker-customization.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/marker-customization/marker-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dragging Pointer

The pointers can be dragged over the axis line by clicking and dragging the same. To enable or disable the pointer drag, use the [`EnablePointerDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnablePointerDrag) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/dragging-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dragging-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/dragging-pointer/dragging-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/dragging-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragging-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/dragging-pointer/dragging-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Pointers

In addition to the default pointer, you can add n number of pointer to an axis by using `pointers` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/multiple-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/multiple-pointer/multiple-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/multiple-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-pointer.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/multiple-pointer/multiple-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Animation

Pointer will get animate on loading the gauge, this can be handled by using
[`animation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property in pointer.
The [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property in animation allows you to enable or disable the animation.
The [`duration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html) property specify the duration of the animation in milliseconds.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gradient Color

Gradient support allows to add multiple colors in the range and pointer of the circular gauge. The following gradient types are supported in the circular gauge.

* Linear Gradient
* Radial Gradient

### Linear Gradient

Using linear gradient, colors will be applied in a linear progression. The start value of the linear gradient will be set using the [`startValue`](../api/circular-gauge/linearGradient/#startvalue) property. The end value of the linear gradient will be set using the [`endValue`](../api/circular-gauge/linearGradient/#endvalue) property. The color stop values such as color, opacity and offset are set using [`colorStop`](../api/circular-gauge/linearGradient/#colorstop) property.

The linear gradient can be applied to all pointer types like marker, range bar and needle. To do so, follow the below code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/lineargradient/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lineargradient.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/lineargradient/lineargradient.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/lineargradient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Lineargradient.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/lineargradient/lineargradient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Radial Gradient

Using radial gradient, colors will be applied in circular progression. The inner circle position of the radial gradient will be set using the [`innerPosition`](../api/circular-gauge/radialGradient/#innerposition) property. The outer circle position of the radial gradient can be set using the [`outerPosition`](../api/circular-gauge/radialGradient/#outerposition) property. The color stop values such as color, opacity and offset are set using [`colorStop`](../api/circular-gauge/radialGradient/#colorstop) property.

The radial gradient can be applied to all pointer types like marker, range bar and needle. To do so, follow the below code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/radialgradient/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radialgradient.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/radialgradient/radialgradient.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-pointers/radialgradient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radialgradient.cs" %}
{% include code-snippet/circulargauge/gauge-pointers/radialgradient/radialgradient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


