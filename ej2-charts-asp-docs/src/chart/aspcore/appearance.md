---
title: " Chart Axis Customization | ASP.NET MVC "

component: "Chart"

description: "Chart appearance provides various series color, various point colors, chart area customization like backgound, margin and chart animation"
---

# Appearance

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

**Chart Area Background**

The chart area background can be customized by using the [`background`]
property in the [`chartArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_ChartArea).

{% aspTab template="chart/series/column/background", sourceFiles="background.cs" %}

{% endaspTab %}

## Animation

You can customize animation for a particular series using [`animation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAnimation.html) property. You can enable or disable animation of the series using `enable` property, `duration` specifies the duration of an animation and `delay` allows us to start the animation at desire time.

{% aspTab template="chart/series/column/animation", sourceFiles="column.cs" %}

{% endaspTab %}

### Fluid Animation

Fluid animation used to animate series with updated dataSource continues animation rather than animation whole series. You can customize animation for a particular series using [`animate`] method.

{% aspTab template="chart/series/column/fluid-animation", sourceFiles="fluid.cs" %}

{% endaspTab %}

## Chart Title

Chart can be given a title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Title) property, to show the information about the data plotted.

{% aspTab template="chart/series/column/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Annotation

Annotations are used to mark the specific area of interest in the chart area with texts, shapes or images.

<!-- markdownlint-disable MD033 -->

You can add annotations to the chart by using the <code>annotations</code> option. By using the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAnnotation.html#Syncfusion_EJ2_Charts_ChartAnnotation_Content) option of annotation object, you can specify the id of the element that needs to be displayed in the chart area.

{% aspTab template="chart/series/column/annotation", sourceFiles="annotation.cs" %}

{% endaspTab %}