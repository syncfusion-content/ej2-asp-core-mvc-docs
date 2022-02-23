---
title: " Chart Appearance | ASP.NET MVC "

component: "Chart"

description: "We can customize chart appearance by using color palette, point level customization, chart area cutomization, title and margin customizations."
---

# Appearance

## Chart Theme Customization

You can customize the default theme of the chart `Theme` property. There are 9 themes available. They are,
`Material`, `Fabric`, `Bootstrap`, `HighContrastLight`, `MaterialDark`, `FabricDark`, `HighContrast`, `BootstrapDark` and `Bootstrap4`.

{% aspTab template="chart/series/column/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

## Custom Color Palette

You can customize the default color of series or points by providing a custom color palette of your choice by
using the [`Palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Palettes) property.

{% aspTab template="chart/series/column/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Point Level Customization

Marker, datalabel and fill color of each data point can be customized with
[`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and
[`TextRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event.

{% aspTab template="chart/series/column/point", sourceFiles="point.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Chart Area Customization

<!-- markdownlint-disable MD036 -->

**Customize the Chart Background**

<!-- markdownlint-disable MD013 -->
Using [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Border) properties, you can change the background color and border of the chart.

{% aspTab template="chart/series/column/area", sourceFiles="area.cs" %}

{% endaspTab %}

**Chart Margin**

You can set margin for chart from its container through [`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Margin) property.

{% aspTab template="chart/series/column/margin", sourceFiles="margin.cs" %}

{% endaspTab %}

**Chart Area Customization**

Using [`Background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Border) properties, you can change the background color and border of the chart area. Width for the chart area can be customized using [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Width) property.

{% aspTab template="chart/series/column/background", sourceFiles="background.cs" %}

{% endaspTab %}

## Animation

You can customize animation for a particular series using [`Animation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAnimation.html) property. You can enable or disable animation of the series using `Enable` property, `Duration` specifies the duration of an animation and `Delay` allows us to start the animation at desire time.

{% aspTab template="chart/series/column/animation", sourceFiles="animation.cs" %}

{% endaspTab %}

## Fluid Animation

Fluid animation used to animate series with updated dataSource continues animation rather than animation whole series. You can customize animation for a particular series using [`Animate`] method.

{% aspTab template="chart/series/column/fluid-animation", sourceFiles="fluid.cs" %}

{% endaspTab %}

## Chart Title

Chart can be given a title using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) property, to show the information about the data plotted.

{% aspTab template="chart/series/column/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Chart SubTitle

Chart can be given a subtitle using [`SubTitle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SubTitle) property, to show the information about the data plotted.

{% aspTab template="chart/series/column/subtitle", sourceFiles="subtitle.cs" %}

{% endaspTab %}