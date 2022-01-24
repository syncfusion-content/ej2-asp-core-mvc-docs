---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Ticks of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Ticks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ticks

The Ticks in Slider supports you to easily identify the current value/values of the Slider. It contains `smallStep` and `largeStep`. The value of the major ticks alone will be displayed in the slider. In order to enable/disable the small ticks, use the `showSmallTicks` property.

{% aspTab template="slider/ticks", sourceFiles="ticks.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Ticks](./images/slider-ticks.png)

## Step

When the Slider is moved, it increases/decreases the value based on the step value. By default, the value is increased/decreased by 1. Use the `step` property to change the increment step value.

{% aspTab template="slider/step", sourceFiles="step.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Step](./images/slider-ticks.png)

## Min and Max

Enables the minimum/starting and maximum/ending value of the Slider, by using the `min` and `max` property. By default, the minimum value is 1 and maximum value is 100. In the following sample the slider is rendered with the min value as 100 and max value as 1000.

{% aspTab template="slider/min-max", sourceFiles="min-max.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Min and Max](./images/slider-min-max.png)
