---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Tooltip of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

The tooltip is used to show the card information when the cursor hover over the card elements using the `EnableTooltip` property. Tooltip content is dynamically set based on hovering over the card elements.

> If you wish to show tooltip on Kanban board custom elements, you need to add `e-tooltip-text` class name of a particular element.

## Tooltip template

You can customize the tooltip content with any HTML or CSS element and styling using the `TooltipTemplate` property. In the following demo, the tooltip is customized with HTML elements.

{% aspTab template="kanban/tooltip", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/tooltip.PNG)
