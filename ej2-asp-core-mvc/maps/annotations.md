---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Annotations of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Annotations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Annotations

<!-- markdownlint-disable MD013 -->

Annotations are used to mark the specific area of interest in the Maps with texts, shapes, or images. Any number of annotations can be added to the Maps component.

## Annotation

By using the `Content` property of `MapsAnnotation`, text content or id of an element or an HTML string can be specified to render a new HTML element in Maps.

{% aspTab template="maps/annotations", sourceFiles="annotation.cs" %}

{% endaspTab %}

![Annotation](./images/Annotation/Annotation.PNG)

## Annotation customization

### Changing the z-index

The stack order of an annotation element can be changed using the `ZIndex` property in the `MapsAnnotation`.

{% aspTab template="maps/annotations/annotaion-zindex", sourceFiles="annotaion-zindex.cs" %}

{% endaspTab %}

![Annotation zindex](./images/Annotation/Annotation-zindex.PNG)

### Positioning an annotation

Annotations can be placed anywhere in the Maps by specifying pixel or percentage values to the `X` and `Y` properties in the `MapsAnnotation`.

{% aspTab template="maps/annotations/annotation-position", sourceFiles="annotation-position.cs" %}

{% endaspTab %}

![Annotation zindex](./images/Annotation/Annotation-position.PNG)

### Alignment of an annotation

Annotations can be aligned using the `HorizontalAlignment` and `VerticalAlignment` properties in the `MapsAnnotation`. The possible values can be **Center**, **Far**, **Near** and **None**.

{% aspTab template="maps/annotations/annotation-alignment", sourceFiles="annotation-alignment.cs" %}

{% endaspTab %}

![Annotation zindex](./images/Annotation/Annotation-alignment.PNG)

## Multiple Annotation

Multiple annotations can be added to the Maps by adding Multiple `MapsAnnotation` in the `MapsAnnotations` and customization for the annotations can be done with the `MapsAnnotation`.

{% aspTab template="maps/annotations/multiple-annotation", sourceFiles="multiple-annotation.cs" %}

{% endaspTab %}

![Annotation zindex](./images/Annotation/Multiple-annotation.PNG)