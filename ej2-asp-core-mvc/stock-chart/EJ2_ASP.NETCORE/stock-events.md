---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Stock Events of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Stock Events
publishingplatform: ##Platform_Name##
documentation: ug
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
