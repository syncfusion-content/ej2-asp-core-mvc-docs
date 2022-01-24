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

Legend provides information about the series rendered in the chart.

## Enable Legend

You can use legend for the chart by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Visible)
property to true in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html) object.

{% aspTab template="chart/getting-started/legend", sourceFiles="legend.cs" %}

{% endaspTab %}

## Position and Alignment

By using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Position) property, you can position the legend
at left, right, top or bottom of the chart. The legend is positioned at the bottom of the chart, by default.

{% aspTab template="chart/axis/legend/default", sourceFiles="default.cs" %}

{% endaspTab %}

Custom position helps you to position the legend anywhere in the chart using x, y coordinates.

{% aspTab template="chart/axis/legend/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Legend Reverse

You can reverse the order of the legend items by using the [`Reverse`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Reverse) property. By default, legend for the first series in the collection will be placed first.

{% aspTab template="chart/axis/legend/reverse", sourceFiles="reverse.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Legend Alignment**

<!-- markdownlint-disable MD036 -->

You can align the legend as `Center`, `Far` or `Near` to the chart using
[`Alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Alignment) property.

{% aspTab template="chart/axis/legend/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}

## Customization

To change the legend icon shape, you can use [`LegendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_LegendShape) property
in the [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html). By default legend icon shape is `SeriesType`.

{% aspTab template="chart/axis/legend/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

**Legend Size**

By default, legend takes 20% - 25% of the chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the
chart's width vertically, when placed on left or right position of the chart. You can change this default legend size by using the
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Height) property of the `LegendSettings`.

{% aspTab template="chart/axis/legend/size", sourceFiles="size.cs" %}

{% endaspTab %}

**Legend Item Size**

You can customize the size of the legend items by using the [`ShapeHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeHeight)
and [`ShapeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeWidth) property.

{% aspTab template="chart/axis/legend/item-size", sourceFiles="item-size.cs" %}

{% endaspTab %}

**Paging for Legend**

Paging will be enabled by default, when the legend items exceeds the legend bounds. You can view each legend
items by navigating between the pages using navigation buttons.

{% aspTab template="chart/axis/legend/paging", sourceFiles="paging.cs" %}

{% endaspTab %}

## Series Selection on Legend

By default, legend click enables you to collapse the series visibility.  On other hand, if you need to select
a series through legend click, disable the
[`ToggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ToggleVisibility).

{% aspTab template="chart/axis/legend/selection", sourceFiles="selection.cs" %}

{% endaspTab %}

## Enable Animation

You can customize the animation while clicking legend by setting enableAnimation as true or false using `EnableAnimation` property in chart.

{% aspTab template="chart/axis/legend/animation", sourceFiles="animation.cs" %}

{% endaspTab %}

## Collapsing Legend Item

By default, series name will be displayed as legend. To skip the legend for a particular series, you can give empty string to the series name.

{% aspTab template="chart/axis/legend/collapse", sourceFiles="collapse.cs" %}

{% endaspTab %}

## Legend Title

You can set title for legend using `Title` property in `LegendSettings`. You can also customize the `FontStyle`, `Size`, `FontWeight`,
`Color`, `TextAlignment`, `FontFamily`, `Opacity` and `TextOverflow` of legend title. `TitlePosition` is used to set the legend position in `Top`, `Left` and `Right` position. `MaximumTitleWidth` is used to set the width of the legend title. By default, it will be `100px`.

{% aspTab template="chart/axis/legend/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Arrow Page Navigation

By default, the page number will be enabled while legend paging. Now, you can disable that page number and also you can get left and right arrows for page navigation. You have to set `false` value to `EnablePages` to get this support.

{% aspTab template="chart/axis/legend/arrow-page", sourceFiles="arrow-page.cs" %}

{% endaspTab %}