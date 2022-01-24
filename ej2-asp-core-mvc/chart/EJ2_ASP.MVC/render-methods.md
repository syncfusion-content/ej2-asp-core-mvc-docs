---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Render Methods of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Render Methods
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Rendering Types

Chart uses following two rendering methods.

* SVG
* Canvas

## SVG

SVG is used to render Chart by default for all browsers expect IE8 and old versions.

## Canvas

You can switch between SVG and Canvas rendering by using the `EnableCanvas` option. The canvas mode rendering is used in the following scenarios,

* Plotting large number of data points.
* Performing high frequency live updates.

**Limitations**

* Animation is not supported.