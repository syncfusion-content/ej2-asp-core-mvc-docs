---
title: " Chart Polar and Radar | ASP.NET MVC "

component: "Chart"

description: "Polar and Radar chart supports different draw types and customization to display the data."
---

<!-- markdownlint-disable MD036 -->

# Polar Chart and Radar Chart

## Polar Chart

To render a polar series, use series[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Polar`.

### Draw Types

Polar drawType property is used to change the series plotting type to line, column, area, range column, spline,
scatter, stacking area and stacking column. The default value of drawType is `Line`.

**Line**

To render a line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Line`.
[`IsClosed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IsClosed) property specifies whether to join start and end point of
 a line series used in polar chart to form a closed path. Default value of isClosed is true.

{% aspTab template="chart/series/polar_radar/polar-line", sourceFiles="polar-line.cs" %}

{% endaspTab %}

**Spline**

To render a spline line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Spline`.

{% aspTab template="chart/series/polar_radar/polar-spline", sourceFiles="polar-spline.cs" %}

{% endaspTab %}

**Area**

To render a area line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Area`.

{% aspTab template="chart/series/polar_radar/polar-area", sourceFiles="polar-area.cs" %}

{% endaspTab %}

**Stacked Area**

To render a stacked area draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `StackingArea`.

{% aspTab template="chart/series/polar_radar/polar-stackedarea", sourceFiles="polar-stackedarea.cs" %}

{% endaspTab %}

**Column**

To render a column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Column`.

{% aspTab template="chart/series/polar_radar/polar-column", sourceFiles="polar-column.cs" %}

{% endaspTab %}

**Stacked Column**

To render a stacked column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `StackingColumn`.

{% aspTab template="chart/series/polar_radar/polar-stackedcolumn", sourceFiles="polar-stackedcolumn.cs" %}

{% endaspTab %}

**Range Column**

To render a range column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `RangeColumn`.

{% aspTab template="chart/series/polar_radar/polar-rangecolumn", sourceFiles="polar-rangecolumn.cs" %}

{% endaspTab %}

**Scatter**

To render a scatter draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Scatter`.

{% aspTab template="chart/series/polar_radar/polar-scatter", sourceFiles="polar-scatter.cs" %}

{% endaspTab %}

## Radar Chart

To render a radar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Radar`.

### Draw Type

**Line**

To render a line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Line`.
[`IsClosed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IsClosed) property specifies whether to join start and end point of
a line series used in polar chart to form a closed path. Default value of isClosed is true.

{% aspTab template="chart/series/polar_radar/radar-line", sourceFiles="radar-line.cs" %}

{% endaspTab %}

### Customization

**Start Angle**

You can customize the start angle of the polar series using
[`StartAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_StartAngle) property. By default, `StartAngle` is 0 degree.

{% aspTab template="chart/series/polar_radar/start-angle", sourceFiles="start-angle.cs" %}

{% endaspTab %}

**Coefficient in axis**

You can customize the radius of the polar series and radar series using
[`Coefficient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Coefficient) property. By default, `Coefficient` is 100.

{% aspTab template="chart/series/polar_radar/co-efficient", sourceFiles="co-efficient.cs" %}

{% endaspTab %}

## See Also

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)
