---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Tool Tip of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

<!-- markdownlint-disable MD036 -->

Chart will display details about the points through tooltip, when the mouse is moved over the point.

## Enable Tooltip

The tooltip is useful when you cannot display information by using the data labels due to space constraints.
You can enable tooltip by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable) property as true
in [`Tooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html) object.

{% aspTab template="chart/user-interaction/tooltip/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Format the Tooltip

<!-- markdownlint-disable MD013 -->

By default, tooltip shows information of x and y value in points. In addition to that, you can show more
information in tooltip. For example the format '${series.name} ${point.x}' shows series name and point x
value.

{% aspTab template="chart/user-interaction/tooltip/format", sourceFiles="format.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD013 -->

## Tooltip Template

Any HTML elements can be displayed in the tooltip by using the ‘template’ property of the tooltip. You can use the ${x} and ${y} as place holders in the HTML element to display the x and y values of the corresponding data point.

{% aspTab template="chart/user-interaction/tooltip/template", sourceFiles="template.cs" %}

{% endaspTab %}

## Customize the Appearance of Tooltip

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill)
and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border)
properties are used to customize the background color and border of the tooltip respectively.
The [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle)
property in the tooltip is used to customize the font of the tooltip text.
The [`HighlightColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_HighlightColor) property is used to customize the point color while hovering for tooltip.

{% aspTab template="chart/user-interaction/tooltip/custom-tooltip", sourceFiles="custom-tooltip.cs" %}

{% endaspTab %}

## Tooltip Mapping Name

By default, tooltip shows information of x and y value in points. You can show more information from data source in tooltip by using the `TooltipMappingName` property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

{% aspTab template="chart/user-interaction/tooltip/tooltip-mapping", sourceFiles="tooltip-mapping.cs" %}

{% endaspTab %}
