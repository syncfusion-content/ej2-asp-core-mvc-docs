---
title: "Populate Tab items and their content through ViewBag"
component: "Tab"
description: "This example demonstrates how to Populate Tab items and their content through ViewBag in the Essential JS 2 Tab component."
---

# Populate Tab items and their content through ViewBag

For the Tab control, the tab items can be rendered in the controller and can be returned as ViewBag to bind as items. You can also map the content to other contents using the mapping id in controller to return as ViewBag.
Please refer to the below sample, which takes [chart](../../chart), [grid](../../grid), [calender](../../calendar) as its content through viewBag content id mapped in view.

{% aspTab template="tab/viewbag", sourceFiles="viewbag.cs" %}

{% endaspTab %}

Output be like the below.

![content template](../images/viewbag.PNG)
