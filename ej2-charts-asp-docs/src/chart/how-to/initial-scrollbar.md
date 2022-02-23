---
title: " Chart How To | ASP.NET MVC "

component: "Chart"

description: "How to section explains knowledge base samples and howto access different types properties and events of the chart."
---

<!-- markdownlint-disable MD036 -->

# To make the scrollbar visible in initial rendering of chart

By setting `zoomFactor` in primaryXAxis and `isZoomed` value as `true` in [`load`](../../api/chart/chartModel/#load) event and `enableScrollbar` value as `true` in `zoomSettings`, you can make the scrollbar visible in initial rendering of chart.

{% aspTab template="chart/series/column/initial-scroll", sourceFiles="initial-scroll.cs" %}

{% endaspTab %}