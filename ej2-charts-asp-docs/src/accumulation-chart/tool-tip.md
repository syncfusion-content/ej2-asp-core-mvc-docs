---
title: "Accumulation Chart Tooltip | TASP.NET MVC "

component: "Accumulation Chart"

description: "Accumulation chart tooltip represents the x and y values of the current mouse pointer point."
---

# Tooltip

Tooltip for the accumulation chart can be enabled by using the `enable` property.

{% aspTab template="chart/accumulation-charts/tooltip/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Header

We can specify header for the tooltip using `header` property.

{% aspTab template="chart/accumulation-charts/tooltip/header", sourceFiles="header.cs" %}

{% endaspTab %}

## Format

By default, tooltip shows information of x and y value in points. In addition to that, you can show more
information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

{% aspTab template="chart/accumulation-charts/tooltip/format", sourceFiles="format.cs" %}

{% endaspTab %}

## Tooltip Format

Any HTML element can be displayed in the tooltip by using the `template` property.

{% aspTab template="chart/accumulation-charts/tooltip/tooltip-format", sourceFiles="tooltip-format.cs" %}

{% endaspTab %}

## Customization

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Fill) and
[`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Border)
properties are used to customize the background color and border of the tooltip respectively.
The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_TextStyle)
property in the tooltip is used to customize the font of the tooltip text.

{% aspTab template="chart/accumulation-charts/tooltip/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## To customize individual tooltip

Using `tooltipRender` event, you can customize a tooltip for particular point. event, you can customize a
tooltip for particular point.

{% aspTab template="chart/accumulation-charts/tooltip/individual", sourceFiles="individual.cs" %}

{% endaspTab %}

## Tooltip Mapping Name

By default, tooltip shows information of x and y value in points. You can show more information from datasource in tooltip by using the `tooltipMappingName` property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

{% aspTab template="chart/accumulation-charts/tooltip/mapping", sourceFiles="mapping.cs" %}

{% endaspTab %}
