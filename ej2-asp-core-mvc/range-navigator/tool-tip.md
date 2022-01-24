---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Tool Tip of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

<!-- markdownlint-disable MD036 -->

The tooltip for sliders are supported by the Range Selector. Sliders are used in the Range Selector to select data from a specific range. The tooltip displays the selected start and end values.

<!-- markdownlint-disable MD013 -->

## Enable Tooltip

The tooltip can be used to display information about the selected data and it is enabled by setting the `enable` property to **true**.

{% aspTab template="range-navigator/getting-started/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

![Enable tooltip](images/tooltip/tooltip.png)

## Customization

Tooltip can be customized using the following properties:

* enable - Customizes the visibility of the tooltip.
* fill - Customizes the background color of the tooltip.
* opacity - Customizes the opacity of the tooltip.
* textStyle - Customizes the font size, color, family, style, weight, alignment, and overflow of the tooltip.

{% aspTab template="range-navigator/tooltip/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

![Tooltip Customization](images/tooltip/tooltip-custom.png)

## Label Format

The `labelFormat` property in the tooltip is used to format and parse the date to all globalize formats.

{% aspTab template="range-navigator/tooltip/format", sourceFiles="format.cs" %}

{% endaspTab %}

![Label Format](images/tooltip/tooltip-format.png)

The following table shows the results of applying some common date and time formats to the `labelFormat` property.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format Property Value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>EEEE</td>
<td>Monday</td>
<td>The Date is displayed in day format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>yMd</td>
<td>04/10/2000</td>
<td>The Date is displayed in month/date/year format</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td> MMM </td>
<td>Apr</td>
<td>The Shorthand month for the date is displayed</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hm</td>
<td>12:00 AM</td>
<td>Time of the date value is displayed as label</td>
</tr>
<tr>
<td>new Date(2000, 03, 10)</td>
<td>hms</td>
<td>12:00:00 AM</td>
<td>The Label is displayed in hours:minutes:seconds format</td>
</tr>
</table>