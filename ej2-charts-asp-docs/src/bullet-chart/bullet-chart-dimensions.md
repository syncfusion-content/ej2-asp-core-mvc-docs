---
title: " Bullet Chart Appearance | ASP.NET CORE "

component: "Bullet Chart"

description: "We can set bullet-chart size manually by using width and height properties. We can set percentage or pixel size values to the bullet-chart."
---

# Bullet Chart Dimensions

## Size for Container

The size of the Bullet Chart is determined by the container size, and it can be changed inline or via CSS as following.

{% aspTab template="bullet-chart/bullet-chart-dimensions/container", sourceFiles="container.cs" %}

{% endaspTab %}

## Size for Bullet Chart

The `width` and `height` properties are used to adjust the size of the Bullet Chart.

### Pixel

Can set the size of the Bullet Chart in pixels as shown below.

{% aspTab template="bullet-chart/bullet-chart-dimensions/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

### Percentage

By setting a value in percentage, the Bullet Chart gets its dimension with respect to its container. For example, when the height is **50%**, the Bullet Chart renders to half of the container’s height.

{% aspTab template="bullet-chart/bullet-chart-dimensions/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}

>If the size is not specified, the Bullet Chart will be rendered with a height of **126px** and a width of the window.