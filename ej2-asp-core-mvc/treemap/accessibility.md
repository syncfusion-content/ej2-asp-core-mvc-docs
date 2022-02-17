---
layout: post
title: Accessibility in ##Platform_Name## Treemap Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The TreeMap control provides built-in compliance with [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications. WAI-ARIA accessibility supports are achieved using attributes such as `aria-label`. It helps to provide information about elements in a document for assistive technology.

This attribute provides the text label with some default description for the following elements in TreeMap.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>TreeMap container</td>
<td>Reads the TreeMap description</td>
</tr>
<tr>
<td>TreeMap Title</td>
<td>Reads the TreeMap title</td>
</tr>
<tr>
<td>TreeMap Subtitle</td>
<td>Reads the TreeMap subtitle</td>
</tr>
<tr>
<td>Legend Title</td>
<td>Reads the legend title</td>
</tr>
</table>

You can change this default description using the description property available in `Legend`, `TitleSettings`, `SubtitleSettings`, and `TreeMap` objects. It helps screen readers to read for assistive purpose.
