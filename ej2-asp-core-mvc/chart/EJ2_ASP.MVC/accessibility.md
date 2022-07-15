---
layout: post
title: Accessibility in Syncfusion Chart Component
description: Learn here all about Accessibility in Syncfusion ASP MVC Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in MVC chart component

Accessibility is achieved in the chart control through WAI-ARIA standard and keyboard navigation. The chart features can be effectively accessed through assistive technologies such as screen readers.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with AJAX, HTML, JavaScript, and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

The following ARIA attributes are used in the chart:

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>Datalabel</td>
<td>Reads the Point y value</td>
</tr>
<tr>
<td>Legend</td>
<td>Click to show or hide the series</td>
</tr>
<tr>
<td>Axis Title</td>
<td>Reads the axis tile</td>
</tr>
<tr>
<td>Chart Title</td>
<td>Reads the chart title</td>
</tr>
<tr>
<td>Series Points</td>
<td>Reads the Point x :  Point y value</td>
</tr>
</table>

## Keyboard navigation

All the chart actions can be controlled via keyboard keys. The applicable key combinations and their relative functionalities are listed below.

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
<kbd>Ctrl + +</kbd> |Zoom-in the chart.
<kbd>Ctrl + -</kbd> |Zoom-out the chart.
<kbd>Down/Up Arrow</kbd> |Pan the chart vertically.
<kbd>Left/Right Arrow</kbd> |Pan the chart horizontally.
<kbd>R</kbd> |Reset the zoomed chart.
<kbd>Ctrl + P</kbd> |Print the chart.