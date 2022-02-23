---
title: " Chart Working With Data | ASP.NET MVC "

component: "Chart"

description: "Chart can be rendered by using different types of data source. They are called local data, remote data and empty points. "
---

<!-- markdownlint-disable MD036 -->

# Working with Data

Chart can visualise data bound from local or remote data.

## Local Data

You can bind a simple JSON data to the chart using
[`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in series. Now map the fields in JSON to
[`xName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName) and [`yName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName)
properties.

{% aspTab template="chart/axis/working-data/local-data", sourceFiles="local-data.cs" %}

{% endaspTab %}

### Common Datasource

You can also bind a JSON data common to all series using
[`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in chart.

{% aspTab template="chart/axis/working-data/common-data", sourceFiles="common-data.cs" %}

{% endaspTab %}

## Remote Data

You can also bind remote data to the chart using `DataManager`. The DataManager requires minimal information
like webservice URL, adaptor and crossDomain to interact with service endpoint properly. Assign the instance
 of DataManager to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DataSource) property in series and map
 the fields of data to [`xName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_XName) and
[`yName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_YName) properties. You can also use the
[`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Query) property of the series to filter the data.

{% aspTab template="chart/axis/working-data/remote-data", sourceFiles="remote-data.cs" %}

{% endaspTab %}

## Empty points

The Data points that uses the `null` or `undefined` as value are considered as empty points.
Empty data points are ignored and not plotted in the Chart.
When the data is provided by using the points property,
By using `emptyPointSettings` property in series, you can customize the empty point. Default `mode` of the empty point is `Gap`.

{% aspTab template="chart/axis/working-data/empty-points", sourceFiles="empty-points.cs" %}

{% endaspTab %}

## Lazy loading

Lazy loading allows you to load data for chart on demand. Chart will fire the scrollEnd event, in that we can
get the minimum and maximum range of the axis, based on this, we can upload the data to chart.

{% aspTab template="chart/axis/working-data/lazy-loading", sourceFiles="lazy-loading.cs" %}

{% endaspTab %}
**Customizing empty point**

Specific color for empty point can be set by `fill` property in `emptyPointSettings`. Border for a empty point can be set by
`border` property.

{% aspTab template="chart/axis/working-data/custom-emptypoint", sourceFiles="custom-emptypoint.cs" %}

{% endaspTab %}