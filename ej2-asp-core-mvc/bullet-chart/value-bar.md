---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Value Bar of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Value Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Actual Bar

To display the primary data or the current value of the data being measured known as the **Feature Measure** that should be encoded as a bar. This is called as the **Actual Bar** or the **Feature Bar** in the Bullet Chart, and to display the actual bar the `valueField` should be mapped to the appropriate field from the data source.

{% aspTab template="bullet-chart/value-bar/value-bar", sourceFiles="value-bar.cs" %}

{% endaspTab %}

![Actual Bar in Bullet Chart](images/blazor-bullet-chart-actual-bar.png)

## Types of Actual Bar

The shape of the actual bar can be customized using the `type` property of the Bullet Chart. The actual bar contains `Rect` and `Dot` shapes. By default, the actual bar shape is Rect.

{% aspTab template="bullet-chart/value-bar/types", sourceFiles="types.cs" %}

{% endaspTab %}

![Bullet Chart with Dot Actual Bar](images/blazor-bullet-chart-dot-actual-bar.png)

## Actual Bar Customization

### Border Customization

Using the `valueBorder` property of the bullet chart, you can customize the border `color` and `width` of the actual bar.

{% aspTab template="bullet-chart/value-bar/value-border", sourceFiles="value-border.cs" %}

{% endaspTab %}

### Fill color and height Customization

Customize the fill color and height of the actual bar using the `valueFill` and `valueHeight` properties of the bullet chart.

{% aspTab template="bullet-chart/value-bar/value-fill", sourceFiles="value-fill.cs" %}

{% endaspTab %}

![Customizing Actual Bar in Bullet Chart](images/blazor-bullet-chart-actual-bar-customization.png)