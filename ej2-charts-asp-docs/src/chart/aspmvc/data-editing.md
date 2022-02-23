---
title: " Chart Data Editing | ASP.NET MVC "

component: "Chart"

description: "Chart have zooming and panning properties. Chart contains different  zoom modes, zoom toolbar items, scrollbar and auto interval zooming. "
---

# Data Editing

## Enable Data Editing

It provides drag and drop support to the rendered points. Now, we can change the location or value of the point based on its `y` value.  To enable the data editing, set the `Enable` property to true in the drag settings of the series. Also, we can set color using `Fill` property and set the data editing minimum and maximum range using `MinY` and `MaxY` properties.

{% aspTab template="chart/user-interaction/data-editing/default", sourceFiles="default.cs" %}

{% endaspTab %}