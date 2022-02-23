---
title: "Sparkline Dimensions"
component: "Sparkline"
description: "Explains how to customize dimensions of sparkline"
---

# Sparkline Dimensions

## Size for container

Sparkline can be rendered to its container size. You can set the size through inline or CSS as shown in the following code.

{% aspTab template="sparkline/sparkline-dimensions/size", sourceFiles="size.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Size for sparkline

<!-- markdownlint-disable MD036 -->

You can also set the size for sparkline directly using the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Height.html) properties.

**In pixel**

You can set the size for sparkline in pixel as demonstrated in the following code.

{% aspTab template="sparkline/sparkline-dimensions/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

**In percentage**

By setting values in percentage, sparkline gets its dimension with respect to its container. For example, when the height is set to ‘50%’, sparkline is rendered to half of its container height.

{% aspTab template="sparkline/sparkline-dimensions/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}