---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Click Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Click Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Get the data of clicked area in accumulation chart

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the chart data of clicked area.

To show the clicked area data from pie, follow the given steps:

**Step 1**:

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the `args.point.x` and `args.point.y` values.

{% aspTab template="chart/series/column/click-data", sourceFiles="click-data.cs" %}

{% endaspTab %}