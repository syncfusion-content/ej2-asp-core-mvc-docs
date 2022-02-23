---
title: " Chart Appearance | ASP.NET MVC "

component: "Chart"

description: "We can set chart size manually by using width and height properties. We can set percentage or pixel size values to the chart."
---

# Chart Dimensions

## Size for Container

Chart can render to its container size. You can set the size via inline or CSS as demonstrated below.

{% aspTab template="chart/getting-started/size", sourceFiles="size.cs" %}

{% endaspTab %}

## Size for Chart

You can also set size for chart directly through [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Width) and
[`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Height) properties.

<!-- markdownlint-disable MD036 -->
**In Pixel**
<!-- markdownlint-disable MD036 -->

You can set the size of chart in pixel as demonstrated below.

{% aspTab template="chart/getting-started/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

**In Percentage**

By setting value in percentage, chart gets its dimension with respect to its container. For example,
when the height is ‘50%’, chart renders to half of the container height.

{% aspTab template="chart/getting-started/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}

> Note:  When you do not specify the size, it takes `450px` as the height and window size as its width.