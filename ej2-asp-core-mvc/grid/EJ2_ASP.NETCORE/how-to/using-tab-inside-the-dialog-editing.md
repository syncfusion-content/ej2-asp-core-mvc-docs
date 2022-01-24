---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Using Tab Inside The Dialog Editing of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Using Tab Inside The Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Using Tab Inside the Dialog Editing

You can use **tab** component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) as **Dialog** and [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% aspTab template="grid/edit/tabediting", sourceFiles="*.cs" %}

{% endaspTab %}
