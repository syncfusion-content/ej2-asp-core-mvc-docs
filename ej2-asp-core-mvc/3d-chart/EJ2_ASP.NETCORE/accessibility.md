---
layout: post
title: Accessibility in Syncfusion 3D Chart Component
description: Learn here all about Accessibility in Syncfusion ASP Core 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in Core 3D chart component

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with AJAX, HTML, JavaScript, and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

* img (role)
* button (role)
* region (role)
* aria-label (attribute)
* aria-hidden (attribute)
* aria-pressed (attribute)

## Keyboard navigation

All the 3D chart actions can be controlled via keyboard keys. The applicable key combinations and their relative functionalities are listed below.

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves the focus to the next element in the chart.
<kbd>Shift + Tab</kbd> |Moves the focus to the previous element in the chart.
<kbd>DownArrow</kbd> |Moves the focus to the data point left side from the selected point.
<kbd>UpArrow</kbd> |Moves the focus to the data point right side from the selected point.
<kbd>Left Arrow</kbd> |Moves the focus to the next series in the chart.
<kbd>Right Arrow</kbd> |Moves the focus to the previous series in the chart.
<kbd>ESC</kbd> |Cancel the tooltip for the data point.
<kbd>Enter/Space</kbd> |Selects the data point in the series.
<kbd>Down/Left Arrow</kbd> |Moves the focus to the legend left side from the selected legend.
<kbd>Up/Right Arrow</kbd> | Moves the focus to the legend right side from the selected legend.
<kbd>Enter/Space</kbd> |Toggles the visibility of the corresponding series.
<kbd>Ctrl + P</kbd> |Print the chart.