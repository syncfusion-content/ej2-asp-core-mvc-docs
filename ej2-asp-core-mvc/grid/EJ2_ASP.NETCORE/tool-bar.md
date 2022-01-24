---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Tool Bar of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# ToolBar

The Grid provides ToolBar support to handle grid actions. The [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar)
property accepts either the collection of built-in toolbar items and **ItemModel** objects for custom toolbar items or HTML element ID for toolbar template.

## Built-in toolbar items

Built-in toolbar items execute standard actions of the grid, and it can be added by defining the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar)
as a collection of built-in items. It renders the button with icon and text.

The following table shows built-in toolbar items and its actions.

| Built-in Toolbar Items | Actions |
|------------------------|---------|
| Add | Adds a new record.|
| Edit | Edits the selected record.|
| Update | Updates the edited record.|
| Delete | Deletes the selected record.|
| Cancel | Cancels the edit state.|
| Search | Searches the records by the given key.|
| Print | Prints the grid.|
| ExcelExport | Exports the grid to Excel.|
| PdfExport | Exports the grid to PDF.|
| WordExport | Exports the grid to Word.|

{% aspTab template="grid/toolbar/toolbar", sourceFiles="toolbar.cs" %}

{% endaspTab %}

> * The [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added by defining the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) as a collection of
**ItemModel**.
Actions for this customized toolbar items are defined in the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

By default, Custom toolbar items are in position **Left**. You can change the position by using the **align** property. In the below sample, we have applied position **Right** for the **Collapse All** toolbar item.

{% aspTab template="grid/toolbar/custom-toolbar-item", sourceFiles="custom-toolbar-item.cs" %}

{% endaspTab %}

> * The [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) has options to define both built-in and custom toolbar items.
> * If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Built-in and custom items in toolbar

Grid have an option to use both built-in and custom toolbar items at same time.

In the below example, **Add**, **Edit**, **Delete**, **Update**, **Cancel** are built-in toolbar items and **Click** is custom toolbar item.

{% aspTab template="grid/toolbar/builtin-custom-items", sourceFiles="builtin-custom-items.cs" %}

{% endaspTab %}

## Enable/disable toolbar items

You can enable/disable toolbar items by using the **enableItems** method.

{% aspTab template="grid/toolbar/enable-disable", sourceFiles="enable-disable.cs" %}

{% endaspTab %}
