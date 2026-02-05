---
layout: post
title: Cross Hair And Track Ball in Syncfusion ##Platform_Name## Chart Component
description: Learn here all about Cross Hair And Track Ball in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cross Hair And Track Ball
publishingplatform: ##Platform_Name##
documentation: ug
---


# Crosshair in ##Platform_Name## Chart Component

The crosshair feature displays vertical and horizontal guide lines that intersect at the mouse or touch position, helping to identify the corresponding axis values precisely.

Crosshair lines can be enabled by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Enable) property in the `Crosshair` settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/crosshair/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/crosshair/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip for axis

Axis tooltip labels can be enabled by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairTooltip.html#Syncfusion_EJ2_Charts_ChartCrosshairTooltip_Enable) property of `CrosshairTooltip` in the corresponding axis. This tooltip displays the current axis value at the crosshair position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/axis-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/axis-tooltip/axis-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/axis-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/axis-tooltip/axis-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) properties of `CrosshairTooltip` are used to customize the background color and font style of the crosshair label.

The color and width of the crosshair lines can be customized by using the [`Line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Line) property in the crosshair settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Snap to data**

By enabling the [`SnapToData`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_SnapToData) property, the crosshair snaps to the nearest data point instead of following the exact mouse position. This improves accuracy when inspecting values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/snapToData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SnapToData.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/snapToData/snapToData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/snapToData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SnapToData.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/snapToData/snapToData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Trackball

The trackball feature tracks the data point closest to the mouse or touch position. A trackball marker highlights the nearest point, and the trackball tooltip displays detailed information about that point.

Trackball functionality can be enabled by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the crosshair to **true** and the [`Shared`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the `Tooltip` to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/trackball/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Trackball.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/trackball/trackball.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/trackball/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Trackball.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/trackball/trackball.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Crosshair highlight

The [`HighlightCategory`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_HighlightCategory) property highlights the background of the entire category when the crosshair is moved over the chart.

The crosshair line color can be customized using the [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartBorder.html#Syncfusion_EJ2_Charts_ChartBorder_Color) property within the [`Line`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Line) configuration.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/highlight-category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-category.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/highlight-category/highlight-category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/highlight-category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-category.cs" %}
{% include code-snippet/chart/user-interaction/crosshair-trackball/highlight-category/highlight-category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


