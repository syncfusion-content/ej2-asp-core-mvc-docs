---
layout: post
title: Data Markers in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Data Markers in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Markers
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Markers in ##Platform_Name## Chart Component

Data markers are used to provide information about the data points in the series. You can add a shape to adorn each data point.

<!-- markdownlint-disable MD036 -->

## Marker

<!-- markdownlint-disable MD036 -->

Markers can be added to the points by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) option of the marker property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/chart/data-marker/marker/marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/chart/data-marker/marker/marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Shape

Markers can be assigned with different shapes such as Rectangle, Circle, Diamond etc. using the `shape`property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/shape/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shape.cs" %}
{% include code-snippet/chart/data-marker/shape/shape.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/shape/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Shape.cs" %}
{% include code-snippet/chart/data-marker/shape/shape.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> To know more about the marker shape type refer the [`shape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_Shape).

## Images

Apart from the shapes, you can also add custom images to mark the data point using the [`imageUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_ImageUrl) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/images/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Images.cs" %}
{% include code-snippet/chart/data-marker/images/images.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/images/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Images.cs" %}
{% include code-snippet/chart/data-marker/images/images.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Marker's color and border can be customized using `fill` and `border` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/data-marker/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/data-marker/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing specific point

You can also customize the specific marker and label using [`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event. The `pointRender` event allows you to change the shape, color and border for a point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/custom-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/data-marker/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/custom-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/data-marker/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Fill marker with series color

Marker can be filled with the series color by setting the [`isFilled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_IsFilled) property to <b>true</b>.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/isfilled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="IsFilled.cs" %}
{% include code-snippet/chart/data-marker/isfilled/isfilled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/data-marker/isfilled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="IsFilled.cs" %}
{% include code-snippet/chart/data-marker/isfilled/isfilled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}