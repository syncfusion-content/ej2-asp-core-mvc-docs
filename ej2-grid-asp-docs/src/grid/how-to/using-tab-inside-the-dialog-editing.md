---
title: "Using Tab Inside the Dialog Editing"
component: "Grid"
description: "Learn how to using Tab Inside the Dialog Editing."
---

# Using Tab Inside the Dialog Editing

You can use [`tab`](../../tab/index.html) component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog** and [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% aspTab template="grid/edit/tabediting", sourceFiles="*.cs" %}

{% endaspTab %}
