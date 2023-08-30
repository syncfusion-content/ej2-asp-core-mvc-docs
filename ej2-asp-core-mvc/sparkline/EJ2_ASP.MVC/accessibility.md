---
layout: post
title: Accessibility in Syncfusion Sparkline Component
description: Learn here all about Accessibility in Syncfusion ASP MVC Sparkline component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in MVC sparkline component

Accessibility is achieved in the sparkline control through WAI-ARIA standard and keyboard navigation. The sparkline features can be effectively accessed through assistive technologies such as screen readers.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with AJAX, HTML, JavaScript, and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

The following ARIA attributes are used in the sparkline:

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<td>Maker</td>
<td>Reads the Location x :  Location y value</td>
</tr>
<tr>
<td>Series Points</td>
<td>Reads the Point x :  Point y value</td>
</tr>
</table>