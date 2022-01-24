---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Initial Scrollbar of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Initial Scrollbar
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# To make the scrollbar visible in initial rendering of chart

By setting `zoomFactor` in primaryXAxis and `isZoomed` value as `true` in [`load`](../../api/chart/chartModel/#load) event and `enableScrollbar` value as `true` in `zoomSettings`, you can make the scrollbar visible in initial rendering of chart.

{% aspTab template="chart/series/column/initial-scroll", sourceFiles="initial-scroll.cs" %}

{% endaspTab %}