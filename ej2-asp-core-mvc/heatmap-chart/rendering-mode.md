---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Rendering Mode of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Rendering Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rendering mode

Heat map can be displayed using `Canvas` or `Scalable Vector Graphics (SVG)` rendering logic to improve the initial load performance and scalability. Heat map can also be automatically switched between `Canvas` and `SVG` modes based on dataset size. You can enable this mode by setting the [`renderingMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~RenderingMode.html) property to `Auto`.

> If the `Auto` mode is enabled in the heat map and there are more than 10,000 data points, then the heat map will be rendered in a `Canvas` mode; Otherwise, the heat map will be rendered in a `SVG` mode.

{% aspTab template="heatmap/rendering-mode", sourceFiles="rendering-mode.cs" %}

{% endaspTab %}