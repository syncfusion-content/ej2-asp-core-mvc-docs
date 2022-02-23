---
title: " Accumulation Chart Annotation | ASP.NET MVC "

component: "Accumulation Chart"

description: "The annotations are used to mark the specific area of interest in the chart area with texts, shapes or images"
---

# Annotation

The annotations are used to mark the specific area of interest in the chart area with texts, shapes or images.

<!-- markdownlint-disable MD033 -->

By using the <code>content</code> option of annotation property, you can specify the Id of the element that needs to be displayed in the chart area.

{% aspTab template="chart/accumulation-charts/annotation/annotation", sourceFiles="annotation.cs" %}

{% endaspTab %}

## Region

The annotation can be placed with respect to either `Series` or `Chart`.

{% aspTab template="chart/accumulation-charts/annotation/region", sourceFiles="region.cs" %}

{% endaspTab %}

## Co-ordinate Units

Specifies the coordinate units of an annotation either in `Pixel` or `Point`.

{% aspTab template="chart/accumulation-charts/annotation/co-ordinate", sourceFiles="co-ordinate.cs" %}

{% endaspTab %}

## Alignment

The annotations can be moved vertically and horizontally from its default position by using `verticalAlignment`
or `horizontalAlignment` properties. The verticalAlignment property takes value as `Top`, `Bottom` or `Middle` and the
horizontalAlignment property takes value as `Near`, `Far` or `Center`.

{% aspTab template="chart/accumulation-charts/annotation/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}