---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

## Orientation

The Bullet Chart can be rendered in different orientations such as **Horizontal** or **Vertical** via the `orientation` property. By default, the Bullet Chart is rendered in the **Horizontal** orientation.

{% aspTab template="bullet-chart/customization/orientation", sourceFiles="orientation.cs" %}

{% endaspTab %}

![Bullet Chart with Orientation](images/blazor-bullet-chart-orientation.png)

## Right-to-left (RTL)

The Bullet Chart supports the right-to-left rendering that can be enabled by setting the `enableRtl` property to **true**.

{% aspTab template="bullet-chart/customization/right-to-left", sourceFiles="right-to-left.cs" %}

{% endaspTab %}

![Right to Left Flow Direction in Bullet Chart](images/blazor-bullet-chart-right-to-left-direction.png)

## Animation

The actual and the target bar supports the linear animation via the `animation` setting. The speed and the delay are controlled using the `duration` and `delay` properties respectively.

{% aspTab template="bullet-chart/customization/animation", sourceFiles="animation.cs" %}

{% endaspTab %}

## Theme

The Bullet Chart supports different type of themes via the `theme` property.

{% aspTab template="bullet-chart/customization/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

![Applying Theme to Bullet Chart](images/blazor-bullet-chart-theme.png)