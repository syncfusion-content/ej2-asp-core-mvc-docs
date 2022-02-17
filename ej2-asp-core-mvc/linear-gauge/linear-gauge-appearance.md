---
layout: post
title: Linear Gauge Appearance in ##Platform_Name## Linear Gauge Component
description: Learn here all about Linear Gauge Appearance in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Linear Gauge Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance

## Gauge Area Customization

<!-- markdownlint-disable MD036 -->

**Customize the Linear Gauge background**

Using [`background`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.html) and
[`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.html) properties, you can change the background color and border of the linear gauge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-background/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-background.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-background/gauge-background.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-background/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-background.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-background/gauge-background.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Gauge Margin**

You can set margin for the lineargauge through [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeMargin.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-margin.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-margin/gauge-margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-margin.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-margin/gauge-margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gauge Title

You can give the title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Title.html) property to show the information about the linear gauge. Its appearance can be customized by using the [`titleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~TitleStyle.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-title.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-title/gauge-title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-title.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-title/gauge-title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gauge Container

The area used to render the ranges and pointers at the center position of the gauge is called [`container`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer.html). It can be customized by using [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Type.html), [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Offset.html), [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Width.html), [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Height.html) and [`backgroundColor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~BackGroundColor.html) properties in [`container`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer.html). It is of three types namely,

* Normal
* Rounded Rectangle
* Thermometer

**Normal**

The normal type will render the container as rectangle and this is the default container type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-container/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-container.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-container/gauge-container.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-container/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-container.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/gauge-container/gauge-container.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Rounded Rectangle**

The rounded rectangle type will render the container as rectangle with rounded corners.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/rounded-rectangle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded-rectangle.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/rounded-rectangle/rounded-rectangle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/rounded-rectangle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded-rectangle.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/rounded-rectangle/rounded-rectangle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Thermometer**

This type is used to render the container similar to the thermometer appearance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/thermo-meter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Thermo-meter.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/thermo-meter/thermo-meter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/lineargauge-appearance/thermo-meter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Thermo-meter.cs" %}
{% include code-snippet/lineargauge/lineargauge-appearance/thermo-meter/thermo-meter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

