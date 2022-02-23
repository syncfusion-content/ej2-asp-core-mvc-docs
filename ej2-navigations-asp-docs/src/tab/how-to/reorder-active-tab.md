---
title: "Reorder Active Tab"
component: "Tab"
description: "This example demonstrates how to prevent the reordering the tab items when browser resize and popup item click of the Essential JS 2 Tab component."
---

# How to prevent reorder active tab while selecting inside popup

We can able to prevent the changing of the active tab item on resizing the browser when overflow mode is popup by using the `reorderActiveTab` property. By default, the active Tab should be reordered when we click the tab items from the popup. If we set `false` to `reorderActiveTab` property the active tab item from the popup will not be reordered and an active item is highlighted inside the popup. The following code example depicts to prevent the reorder active tab item inside the popup.

{% aspTab template="tab/reorderactivetab", sourceFiles="reorderactivetab.cs" %}

{% endaspTab %}
