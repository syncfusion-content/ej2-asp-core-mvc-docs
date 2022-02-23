---
title: "Group items in Popup"
component: "SplitButton"
description: "SplitButton how to section, group popup items using list view component, dialog open on popup item click."
---

# Group items in Popup

Grouped items are possible in SplitButton by templating entire popup with ListView. Check ListView [`grouping`](../list-view/grouping#grouping) and create such items. Create ListView with id `listview` and provide element of the ListView as target of SplitButton to render it in popup area.

In this following example, ListView is created and its element is set as [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Target) for SplitButton.

{% aspTab template="split-button/listview/demo", sourceFiles="listview.cs" %}

{% endaspTab %}