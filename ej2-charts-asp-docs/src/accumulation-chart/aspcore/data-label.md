---
title: " Accumulation Chart Data Label | ASP.NET MVC "

component: "Accumulation Chart"

description: "Data labels are names of the data points that are displayed on the x-axis of a chart and also used to highlight important data points"
---

# Data Label

Data label can be added to a chart series by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Visible)
option in the dataLabel property.

{% aspTab template="chart/accumulation-charts/datalabel/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Positioning

Accumulation chart provides support for placing the data label either `inside` or `outside` the chart.

{% aspTab template="chart/accumulation-charts/datalabel/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Smart Labels

Datalabels will be arranged smartly without overlapping with each other. You can enable or disable this feature using
the [`enableSmartLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_EnableSmartLabels)
property.

{% aspTab template="chart/accumulation-charts/datalabel/smartlabels", sourceFiles="smartlabels.cs" %}

{% endaspTab %}

## Data Label Template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text
`${point.x}` and `${point.y}` to display corresponding data points x & y value. Using
[`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Template)
property, you can set data label template in chart.

{% aspTab template="chart/accumulation-charts/datalabel/template", sourceFiles="template.cs" %}

{% endaspTab %}

## Connector Line

Connector line will be visible when the data label is placed `outside` the chart.
The connector line can be customized using the `type`, `color`, `width`, `length` and `dashArray` properties

{% aspTab template="chart/accumulation-charts/datalabel/connector", sourceFiles="connector.cs" %}

{% endaspTab %}

## Text Mapping

Text from the data source can be mapped to data label using `name` property.

{% aspTab template="chart/accumulation-charts/datalabel/map", sourceFiles="map.cs" %}

{% endaspTab %}

## Customization

Individual text can be customized using the `textRender` event.

{% aspTab template="chart/accumulation-charts/datalabel/custom", sourceFiles="custom.cs" %}

{% endaspTab %}