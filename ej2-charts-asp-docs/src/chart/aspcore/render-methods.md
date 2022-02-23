---
title: "Chart Rendering | ASP.NET MVC"

component: "Chart"

description: "It describes the various rendering methods of the asp.net mvc chart"
---
<!-- markdownlint-disable MD036 -->

# Rendering Types

Chart uses following two rendering methods.

* SVG
* Canvas

## SVG

SVG is used to render Chart by default for all browsers expect IE8 and old versions.

## Canvas

You can switch between SVG and Canvas rendering by using the `enableCanvas` option. The canvas mode rendering is used in the following scenarios,

* Plotting large number of data points.
* Performing high frequency live updates.

**Limitations**

* Animation is not supported.