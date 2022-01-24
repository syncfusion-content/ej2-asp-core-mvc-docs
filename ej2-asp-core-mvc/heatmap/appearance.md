---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Appearance of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
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