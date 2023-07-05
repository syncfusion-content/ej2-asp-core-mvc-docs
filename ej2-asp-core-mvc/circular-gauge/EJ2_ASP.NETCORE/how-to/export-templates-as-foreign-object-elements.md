---
layout: post
title: Print And Export in ##Platform_Name## Circular Gauge Component
description: Learn here all about Circular Gauge Export with Annotations in Syncfusion ##Platform_Name## Circular Gauge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Circular Gauge export with annotations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Gauge Export in ##Platform_Name## Circular gauge control

## How to export a Circular Gauge with Annotations using ForeignObject

The Circular Gauge component do not support exporting with annotations. This is because the annotations are intended to render any elements in the Circular Gauge component such as text, images, or custom elements. Since Circular Gauge is a SVG based control, the annotations can be rendered as **foreignObject** element. However, some web browsers do not support it.  As a workaround, we can achieve the same in the sample level.

The Circular Gauge with annotations can be exported in **PNG**, **JPEG**, and **PDF** formats. Similarly, the tooltip template can be exported as **foreignObject** elements. The example below demonstrates to export the Circular Gauge with annotations.