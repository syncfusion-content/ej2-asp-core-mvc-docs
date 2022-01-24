---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Layout of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Layout
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layout

Determine the visual representation of nodes belonging to all the TreeMap levels using the `layoutType` property.

## Types of layout

The available layout types are,

* Squarified
* SliceAndDiceVertical
* SliceAndDiceHorizontal
* SliceAndDiceAuto

### Squarified

The `Squarified` layout displays the nested rectangles based on aspect ratio in the TreeMap. The rectangles will be split based on the height and width of the parent. The default rendering type of layout is `Squarified`.

{% aspTab template="treemap/layout/squarified", sourceFiles="squarified.cs" %}

{% endaspTab %}

![TreeMap with squarified layout](images/Layout/Squarified.png)

### SliceAndDiceVertical

The `SliceAndDiceVertical` layout creates rectangles with high aspect ratio and displays items in a vertically sorted order.

{% aspTab template="treemap/layout/slice_vertical", sourceFiles="slice_vertical.cs" %}

{% endaspTab %}

![TreeMap with slice and dice vertical layout](images/Layout/SliceAndDiceVertical.png)

### SliceAndDiceHorizontal

The `SliceAndDiceHorizontal` layout creates rectangles with high aspect ratio and displays items in a horizontally sorted order.

{% aspTab template="treemap/layout/slice_horizontal", sourceFiles="slice_horizontal.cs" %}

{% endaspTab %}

![TreeMap with slice and dice horizontal](images/Layout/SliceandDiceHorizontal.png)

### SliceAndDiceAuto

The `SliceAndDiceAuto` layout creates rectangles with high aspect ratio and display items sorted both horizontally and vertically.

{% aspTab template="treemap/layout/slice_auto", sourceFiles="slice_auto.cs" %}

{% endaspTab %}

![TreeMap with slice and dice auto layout](images/Layout/SliceAndDiceAuto.png)

## Right-to-left rendering

The TreeMap control supports right-to-left rendering for all its elements such as nodes, tooltip, data labels, and legends.

## Legend with Rtl support

If you set the `enableRtl` property to true, then the legend icon will be rendered on the right and the legend text will be rendered on the left of the legend icon.

{% aspTab template="treemap/layout/legend-rtl", sourceFiles="legend-rtl.cs" %}

{% endaspTab %}

![TreeMap with slice and dice auto layout](images/Layout/LegendRTL.png)

## Tooltip with Rtl support

If the `enableRtl` property is set to true, the tooltip data will be rendered in reverse direction.

The following example shows the format of the tooltip.

{% aspTab template="treemap/layout/tooltip-rtl", sourceFiles="tooltip-rtl.cs" %}

{% endaspTab %}

![TreeMap with tooltip RTL](images/Layout/TooltipRtl.png)

## Treemap Item Rendering Direction

The direction of TreeMap item is `TopLeftBottomRight` by default and customize the rendering direction of the TreeMap item by setting the `RenderDirection` property.

The TreeMap can be rendered in the following directions:

* TopLeftBottomRight
* TopRightBottomLeft
* BottomRightTopLeft
* BottomLeftTopRight

The following example demonstrate how to render the treemap in the RTL direction with `TopLeftBottomRight`.

{% aspTab template="treemap/layout/render-direction-one", sourceFiles="render-direction-one.cs" %}

{% endaspTab %}

![TreeMap with custom rendering direction](images/Layout/TopLeftBottomRight.png)

The following example demonstrate how to render the treemap in the RTL direction with `TopRightBottomLeft`.

{% aspTab template="treemap/layout/render-direction-two", sourceFiles="render-direction-two.cs" %}

{% endaspTab %}

![TreeMap custom rendering direction](images/Layout/TopRightBottomLeft.png)

The following example demonstrate how to render the treemap in the RTL direction with `BottomRightTopLeft`.

{% aspTab template="treemap/layout/render-direction-three", sourceFiles="render-direction-three.cs" %}

{% endaspTab %}

![TreeMap custom rendering direction](images/Layout/BottomRightTopLeft.png)

The following example demonstrate how to render the treemap in the RTL direction with `BottomLeftTopRight`.

{% aspTab template="treemap/layout/render-direction-four", sourceFiles="render-direction-four.cs" %}

{% endaspTab %}

![TreeMap custom rendering direction](images/Layout/BottomLeftTopRight.png)