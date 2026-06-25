---
layout: post
title: CDN Script References in ##Platform_Name## | Syncfusion
description: Learn here about referencing Syncfusion ##Platform_Name## control scripts and styles via CDN, including individual control CDN references.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# CDN Reference in ASP.NET Core Application

This section provides information about referencing Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core control scripts and stylesheets from CDN. Syncfusion<sup style="font-size:70%">&reg;</sup> hosts every control package on CDN, available both as a single combined file and as individual per-package files.

> For production applications, Syncfusion<sup style="font-size:70%">&reg;</sup> recommends [Static Web Assets](./script-reference) as the primary reference approach, since script versions are automatically tied to the installed NuGet package version. CDN is well suited for quick prototypes, demos, and applications that can tolerate a dependency on external network availability.

## CDN Reference for all controls

The combined package includes every Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core control in a single script and stylesheet file. This is the fastest way to get started.

| Resource | CDN Reference |
| --- | --- |
| Scripts (all controls) | `https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js` |
| Styles (all controls) | `https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{THEME-NAME}.css` |

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

N> Syncfusion<sup style="font-size:70%">&reg;</sup> does not recommend the combined CDN for production applications. The combined package includes all controls, which increases page load time and memory usage. Use individual control CDN references for production.

## Individual control CDN Reference

Individual control CDN references load only the scripts for the controls your application uses, reducing payload and improving load times. When using individual CDN references, you do not need to manage dependency order — each package CDN file is self-contained and bundles its own dependencies.

The CDN URL pattern for individual packages is:

| Resource | CDN Reference |
| --- | --- |
| Scripts | `https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/dist/global/{PACKAGE-NAME}.min.js` |
| Styles | `https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/styles/{THEME-NAME}.css` |

The following table lists the CDN script reference for each Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core control group.

<table>
<tr>
<th>Controls</th>
<th>CDN Script Reference</th>
</tr>
<tr>
<td>AccumulationChart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Accordion</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>AppBar</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>AI AssistView, Chat UI, Inline AI Assist</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-interactive-chat/dist/global/ej2-interactive-chat.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Avatar, Card, Dashboard Layout, Splitter, Timeline</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Barcode Generator, DataMatrix, QR Code</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-barcode-generator/dist/global/ej2-barcode-generator.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Block Editor</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-blockeditor/dist/global/ej2-blockeditor.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Breadcrumb, Context Menu, Menu</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Bullet Chart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Button, CheckBox, Chips, FloatingActionButton, RadioButton, SpeedDial, Switch</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Calendar</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Carousel, Sidebar</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Chart, AccumulationChart, Smith Chart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>3D Chart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-chart3d/dist/global/ej2-chart3d.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>3D Circular Chart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-circularchart3d/dist/global/ej2-circularchart3d.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Circular Gauge</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-circulargauge/dist/global/ej2-circulargauge.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Color Picker</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>DatePicker</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>DateRangePicker</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>DateTimePicker, TimePicker</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Diagram</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-diagrams/dist/global/ej2-diagrams.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Dialog</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Document Editor, Document Editor Container</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-office-chart/dist/global/ej2-office-chart.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-documenteditor/dist/global/ej2-documenteditor.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>AutoComplete, ComboBox, DropDownList, MultiSelect</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>DropDownTree</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>DropDownButton, ProgressButton, SplitButton</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>File Manager</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Gantt</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treegrid/dist/global/ej2-treegrid.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/dist/global/ej2-richtexteditor.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-gantt/dist/global/ej2-gantt.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Grid</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>HeatMap, ProgressBar</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-heatmap/dist/global/ej2-heatmap.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Image Editor</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-image-editor/dist/global/ej2-image-editor.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>In-place Editor</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inplace-editor/dist/global/ej2-inplace-editor.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Kanban</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-kanban/dist/global/ej2-kanban.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Linear Gauge</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lineargauge/dist/global/ej2-lineargauge.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>ListBox, ListView</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Maps</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-maps/dist/global/ej2-maps.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Message, Skeleton, Toast</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/dist/global/ej2-notifications.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>MultiColumn ComboBox</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-multicolumn-combobox/dist/global/ej2-multicolumn-combobox.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>PDF Viewer</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-notifications/dist/global/ej2-notifications.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-drawings/dist/global/ej2-drawings.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inplace-editor/dist/global/ej2-inplace-editor.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdfviewer/dist/global/ej2-pdfviewer.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Pivot Table</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pivotview/dist/global/ej2-pivotview.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Query Builder</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-querybuilder/dist/global/ej2-querybuilder.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Range Navigator</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Range Slider</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Ribbon</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-ribbon/dist/global/ej2-ribbon.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Rich Text Editor</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-filemanager/dist/global/ej2-filemanager.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/dist/global/ej2-richtexteditor.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Sankey</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-sankey/dist/global/ej2-sankey.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Schedule</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-schedule/dist/global/ej2-schedule.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Signature, TextBox, Masked TextBox, NumericTextBox, TextArea, OTP Input, Rating, SpeechToText, Uploader</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Sparkline, Bullet Chart, Smith Chart, Range Navigator, HeatMap, TreeMap</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Spreadsheet</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-layouts/dist/global/ej2-layouts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treegrid/dist/global/ej2-treegrid.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-richtexteditor/dist/global/ej2-richtexteditor.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-ribbon/dist/global/ej2-ribbon.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-spreadsheet/dist/global/ej2-spreadsheet.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Stepper</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Stock Chart</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-charts/dist/global/ej2-charts.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Tabs, Toolbar</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Tooltip</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>Tree Grid</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-dropdowns/dist/global/ej2-dropdowns.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-excel-export/dist/global/ej2-excel-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-file-utils/dist/global/ej2-file-utils.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-compression/dist/global/ej2-compression.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-splitbuttons/dist/global/ej2-splitbuttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-grids/dist/global/ej2-grids.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treegrid/dist/global/ej2-treegrid.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>TreeMap</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-data/dist/global/ej2-data.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-pdf-export/dist/global/ej2-pdf-export.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-svg-base/dist/global/ej2-svg-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-treemap/dist/global/ej2-treemap.min.js"></script>
{% endhighlight %}

</td>
</tr>
<tr>
<td>TreeView</td>
<td>

{% highlight cshtml %}
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-inputs/dist/global/ej2-inputs.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
<script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-navigations/dist/global/ej2-navigations.min.js"></script>
{% endhighlight %}

</td>
</tr>
</table>

## CDN Fallback

If your application loads scripts from CDN, a CDN outage will break the page. To protect against this, configure fallback scripts and stylesheets that are served locally. Refer to the [CDN Fallback](./cdn-fallback) documentation for step-by-step setup using ASP.NET Core link and script tag helpers.

## Latest CDN (unversioned)

Syncfusion<sup style="font-size:70%">&reg;</sup> also provides unversioned CDN URLs that always serve the latest release:

| Resource | CDN Reference |
| --- | --- |
| Scripts (all controls) | `https://cdn.syncfusion.com/ej2/dist/ej2.min.js` |
| Styles (all controls) | `https://cdn.syncfusion.com/ej2/{THEME-NAME}.css` |

W> The unversioned CDN links are deprecated from 2022 Vol1 - 20.1 onwards. They remain available with 19.4 version scripts only to avoid breaking existing sites. Do not use these in new applications.

## See also

* [Script Reference — Static Web Assets](./script-reference)
* [CDN Fallback](./cdn-fallback)
* [Custom Resource Generator](./custom-resource-generator)
