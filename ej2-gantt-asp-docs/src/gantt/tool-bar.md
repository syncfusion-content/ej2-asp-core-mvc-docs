---
title: "Tool Bar"
component: "Gantt"
description: "Learn how to use the toolbar and add custom toolbar items in the Essential JS 2 Gantt control"
---

# Toolbar

The Gantt control provides the toolbar support to handle Gantt actions. The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) property accepts the collection of built-in toolbar items and [`ItemModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html) objects for custom toolbar items.

## Built-in toolbar items

Built-in toolbar items execute standard actions of the Gantt control, and these items can be added to toolbar by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) as a collection of built-in items. It renders the button with icon and text.

The following table shows built-in toolbar items and its actions.

| Built-in Toolbar Items | Actions |
|------------------------|---------|
| Add | Adds a new record. |
| Cancel | Cancels the edit state. |
| CollapseAll | Collapses all the rows. |
| Delete | Deletes the selected record. |
| Edit | Edits the selected record. |
| Indent | Indent the selected record to one level.|
| Outdent | Outdent the elected record to one level.|
| ExpandAll | Expands all the rows. |
| NextTimeSpan | Navigate the Gantt timeline to next time span. |
| PrevTimeSpan | Navigate the Gantt timeline to previous time span. |
| Search | Searches the records by the given key. |
| Update | Updates the edited record. |

{% aspTab template="gantt/toolbar/defaultItems", sourceFiles="defaultItems.cs" %}

{% endaspTab %}

> * The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added to the toolbar by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) property as a collection of [`ItemModels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html).
Actions for this customized toolbar items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ToolbarClick) event.

By default, the custom toolbar items are at left position. You can change the position by using the [`Align`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_Align) property. In the following sample, the `Quick Filter` toolbar item is positioned at right.

{% aspTab template="gantt/toolbar/customItems", sourceFiles="customItems.cs" %}

{% endaspTab %}

> * The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) has options to define both built-in and custom toolbar items.
> * If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Built-in and custom items in toolbar

The Gantt control has an option to use both built-in and custom toolbar items at the same time.

In the following example, the `ExpandAll` and `CollapseAll` are built-in toolbar items and `Test` is the custom toolbar item.

{% aspTab template="gantt/toolbar/defaultandCustomItems", sourceFiles="defaultandCustomItems.cs" %}

{% endaspTab %}

## Enable/disable toolbar items

You can enable or disable the toolbar items by using the `enableItems` method.

{% aspTab template="gantt/toolbar/enable-disabletoolbarItems", sourceFiles="enable-disabletoolbarItems.cs" %}

{% endaspTab %}