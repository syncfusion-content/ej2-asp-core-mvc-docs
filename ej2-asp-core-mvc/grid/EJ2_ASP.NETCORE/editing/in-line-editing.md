---
layout: post
title: ##Platform_Name## Grid Inline Editing | Syncfusion
description: Learn how to perform inline editing in ##Platform_Name## Data Grid, update records directly, customize editing behavior, and manage CRUD operations efficiently.
platform: ej2-asp-core-mvc
control: Inline Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Inline Editing in ASP.NET Core Data Grid

The Data Grid component provides an efficient inline editing feature, enabling direct modification of row or cell values within the grid. Inline editing is ideal for streamlining data entry and updates without invoking a separate form. In normal edit mode, the selected record enters an editable state, allowing updates to cell values which are then saved back to the data source.

## Enable inline editing

To enable inline editing in the grid component, set the [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to `Normal`. This property determines the editing mode of the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/grid/edit/inline/inline.cs %}
{% endhighlight %}
{% endtabs %}

![Inline Editing](../images/editing/inline-editing.gif)

> * The `Normal` edit mode is the default mode of editing.
> * When enabling editing, it is necessary to set the `isPrimaryKey` property value to `true` for the unique column.
> * For basic editing setup and configuration, refer to the [Edit Feature Setup](./edit#set-up-editing).

## Update column values automatically

The Cell Edit Template feature enables automatic updating of a column’s value whenever a value in another column is edited. This feature enables dynamic calculations and real-time updates to column values based on changes in related columns, streamlining data entry workflows. 

To enable this functionality:
- Define the `editType` property to specify the editor type for editing.
- Provide an object for the `edit` property to customize editing behavior.

In the following example, the "Total Cost" column value is updated based on changes to the "Unit Price" and "Unit In Stock" columns during editing.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-autoupdate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="autoupdate.cs" %}
{% include code-snippet/grid/edit/inline-autoupdate/autoupdate.cs %}
{% endhighlight %}
{% endtabs %}

![Automatically update](../images/editing/inline-automatically.gif)

## Set default values for new records

Preset column values streamline data entry for new records. Set `defaultValue` for columns in the grid configuration to ensure these fields are pre-filled in new rows.

Here's an example of how to set a default value for a column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-defaultcolumnvalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="defaultcolumnvalue.cs" %}
{% include code-snippet/grid/edit/inline-defaultcolumnvalue/defaultcolumnvalue.cs %}
{% endhighlight %}
{% endtabs %}

![Display default value for columns while adding](../images/editing/inline-default-value.png)

## Show confirmation dialog while deleting

The built-in confirmation dialog enhances data safety by requesting confirmation before deleting records. Enable this dialog by setting [showDeleteConfirmDialog](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) in [editSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) to `true` (default is `false`).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-show-confirmation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="showconfirmationdialog.cs" %}
{% include code-snippet/grid/edit/inline-show-confirmation/showconfirmationdialog.cs %}
{% endhighlight %}
{% endtabs %}

![Show confirmation dialog while deleting](../images/editing/inline-show-confirmation.png)

> The [showDeleteConfirmDialog](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) supports all type of edit modes.

## Delete multiple rows

Multiple row deletion is supported via the in-built toolbar or through methods.

**Using the toolbar:** Set the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property of the grid and set the [selectionSettings.type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) to `Multiple`. Select rows and use the toolbar delete icon to remove them.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-multiple-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="inbuilt-toolbar.cs" %}
{% include code-snippet/grid/edit/inline-multiple-rows/inbuilt-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Using the inbuilt toolbar delete option](../images/editing/inline-multiple-rows.gif)

> Selected records can also be deleted using the `Delete` key.

**Using method**

Multiple rows can be deleted programmatically using the following methods.

1. `deleteRecord` - This method deletes a record with the given options. If the `fieldname` (primary key field) and `data` parameters are not provided, the grid deletes the selected records.

    ```ts
        var grid = document.getElementById("grid").ej2_instances[0];
        grid.deleteRecord();
    ```

2. `deleteRow` - This method deletes a visible row by providing the corresponding `<tr>` element. Use `getSelectedRows` to retrieve the selected rows and iterate over them. For each row, pass the `<tr>` element to `deleteRow` to initiate deletion. This approach enables selective deletion based on the `<tr>` elements obtained from `getSelectedRows`.

    ```ts
        var grid = document.getElementById("grid").ej2_instances[0];
        var selectedRows = grid.getSelectedRows();
        selectedRows.forEach((row) => {
            grid.deleteRow(row);
        });
    ```

> Use [selectionSettings.type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) = `Multiple` and consider enabling `showDeleteConfirmDialog` property of the `editSettings` to prevent accidental deletions

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="inline-method.cs" %}
{% include code-snippet/grid/edit/inline-method/inline-method.cs %}
{% endhighlight %}
{% endtabs %}

![Using method](../images/editing/inline-delete-method.gif)

## Adding a new row at the bottom of the grid

The Data Grid enables seamless addition of new rows at the bottom of the grid, inserting records at the end of the existing data set. This convenient feature proves particularly useful for intuitive record addition without requiring scroll repositioning, improving workflow efficiency.

By default, the new row form is inserted at the top of the grid for data entry. To change this behavior, set the  [newRowPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) property in the [editSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) configuration to `Bottom`. This property controls the position where the new row form is inserted.

The following example displays the add form at the bottom of the grid using `newRowPosition`:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-rowposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="rowposition.cs" %}
{% include code-snippet/grid/edit/inline-rowposition/rowposition.cs %}
{% endhighlight %}
{% endtabs %}

![Adding a new row at the bottom of the grid](../images/editing/inline-poistion.png)


> * The [newRowPostion](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) property is supported for `Normal` and `Batch` editing modes.
> * When `newRowPostion` is set to `Bottom`, the grid displays a blank row form at the bottom by default for data entry. However, when the data is saved or updated, it is inserted at the top of the grid.

## Always display an add new row in the grid

The Data Grid simplifies the addition of new records by consistently presenting a blank "add new row" form within the grid. To enable this feature, set the [showAddNewRow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowAddNewRow) property within the `editSettings` configuration to `true`. This enables continuous record addition. The add new row displays at either the `top` or `bottom` of the grid content, depending on the [newRowPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) property of `editSettings`. By default, the add new row displays at the top of the grid content.

The following sample demonstrates how to add a new record continuously using `showAddNewRow` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-showaddnewrow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="showaddnewrow.cs" %}
{% include code-snippet/grid/edit/inline-showaddnewrow/showaddnewrow.cs %}
{% endhighlight %}
{% endtabs %}

![Show add new row always in grid](../images/editing/inline-top-position.png)

> To save newly added records, press the <kbd>Enter</kbd> key or click the "Update" button on the toolbar after filling the add form.

### Constraints

The always‑visible add new row feature is compatible with `Inline`/`Normal` editing mode only. In grids with virtual or infinite scrolling, the blank row is consistently displayed at the top for stable behavior.

## Cancel edit based on condition

The Data Grid provides the ability to cancel the edit operations for particular row or cell based on specific conditions. This feature allows controlling whether editing should be allowed or prevented for certain rows or cells in the grid. This functionality is achieved by leveraging the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of the grid component. This event is triggered when a CRUD (Create, Read, Update, Delete) operation is initiated in the grid.

This customization is useful when restricting editing for certain rows, such as read-only data, calculated values, or protected information. It helps maintain data integrity and ensures that only authorized changes can be made in the grid.

To cancel the edit operation based on a specific condition, handle the `actionBegin` event of the grid component and check the `requestType` parameter. This parameter indicates the type of action being performed:

| Request Type | Description |
|--------------|-------------|
| `beginEdit` | Editing an existing record |
| `add` | Creating a new record |
| `save` | Updating a new or existing record |
| `delete` | Deleting an existing record |

Apply the desired condition and cancel the operation by setting the `args.cancel` property to `true`.

The following example prevents CRUD actions for rows where the "Role" column equals "Admin".

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-cancel-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="canceleditinline.cs" %}
{% include code-snippet/grid/edit/inline-cancel-edit/canceleditinline.cs %}
{% endhighlight %}
{% endtabs %}

![Cancel edit based on condition](../images/editing/inline-cancel.gif)

## Disable editing for specific rows

Editing can be restricted for designated rows using the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. Set `args.cancel = true` based on custom condition checks in the event handler.

In the below demo, the rows which are having the value for "ShipCountry" column as "France" is prevented from editing.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-particular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-particular.cs" %}
{% include code-snippet/grid/edit/inline-particular/inline-particular.cs %}
{% endhighlight %}
{% endtabs %}

![Disable editing for a particular row](../images/editing/inline-particular-row.gif)

## Perform CRUD action programmatically

Programmatic CRUD operations enable creating, reading, updating, and deleting data through code instead of manual interaction. This approach provides flexibility for advanced data manipulation workflows. The following table outlines key methods for programmatic CRUD operations:

| Method | Description | Usage |
|--------|-------------|-------|
| `addRecord` | Add a new record to the grid | Pass the `data` parameter to add a record. Use the `index` parameter for a specific position. Without parameters, creates an empty row at index zero. |
| `startEdit` | Change the selected row to edit state | First select the row, then invoke this method. The selected row enters edit mode immediately. Without row selection along with default `showConfirmDialog` enabled state, "No records selected for edit operation" dialog appears. |
| `updateRow` | Update row data in the data source | Provide the row `index` and the updated `data` as parameters. The data source updates accordingly. |
| `setCellValue` | Update a particular cell in a row | Provide the primary key value, field name, and new value. Changes appear visually in the UI only (not persisted). Useful for unbound columns, auto-calculated columns, and formula columns. |
| `deleteRecord` | Remove a selected row from the grid | First select the row, then invoke this method. The selected row is immediately removed. Without row selection along with default `showConfirmDialog` enabled state, "No records selected for delete operation" dialog appears. |

> In both `Normal` and `Dialog` editing modes, these methods can be used.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-programmatic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="programmatic.cs" %}
{% include code-snippet/grid/edit/inline-programmatic/programmatic.cs %}
{% endhighlight %}
{% endtabs %}

![Perform CRUD action programmatically](../images/editing/inline-curd.png)

## Set focus to a specific cell during row editing

The Data Grid enables moving focus to a specific cell when editing a row, rather than the default behavior of focusing on the first cell. This feature improves the editing experience by automatically focusing on the cell requiring immediate attention.

To achieve this functionality, leverage the [recordDoubleClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RecordDoubleClick) event of the grid component. The `recordDoubleClick` event is triggered when a row is double-clicked, indicating intent to edit. Handle this event and programmatically move focus to the desired cell within the row.

Here's an example of how to use the `recordDoubleClick` event to move the focus to a particular cell:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="inline-focus.cs" %}
{% include code-snippet/grid/edit/inline-focus/inline-focus.cs %}
{% endhighlight %}
{% endtabs %}

![Move the focus to a particular cell](../images/editing/inline-move-focus.gif)

## Enable single-click editing

Enabling single-click editing in the Data Grid's `Normal` editing mode is a valuable and intuitive feature that makes a row editable with just one click. This seamless experience is achieved by using the `startEdit` and `endEdit` methods for rapid, efficient data modification.

To implement this feature, bind the `mouseup` event for the grid and, within the event handler, call the `startEdit` and `endEdit` methods based on the clicked target element. This ensures editing mode is triggered when clicking on a specific element within the grid.

The following sample demonstrates enabling editing with a single click using the `mouseup` event along with the [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline-single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Single-click.cs" %}
{% include code-snippet/grid/edit/inline-single/single-click.cs %}
{% endhighlight %}
{% endtabs %}

![Enable editing in single click](../images/editing/inline-single-click.gif)