---
layout: post
title: Gauge Ranges in ##Platform_Name## Circular Gauge Control | Syncfusion
description: Learn here all about Gauge Ranges in Syncfusion ##Platform_Name## Circular Gauge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Gauge Ranges
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ranges in Circular Gauge Control

You can categories certain interval on gauge axis using [ranges](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html) property.

## Start and End

Start and end value of a range in an axis can be customized by using [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Start) and [end](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_End) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/ranges/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Color and thickness of the range can be customized by using [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Color), [startWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_StartWidth) and [endWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_EndWidth) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/customization/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Radius

You can place the range inside or outside of the axis by using [radius](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Radius) property. The radius of the range can take value either in percentage or in pixels. By default, ranges take 100% of the axis radius.

**In Pixel**

You can set the radius of the range in pixel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radius/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/radius/radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**In Percentage**

By setting value in percentage, range gets its dimension with respect to its axis radius. For example, when the radius is ‘50%’, range renders to half of the axis radius.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radius-percentage/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radius-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius-percentage.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/radius-percentage/radius-percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dragging Ranges

The ranges can be dragged over the axis line by clicking and dragging the same. To enable or disable the range drag, use the [EnableRangeDrag](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnableRangeDrag) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/dragging-range/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/dragging-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dragging-range.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/dragging-range/dragging-range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Ranges

You can add multiple ranges to an axis with the above customization.

N> You can set the range color to axis ticks and labels by enabling `useRangeColor` property in [majorTicks](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html), [minorTicks](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html) and [labelStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/multiple-ranges/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/multiple-ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-ranges.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/multiple-ranges/multiple-ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rounded corner radius

You can customize the corner radius using the `roundedCornerRadius` property in `ranges`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/roundedcorner/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/roundedcorner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/roundedcorner/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gradient Color

Gradient support allows to add multiple colors in the ranges and pointers of the circular gauge. The following gradient types are supported in the circular gauge.

* Linear Gradient
* Radial Gradient

### Linear Gradient

Using linear gradient, colors will be applied in a linear progression. The start value of the linear gradient will be set using the [startValue](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLinearGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLinearGradient_StartValue) property. The end value of the linear gradient will be set using the [endValue](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLinearGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLinearGradient_EndValue) property. The color stop values such as color, opacity and offset are set using [colorStop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLinearGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLinearGradient_ColorStop) property.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/lineargradient/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/lineargradient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Lineargradient.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/lineargradient/lineargradient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Radial Gradient

Using radial gradient, colors will be applied in circular progression. The inner circle position of the radial gradient will be set using the [innerPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRadialGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRadialGradient_InnerPosition) property. The outer circle position of the radial gradient can be set using the [outerPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRadialGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRadialGradient_OuterPosition) property. The color stop values such as color, opacity and offset are set using [colorStop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRadialGradient.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRadialGradient_ColorStop) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radialgradient/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-ranges/radialgradient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radialgradient.cs" %}
{% include code-snippet/circulargauge/gauge-ranges/radialgradient/radialgradient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CircularGauge/CircularGaugeUGSample).

## See also

* [Tooltip for Ranges](gauge-user-interaction/#tooltip-for-ranges)
