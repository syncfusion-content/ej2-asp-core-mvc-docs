---
title: "Tooltip"
component: "Smith Chart"
description: "Tooltip support in smith chart"
---

# Tooltip

Smithchart will display details about the points through tooltip, when the mouse is moved over the point. By default, tooltip is disabled. To enable the tooltip for smithchart, you need to import and inject TooltipRender module from chart. And also set the property visible as true, in tooltip settings. You can customize the tooltip's visibility and appearance differently each series in the smithchart.

{% aspTab template="smithchart/tooltip/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}