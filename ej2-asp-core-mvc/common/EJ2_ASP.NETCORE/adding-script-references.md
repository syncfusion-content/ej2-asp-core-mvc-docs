---
layout: post
title: Adding script references in ##Platform_Name## control
description: Learn here all about adding script references in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reference Scripts in ASP.NET Core Application

This section provides information about reference scripts from CDN and Custom resource generator (CRG) for Syncfusion ASP.NET Core controls.

## CDN Reference

Syncfusion hosts every ASP.NET Core control as a separate node package in CDN, from which scripts and style sheets of the individual package can be loaded. Syncfusion also hosts a single node package with all ASP.NET Core controls on it, from which scripts and style sheets of all controls can be loaded as single script and style file.

Here, the Syncfusion ASP.NET Core CDN URL for the both Individual ASP.NET Core control package and Complete ASP.NET Core controls package has been explained.

### CDN Reference for all controls

The primary goal of all the ASP.NET Core controls package is to help the novice to get started with Syncfusion ASP.NET Core control by referring the single line for script and styles without bothering about the dependency graph of the ASP.NET Core controls.

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{THEME-NAME}.css |

> Syncfusion will never recommend all controls CDN for real-time projects. Because, the size of this CDN impacts website/app loading time since this package includes all the Syncfusion ASP.NET Core controls.

Add the EJ2 CDN client-side resources to the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />

    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

### Individual control CDN Reference

The primary goal of individual control CDN is to optimize the loading time and memory of the website/app in the production stage. The order of individual control package loading should be in line with its dependency graph. The CDN of the Dependency Packages should be included manually before the intended individual control package CDN.

| controls | CDN Reference |
| --- | --- |
| Scripts reference for individual control| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/dist/global/{PACKAGE-NAME}.min.js |
| Styles reference for individual control | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/styles/{THEME-NAME}.css |

Add the CDN client-side resources in the `<head>` element of the `~/Pages/Shared/_Layout.cshtml` layout page.

For example, the scripts and styles for the ASP.NET Core Calendar control are listed below.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/styles/material.css" />

    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

The following table demonstrates the list of individual Syncfusion ASP.NET Core control CDN reference and its dependency packages.

<table>
<tr>
<th>Controls</th>
<th>Scripts</th>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/accordion/getting-started">Accordion</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/accumulation-chart/getting-started">Accumulation Chart, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/smithchart/getting-started">Smith Chart, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/chart/getting-started">Chart</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js">charts.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/avatar/getting-started">Avatar, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/card/getting-started">Card, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/dashboard-layout/getting-started">Dashboard Layout, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/splitter/getting-started">Splitter</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js">layouts.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/badge/getting-started-asp-core">Badge</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/dist/global/ej2-notifications.min.js">notifications.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/barcode/getting-started">Barcode</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-barcode-generator/dist/global/ej2-barcode-generator.min.js">barcode-generator.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/bullet-chart/getting-started">Bullet Chart,</a> <a href="https://ej2.syncfusion.com/aspnetcore/documentation/sparkline/getting-started">Sparkline</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js">charts.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/button/getting-started">Button, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/check-box/getting-started">CheckBox, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/chips/getting-started">Chips, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/radio-button/getting-started">Radio Button, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started">Switch</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/button-group/getting-started">ButtonGroup</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/calendar/getting-started">Calendar</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/carousel/getting-started">Carousel</a>, <a href="https://ej2.syncfusion.com/aspnetcore/documentation/sidebar/getting-started">Sidebar</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/circular-gauge/getting-started">Circular Gauge</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-circulargauge/dist/global/ej2-circulargauge.min.js">circulargauge.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/color-picker/getting-started">Color Picker</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/breadcrumb/getting-started">Breadcrumb, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/context-menu/getting-started">Context Menu, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/menu/getting-started">Menu</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/datepicker/getting-started">DatePicker</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/daterangepicker/getting-started">DateRangePicker</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/datetimepicker/getting-started">DateTimePicker</a>, <a href="https://ej2.syncfusion.com/aspnetcore/documentation/timepicker/getting-started">TimePicker</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/diagram/getting-started">Diagram</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-diagrams/dist/global/ej2-diagrams.min.js">diagrams.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/dialog/getting-started">Dialog</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started">Auto Complete, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started">DropDownList, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/multi-select/getting-started">MultiSelect, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/combo-box/getting-started">ComboBox</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-tree/getting-started">DropDownTree</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/getting-started">File Manager</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js">layouts.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js">grids.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js">filemanager.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core">Grid</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js">excel-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js">grids.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/heatmap/getting-started">HeatMap</a>, <a href="https://ej2.syncfusion.com/aspnetcore/documentation/progress-bar/getting-started">ProgressBar</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-heatmap/dist/global/ej2-heatmap.min.js">heatmap.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/getting-started">RichTextEditor</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js">filemanager.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/dist/global/ej2-richtexteditor.min.js">richtexteditor.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/signature/getting-started">Signature, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/textbox/getting-started">TextBox, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/maskedtextbox/getting-started">Masked TextBox, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/numerictextbox/getting-started">NumericTextBox</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-button/getting-started">DropDownButton, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/split-button/getting-started">SplitButton, </a><a href="https://ej2.syncfusion.com/aspnetcore/documentation/progress-button/getting-started">ProgressButton</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/tab/getting-started">Tabs</a>, <a href="https://ej2.syncfusion.com/aspnetcore/documentation/toolbar/getting-started">Toolbar</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/toast/getting-started">Toast</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/dist/global/ej2-notifications.min.js">notifications.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/treeview/getting-started">TreeView</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/tooltip/getting-started">ToolTip</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/getting-started-core">TreeGrid</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js">excel-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js">grids.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treegrid/dist/global/ej2-treegrid.min.js">treegrid.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/treemap/getting-started">TreeMap</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treemap/dist/global/ej2-treemap.min.js">treemap.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/uploader/getting-started">Uploader</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/kanban/getting-started">Kanban</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-kanban/dist/global/ej2-kanban.min.js">kanban.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/linear-gauge/getting-started">Linear Gauge</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lineargauge/dist/global/ej2-lineargauge.min.js">lineargauge.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/list-box/getting-started-core">ListBox</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/listview/getting-started">ListView</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/maps/getting-started">Maps</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-maps/dist/global/ej2-maps.min.js">maps.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/getting-started">Pivot Table</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js">grids.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js">excel-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pivotview/dist/global/ej2-pivotview.min.js">pivotview.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/query-builder/getting-started">QueryBuilder</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-querybuilder/dist/global/ej2-querybuilder.min.js">querybuilder.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/range-navigator/getting-started">Range Navigator</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-ej2-svg-base/dist/global/ej2-ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js">charts.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/range-slider/getting-started">Range Slider</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/in-place-editor/getting-started">In-place Editor</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inplace-editor/dist/global/ej2-inplace-editor.min.js">inplace-editor.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/schedule/getting-started">Schedule</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-schedule/dist/global/ej2-schedule.min.js">schedule.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/stock-chart/getting-started">Stock Chart</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js">charts.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/document-editor/getting-started-core">Document Editor</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js">file-utils.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js">compression.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js">svg-base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js">charts.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-office-chart/dist/global/ej2-office-chart.min.js">office-chart.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-documenteditor/dist/global/ej2-documenteditor.min.js">documenteditor.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/gantt/getting-started">Gantt</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js">layouts.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js">calendars.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js">excel-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js">filemanager.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js">pdf-export.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js">grids.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treegrid/dist/global/ej2-treegrid.min.js">treegrid.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/dist/global/ej2-richtexteditor.min.js">richtexteditor.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-gantt/dist/global/ej2-gantt.min.js">gantt.min.js</a></td>
</tr>
<tr>
<td><a href="https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started">PDF Viewer</a></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js">base.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js">data.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js">buttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js">inputs.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js">popups.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js">lists.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js">filemanager.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js">navigations.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js">dropdowns.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js">splitbuttons.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/dist/global/ej2-notifications.min.js">notifications.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-drawings/dist/global/ej2-drawings.min.js">drawings.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inplace-editor/dist/global/ej2-inplace-editor.min.js">inplace-editor.min.js</a></td>
</tr>
<tr>
<td></td>
<td><a href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdfviewer/dist/global/ej2-pdfviewer.min.js">pdfviewer.min.js</a></td>
</tr>
</table>

In addition to above, Syncfusion ASP.NET Core controls provides latest scripts and styles in CDN without versioning. You can use this in development environment if you want to always use the latest version of scripts and styles. It is not recommended to use this in production environment.

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{THEME-NAME}.css |

W> The un-versioned CDN links which always maintains latest version scripts are deprecated from 2022 Vol1 - 20.1 version. These links are available with 19.4 version scripts to avoid breaking in sites and apps that uses un-versioned links.

## Node Package Manager (NPM)

A package in Node.js consists of a set of files needed for a JavaScript module which can be included in any web application. NPM is the popular package manager for both public and private packages.

### Syncfusion NPM packages

Scripts and style sheets of Syncfusion ASP.NET Core controls can be included in an ASP.NET Core web application using NPM packages, since Syncfusion publishes its ASP.NET Core controls as the scoped package in NPM.

#### Installing NPM packages in ASP.NET Core Web Application

1.Open the Source Explorer and right click the application name. Then, select “**Add New Item**” menu item to open the “**Add New Item**” window. 

![Add New Item Window](images/add-new-item.png)

2.Select “**Web**” on the left side Tree View and select “**npm configuration File**” in “**Add New Item**” window which will include and configure “**package.json**” file in root folder of the ASP.NET Core web application. 

![Adding package.json](images/add-package-json.png)

3.Open the Source Explorer and right click on the application name. Then, select “**Open Folder in File Explorer**”. 

4.Open the Command Prompt for this location and install the required Syncfusion packages using “**npm install @syncfusion/{PACKAGE_NAME} --save**”

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install @syncfusion/ej2-calendars --save

{% endhighlight %}
{% endtabs %}

5.Installed packages with all its dependencies can be found under the  “**node_modules**” folder as shown in the following image.

![Installed Syncfusion Packages](images/installed-syncfusion-package.png)

#### From Installed Packages

Scripts and style sheets of Syncfusion ASP.NET Core controls from locally-installed packages can be included in an ASP.NET Core web application using the following two methods.

>Files in the **wwwroot** folder can be accessed only in client-side, hence Syncfusion scripts and style sheets should be copied from **node_modules** to **wwwroot**.

By using either one of the following methods, Client-Side Resource can be loaded in ASP.NET Core web application:

1. Copying scripts and styles using gulp
2. Generating scripts and styles using [CRG (Custom Resource Generator)](./custom-resource-generator)

#### Copying by Gulp

Install required Syncfusion ASP.NET Core control packages as mentioned in “[**Installing NPM Packages in ASP.NET Core Web Application**](#installing-npm-packages-in-aspnet-core-web-application)”. 

1.In addition to Syncfusion ASP.NET Core packages, install gulp and glob packages using below commands.

>Gulp Installation - **npm install gulp --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install gulp@latest --save

{% endhighlight %}
{% endtabs %}

>Glob Installation - **npm install glob --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install glob@latest --save

{% endhighlight %}
{% endtabs %}

2.To set up the server, open Dependencies -> Manage NuGet Packages -> Browse. Then, search and install "**Microsoft.AspNetCore.StaticFiles -V2.2.0**" and "**Microsoft.TypeScript.MSBuild -V3.8.3**" packages.

![Install NuGet Packages](images/install-nuGet-package.png)
     
Open up your "**Startup.cs**" file and edit your Configure function to looks like the below code snippet.

{% tabs %}
{% highlight c# tabtitle="Startup.cs" %}

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseDefaultFiles();
    app.UseStaticFiles();
}

{% endhighlight %}
{% endtabs %}

Restart Visual Studio for the red squiggly lines below "**UseDefaultFiles**" and "**UseStaticFiles**" to disappear.

3.Open the Source Explorer and right click on the application name. Then, select “**Add New Item**” menu item to open the “**Add New Item**” window. 

4.Select “**ASP.NET Core**” on the left side Tree View and select “**JavaScript File**” in the “**Add New Item**” window. It will include a js file in the root folder of the ASP.NET Core web application. Rename the js file as “**gulpfile.js**”.

![Add gulpjs file](images/add-gulpjs.png)

5.Copy the following code snippet and paste it in **gulpfile.js** for automatically copying the script and styles from “**node_modules**” to “**wwwroot**” while building the web application.

{% tabs %}
{% highlight c# tabtitle="gulpfile.js" %}

/// <binding BeforeBuild='copy-client-resource'/>
// nodejs requiring statement for importing and using the package in this js file
var gulp = require('gulp');
var glob = require('glob');
// gulp task for copying file form “node_modules” to “wwwroot” directory
gulp.task("copy-client-resource", function (done) {
    let packagePath = './node_modules/@syncfusion/';
    let destCommonPath = 'wwwroot/syncfusion'
    let installedPackages = glob.sync(`${packagePath}*`);
    for (let insPackage of installedPackages) {
        let packagename = insPackage.replace(packagePath, '');
        gulp.src(`${insPackage}/dist/global/**/*`)
            .pipe(gulp.dest(`${destCommonPath}/${packagename}/`));
        gulp.src(`${insPackage}/styles/**/*.css`)
            .pipe(gulp.dest(`${destCommonPath}/${packagename}/styles/`));
    }
    done();
});

{% endhighlight %}
{% endtabs %}

6.Build the ASP.NET Core web application and notice that a new folder named “**Syncfusion**” is created in “**wwwroot**” folder.

![Copied to wwwroot](images/copied-to-wwwroot.png)

7.Add the client-side resource in the `<head>` element of the `~/Views/Shared/_Layout.cshtml`. Here, scripts and styles of Syncfusion ASP.NET Core Calendar has been loaded for example.  

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="~/syncfusion/ej2-calendars/styles/calendar/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-base/styles/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-buttons/styles/button/material.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="~/syncfusion/ej2-base/ej2-base.min.js"></script>
    <script src="~/syncfusion/ej2-calendars/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Custom Resource Generator

The Syncfusion ASP.NET Core provides an option to generate a control's scripts using the [Custom Resource Generator](https://crg.syncfusion.com/) (CRG) tool for the ASP.NET Core Controls. To generate the control-wise scripts externally using CRG, refer [here](./custom-resource-generator).

## See also

* [CDN Fallback](./cdn-fallback)
* [Adding Nonce to Script tag in ASP.NET Core](./security-aspects#adding-nonce-to-script-tag-in-aspnet-core)
