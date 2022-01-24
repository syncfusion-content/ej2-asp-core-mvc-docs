---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Drag And Drop of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and drop

The ListBox has support to drag an item or a group of selected items and drop it within the same list box or into another list box.

The elements can be customized on drag and drop by using the following events,

| Events | Description |
|------|------|
| [`dragStart`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~DragStart.html) | Triggers when the selected element is being dragged. |
| [`drag`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Drag.html) | Triggers when the selected element is being dragged. |
| [`drop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Drop.html) | Triggers when the selected element is being dropped. |

## Single listbox

To drag and drop an item or group of item within the list box can be achieved by setting [`allowDragAndDrop`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~AllowDragAndDrop.html) property as `true`.

The following sample illustrates how to drag and drop an item within the same list box by enabling `allowDragAndDrop` property.

{% aspTab template="listbox/drag-drop/single", sourceFiles="dragdrop.cs" %}

{% endaspTab %}

## Multiple listbox

To drag and drop an item or group of item between two list boxes can be achieved by setting `allowDragAndDrop` property as `true` and [`scope`](../api/list-box/#scope) property should be set to both the list boxes.

In the following sample, the `allowDragAndDrop` property is set as `true` and `scope` is set as `combined-list` to enable drop and drop in both list boxes.

{% aspTab template="listbox/drag-drop/multiple", sourceFiles="dragdrop.cs" %}

{% endaspTab %}