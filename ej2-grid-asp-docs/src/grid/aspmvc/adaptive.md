---
title: "Adaptive"
component: "Grid"
description: "Learn how to render the row elements, filter, sort, and edit dialogs adaptively in the Essential JS 2 DataGrid control."
---

# Adaptive View

The Grid user interface (UI) was redesigned to provide an optimal viewing experience and improve usability on small screens. This interface will render the filter, sort, and edit dialogs adaptively and have an option to render the grid row elements in the vertical direction.

## Render adaptive dialogs

When we enable the [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property, the grid will render the filter, sort, and edit dialogs in full screen for a better user experience. This behavior is demonstrated in the below demo.

{% aspTab template="grid/adaptive", sourceFiles="default.cs" %}

{% endaspTab %}

## Vertical row rendering

The grid will render the row elements in vertical order while setting the [`rowRenderingMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode) property value as **Vertical**.

{% aspTab template="grid/vertical-rendering", sourceFiles="default.cs" %}

{% endaspTab %}

> * [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property must be enabled for vertical row rendering.

### Supported features by vertical row rendering

The following features are only supported in vertical row rendering:

* Paging
* Sorting
* Filtering
* Selection
* Dialog Editing
* Aggregate
* Infinite scroll
* Toolbar
