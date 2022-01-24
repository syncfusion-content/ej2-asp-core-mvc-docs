---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Chart Dimensions of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Chart Dimensions
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stock Chart Dimensions

## Size for Container

Chart can render to its container size. You can set the size via inline or CSS as demonstrated below.

{% aspTab template="stock-chart/getting-started/size", sourceFiles="size.cs" %}

{% endaspTab %}

## Size for Stock Chart

You can also set size for chart directly through [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Width) and
[`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Height)properties.

<!-- markdownlint-disable MD036 -->
**In Pixel**
<!-- markdownlint-disable MD036 -->

You can set the size of chart in pixel as demonstrated below.

{% aspTab template="stock-chart/getting-started/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

**In Percentage**

By setting value in percentage, chart gets its dimension with respect to its container. For example,
when the height is ‘50%’, chart renders to half of the container height.

{% aspTab template="stock-chart/getting-started/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}

> Note:  When you do not specify the size, it takes `450px` as the height and window size as its width.