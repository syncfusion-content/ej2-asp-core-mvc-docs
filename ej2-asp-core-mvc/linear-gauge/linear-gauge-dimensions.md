---
layout: post
title: Linear Gauge Dimensions in ##Platform_Name## Linear Gauge Component
description: Learn here all about Linear Gauge Dimensions in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Linear Gauge Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Linear Gauge Dimensions

<!-- markdownlint-disable MD036 -->

## Size for Linear Gauge

You can also set size for linear gauge directly through [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Height.html) properties.

**In Pixel**

You can set the size of lineargauge in pixel as demonstrated below.

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



**In Percentage**

By setting value in percentage, linear gauge gets its dimension with respect to its container. For example, when the height is ‘50%’, linear gauge renders to half of the container height.

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



> When you do not specify the size, it takes `450px` as the height and window size as its width.