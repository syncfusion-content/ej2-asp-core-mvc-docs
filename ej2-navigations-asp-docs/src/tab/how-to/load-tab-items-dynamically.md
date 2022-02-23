---
title: "Load Tab items dynamically"
component: "Tab"
description: "This example demonstrates how to dynamically load or add a tab item in the Essential JS 2 Tab component."
---

# Load Tab items dynamically

Tabs can be added dynamically by passing array of items and index value to the addTab method.

In the following demo, you can add the tab content by clicking the **+**. Enter the new Tab heading and  content details in the available text boxes, click 'Add Tab' button to pass the details as an array and here last index is calculated to append the new tab at the end.

{% aspTab template="tab/dynamic", sourceFiles="dynamic.cs" %}

{% endaspTab %}
