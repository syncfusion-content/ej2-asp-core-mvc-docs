---
title: "Legend"
component: "Smith Chart"
description: "Legend support in smith chart"
---

<!-- markdownlint-disable MD036 -->

# Legend

Legend is a key used in smithchart, that contains symbol and descriptions. It provides valuable information for interpreting what the smithchart is displaying and can be represented in various colors, shapes or other identifiers based on the data. In simple words, we can define that legend is used to denote the series rendered in the smithchart.

## Position and Alignment

By default visibility of the legend is false. To enable the legend, kindly set visible as true in legendSettings. Default position for the legend is bottom. By using [`position`] property, you can change the position of the legend. You can either place the legend at bottom, top, right and left side of the smithchart. To use the legend in smithchart, you need to import and inject the SmithchartLegend from chart.

{% aspTab template="smithchart/legend/position", sourceFiles="position.cs" %}

{% endaspTab %}

Other than these positions, you can place the legend anywhere in the smithchart. To achieve this, you have to set position as custom in legendSettings and specify the x and y coordinates using the x and y properties in the location.

{% aspTab template="smithchart/legend/custom-position", sourceFiles="custom-position.cs" %}

{% endaspTab %}

**Legend Alignment**

Other than positioning the legend in the smithchart, you can customize its alignment also. By default, legend is aligned at center. Using the [`alignment`] property, you can align the legend in near and far locations of the smithchart.

{% aspTab template="smithchart/legend/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}

## Customization

**Legend Shape**

By default, legend is rendered in the circle shape and the color of the shape is as same as series color in the smithchart. Using the property [`shape`] in legend settings, you can change the icon shape of the legend as rectangle, triangle and so on.

{% aspTab template="smithchart/legend/custom-shape", sourceFiles="custom-shape.cs" %}

{% endaspTab %}

**Legend Size**

By default, legend takes 20% - 25% of the chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the width vertically, while placing on left or right position of the chart. You can change this default legend size by using the [`width`] and [`height`] property of the legendSettings.

{% aspTab template="smithchart/legend/legend-size", sourceFiles="legend-size.cs" %}

{% endaspTab %}

**Padding**

You can customize the space between two legend items and space between legend shape and text as per your requirement. For customizing the space between two legend items, you can use [`itemPadding`] property. To control space between legend shape and text, you can use [`shapePadding`] property.

{% aspTab template="smithchart/legend/padding", sourceFiles="padding.cs" %}

{% endaspTab %}

## Toggle Visibility

By default series name is displayed in the legend. You can collapse the visibility of the series by clicking the legend for the particular series. You can toggle the series visibility as true or false using the [`toggleVisibility`] property. By default it is true.

{% aspTab template="smithchart/legend/toggle", sourceFiles="toggle.cs" %}

{% endaspTab %}