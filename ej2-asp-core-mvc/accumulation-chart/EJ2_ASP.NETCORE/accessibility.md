---
layout: post
title: Accessibility in Syncfusion Accumulation chart Component
description: Learn here all about Accessibility in Syncfusion ASP Core Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in Core accumulation chart component

Accessibility is achieved in the accumulation chart control through WAI-ARIA standard and keyboard navigation. The accumulation chart features can be effectively accessed through assistive technologies such as screen readers.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with AJAX, HTML, JavaScript, and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

The following ARIA attributes are used in the accumulation chart:

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<td>Title</td>
<td>Reads the accumulation chart's title</td>
</tr>
<tr>
<td>Legend</td>
<td>Reads the series point name</td>
</tr>
<tr>
<td>Series Points</td>
<td>Reads the Point x :  Point y value</td>
</tr>
</table>