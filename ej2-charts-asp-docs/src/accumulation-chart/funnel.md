---
title: "Funnel | ASP.NET MVC "

component: "Accumulation Chart"

description: "The funnel chart displays series value as progressively decreasing amount to hundred percent in total"
---

# Funnel Chart

To render a funnel series, use the series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Type)
as `Funnel`.

{% aspTab template="chart/accumulation-charts/funnel/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Size

The size of the funnel chart can be customized by using the  `width` and `height` properties.

{% aspTab template="chart/accumulation-charts/funnel/size", sourceFiles="size.cs" %}

{% endaspTab %}

## Neck Size

The funnel's neck size can be customized by using the `neckWidth` and `neckHeight` properties.

{% aspTab template="chart/accumulation-charts/funnel/neck-size", sourceFiles="neck-size.cs" %}

{% endaspTab %}

## Gap Between the Segments

Funnel chart provides options to customize the space between the segments by using the `gapRatio` property of the
series. It ranges from 0 to 1.

{% aspTab template="chart/accumulation-charts/funnel/gap", sourceFiles="gap.cs" %}

{% endaspTab %}

## Explode

Points can be exploded on mouse click by setting the `explode` property to true. You can also explode the point
on load using `explodeIndex`. Explode distance can be set by using `explodeOffset` property.

{% aspTab template="chart/accumulation-charts/funnel/explode", sourceFiles="explode.cs" %}

{% endaspTab %}

## Smart Data Label

It provides the data label smart arrangement of the funnel and pyramid series. The overlap data label will be placed on left side of the funnel/pyramid series.

{% aspTab template="chart/accumulation-charts/funnel/data-label", sourceFiles="data-label.cs" %}

{% endaspTab %}

## Customization

Individual points can be customized using the `pointRender` event.

{% aspTab template="chart/accumulation-charts/funnel/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## See Also

* [Data label](./data-label/)
* [Grouping](./grouping/)
