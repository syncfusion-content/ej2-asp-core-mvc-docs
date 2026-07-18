---
layout: post
title: Chart Appearance in Syncfusion Chart Component
description: Learn here all about Chart Appearance in Syncfusion ASP MVC Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chart Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance in MVC Chart component

## Chart theme customization

You can customize the default theme of the chart `Theme` property. There are 9 themes available. They are, `Material`, `Fabric`, `Bootstrap`, `HighContrastLight`, `MaterialDark`, `FabricDark`, `HighContrast`, `BootstrapDark` and `Bootstrap4`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/chart/series/column/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/chart/series/column/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom color palette

Customize the default color of series or points by providing a custom color palette using the [`Palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Palettes) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/series/column/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/series/column/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Data point customization

The color of individual data point or data points within a range can be customized using the options below.

### Point color mapping

You can bind the color for the points from [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) for the series using [`PointColorMapping`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_PointColorMapping) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/point-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-color.cs" %}
{% include code-snippet/chart/series/column/point-color/point-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/point-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-color.cs" %}
{% include code-snippet/chart/series/column/point-color/point-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Range color mapping

You can differentiate data points based on their y values using [`RangeColorSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartRangeColorSettings.html) in the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/range-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range-color.cs" %}
{% include code-snippet/chart/series/column/range-color/range-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/range-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range-color.cs" %}
{% include code-snippet/chart/series/column/range-color/range-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Point level customization

Marker, data label, and fill color of individual data points can be customized using the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and [`TextRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point.cs" %}
{% include code-snippet/chart/series/column/point/point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point.cs" %}
{% include code-snippet/chart/series/column/point/point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Chart area customization

<!-- markdownlint-disable MD036 -->

**Customize the chart background**

<!-- markdownlint-disable MD013 -->

Use the [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Border) properties on the chart to change its background color and border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/column/area/area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/column/area/area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Chart margin**

Set the chart margin relative to its container using the [`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Margin) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/chart/series/column/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/chart/series/column/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Chart area customization**

To customize the plotting region (chart area), use the `ChartArea` properties: [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Border) change the chart area's appearance, and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Width) adjusts its size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/background/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Background.cs" %}
{% include code-snippet/chart/series/column/background/background.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/background/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Background.cs" %}
{% include code-snippet/chart/series/column/background/background.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Chart area margin**

You can customize the space between the chart area from its chart container through [`Margin`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Margin) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/area-margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area-margin.cs" %}
{% include code-snippet/chart/series/column/area-margin/area-margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/area-margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area-margin.cs" %}
{% include code-snippet/chart/series/column/area-margin/area-margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Animation

Customize animation for a series using the [`Animation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAnimation.html) property. Use `Enable` to turn animation on or off; `Duration` controls the animation length and `Delay` sets when the animation starts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/series/column/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/series/column/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Fluid animation

Fluid animation used to animate series with updated dataSource continues animation rather than animation whole series. You can customize animation for a particular series using [`Animate`] method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/fluid-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fluid.cs" %}
{% include code-snippet/chart/series/column/fluid-animation/fluid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/fluid-animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fluid.cs" %}
{% include code-snippet/chart/series/column/fluid-animation/fluid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Chart title

Add a chart title using the [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) property. The title appears at the top of the chart by default and is used to describe the purpose or subject of the visualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/series/column/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/series/column/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Title position

Use the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTitleSettings.html#Syncfusion_EJ2_Charts_ChartTitleSettings_Position) property within [`TitleStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TitleStyle) to place the [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) at the left, right, top, or bottom of the chart. The default position is at the top.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titleposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleposition.cs" %}
{% include code-snippet/chart/series/column/titleposition/titleposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titleposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleposition.cs" %}
{% include code-snippet/chart/series/column/titleposition/titleposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



To manually position the title anywhere within the chart, use the [`X`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTitleSettings.html#Syncfusion_EJ2_Charts_ChartTitleSettings_X) and [`Y`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTitleSettings.html#Syncfusion_EJ2_Charts_ChartTitleSettings_Y) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titleoption/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleoption.cs" %}
{% include code-snippet/chart/series/column/titleoption/titleoption.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titleoption/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleoption.cs" %}
{% include code-snippet/chart/series/column/titleoption/titleoption.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Title alignment

Align the chart title to the near, center, or far side of the chart using the [`TextAlignment`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTitleSettings.html#Syncfusion_EJ2_Charts_ChartTitleSettings_TextAlignment) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titlealignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titlealignment.cs" %}
{% include code-snippet/chart/series/column/titlealignment/titlealignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/titlealignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titlealignment.cs" %}
{% include code-snippet/chart/series/column/titlealignment/titlealignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Chart subTitle

Chart can be given a subtitle using [`SubTitle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SubTitle) property, to show the information about the data plotted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/subtitle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Subtitle.cs" %}
{% include code-snippet/chart/series/column/subtitle/subtitle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/subtitle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Subtitle.cs" %}
{% include code-snippet/chart/series/column/subtitle/subtitle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}