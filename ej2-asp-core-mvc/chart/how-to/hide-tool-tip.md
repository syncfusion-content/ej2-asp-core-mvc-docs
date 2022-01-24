---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Hide Tool Tip of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Hide Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Hide the tooltip for unselected series

By using the [`tooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TooltipRender) event,
you can cancel the tooltip for unselected series in the chart.

To hide the tooltip value in unselected series, follow the given steps:

**Step 1**:

By using the [`tooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TooltipRender) event,
you can get the series elements in the arguments. By using this argument we can compare whether seriesElementclasslist is deselected container or not.
If it is true then we cancel the tooltip by setting the value for `args.cancel` as `true`.

{% aspTab template="chart/series/column/hide-tooltip", sourceFiles="hide-tooltip.cs" %}

{% endaspTab %}