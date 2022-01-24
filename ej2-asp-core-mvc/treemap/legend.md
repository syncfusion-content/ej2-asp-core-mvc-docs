---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Legend of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---

# Legend

Legend is used to provide valuable information for interpreting what the TreeMap displays. The legends can be represented in various colors, shapes or other identifiers based on the data.

## Position and alignment

Legend position is used to place legend in various positions. Based on the legend position, the legend item will be aligned. For example, if the position is top or bottom, the legend items are placed by rows. If the position is left or right, the legend items are placed by columns.

The following options are available to customize the legend position:

* Top
* Bottom
* Left
* Right
* Float

{% aspTab template="treemap/legend/position", sourceFiles="position.cs" %}

{% endaspTab %}

![TreeMap with legend on top](images/Legend/LegendPosition.png)

Legend Alignment is used to align the legend items in specific location. The following options are available to customize the legend alignment:

* Near
* Center
* Far

{% aspTab template="treemap/legend/align", sourceFiles="align.cs" %}

{% endaspTab %}

![TreeMap with legend alignment](images/Legend/LegendAlignment.png)

## Legend mode

The TreeMap control supports two different types of legend rendering modes such as `Default` and `Interactive`.

<!-- markdownlint-disable MD036 -->

### Default mode

In default mode, the legends have symbols with legend labels that are used to identify the items in the TreeMap.

{% aspTab template="treemap/legend/default", sourceFiles="default.cs" %}

{% endaspTab %}

![TreeMap with default legend mode](images/Legend/DefaultLegend.png)

<!-- markdownlint-disable MD036 -->

### Interactive mode

The legends can be made interactive with an arrow mark that indicates exact range color in the legend when the mouse hovers on the TreeMap item. Enable this option by setting the `mode` property in the `legendSettings` to **Interactive**.

{% aspTab template="treemap/legend/interactive", sourceFiles="interactive.cs" %}

{% endaspTab %}

![TreeMap with interactive legend](images/Legend/InteractiveLegend.png)

## Legend size

Customize the legend size by modifying the `height` and `width` properties in the `legendSettings`. It accepts values in both percentage and pixel.

{% aspTab template="treemap/legend/size", sourceFiles="size.cs" %}

{% endaspTab %}

![TreeMap with custom legend size](images/Legend/legendSize.png)

### Paging support

TreeMap support legend paging, if the legend items cannot be placed within the provided `height` and `width` of the legend.

{% aspTab template="treemap/legend/paging", sourceFiles="paging.cs" %}

{% endaspTab %}

![TreeMap legend with paging](images/Legend/Paging.png)

## Legend for items excluded from color mapping

Based on the mapping ranges in the data source, get the excluded ranges from the color mapping, and show the legend with the excluded range values that are bound to the specific legend.

{% aspTab template="treemap/legend/excludelegend", sourceFiles="excludelegend.cs" %}

{% endaspTab %}

![TreeMap legend for excluded items](images/Legend/ExcludeLegend.png)

## Hide desired legend items

To enable or disable the desired legend item for each color mapping, set the `showLegend` property to **true** in the `colorMapping`.

{% aspTab template="treemap/legend/hidelegend", sourceFiles="hidelegend.cs" %}

{% endaspTab %}

![Hide specific legend item in TreeMap](images/Legend/HideLegendDS.png)

## Hide legend items based data source value

To enable or disable the legend visibility for each item through the data source, bind the appropriate data source field name to `showLegendPath` property in the `legendSettings`.

{% aspTab template="treemap/legend/hidelegendbasedDS", sourceFiles="hidelegendbasedDS.cs" %}

{% endaspTab %}

![Hide TreeMap legend based on datasource](images/Legend/HideLegendDS.png)

## Bind legend item text from data source

To show the legend item text from the data source, bind the property name from data source to the `valuePath` property in the `legendSettings`.

{% aspTab template="treemap/legend/bindlegendtext", sourceFiles="bindlegendtext.cs" %}

{% endaspTab %}

![TreeMap legend text from datasource](images/Legend/legendTextDS.png)

## Hide duplicate legend items

To enable or disable the duplicate legend items, set the `removeDuplicateLegend` property to **true** in the `legendSettings`.

{% aspTab template="treemap/legend/duplicatelegend", sourceFiles="duplicatelegend.cs" %}

{% endaspTab %}

![Remove duplicate legend item](images/Legend/DuplicateLegend.png)

## Legend Responsiveness

Use a responsive legend that switches positions between the right and the bottom based on the available height and width. To enable the responsive legend, set the `position` property to **Auto** in the `legendSettings` and the legend position is changed based on the available height and width.

{% aspTab template="treemap/legend/legend-responsive", sourceFiles="legend-responsive.cs" %}

{% endaspTab %}

![TreeMap legend with responsive](images/Legend/LegendResponsive.png)