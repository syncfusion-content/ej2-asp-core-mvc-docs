---
title: " Chart Print and Export | ASP.NET MVC "

component: "Chart"

description: "The rendered chart can be printed or exported directly from the browser by calling the public method print and export."
---

# To add dotted line using annotation

By using `annotation`, you can add dotted lines in the chart.

To add dotted lines in the chart, follow the given steps:

**Step 1**:

Initialize the custom elements by using the `annotation` property.

By setting `coordinateUnits` value as `point` in annotation object you can placed dotted lines
in the chart based on point x and y values.

{% aspTab template="chart/series/column/dotted-annotation", sourceFiles="dotted-annotation.cs" %}

{% endaspTab %}