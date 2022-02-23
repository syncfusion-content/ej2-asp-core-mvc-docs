---
title: " Chart Types | ASP.NET MVC "

component: "Chart"

description: "Essential JS 2 Chart  chart supports 32 types of series and also supports different tpes customizations for each type of chart."
---

# Chart Types

Essential JS 2 Chart supports 32 types of series.

<!-- markdownlint-disable MD036 -->

## Line Charts

<!-- markdownlint-disable MD036 -->

**Line**

To render a line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Line`.

{% aspTab template="chart/series/line-charts/line", sourceFiles="line.cs" %}

{% endaspTab %}

**Step Line**

To render a step line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StepLine`.

{% aspTab template="chart/series/line-charts/stepline", sourceFiles="stepline.cs" %}

{% endaspTab %}

**Stacked Line**

To render a stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingLine`.

{% aspTab template="chart/series/line-charts/stacked-line", sourceFiles="stacked-line.cs" %}

{% endaspTab %}

**100% Stacked Line**

To render a 100% stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingLine100`.

{% aspTab template="chart/series/line-charts/stacked-line-100", sourceFiles="stacked-line-100.cs" %}

{% endaspTab %}

**Spline**

To render a spline series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Spline`.

{% aspTab template="chart/series/line-charts/spline", sourceFiles="spline.cs" %}

{% endaspTab %}

**Spline Area**

To render a spline series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Spline`.

{% aspTab template="chart/series/line-charts/splinearea", sourceFiles="splinearea.cs" %}

{% endaspTab %}

**Multicolored Line**

To render a multicolored line series, use the series type as `MultiColoredLine`.
Here, the individual colors to the data can be mapped by using `PointColorMapping`.

{% aspTab template="chart/series/line-charts/multi-line", sourceFiles="multi-line.cs" %}

{% endaspTab %}

**Customization of Line Charts**

`stroke`, `stroke-width` and `dashArray` of all line type series can be customized by using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill),
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) and [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) properties.

{% aspTab template="chart/series/line-charts/custom-line", sourceFiles="custom-line.cs" %}

{% endaspTab %}

## Area Charts

**Area**

To render a area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Area`.

{% aspTab template="chart/series/area-charts/area", sourceFiles="area.cs" %}

{% endaspTab %}

**Range Area**

To render a range area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type)
as `RangeArea`.

{% aspTab template="chart/series/area-charts/rangearea", sourceFiles="rangearea.cs" %}

{% endaspTab %}

**Spline Range Area**

The Spline Range Area Chart is used to display continuous data points as a set of splines that vary between high and low values over intervals of time and across different categories.

To render a spline range area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html) as `SplineRangeArea`.

{% aspTab template="chart/series/area-charts/splinerangearea", sourceFiles="splinerangearea.cs" %}

{% endaspTab %}

**Stacked Area**

To render a stacked area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingArea`.

{% aspTab template="chart/series/area-charts/stackedarea", sourceFiles="stackedarea.cs" %}

{% endaspTab %}

**100% Stacked Area**

To render a 100% stacked area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingArea100`.

{% aspTab template="chart/series/area-charts/100%stackedarea", sourceFiles="stackedarea100.cs" %}

{% endaspTab %}

**Step Area**

To render a step area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StepArea`.

{% aspTab template="chart/series/area-charts/steparea", sourceFiles="steparea.cs" %}

{% endaspTab %}

**Stacked Step Area**

To render a stacked step area series, use series `Type` as `StackingStepArea`.

{% aspTab template="chart/series/area-charts/stacked-step-area", sourceFiles="stacked-step-area.cs" %}

{% endaspTab %}

**Multicolored area**

To render a multicolored area series, use the series type as `MultiColoredArea`.
The required `Segments` of the series can be customized using the `Value`, `Color`, and `DashArray`.

{% aspTab template="chart/series/area-charts/multicolor-area", sourceFiles="multicolor-area.cs" %}

{% endaspTab %}

**Customization of Area Charts**

fill, width and dashArray properties can be customized by [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill),
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) and [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) properties.

{% aspTab template="chart/series/area-charts/custom-area", sourceFiles="custom-area.cs" %}

{% endaspTab %}

## Column Charts

**Column**

To render a column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Column`.

{% aspTab template="chart/series/column-charts/column", sourceFiles="column.cs" %}

{% endaspTab %}

**Range Column**

To render a range column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `RangeColumn`.

{% aspTab template="chart/series/column-charts/rangecolumn", sourceFiles="rangecolumn.cs" %}

{% endaspTab %}

**Stacked Column**

To render a stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingColumn`.

{% aspTab template="chart/series/column-charts/stackedcolumn", sourceFiles="stackedcolumn.cs" %}

{% endaspTab %}

**100% Stacked Column**

To render a 100% stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingColumn100`.

{% aspTab template="chart/series/column-charts/100%stackedcolumn", sourceFiles="stackedcolumn100.cs" %}

{% endaspTab %}

**Stacking Group**

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked columns and 100% stacked columns.
Columns with same group name are stacked on top of each other.

{% aspTab template="chart/series/column-charts/group", sourceFiles="group.cs" %}

{% endaspTab %}

**Grouped Column**

You can use the [`GroupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_GroupName) property to group the data points in the column type charts.
Data points with same group name are grouped together.

{% aspTab template="chart/series/column-charts/group-column", sourceFiles="group-column.cs" %}

{% endaspTab %}

**Customization of Column Charts**

<!-- markdownlint-disable MD013 -->
`Fill` and `Border` of all column type series can be
customized using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Border) properties.
Width of the column and space between each column can be customized using [`columnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidth) and [`columnSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnSpacing) properties respectively. The [`columnWidthInPixel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidthInPixel) property allows to specify the column width in pixel unit.
For customizing a specify point, please refer the
[`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender).

{% aspTab template="chart/series/column-charts/custom-column", sourceFiles="custom-column.cs" %}

{% endaspTab %}

## Bar Charts

**Bar**

To render a bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Bar`.

{% aspTab template="chart/series/bar-charts/bar", sourceFiles="bar.cs" %}

{% endaspTab %}

**Stacked bar**

To render a stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingBar`.

{% aspTab template="chart/series/bar-charts/stackedbar", sourceFiles="stackedbar.cs" %}

{% endaspTab %}

**100% Stacked Bar**

To render a 100% stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingBar100`.

{% aspTab template="chart/series/bar-charts/100%stackedbar", sourceFiles="stackedbar100.cs" %}

{% endaspTab %}

**Stacking Group**

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked
bar and 100% stacked bar. Columns with same group name are stacked on top of each other.

{% aspTab template="chart/series/bar-charts/group", sourceFiles="group.cs" %}

{% endaspTab %}

**Grouped Bar**

You can use the [`GroupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_GroupName) property to group the data points in the bar type charts.
Data points with same group name are grouped together.

{% aspTab template="chart/series/bar-charts/group-bar", sourceFiles="group-bar.cs" %}

{% endaspTab %}

**Customization of Bar Charts**

`Fill` and `Border` of all bar type series can be
customized using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Border).
Width of the bar and space between each bar can be customized using [`columnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidth) and [`columnSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnSpacing) properties respectively. The [`columnWidthInPixel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidthInPixel) property allows to specify the bar width in pixel unit.
For customizing a specify point, please refer the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender).

{% aspTab template="chart/series/bar-charts/custom-bar", sourceFiles="custom-bar.cs" %}

{% endaspTab %}

## Scatter Charts

To render a scatter series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Scatter`.

{% aspTab template="chart/series/scatter-bubble/scatter", sourceFiles="scatter.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD018 -->

##Bubble Chart

To render a bubble series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Bubble`.

{% aspTab template="chart/series/scatter-bubble/bubble", sourceFiles="bubble.cs" %}

{% endaspTab %}

**Bubble Size Mapping**

`Size` property can be used to map the size value specified in data source.

{% aspTab template="chart/series/scatter-bubble/bubble-size", sourceFiles="bubble-size.cs" %}

{% endaspTab %}