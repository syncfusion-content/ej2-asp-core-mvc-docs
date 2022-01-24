---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Scrolling of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling

 The scrollbar will be displayed in the grid when content exceeds the element [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Width_System_Double_) or [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_). The vertical and horizontal scrollbars will be displayed based on the following criteria:

* The vertical scrollbar appears when the total height of rows present in the grid exceeds its element height.
* The horizontal scrollbar appears when the sum of columns width exceeds the grid element width.
* The [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Width_System_Double_) are used to set the grid height and width, respectively.

> The default value for [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Width_System_Double_) is `auto`.

## Set width and height

To specify the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Width_System_Double_) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_) of the scroller in the pixel, set the pixel value to a number.

{% aspTab template="grid/scrolling/width-height", sourceFiles="width-height.cs" %}

{% endaspTab %}

## Responsive with parent container

Specify the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Width_System_Double_) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_) as `100%` to make the grid element fill its parent container.
Setting the [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Height_System_Double_) to `100%` requires the grid parent element to have explicit height.

{% aspTab template="grid/scrolling/responsive-parent", sourceFiles="responsive-parent.cs" %}

{% endaspTab %}

## Scroll to selected row

You can scroll the grid content to the selected row position by using the `RowSelected` event.

{% aspTab template="grid/scrolling/scroll-selected-row", sourceFiles="scroll-selected-row.cs" %}

{% endaspTab %}

## Frozen rows and columns

Frozen rows and columns provides an option to make rows and columns always visible in the top and left side of the grid while scrolling.

In this demo, the [`FrozenColumns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_FrozenColumns_System_Double_) is set as '2' and the [`FrozenRows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_FrozenRows_System_Double_)
is set as '3'. Hence, the left two columns and top three rows are frozen.

{% aspTab template="grid/scrolling/freeze-row-column", sourceFiles="freeze-row-column.cs" %}

{% endaspTab %}

### Freeze particular columns

To freeze particular column in the grid, the [`IsFrozen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsFrozen) property can be used.

In this demo, the columns with field name `OrderID` and `EmployeeID` is frozen using
the `IsFrozen` property.

{% aspTab template="grid/scrolling/freeze-column", sourceFiles="freeze-column.cs" %}

{% endaspTab %}

> * The `AllowScrolling` must be true while giving frozen rows and columns.
> * Frozen rows and columns should not be set outside the grid view port.

### Limitations

The following features are not supported in frozen rows and columns:

* Grouping
* Row Template
* Detail Template
* Hierarchy Grid