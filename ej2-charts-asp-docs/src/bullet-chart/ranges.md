---
title: " Bullet Chart Ranges | ASP.NET CORE "

component: "Bullet Chart"

description: "Bullet Chart scale can be rendered by using different types of end values. They are used to represnt the status of each data. "
---

# Ranges

Ranges represent the quality of a specific range such as **Good**, **Bad** and **Satisfactory** in the Bullet Chart scale. The ending point of a qualitative range is specified in the `end` property in `ranges`. The `minimum` value of a quantitative scale is considered the starting point of the first range or the previous range end point.

{% aspTab template="bullet-chart/ranges/ranges", sourceFiles="ranges.cs" %}

{% endaspTab %}

![Ranges in Bullet Chart](images/blazor-bullet-chart-range.png)

## Color Customization

Enhance the readability of ranges with color and opacity. It can be applied using the `color` and `opacity` properties in `ranges`.

{% aspTab template="bullet-chart/ranges/ranges-custom", sourceFiles="ranges-custom.cs" %}

{% endaspTab %}

![Customizing Ranges with Color in Bullet Chart](images/blazor-bullet-chart-range-customization.png)