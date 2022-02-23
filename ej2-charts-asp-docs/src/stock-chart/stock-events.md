---
title: "Stock Events   | ASP.NET MVC "

component: "Stock Chart"

description: "Stock Chart can be rendered by using different types of data source. They are called local data, remote data and empty points."
---
<!-- markdownlint-disable MD036 -->

# Stock Events

Stock Events visualizes stockevents in stockchart. 'SplineSeries' is used to represent selected data value. You can customize the specific data value using `stockEvents` event.

{% aspTab template="stock-chart/stockchart-feature/stock-events", sourceFiles="stockEvents.cs" %}

{% endaspTab %}

**Stock Events for individual series**

By default, stock events will be showed for all series. Now, you can set the stock events for particular series using `SeriesIndexes` property.

{% aspTab template="stock-chart/stockchart-feature/stock-events-2", sourceFiles="stock-events-2.cs" %}

{% endaspTab %}
