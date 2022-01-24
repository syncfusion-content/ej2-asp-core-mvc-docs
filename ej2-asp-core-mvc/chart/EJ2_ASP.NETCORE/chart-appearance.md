---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Chart Appearance of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Chart Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance

## Chart Theme Customization

You can customize the default theme of the chart `theme` property. There are 9 themes available. They are,
`Material`, `Fabric`, `Bootstrap`, `HighContrastLight`, `MaterialDark`, `FabricDark`, `HighContrast`, `BootstrapDark` and `Bootstrap4`.

{% aspTab template="chart/series/column/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

## Custom Color Palette

You can customize the default color of series or points by providing a custom color palette of your choice by
using the [`palettes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Palettes) property.

{% aspTab template="chart/series/column/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Point Level Customization

Marker, datalabel and fill color of each data point can be customized with
[`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and
[`textRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event.

{% aspTab template="chart/series/column/point", sourceFiles="point.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Chart Area Customization

<!-- markdownlint-disable MD036 -->

**Customize the Chart Background**

<!-- markdownlint-disable MD013 -->
Using [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Background) and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Border) properties, you can change the background color and border of the chart.

{% aspTab template="chart/series/column/area", sourceFiles="area.cs" %}

{% endaspTab %}

**Chart Margin**

You can set margin for chart from its container through [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Margin) property.

{% aspTab template="chart/series/column/margin", sourceFiles="margin.cs" %}

{% endaspTab %}

**Chart Area Customization**

Using [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Background) and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Border) properties, you can change the background color and border of the chart area. Width for the chart area can be customized using [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartArea.html#Syncfusion_EJ2_Charts_ChartArea_Width) property.

{% aspTab template="chart/series/column/background", sourceFiles="background.cs" %}

{% endaspTab %}

## Animation

You can customize animation for a particular series using [`animation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAnimation.html) property. You can enable or disable animation of the series using `enable` property, `duration` specifies the duration of an animation and `delay` allows us to start the animation at desire time.

{% aspTab template="chart/series/column/animation", sourceFiles="animation.cs" %}

{% endaspTab %}

## Fluid Animation

Fluid animation used to animate series with updated dataSource continues animation rather than animation whole series. You can customize animation for a particular series using [`animate`] method.

{% aspTab template="chart/series/column/fluid-animation", sourceFiles="fluid.cs" %}

{% endaspTab %}

## Chart Title

Chart can be given a title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) property, to show the information about the data plotted.

{% aspTab template="chart/series/column/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Chart SubTitle

Chart can be given a subtitle using [`subTitle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SubTitle) property, to show the information about the data plotted.

{% aspTab template="chart/series/column/subtitle", sourceFiles="subtitle.cs" %}

{% endaspTab %}