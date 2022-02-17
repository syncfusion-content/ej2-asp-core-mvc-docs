---
layout: post
title: Gauge Appearance in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge Appearance in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance

## Gauge Title

Circular gauge can be given a title by using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Title) property, to show the information about the gauge.
Title can be customized by using [`titleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_TitleStyle) property in gauge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gauge Position

<!-- markdownlint-disable MD036 -->

Gauge can be positioned anywhere in the container with the help of
[`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX) and
[`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY)
property and it accepts values either in percentage or in pixels.
The default value of the [`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX) and
[`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY) property is 50%, which means gauge will get rendered to the centre of the container.

**In Pixel**

You can set the mid point of the gauge in pixel as demonstrated below,

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In Percentage**

By setting the value in percentage, gauge gets its mid point with respect to its plot area.
For example, when the [`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX)
value as '0%' and [`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY) value is ‘50%’, gauge will get positioned at the top left corner of the plot area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/position-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position-Percentage.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/position-percentage/position-percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/position-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position-Percentage.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/position-percentage/position-percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Area Customization

**Customize the gauge background**

Using [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Background) and
[`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Border) properties, you can change the background color and border of the circular gauge.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/area-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area-customization.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/area-customization/area-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/area-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area-customization.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/area-customization/area-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Gauge Margin**

You can set margin for gauge from its container through
[`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Margin) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Radius calculation based on angles

Render semi or quarter circular gauges by modifying the start and end angles. By enabling the radius based on angle option, the radius of circular gauge will be calculated based on the start and end angles to avoid excess white space.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/radiusbasedgauge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position-percentage.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/radiusbasedgauge/position-percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-appearance/radiusbasedgauge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position-percentage.cs" %}
{% include code-snippet/circulargauge/gauge-appearance/radiusbasedgauge/position-percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

