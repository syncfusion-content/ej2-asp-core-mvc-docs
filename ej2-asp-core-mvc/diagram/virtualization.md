---
layout: post
title: Virtualization in ##Platform_Name## Diagram Component
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization

## Virtualization in Diagram

Virtualization is the process of loading the diagramming objects available in the visible area of the Diagram control, that is, only the diagramming objects that lie within the ViewPort of the Scroll Viewer are loaded (remaining objects are loaded only when they come into view).

This feature gives an optimized performance while loading and dragging items to the Diagram that consists of many Nodes and Connectors.

The following code illustrates how to enable Virtualization mode in the diagram.

```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
//Enable virtualization in diagram
diagram.constraints = DiagramConstraints.Default | DiagramConstraints.Virtualization,
diagram.dataBind();

```
