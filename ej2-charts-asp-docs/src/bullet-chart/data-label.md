---
title: " Bullet Chart Data Labels | ASP.NET CORE"

component: "Bullet Chart"

description: "Bullet Chart can be rendered by using different types of data source. They are called local data, remote data. "
---

# Data Label

Data Labels are used to identify the value of actual bar in the Bullet Chart component. The Data Labels will be shown by specifying the `dataLabel` setting's `enable` property to **true**.

{% aspTab template="bullet-chart/data-label/data-label", sourceFiles="data-label.cs" %}

{% endaspTab %}

## Data Label Customization

Data Labels color, opacity, font size, font family, font weight, and font style can be customized using the `labelStyle`.

{% aspTab template="bullet-chart/data-label/data-label-custom", sourceFiles="data-label-custom.cs" %}

{% endaspTab %}

![Bullet Chart with Data Labels](images/blazor-bullet-chart-data-label.png)