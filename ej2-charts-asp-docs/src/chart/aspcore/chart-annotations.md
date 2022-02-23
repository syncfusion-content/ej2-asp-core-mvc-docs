---
title: " Chart Annotations | ASP.NET MVC "

component: "Chart"

description: "Chart annotations are used to mark the specific area of interest in the chart area with texts, shapes or images."
---

# Annotation

Annotations are used to mark the specific area of interest in the chart area with texts, shapes or images.

<!-- markdownlint-disable MD033 -->

You can add annotations to the chart by using the <code>annotations</code> option. By using the
[`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAnnotation.html#Syncfusion_EJ2_Charts_ChartAnnotation_Content) option of annotation object, you can specify
the id of the element that needs to be displayed in the chart area.

{% aspTab template="chart/series/column/annotation", sourceFiles="annotation.cs" %}

{% endaspTab %}

## Region

Annotations can be placed either with respect to `Series` or `Chart`. by default, it will placed with respect
to `Chart`.

{% aspTab template="chart/series/column/region", sourceFiles="region.cs" %}

{% endaspTab %}

## Co-ordinate Units

Specified the coordinates units of the annotation either `Pixel` or `Point`.

{% aspTab template="chart/series/column/co-ordinate", sourceFiles="co-ordinate.cs" %}

{% endaspTab %}

## Alignment

Annotation provides `verticalAlignment` and `horizontalAlignment`. The `verticalAlignment` can be customized
via `Top`, `Bottom` or `Middle` and the `horizontalAlignment` can be customized via `Near`, `Far` or `Center`.

{% aspTab template="chart/series/column/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}

## Adding y-axis sub title through on annotation

By setting text div in the `content` option of annotation object you can add sub title to chart y-axis. Specified the
`coordinate` value as `pixel` and customize x and y location of the text.

{% aspTab template="chart/series/column/axis-sub", sourceFiles="axis-sub.cs" %}

{% endaspTab %}