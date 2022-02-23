---
title: " Chart Category Axis | ASP.NET MVC "

component: "Chart"

description: "Category axis are used to represent, the string values instead of numbers.It contains range, label placement customizations."
---

# Category Axis

<!-- markdownlint-disable MD036 -->

Category axis are used to represent, the string values instead of numbers.

{% aspTab template="chart/axis/category/column", sourceFiles="column.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Labels Placement

<!-- markdownlint-disable MD036 -->

By default, category labels are placed between the ticks in an axis, this can also be placed on ticks
using [`LabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelPlacement) property.

{% aspTab template="chart/axis/category/placement", sourceFiles="placement.cs" %}

{% endaspTab %}

## Range

Range of the category axis can be customized using [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Minimum),
[`Maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Maximum) and [`Interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Interval) property of
the axis.

{% aspTab template="chart/axis/category/range", sourceFiles="range.cs" %}

{% endaspTab %}

## Indexed category axis

Category axis also can be rendered based on the index values of data source. This can be achieved by defining the
`IsIndexed` property to `true` in the axis.

{% aspTab template="chart/axis/category/index", sourceFiles="index.cs" %}

{% endaspTab %}