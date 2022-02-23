---
title: "Legend"
component: "Heatmap"
description: "The legend section describes the legend types available in heatmap and other display options like legend placement, alignment and defining dimensions for legend in heatmap"
---

# Legend

The legend is used to provide the information about the heat map cell. You can enable the legend by setting the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Visible.html) property to true.

{% aspTab template="heatmap/legend/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Legend types

Heat map supports two legend types: Gradient and list type.

* Gradient - This is a continuous color legend with smooth color transition between palette color values.
* List - List is a fixed color legend. Each palette color information is shown separately in the list item.

You can change the legend type by using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the `paletteSettings` property.

{% aspTab template="heatmap/legend/types", sourceFiles="types.cs" %}

{% endaspTab %}

## Placement

You can place the legend at left, right, top, or bottom to the heat map layout by using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Position.html) property. The legend is positioned at the right to the heat map by default.

{% aspTab template="heatmap/legend/placement", sourceFiles="placement.cs" %}

{% endaspTab %}

## Alignment

You can align the legend as center, far, or near to the heat map using the [`alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Alignment.html) property.

{% aspTab template="heatmap/legend/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}

## Legend dimensions

You can change the legend dimensions with values in pixels or percentage by using the[`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Height.html) properties.

{% aspTab template="heatmap/legend/dimensions", sourceFiles="dimensions.cs" %}

{% endaspTab %}

## Paging for legend

Paging is available only for the list type legend in the heat map, and it can be enabled by default,when the legend items exceed the legend bounds. You can view each legend items by navigating between the pages using navigation buttons.

{% aspTab template="heatmap/legend/paging", sourceFiles="paging.cs" %}

{% endaspTab %}

## Smart Legend

Smart legend is another way of showing list type legend with responsiveness and readability, when the palette has more number of items. You can enable this smart legend by using the [`enableSmartLegend`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~EnableSmartLegend.html) property when the palette type is set to `Fixed`.

In smart legend, you can change the display type of legend labels by using the [`labelDisplayType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~LabelDisplayType.html) property.

The following are the legend label display types:
* All: Displays all labels in the legend.
* Edge: Displays the legend labels only at extreme ends.
* None: None of the labels are displayed. The tooltip will appear for this type of label display when hovering over the legend item.

{% aspTab template="heatmap/legend/smart-legend", sourceFiles="smart-legend.cs" %}

{% endaspTab %}

## Legend Selection

In the HeatMap, the legend selection is used to toggle the visibility of cell for viewing the specific range value. You can enable the legend selection using the [`toggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~ToggleVisibility.html) property.

{% aspTab template="heatmap/legend/legend-selection", sourceFiles="legend-selection.cs" %}

{% endaspTab %}

## Legend Title

The legend title displays a specific information about the legend. You can enable the legend title by setting the [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~title.html) property by providing the text and customizing the legend title text style using the [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~titleModel~textStyle.html) property.

{% aspTab template="heatmap/legend/legend-title", sourceFiles="legend-title.cs" %}

{% endaspTab %}