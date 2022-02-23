---
title: "Appearance"
component: "Heatmap"
description: "This section describes on how to customize the overall apperance of the Heatmap, like adding borders for heatmap cells or data points, adding margin and title for heatmap layout, mouse hover highligting options for the cells and formatting options for the data labels"
---

# Appearance

## Cell/customizations

You can customize the cell by using the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

## Border

Change the width, color, and radius of the heat map cells by using the [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~Border.html) property.

{% aspTab template="heatmap/appearance/border", sourceFiles="border.cs" %}

{% endaspTab %}

## Cell highlighting

Enable or disable the cell highlighting while hover over the heat map cells by using the  [`enableCellHighlighting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~EnableCellHighlighting.html) property.

>Note: The cell highlighting only works in a SVG rendering mode.

{% aspTab template="heatmap/appearance/cell-highlight", sourceFiles="cell-highlight.cs" %}

{% endaspTab %}

### Color gradient mode

You can set the minimum and maximum value colors based on row and column using the `ColorGradientMode` property.
The types of ColorGradientMode,

* Table: The minimum and maximum value colors calculated for overall data.
* Row: The minimum and maximum value colors calculated for each row of data.
* Column: The minimum and maximum value colors calculated for each column of data.

>Note: The default value of `ColorGradientMode` is Table.

{% aspTab template="heatmap/appearance/colormode", sourceFiles="colormode.cs" %}

{% endaspTab %}

## Margin

Set the margin for the heat map from its container by using the  [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Margin.html) property.

{% aspTab template="heatmap/appearance/margin", sourceFiles="margin.cs" %}

{% endaspTab %}

## Title

The title is used to provide a quick information about the data plotted in heat map. The [`text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTitle~Text.html) property is used to set the title for heat map. You can also customize text style of a title by using the [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTitle~TextStyle.html) property.

{% aspTab template="heatmap/appearance/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Data label

You can toggle the visibility of data labels by using the [`showLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~ShowLabel.html) property. By default, the data label will be visible.

{% aspTab template="heatmap/appearance/data-label", sourceFiles="data-label.cs" %}

{% endaspTab %}

## Text style

You can customize the font family, font size, and color of the data label by using the [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TextStyle.html) in the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) property.

{% aspTab template="heatmap/appearance/text-style", sourceFiles="text-style.cs" %}

{% endaspTab %}

## Format

You can change the format of the data label, such as currency, decimal, percent etc. by using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~Format.html) property.

{% aspTab template="heatmap/appearance/format", sourceFiles="format.cs" %}

{% endaspTab %}

## Customize the cell value

In the HeatMap, you can customize the cell value using the [`cellRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellRender.html) client-side event.

{% aspTab template="heatmap/appearance/cellRender", sourceFiles="cellRender.cs" %}

{% endaspTab %}

## See Also

* [To customize the appearance of tool tip](./tooltip/#customize-the-appearance-of-tooltip)
