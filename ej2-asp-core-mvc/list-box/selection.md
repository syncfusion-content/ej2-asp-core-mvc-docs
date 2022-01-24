---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Selection of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection

The ListBox provides support to select an item or a group of item by mouse or keyboard action. There are two selection modes available in list box,

* Single -  To select single item in the list box.
* Multiple -  To select multiple items in the list box.

On selection of each list box item, [`change`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ListBox.html#Syncfusion_EJ2_DropDowns_ListBox_Change) event is triggered.

## Single selection

To enable single selection in the list box, [`mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxSelectionSettings~Mode.html) should be set as `Single` in [`selectionSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~SelectionSettings.html) property.

{% aspTab template="listbox/selection/single", sourceFiles="selection.cs" %}

{% endaspTab %}

## Multiple selection

To enable multiple selection in the list box, `mode` should be set as `Multiple` in `selectionSettings` property.

To select multiple items, use the SHIFT, CTRL, and arrow keys to make selections.

> By default, the selection mode is set as `Multiple`.

{% aspTab template="listbox/selection/multiple", sourceFiles="selection.cs" %}

{% endaspTab %}

> To select all the items in the list box, [`showSelectAll`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxSelectionSettings~ShowSelectAll.html) method can also be used.