---
title: "Enable editing in single click"
component: "Grid"
description: "Learn how to enable single click editing in the Essential JS 2 DataGrid control."
---

# Enable editing in single click

## Normal Editing

You can make a row editable on a single click with **Normal** mode of editing in Grid, by using the **startEdit** and **endEdit** methods.

Bind the **mouseup** event for Grid and in the event handler call the **startEdit** and **endEdit**, based on the clicked target element.

{% aspTab template="grid/how-to/single-click-inline-edit", sourceFiles="single-click-normal-edit.cs" %}

{% endaspTab %}

### Open dropdown edit popup on single click

You can open the default dropdown edit popup with single click edit by focusing the dropdown element and calling the EJ2 dropdown list's **showPopup** method in the Grid's **ActionComplete** event. In this demo we have used a global flag variable in the **mouseup** event to ensure if the dropdown column is the clicked edit target.

{% aspTab template="grid/how-to/open-dropdown-popup", sourceFiles="open-dropdown-popup.cs" %}

{% endaspTab %}

## Batch Editing

You can make a cell editable on a single click with **Batch** mode of editing in Grid, by using the **editCell** method.

Bind the **mouseup** event for Grid and in the event handler call the **editCell** method, based on the clicked target element.

{% aspTab template="grid/how-to/single-click-batch-edit", sourceFiles="single-click-batch-edit.cs" %}

{% endaspTab %}
