---
layout: post
title: Accessibility in ##Platform_Name## Linear Gauge Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in ASP.NET MVC Linear Gauge

<!-- markdownlint-disable MD013 -->
Linear Gauge provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications. The WAI-ARIA accessibility support is achieved through the attribute like `aria-label` in the SVG element. It helps to provide information about elements in a document for assistive technology. This attribute sets the text label with some default descriptions for the following elements in the Linear Gauge.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>Gauge title</td>
<td>Specifies the title of the Linear Gauge.</td>
</tr>
<tr>
<td>Pointer value</td>
<td>Specifies the value of the pointer in the Linear Gauge.</td>
</tr>
</table>

To change this default description, use the [`Description`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_Description) property available in [`LinearGaugePointer`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html#Syncfusion_EJ2_LinearGauge_LinearGaugePointer_Description) and [`LinearGauge`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGauge.html#Syncfusion_EJ2_LinearGauge_LinearGauge_Description). It helps the screen reader to read for an assistive purpose.