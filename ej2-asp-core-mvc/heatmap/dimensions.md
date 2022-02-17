---
layout: post
title: Dimensions in ##Platform_Name## Heatmap Component
description: Learn here all about Dimensions in Syncfusion ##Platform_Name## Heatmap component and more.
platform: ej2-asp-core-mvc
control: Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dimensions

## Size for container

Heat map can be rendered to its container size. You can set the size through inline or CSS.

```javascript
    <div id='container'>
        <div id='element' style="width:650px; height:350px;"></div>
    </div>
```

## Size for heat map

You can  set the size of heat map directly by using the  [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Height.html) properties.

## In pixel

You can set the size for heat map in a pixel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/dimensions/pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/heatmap/dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/dimensions/pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pixel.cs" %}
{% include code-snippet/heatmap/dimensions/pixel/pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## In percentage

By setting value in percentage, heat map gets its dimension with respect to its container. For example, when the height is ‘50%’, heat map rendered to half of the container height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/dimensions/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/heatmap/dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/dimensions/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/heatmap/dimensions/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

