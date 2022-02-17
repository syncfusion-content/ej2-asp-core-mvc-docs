---
layout: post
title: Linear Gauge Dimensions in ##Platform_Name## Linear Gauge Component
description: Learn here all about Linear Gauge Dimensions in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Linear Gauge Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dimensions in ASP.NET MVC Linear Gauge

<!-- markdownlint-disable MD036 -->

## Size for Linear Gauge

The height and width of the Linear Gauge can be set using the [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_Height) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_Width) properties in [`LinearGauge`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html).

### In Pixel

The size of the Linear Gauge can be set in pixel as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/dimensions/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/lineargauge/dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/dimensions/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/lineargauge/dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Linear Gauge with height and width in pixel value](../linear-gauge/images/gauge-pixel.png)

### In Percentage

By setting value in percentage, Linear Gauge receives its dimension matching to its parent. For example, when the height is set as **50%**, Linear Gauge renders to half of the parent height. The Linear Gauge will be responsive when the width is set as **100%**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/dimensions/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/lineargauge/dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/dimensions/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/lineargauge/dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Linear Gauge with height and width in percentage value](../linear-gauge/images/gauge-percentage.png)

> When the component's size is not specified, the height will be **450px** and the width will be the same as the parent element's width.