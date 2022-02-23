---
title: " Chart Print and Export | ASP.NET MVC "

component: "Chart"

description: "The rendered chart can be printed or exported directly from the browser by calling the public method print and export."
---

# To add chart dynamically

By using html button, you can add the chart dynamically when click the button.

To add the chart dynamically through button click, follow the given steps:

**Step 1**:

Initially create the html button.

Then create chart inside of button `onClick` function. Now click the button charts will render based on click count.

The following code sample demonstrates the output.

{% aspTab template="chart/series/column/dynamic-chart", sourceFiles="dynamic-chart.cs" %}

{% endaspTab %}