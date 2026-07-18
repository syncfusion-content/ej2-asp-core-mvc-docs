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

Data markers are visual indicators placed at each data point on a series, helping to clearly identify and highlight individual values in your chart. Markers improve readability and accessibility, especially in line and area charts where data points may otherwise be unclear. Customize marker shape, color, size, and appearance to match your design requirements.

<!-- markdownlint-disable MD036 -->

## Marker

<!-- markdownlint-disable MD036 -->

Enable markers for data points by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) option to `true` in the marker property. Each series receives distinct markers by default, improving visual differentiation.

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

Assign different shapes to markers such as Rectangle, Circle, Diamond, Triangle, and others using the [`Shape`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) property. Shape selection helps distinguish between multiple series and improves visual clarity.

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



N> To know more about the marker shape type refer the [`Shape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_Shape).

## Images

Use custom images as markers instead of predefined shapes by setting the [`ImageUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_ImageUrl) property. This allows branded or thematic markers that enhance visual appeal and user engagement.

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

Customize marker appearance by modifying the `Fill` (background color) and `Border` properties. Combined with shape and image options, these customizations enable comprehensive marker styling to match your application design.

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

Use the [`PointRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event to customize markers for individual data points. This event allows you to conditionally change shape, color, and border properties based on data values or other criteria.

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

Fill markers with the series color by enabling the [`IsFilled`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_IsFilled) property. This creates a cohesive visual design where markers inherit the series color automatically.

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