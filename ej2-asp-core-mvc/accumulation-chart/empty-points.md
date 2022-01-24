---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Empty Points of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Empty Points
publishingplatform: ##Platform_Name##
documentation: ug
---


# Empty Points

The data points those uses the `null` or `undefined` as value are considered as empty points. The empty data points
are ignored and not plotted in the chart. You can customize those points, using the `emptyPointSettings` property in
series. The default mode of the empty point is `Gap`. Other supported modes are `Average` and `Zero`.

{% aspTab template="chart/accumulation-charts/empty-points/empty", sourceFiles="empty.cs" %}

{% endaspTab %}

## Customization

Specific color for an empty point can be set by using the `fill` property in `emptyPointSettings` and the
border for an empty point can be set by using the `border` property.

{% aspTab template="chart/accumulation-charts/empty-points/custom", sourceFiles="custom.cs" %}

{% endaspTab %}