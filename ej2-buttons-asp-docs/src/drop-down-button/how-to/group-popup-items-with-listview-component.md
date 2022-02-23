---
title: "Group popup items with ListView component"
component: "DropDownButton"
description: "DropDownButton how to section, hide drop down arrow, group popup items using list view component, dialog open on popup item click."
---

# Group popup items with ListView component

Header in popup items is possible in DropdownButton by templating entire popup with ListView.
Create ListView with id `#listview` and provide it as a
[`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) for DropDownButton.

In the following example, ListView element is given as `target` to DropDownButton and header
can be achieved by [`groupBy`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Lists.ListViewFieldSettings.html#Syncfusion_EJ2_Lists_ListViewFieldSettings_GroupBy) property.

{% aspTab template="dropdownbutton/listview", sourceFiles="listview.cs" %}

{% endaspTab %}