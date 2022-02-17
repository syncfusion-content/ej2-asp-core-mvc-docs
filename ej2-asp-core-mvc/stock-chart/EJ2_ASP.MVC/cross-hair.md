---
layout: post
title: Cross Hair in ##Platform_Name## Stock Chart Component
description: Learn here all about Cross Hair in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Cross Hair
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Crosshair

Crosshair has a vertical and horizontal line to view the value of the axis at mouse or touch position.

Crosshair lines can be enabled by using [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Enable)
property in the `Crosshair`.

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

Tooltip label for an axis can be enabled by using [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairTooltip.html#Syncfusion_EJ2_Charts_ChartCrosshairTooltip_Enable)
property of `CrosshairTooltip` in the corresponding axis.

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

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill)
and [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html)
property of the `CrosshairTooltip` is used to customize the background color and font style of the crosshair label
respectively. Color and width of the crosshair line can be customized by using the
[`Line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Line) property in the crosshair.

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



## Add Trackball

Trackball is used to track a data point closest to the mouse or touch position. Trackball marker indicates the
closest point and trackball tooltip displays the information about the point.

Trackball can be enabled by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the crosshair to true and
[`Shared`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property in `Tooltip` to true in chart.

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


