---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grid Tick of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grid Tick
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grid and Tick Lines

## Grid line customization

The gridlines indicate axis divisions by drawing the chart plot. Gridlines include helpful cues to the user, particularly for large or complicated charts. The `width`, `color`, and `dashArray` of the major gridlines can be customized by using the `majorGridLines` setting.

{% aspTab template="range-navigator/grid/grid", sourceFiles="grid.cs" %}

{% endaspTab %}

![Gridline customization](images/grid-tick/grid.png)

## Tick line customization

Ticklines are the small lines which is drawn on the axis line representing the axis labels. Ticklines will be drawn outside the axis by default. The `width`, `color`, and `dashArray` of the major ticklines can be customized by using the `majorTickLines` setting.

{% aspTab template="range-navigator/grid/tick", sourceFiles="tick.cs" %}

{% endaspTab %}

![Tickline customization](images/grid-tick/tick.png)