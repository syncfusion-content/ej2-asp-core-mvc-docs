---
title: " RangeNavigator Series Types | ASP.NET MVC "

component: "RangeNavigator"

description: "Essential JS 2 Range navigator supports 3 types of series, to render the data."
---

# Series Types

To render the data, the Range Selector supports three types of series.

<!-- markdownlint-disable MD036 -->

## Line

<!-- markdownlint-disable MD036 -->

To render a line series, use series `type` as **Line**. By default, the line series is rendered in the Range Selector.

{% aspTab template="range-navigator/series-type/line", sourceFiles="line.cs" %}

{% endaspTab %}

![Line Chart](images/series-type/line.png)

## Area

To render an area series, use series `type` as **Area**.

{% aspTab template="range-navigator/series-type/area", sourceFiles="area.cs" %}

{% endaspTab %}

![Area Chart](images/series-type/area.png)

## StepLine

To render a Step line series, use series `type` as **Step Line**

{% aspTab template="range-navigator/series-type/step", sourceFiles="step.cs" %}

{% endaspTab %}

![Step Line Chart](images/series-type/stepline.png)