---
title: "Dimensions"
component: "Heatmap"
description: "This section describes on how to define the size for the heatmap layout"
---

# Dimensions

## Size for container

Heat map can be rendered to its container size. You can set the size through inline or CSS.

```javascript
    <div id='container'>
        <div id='element' style="width:650px; height:350px;"></div>
    </div>
```

## Size for heat map

You can  set the size of heat map directly by using the  [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~Height.html) properties.

## In pixel

You can set the size for heat map in a pixel.

{% aspTab template="heatmap/dimensions/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

## In percentage

By setting value in percentage, heat map gets its dimension with respect to its container. For example, when the height is ‘50%’, heat map rendered to half of the container height.

{% aspTab template="heatmap/dimensions/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}