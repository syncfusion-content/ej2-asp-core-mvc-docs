---
title: " Chart Marker | ASP.NET MVC "

component: "Chart"

description: "Data markers are used to provide information about the data points in the series. You can add a shape to adorn each data point."
---

# Data Markers

Data markers are used to provide information about the data points in the series. You can add a shape to adorn
each data point.

<!-- markdownlint-disable MD036 -->

## Marker

<!-- markdownlint-disable MD036 -->

Markers can be added to the points by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker)
option of the marker property.

{% aspTab template="chart/data-marker/marker", sourceFiles="marker.cs" %}

{% endaspTab %}

## Shape

Markers can be assigned with different shapes such as Rectangle, Circle, Diamond etc using the `shape`property.

{% aspTab template="chart/data-marker/shape", sourceFiles="shape.cs" %}

{% endaspTab %}

>Note : To know more about the marker shape type refer the [`shape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_Shape).

## Images

Apart from the shapes, you can also add custom images to mark the data point using the
[`imageUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartMarkerSettings.html#Syncfusion_EJ2_Charts_ChartMarkerSettings_ImageUrl) property.

{% aspTab template="chart/data-marker/images", sourceFiles="images.cs" %}

{% endaspTab %}

## Customization

Marker's color and border can be customized using `fill` and `border` properties.

{% aspTab template="chart/data-marker/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Customizing Specific Point

You can also customize the specific marker and label using
[`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event.
`pointRender` event allows you to change the shape, color and border for a point.

{% aspTab template="chart/data-marker/custom-point", sourceFiles="custom-point.cs" %}

{% endaspTab %}