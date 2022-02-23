---
title: "Pie and Doughnut | ASP.NET MVC "

component: "Accumulation Chart"

description: "Pie and doughnut charts are used to presents the relationship of different parts of data and also known biggest data easily"
---

# Pie & Doughnut

## Pie Chart

To render a pie series, use the series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Type)
as `Pie`.

{% aspTab template="chart/accumulation-charts/pie_doughnut/pie", sourceFiles="pie.cs" %}

{% endaspTab %}

## Radius Customization

By default, radius of the pie series will be 80% of the size (minimum of chart width and height).
You can customize this using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Radius)
property of the series.

{% aspTab template="chart/accumulation-charts/pie_doughnut/radius", sourceFiles="radius.cs" %}

{% endaspTab %}

## Pie Center

The center position of the pie can be changed by Center X and Center Y. By default, center value of the pie series x and y is 50%. You can customize this using [`center`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_Center) property of the series.

{% aspTab template="chart/accumulation-charts/pie_doughnut/piecenter", sourceFiles="piecenter.cs" %}

{% endaspTab %}

## Various Radius Pie Chart

You can use radius mapping to render the slice with different [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Radius) pie and also use [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Border) , fill properties to customize the point. dataLabel is used to represent individual data and its value.

{% aspTab template="chart/accumulation-charts/pie_doughnut/various-radius", sourceFiles="various-radius.cs" %}

{% endaspTab %}

## Doughnut Chart

To achieve a doughnut in pie series, customize the [`innerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_InnerRadius)
property of the series. By setting value greater than 0%, a doughnut will appear.
The `innerRadius` property takes value from 0% to 100% of the pie radius.

{% aspTab template="chart/accumulation-charts/pie_doughnut/doughnut", sourceFiles="doughnut.cs" %}

{% endaspTab %}

## Start and End angles

You can customize the start and end angle of the pie series using the
[`startAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_StartAngle) and
[`endAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_EndAngle)
properties. The default value of  `startAngle` is 0 degree, and `endAngle` is 360 degrees. By customizing this,
you can achieve a semi pie series.

{% aspTab template="chart/accumulation-charts/pie_doughnut/start-angle", sourceFiles="start-angle.cs" %}

{% endaspTab %}

## Color & Text Mapping

The fill color and the text in the data source can be mapped to the chart using `pointColorMapping` in series and
`name` in datalabel respectively.

{% aspTab template="chart/accumulation-charts/pie_doughnut/map", sourceFiles="map.cs" %}

{% endaspTab %}

## Customization

Individual points can be customized using the `pointRender` event.

{% aspTab template="chart/accumulation-charts/pie_doughnut/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Hide pie or doughnut border

By default, the border will appear in the pie/doughnut chart while mouse hover on the chart. You can disable the the border by
setting `EnableBorderOnMouseMove` property is `false`.

{% aspTab template="chart/accumulation-charts/pie_doughnut/border", sourceFiles="border.cs" %}

{% endaspTab %}

## Color Palette

You can customize the color the of the point using the `palettes` property.

{% aspTab template="chart/accumulation-charts/pie_doughnut/palette", sourceFiles="palette.cs" %}

{% endaspTab %}

## See Also

* [Data label](./data-label/)
* [Grouping](./grouping/)