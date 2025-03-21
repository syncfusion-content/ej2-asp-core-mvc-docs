---
layout: post
title: Cross Hair in ##Platform_Name## Syncfusion Stock Chart Component
description: Learn here all about Cross Hair in Syncfusion ##Platform_Name## Stock Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cross Hair
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Crosshair

Crosshair has a vertical and horizontal line to view the value of the axis at mouse or touch position.

Crosshair lines can be enabled by using [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Enable) property in the `crosshair`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/crosshair/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/crosshair/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Crosshair.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/crosshair/crosshair.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip for axis

Tooltip label for an axis can be enabled by using [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairTooltip.html#Syncfusion_EJ2_Charts_ChartCrosshairTooltip_Enable) property of `crosshairTooltip` in the corresponding axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/axis-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-tooltip.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/axis-tooltip/axis-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/axis-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-tooltip.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/axis-tooltip/axis-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the `crosshairTooltip` is used to customize the background color and font style of the crosshair label respectively. Color and width of the crosshair line can be customized by using the [`line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Line) property in the crosshair.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Snap to data**

Enabling the [`SnapToData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartCrosshairSettings.html#Syncfusion_EJ2_Charts_StockChartCrosshairSettings_SnapToData) property in the crosshair aligns it with the nearest data point instead of following the exact mouse position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/snapToData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SnapToData.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/snapToData/snapToData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/snapToData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SnapToData.cs" %}
{% include code-snippet/stock-chart/user-interaction/crosshair-trackball/snapToData/snapToData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Add Trackball

Trackball is used to track a data point closest to the mouse or touch position. Trackball marker indicates the closest point and trackball tooltip displays the information about the point.

Trackball can be enabled by setting the [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the crosshair to true and [`shared`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property in `tooltip` to true in chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/trackball/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Trackball.cs" %}
{% include code-snippet/stock-chart/getting-started/trackball/trackball.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/getting-started/trackball/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Trackball.cs" %}
{% include code-snippet/stock-chart/getting-started/trackball/trackball.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


