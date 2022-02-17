---
layout: post
title: Accessibility in ##Platform_Name## Chart Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

Chart provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications.
WAI-ARIA Accessibility supports are achieved through the attributes like `aria-label`. It helps to provides information about elements
in a document for assistive technology.

**Aria-label:**   Attribute provides the text label with some default description for below elements in chart

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>Datalabel</td>
<td>Reads the Point y Value</td>
</tr>
<tr>
<td>Legend</td>
<td>'Click to show or hide the series'</td>
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
<td>Read’s the Point x :  Point y value</td>
</tr>
</table>

 You can change this default description, using description property available in `Datalabel`, `Legend`,
 `Axis Title` and `Chart` object. It helps the screen reader to read for assistive purpose.