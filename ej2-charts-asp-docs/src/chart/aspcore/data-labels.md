---
title: " Chart DataLabel | ASP.NET MVC "

component: "Chart"

description: "Data labels are names of the data points that are displayed on the x-axis of a chart and also used to highlight important data points"
---

# Data Labels

Data label can be added to a chart series by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker)
option in the dataLabel. By default, the labels will arrange smartly without overlapping.

{% aspTab template="chart/datalabels/datalabel", sourceFiles="datalabel.cs" %}

{% endaspTab %}

## Position

Using [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) property, you can place the label either on
`Top`, `Middle`,`Bottom` or `Outer` (outer is applicable for column and bar type series).

{% aspTab template="chart/datalabels/position", sourceFiles="position.cs" %}

{% endaspTab %}

>Note: The position `Outer` is applicable for column and bar type series.

## Datalabel template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text
`${point.x}` and `${point.y}` to display corresponding data points x & y value.
Using [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Template) property, you can set data label template
in chart.

{% aspTab template="chart/datalabels/template", sourceFiles="template.cs" %}

{% endaspTab %}

## Text Mapping

Text from the data source can be mapped using `name` property.

{% aspTab template="chart/datalabels/mapping", sourceFiles="mapping.cs" %}

{% endaspTab %}

## Margin

`margin` for data label can be applied to using `left`, `right`, `bottom` and `top` properties.

{% aspTab template="chart/datalabels/margin", sourceFiles="margin.cs" %}

{% endaspTab %}

## Customization

`stroke` and `border` of data label can be customized using `fill` and `border` properties. Rounded corners
can be customized using `rx` and `ry` properties.

{% aspTab template="chart/datalabels/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

>Note: `rx` and `ry` properties requires `border` values not to be null.

## Customizing Specific Point

You can also customize the specific marker and label using
[`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and
[`textRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event.
 `pointRender` event allows you to change the shape, color and border for a point, whereas the `textRender` event
allows you to change the text for the point.

{% aspTab template="chart/datalabels/custom-point", sourceFiles="custom-point.cs" %}

{% endaspTab %}