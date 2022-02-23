---
title: "Tooltip"
component: "Heatmap"
description: "This section describes on how to define tooltip in heatmap and the customization options available for the tooltip"
---

# Tooltip

Tooltip is used to provide the details of the heatmap cell, and this can be displayed, while hovering the cursor over the cell or performing tap action in touch devices.

## Default tooltip

You can enable the tooltip by setting the [`showTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~ShowTooltip.html)  property to true.

{% aspTab template="heatmap/tooltip/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

## Tooltip template

In heatmap, you can customize the tooltip using the [`tooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TooltipRender.html) client side event.

{% aspTab template="heatmap/tooltip/template", sourceFiles="template.cs" %}

{% endaspTab %}

## Customize the appearance of Tooltip

The [`fill`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~Fill.html) and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~Border.html) properties are used to customize the background color and border of the tooltip respectively. The [`textStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~TextStyle.html) property in the tooltip is used to customize the font of the tooltip text.

{% aspTab template="heatmap/tooltip/tooltipSettings", sourceFiles="template.cs" %}

{% endaspTab %}
