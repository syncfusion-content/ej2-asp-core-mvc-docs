---
layout: post
title: Gauge Dimensions in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge Dimensions in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Circular Gauge Dimensions

## Size for Circular Gauge

<!-- markdownlint-disable MD036 -->

You can also set size for the gauge directly through [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Height) properties.

**In Pixel**

You can set the size of the gauge in pixel as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-dimension/gauge-dimension/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-dimension.cs" %}
{% include code-snippet/circulargauge/gauge-dimension/gauge-dimension/gauge-dimension.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-dimension/gauge-dimension/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gauge-dimension.cs" %}
{% include code-snippet/circulargauge/gauge-dimension/gauge-dimension/gauge-dimension.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In Percentage**

By setting value in percentage, gauge gets its dimension with respect to its container. For example, when
the height is ‘50%’, gauge renders to half of the container height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-dimension/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/circulargauge/gauge-dimension/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-dimension/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/circulargauge/gauge-dimension/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> When you do not specify the size, it takes `450px` as the height and window size as its width.