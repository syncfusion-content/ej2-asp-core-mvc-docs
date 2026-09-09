---
layout: post
title: ##Platform_Name## Grid Cell Editing | Syncfusion
description: Learn how to edit grid cells in ##Platform_Name## Data Grid, customize editing workflows, validate input, manage updates, and control editing behavior.
platform: ej2-asp-core-mvc
control: Cell Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Cell Editing in ASP.NET Core Data Grid

Cell editing provides a streamlined way to update individual cell values directly within the grid. It is designed for quick, inline modifications, making data entry and corrections more efficient. This approach ensures that changes are applied seamlessly to large datasets while maintaining consistency with the grid’s overall editing experience.

## Enable cell editing
 
To enable cell editing in the Data Grid, configure the [editSettings->mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to `Cell` and set the [editSettings->allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing) property to `true`. This configuration allows individual cell values to be updated directly within the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cell-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="cell-edit.cs" %}
{% include code-snippet/grid/edit/cell-edit/cell-edit.cs %}
{% endhighlight %}
{% endtabs %}

> When editing is enabled, it is necessary to set the `isPrimaryKey` property value to `true` for the unique column to ensure accurate data updates.

## Single-click editing
 
Single-click editing allows a cell to enter edit mode with a single click instead of the default interaction. This seamless experience is achieved by using the `editCell` method for rapid, efficient data modification.

To implement this, bind the click event for the grid and, within the event handler, call the `editCell` method based on the clicked target element. This ensures that the editing mode is triggered when clicking on a specific element within the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cell-edit-single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="cell-edit-single.cs" %}
{% include code-snippet/grid/edit/cell-edit-single/cell-edit-single.cs %}
{% endhighlight %}
{% endtabs %}

## Cancel edit based on condition

The Data Grid can prevent edit operations for specific cells based on custom conditions. This functionality is achieved by leveraging the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of the grid component. This event is triggered when a CRUD (Create, Read, Update, Delete) operation is initiated in the grid.

This customization is useful when restricting editing for certain cells, such as read-only data, calculated values, or protected information. It helps maintain data integrity and ensures that only authorized changes can be made in the grid.

To cancel the edit operation based on a specific condition, handle the `actionBegin` event of the grid component and check the `requestType` parameter. This parameter indicates the type of action being performed:

| Request Type | Description |
|--------------|-------------|
| `beginEdit` | Editing an existing record |
| `add` | Creating a new record |
| `save` | Updating a new or existing record |
| `delete` | Deleting an existing record |

Apply the desired condition and cancel the operation by setting the `args.cancel` property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cell-edit-cancel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="cell-edit-cancel.cs" %}
{% include code-snippet/grid/edit/cell-edit-cancel/cell-edit-cancel.cs %}
{% endhighlight %}
{% endtabs %}