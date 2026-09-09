---
layout: post
title: ##Platform_Name## Grid Command Column Editing | Syncfusion
description: Learn how to enable command column editing in ##Platform_Name## Data Grid with built-in edit, save, and delete actions, customizable buttons, and event handling.
platform: ej2-asp-core-mvc
control: Command Column Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Command Column Editing in ASP.NET Core Data Grid

The command column feature provides built‑in action buttons within a dedicated column, enabling direct interaction with individual rows. These commands can be configured for editing, saving, and deleting records, as well as for custom operations such as viewing details or integrating external actions. This approach streamlines row‑level interactions and ensures a consistent experience within the grid interface.

## Enable command column editing

Command column editing is activated through the `column.commands property. This property specifies which command buttons display in the command column, such as `Edit`, `Delete`, `Save`, and `Cancel`.

The following built-in command buttons are available:

| Command button | Actions |
|----------------|---------|
| `Edit` | Enables inline editing for the current row. |
| `Delete` | Removes the current row from the grid. |
| `Save` | Updates changes made to the edited row. |
| `Cancel` | Discards changes and exits edit mode.|

The following example demonstrates CRUD action buttons in a command column using the `commands` property:  

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/commandcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="commandcolumn.cs" %}
{% include code-snippet/grid/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}

![Command column editing](../images/editing/edit-command.gif)

## Custom command column button

Custom command columns provide additional row-level actions beyond the built-in command buttons. This is particularly powerful when specialized functionality for editing, deletion, or custom operations is required beyond the built-in command set.

To define custom command buttons, use the [column.commands](../../api/grid/column#commands) property. Associate the desired actions with these buttons through the [commandClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CommandClick) event, allowing custom logic to be executed on button click.

The following example demonstrates custom command buttons using the `commands` property and custom click behavior through the `commandClick` event, which is used here to show row details in a dialog:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customcommand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customcommand.cs" %}
{% include code-snippet/grid/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% endtabs %}

![Custom command column](../images/editing/edit-custom.png)

## See also

* [Template editing](./template-editing)
* [Cell editing](./cell-editing)
* [Batch editing](./batch-editing)
* [Dialog editing](./dialog-editing)