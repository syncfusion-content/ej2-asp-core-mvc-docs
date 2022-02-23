---
title: "User Interactions"
component: "Sparkline"
description: "Explains how to customize the user interactions in sparkline"
---

# User interactions

Sparkline has two user interaction features: tooltip and tracker line.

## Tooltip

The sparkline provides options to display details about values of data points through tooltips when hovering the mouse over data point. To use tooltip in sparkline, inject the [`SparklineTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineTooltipSettings.html) module to sparkline using the inject method.

The following code example shows enabling tooltip for sparkline with format.

{% aspTab template="sparkline/user-interaction/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

### Tooltip customization

The fill color, text styles, format, and border of the tooltip can be customized. The following code example shows customization of tooltip's fill color and text style.

{% aspTab template="sparkline/user-interaction/tooltip_custom", sourceFiles="tooltip_custom.cs" %}

{% endaspTab %}

### Tooltip template

Sparkline tooltip has template support. By using tooltip template, you can customize tooltips. The following code example shows more customization options provided to  `sparktooltip` class that is used in tooltip template div. Using this template, images also can be added to tooltip.

{% aspTab template="sparkline/user-interaction/tooltip_template", sourceFiles="tooltip_template.cs" %}

{% endaspTab %}

## Track line

The track line tracks data points that are closer to the mouse position or touch contact.

To enable track lines for sparkline, specify the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineTrackLineSettings~Visible.html) option of  [`trackLineSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineTrackLineSettings.html) to true. Based on theme, tracker color will be changed. The default value of tracker color is black.

To use track line in sparkline, inject the [`SparklineTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineTooltipSettings.html) module to sparkline using the inject method.

{% aspTab template="sparkline/user-interaction/tooltip_trackline", sourceFiles="tooltip_trackline.cs" %}

{% endaspTab %}