---
title: "Style and Appearance"
component: "Pivot Table"
description: "CSS Customization allows user to hide axis for the pivot by overriding the styles."
---

# Style and Appearance

## Hiding Axis

The visibility of row, column, value and filter axis in Field List and Grouping Bar can be changed using custom CSS setting. To do so, please refer the code sample below:

{% aspTab template="pivot-table/css-axis", sourceFiles="axis.cs" %}

{% endaspTab %}

## Text Alignment

The alignment of text inside row headers, column headers, value cells and summary cells can be changed using custom CSS setting. To do so, please refer the code sample below:

{% aspTab template="pivot-table/css-align", sourceFiles="text-align.cs" %}

{% endaspTab %}

## Customize header, value and summary cell style

The elements in pivot table like header cell, value cell and summary cell style can be customized using built-in CSS names. To do so, please refer the code sample below:

{% aspTab template="pivot-table/css-pivot", sourceFiles="axis.cs" %}

{% endaspTab %}

![output](images/pivottable-css.png)