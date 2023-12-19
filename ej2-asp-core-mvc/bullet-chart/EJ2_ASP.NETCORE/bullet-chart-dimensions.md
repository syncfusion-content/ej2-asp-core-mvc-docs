---
layout: post
title: Bullet Chart Dimensions in ##Platform_Name## Bullet Chart Component
description: Learn here all about Bullet Chart Dimensions in Syncfusion ##Platform_Name## Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bullet Chart Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bullet chart dimensions

## Size for container

The size of the Bullet Chart is determined by the container size, and it can be changed inline or via CSS as following.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/container/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Container.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/container/container.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/container/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Container.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/container/container.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size for bullet chart

The [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Height) properties are used to adjust the size of the Bullet Chart.

### Pixel

Sets the size of the Bullet Chart in pixels as shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Percentage

By setting a value in percentage, the Bullet Chart gets its dimension with respect to its container. For example, when the height is **50%**, the Bullet Chart renders to half of the container’s height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/bullet-chart/bullet-chart-dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N>If the size is not specified, the Bullet Chart will be rendered with a height of **126px** and a width of the window.