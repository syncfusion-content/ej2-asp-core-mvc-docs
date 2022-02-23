---
title: "ListView Checklist"
component: "ListView"
description: "Listview supports check-list (list-view with checkbox) feature to select single or multiple list items."
---

# Checklist

The ListView supports checkbox in default and group-lists which is used to select multiple items.
The checkbox can be enabled by the `showCheckBox` property.

The Checkbox will be useful in the scenario where we need to select multiple options. For Example,
In Shipping cart we can be able to select or unselect the desired items before checkout and also
it will be useful in selecting multiple items that belongs to same category using the group list.

{% aspTab template="listview/checklist/default", sourceFiles="ListController.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core ListView - CheckList Sample](./images/checklist.png)

## Checkbox Position

In ListView the checkbox can be positioned into either `Left` or `Right` side of the list-item text.
This can be achieved by `checkBoxPositon` property. By default, checkbox will be positioned to `Left` of list-item text.

{% aspTab template="listview/checklist/position", sourceFiles="ListController.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core ListView - CheckBox Position](./images/checkbox-position.png)