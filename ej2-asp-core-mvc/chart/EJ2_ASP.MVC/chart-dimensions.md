---
layout: post
title: Chart Dimensions in ##Platform_Name## Chart Component
description: Learn here all about Chart Dimensions in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chart Dimensions

## Size for Container

The chart can render to its container size. Set the size via inline styles or CSS as shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/getting-started/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/getting-started/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size for Chart

Set the chart size directly using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Height) properties.

<!-- markdownlint-disable MD036 -->
**In Pixel**
<!-- markdownlint-disable MD036 -->

You can set the size of chart in pixel as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/chart/getting-started/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/chart/getting-started/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In Percentage**

When percentage values are used, the chart dimensions are relative to the container. For example, a height of `50%` renders the chart to half the container height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/chart/getting-started/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/chart/getting-started/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> When you do not specify the size, it takes `450px` as the height and window size as its width.
N> Note: When no size is specified, the chart defaults to a height of `450px` and uses the window width.


