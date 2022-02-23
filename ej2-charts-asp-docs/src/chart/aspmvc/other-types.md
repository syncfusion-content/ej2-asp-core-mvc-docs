---
title: " Chart Other Types | ASP.NET MVC "

component: "Chart"

description: "Chart contains box and wishker, errorbar, waterfall and histogram charts and also supports different customization"
---

<!-- markdownlint-disable MD036 -->

# Box and whisker

To render a box and whisker chart, use series[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`.
The field y requires n number of data or it should contains minimum of five values to plot a segment.

{% aspTab template="chart/series/other-types/box", sourceFiles="box.cs" %}

{% endaspTab %}

## Customization of Box and Whisker series

### boxPlotMode

You can change the rendering mode of the Box and Whisker series using the `BoxPlotMode` property.
The default boxPlotMode is `Exclusive`.The other boxPlotMode available are `Inclusive` and `Normal`.

To render a box and whisker chart, use series[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`.
The field y requires n number of data or it should contains minimum of five values to plot a segment.

{% aspTab template="chart/series/other-types/box-plot", sourceFiles="box-plot.cs" %}

{% endaspTab %}

### showMean

In Box and Whisker series `ShowMean` property is used to show the box and whisker average value. The default value of `ShowMean` is false.

{% aspTab template="chart/series/other-types/box-mean", sourceFiles="box-mean.cs" %}

{% endaspTab %}

## Waterfall Chart

Waterfall chart helps to understand the cumulative effect of the sequentially introduced positive
and negative values. To render a Waterfall series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as
`Waterfall`. [`IntermediateSumIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IntermediateSumIndexes)
property of waterfall is used to represent the in between the sum values and
[`SumIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SumIndexes)
is used to represent the cumulative sum values.

{% aspTab template="chart/series/other-types/waterfall", sourceFiles="waterfall.cs" %}

{% endaspTab %}

**Customization of Waterfall Series**

The negative changes of waterfall charts is
represented by using [`NegativeFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_NegativeFillColor)
and the summary changes are represented by using [`SummaryFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SummaryFillColor)
properties.

By default, the negativeFillColor as ‘#E94649’ and the summaryFillColor as ‘#4E81BC’.

{% aspTab template="chart/series/other-types/custom-waterfall", sourceFiles="custom-waterfall.cs" %}

{% endaspTab %}

## Error Bar Chart

Error bars are graphical representations of the variability of data and used on graphs to indicate the error or uncertainty in a reported
measurement. To render the error bar for the series, set [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Visible)
as `true` in error bar object.

{% aspTab template="chart/series/other-types/errorbar", sourceFiles="errorbar.cs" %}

{% endaspTab %}

**Changing Error Bar Type**

To change the error bar rendering type using [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type)
option of error bar. To change the error bar line length you can use [`VerticalError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html)
property.

{% aspTab template="chart/series/other-types/error-type", sourceFiles="error-type.cs" %}

{% endaspTab %}

**Customizing Error Bar Type**

To customize the error bar type, set error bar [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Custom` and
then change the horizontal/vertical positive and negative error of error bar.

{% aspTab template="chart/series/other-types/custom-error", sourceFiles="custom-error.cs" %}

{% endaspTab %}

**Changing Error Bar Mode**

Error bar mode is used to define whether the error bar line has to be drawn horizontally, vertically or in both side.
To change the error bar mode use [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% aspTab template="chart/series/other-types/error-mode", sourceFiles="error-mode.cs" %}

{% endaspTab %}

**Changing Error Bar Direction**

To change the error bar direction to plus, minus or both side using [`Direction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% aspTab template="chart/series/other-types/error-direction", sourceFiles="error-direction.cs" %}

{% endaspTab %}

**Customizing Error Bar Cap**

To customize the error bar cap length, width and fill color, you can use [`ErrorBarCap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% aspTab template="chart/series/other-types/error-cap", sourceFiles="error-cap.cs" %}

{% endaspTab %}

## Vertical Chart

In EJ2 chart, you can draw a chart in vertical manner by changing orientation of the axis. All series types support this feature.
You can use `IsTransposed` property in chart to render a chart in vertical manner.

{% aspTab template="chart/series/other-types/vertical", sourceFiles="vertical.cs" %}

{% endaspTab %}

## Pareto chart

Pareto charts are used to find the cumulative values of data in different categories. It is a combination of Column and Line series.
The initial values are represented by column chart and the cumulative values are represented by Line chart.
To render a pareto chart, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Pareto`.

{% aspTab template="chart/series/other-types/pareto", sourceFiles="pareto.cs" %}

{% endaspTab %}

## See Also

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)
