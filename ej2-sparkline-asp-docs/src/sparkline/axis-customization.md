---
title: "Axis Customization"
component: "Sparkline"
description: "Explains how to customize the axis in sparkline"
---

# Axis Customization

You can customize axis value types and min and max values of the sparkline.

## Change value type of the sparkline

You can change the sparkline value type by setting the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~ValueType.html) property to `Numeric`, `Category`, or `DateTime`.
<!-- markdownlint-disable MD036 -->

**DateTime**

You can assign date-time values to the sparkline by setting the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~ValueType.html) property to `DateTime`.

{% aspTab template="sparkline/axis/datetime", sourceFiles="datetime.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Category**

You can assign category values to the sparkline by setting [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~ValueType.html) to `Category`.

{% aspTab template="sparkline/axis/category", sourceFiles="category.cs" %}

{% endaspTab %}

**Numeric**

You can assign numeric values to the sparkline by setting [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~ValueType.html) to `Numeric`.

{% aspTab template="sparkline/axis/numeric", sourceFiles="numeric.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Change min and max values of axis

You can change the min and max values of x-axis by setting the [`minX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings~MinX.html) and [`maxX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings~MaxX.html) values to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property. You can also change the min and max values of y-axis by setting the [`minY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings~MinY.html) and [`maxY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings~MaxY.html) values to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property.

{% aspTab template="sparkline/axis/minmax", sourceFiles="minmax.cs" %}

{% endaspTab %}

## Change value of axis

You can set horizontal axis line value of the sparkline by setting [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings~Value.html) to the [`axisSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineAxisSettings.html) property. The following code example shows this.

{% aspTab template="sparkline/axis/value", sourceFiles="value.cs" %}

{% endaspTab %}

## Axis line customization

Axis of the sparkline can be collapsed using the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings~Visible.html) property in [`lineSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings.html); this is not applicable for win-loss. You can customize the [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings~Color.html), [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings~Width.html), [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings~Opacity.html), and [`dashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineLineSettings~DashArray.html) of axis line.

{% aspTab template="sparkline/axis/axis_line", sourceFiles="axis_line.cs" %}

{% endaspTab %}