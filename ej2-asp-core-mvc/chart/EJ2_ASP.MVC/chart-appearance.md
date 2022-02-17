---
layout: post
title: Chart Appearance in ##Platform_Name## Chart Component
description: Learn here all about Chart Appearance in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Chart Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance

## Chart Theme Customization

You can customize the default theme of the chart `Theme` property. There are 9 themes available. They are,
`Material`, `Fabric`, `Bootstrap`, `HighContrastLight`, `MaterialDark`, `FabricDark`, `HighContrast`, `BootstrapDark` and `Bootstrap4`.

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



## Custom Color Palette

You can customize the default color of series or points by providing a custom color palette of your choice by
using the [`Palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Palettes) property.

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



## Point Level Customization

Marker, datalabel and fill color of each data point can be customized with
[`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and
[`TextRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event.

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

## Chart Area Customization

<!-- markdownlint-disable MD036 -->

**Customize the Chart Background**

<!-- markdownlint-disable MD013 -->
Using [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Border) properties, you can change the background color and border of the chart.

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



**Chart Margin**

You can set margin for chart from its container through [`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Margin) property.

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



**Chart Area Customization**

Using [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Border) properties, you can change the background color and border of the chart area. Width for the chart area can be customized using [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Width) property.

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



## Animation

You can customize animation for a particular series using [`Animation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAnimation.html) property. You can enable or disable animation of the series using `Enable` property, `Duration` specifies the duration of an animation and `Delay` allows us to start the animation at desire time.

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



## Fluid Animation

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



## Chart Title

Chart can be given a title using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) property, to show the information about the data plotted.

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



## Chart SubTitle

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

