---
title: " Chart Print and Export | ASP.NET MVC "

component: "Chart"

description: "The rendered chart can be printed or exported directly from the browser by calling the public method print and export."
---

# Get the data of clicked area in accumulation chart

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the chart data of clicked area.

To show the clicked area data from pie, follow the given steps:

**Step 1**:

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the `args.point.x` and `args.point.y` values.

{% aspTab template="chart/series/column/click-data", sourceFiles="click-data.cs" %}

{% endaspTab %}