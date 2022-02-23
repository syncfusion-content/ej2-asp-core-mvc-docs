---
title: "Accumulation Chart Legend | ASP.NET MVC "

component: "Accumulation Chart"

description: "Accumulation chart legend is used to give additional information about the chart series."
---

# Legend

As like a chart, the legend is also available for accumulation charts, which gives information about the points.
By default, the legend will be placed on the right, if the width of the chart is high or will be placed on the bottom,
if the height of the chart is high. Other customization features regarding the legend element are same as the
[`chart legend`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html).
Here, the legend for a point can be collapsed by giving the empty string to the x value of the point.

{% aspTab template="chart/accumulation-charts/legend/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Position and Alignment

By using the position property, you can position the legend at the `left`, `right`, `top` or `bottom` of the chart.
You can also align the legend to `center`, `far` or `near` of the chart using the alignment property.

{% aspTab template="chart/accumulation-charts/legend/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Legend Shape

To change the legend icon shape, use the `legendShape` property in the `series`. By default, legend icon shape
is `seriesType`.

{% aspTab template="chart/accumulation-charts/legend/legend-shape", sourceFiles="legend-shape.cs" %}

{% endaspTab %}

## Legend Size

The legend size can be changed by using the `width` and `height` properties of the `legendSettings`.

{% aspTab template="chart/accumulation-charts/legend/size", sourceFiles="size.cs" %}

{% endaspTab %}

## Legend Item Size

You can customize the size of the legend items by using the `shapeHeight` and `shapeWidth` properties.

{% aspTab template="chart/accumulation-charts/legend/item-size", sourceFiles="item-size.cs" %}

{% endaspTab %}

## Paging for Legend

Paging will be enabled by default, when the legend items exceeds the legend bounds. You can view the each legend
item by navigating between the pages using the navigation buttons.

{% aspTab template="chart/accumulation-charts/legend/paging", sourceFiles="paging.cs" %}

{% endaspTab %}

## Enable Animation

You can customize the animation while clicking legend by setting enableAnimation as true or false using `enableAnimation` property in Accumulation Chart.

{% aspTab template="chart/accumulation-charts/legend/accumulation-animation",  sourceFiles="accumulation-animation.cs" %}

{% endaspTab %}

## Legend Title

You can set title for legend using `Title` property in `LegendSettings`. You can also customize the `FontStyle`, `Size`, `FontWeight`,
`Color`, `TextAlignment`, `FontFamily`, `Opacity` and `TextOverflow` of legend title. `TitlePosition` is used to set the legend position in `Top`, `Left` and `Right` position. `MaximumTitleWidth` is used to set the width of the legend title. By default, it will be `100px`.

{% aspTab template="chart/accumulation-charts/legend/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Arrow Page Navigation

By default, the page number will be enabled while legend paging. Now, you can disable that page number and also you can get left and right arrows for page navigation. You have to set `false` value to `EnablePages` to get this support.

{% aspTab template="chart/accumulation-charts/legend/arrow-page", sourceFiles="arrow-page.cs" %}

{% endaspTab %}