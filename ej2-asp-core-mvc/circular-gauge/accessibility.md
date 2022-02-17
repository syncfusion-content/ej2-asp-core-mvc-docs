---
layout: post
title: Accessibility in ##Platform_Name## Circular Gauge Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

Circular gauge provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications.
WAI-ARIA Accessibility supports are achieved through the attributes like `aria-label`. It helps to provides information about elements
in a document for assistive technology.

**Aria-label:**   Attribute provides the text label with some default description for below elements in gauge.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>Pointer</td>
<td>Reads the pointer value</td>
</tr>
<tr>
<td>Annotation</td>
<td>Read the annotation description</td>
</tr>
<tr>
<td>Gauge Title</td>
<td>Reads the gauge title</td>
</tr>
</table>

 You can change this default description,
 using description property available in [`Pointers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugePointer.html),
 [`Annotations`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html) and
 [`CircularGauge`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html) object.
 It helps the screen reader to read for assistive purpose.