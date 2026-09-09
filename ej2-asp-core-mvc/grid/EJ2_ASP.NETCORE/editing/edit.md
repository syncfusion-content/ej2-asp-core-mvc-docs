---
layout: post
title: ##Platform_Name## Grid Editing | Syncfusion
description: Learn how to configure editing in ##Platform_Name## Data Grid, customize edit modes, apply validation rules, use templates, and manage CRUD workflows efficiently.
platform: ej2-asp-core-mvc
control: Edit
publishingplatform: ##Platform_Name##
documentation: ug
---

# Editing in ASP.NET Core Data Grid

The Data Grid component includes built-in editing features for creating, reading, updating, and deleting data directly in the grid. This eliminates the need for separate forms and allows data modification within a single interface. The grid editing provides powerful options through multiple edit modes such as inline editing, dialog editing, batch editing, custom editors, validation, CRUD operations, and template-based editing.

## Enable editing

To enable editing functionality directly within the grid, configure the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing), [allowAdding](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowAdding), and [allowDeleting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowDeleting) properties within the [editSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) to `true`.

| Property | Purpose |
|----------|---------|
| `allowEditing` | Enable editing of existing records |
| `allowAdding` | Enable adding new records |
| `allowDeleting` | Enable deleting records |

Editing requires a primary key column to support full CRUD functionality. Define the primary key by setting `columns.isPrimaryKey` to `true` on the relevant column.

Edit actions can be initiated by double-clicking a row or by selecting a row and clicking the `Edit` button in the toolbar. Records can be added by clicking the `Add` button in the toolbar or via an external trigger that invokes the `addRecord` method. Use `Save` and `Cancel` to commit or discard changes from the toolbar during edit mode. Deletion is performed by selecting the target row and clicking the `Delete` button.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

![Inline Editing](../images/editing/inline-edit.gif)

> * If `columns.isIdentity` is enabled, the column will be treated as read-only when editing or adding records.
> * Use `columns.allowEditing` set to `false` to disable editing for specific columns.
> * The `Insert` key adds a new row, and the `Delete` key deletes the selected row in the grid.

## Edit modes

The Data Grid supports multiple editing options to meet different data-editing requirements:

- **[Inline edit](./in-line-editing)**: Allows direct modification of row or cell values within the grid.
- **[Batch edit](./batch-editing)**: Enables editing and saving of multiple cells in a single action.
- **[Cell edit](./cell-editing)**: Allows to edit individual cell values directly within the grid.
- **[Dialog edit](./dialog-editing)**: Opens a dedicated modal dialog window to edit row data.

Use the `editSettings.mode` property to specify the desired edit mode.

## Edit records using the toolbar

The toolbar with edit option feature provides a [built-in toolbar](https://ej2.syncfusion.com/aspnetcore/documentation/grid/tool-bar/tool-bar-items#built-in-toolbar-items) that includes items for editing actions. Using the toolbar, grid records can be modified, updated, or canceled during edit operations.

Configure the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property of the Grid component to enable this feature. The toolbar property defines the items displayed in the grid toolbar. Include relevant items like `Edit`, `Add`, `Delete`, `Update`, and `Cancel` within the `toolbar` property to enable edit options in the toolbar.

The following example demonstrates enabling the toolbar with editing options in the Data Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-toolbar.cs" %}
{% include code-snippet/grid/edit/edit-toolbar/edit-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Edit with toolbar](../images/editing/edit-with-toolbar.gif)

## Column validation

Column validation applies validation rules to individual columns during edit operations, ensuring data accuracy before saving. Invalid data displays error messages and prevents saving. The `FormValidator` component validates data using rules defined in the `validationRules` property for each column.

The following example demonstrates validation rules applied to a grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/validation-columnvalid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="columnvalid.cs" %}
{% include code-snippet/grid/edit/validation-columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

![Column validation](../images/editing/validation.png)

## Disable editing for specific columns

The Data Grid provides the option to disable editing for specific columns. This is useful when certain columns should remain read-only, such as columns containing calculated values, IDs, or system-generated data.

### Static column disabling

To permanently disable editing for a column, set the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing) property to `false` on the column. This prevents editing for that column across all rows:

```html
<ejs-grid id="Grid" dataSource="@ViewBag.data">
    <e-grid-columns>
        <e-grid-column field="OrderID" allowEditing="false"></e-grid-column>
    </e-grid-columns>
</ejs-grid>
```

### Dynamic column disabling

To disable editing for a column based on application interaction or conditions, use the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing) property of the `columns` object. Set this property to `false` to prevent editing for that specific column. 

The following example demonstrates how to disable editing for selected columns dynamically in the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-column-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/prevent-column-edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

![Disable Edit for particular column](../images/editing/disable-column-editing.png)

> * If [isPrimaryKey](../../api/grid/column#isprimarykey) is enabled, editing is automatically disabled for that column.
> * To disable editing for a specific row using the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. Please refer this [link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/in-line-editing#cancel-edit-based-on-condition).
> * To disable editing for a particular cell using the [cellEdit](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event. Please refer this [link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/batch-editing#cancel-edit-based-on-condition-in-batch-mode).

## Customize column editors using templates

Customizing the editing experience for specific columns is possible by defining an editing template. Use the `field` property to connect the column with its corresponding data field.

In this example, the "Ship Country" column is rendered with a template:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/template-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-template.cs" %}
{% include code-snippet/grid/edit/template-edit/edit-temp.cs %}
{% endhighlight %}
{% endtabs %}

| Before Editing | After Editing |
| -------------- | ------------- |
| ![Before template column edit](../images/editing/before-template-column-editing.png) | ![After template column edit](../images/editing/after-template-column-editing.png) |

## Edit enum column 

Enum columns contain predefined list values (enumerated data). Instead of allowing free-form text input, using a dropdown editor ensures data consistency and prevents invalid entries. The `edit` property enables custom editors for enum data.

The following example demonstrates how to render a `DropDownList` component as an edit template for the "Employee Feedback" column, binding it to a predefined list of enum values: 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/enum-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enum.cs" %}
{% include code-snippet/grid/edit/enum-column/enum.cs %}
{% endhighlight %}
{% endtabs %}

| On Editing | After Editing |
| -------------- | ------------- |
| ![Enum column edit](../images/editing/on-enum-column-editing.png) | ![After enum column edit](../images/editing/after-enum-column-editing.png) |


## Edit complex column 

Complex columns contain nested data objects (such as "Name.FirstName"). When editing complex data with custom input elements, the binding syntax differs from simple columns. Use the underscore operator (`___`) instead of the dot operator (`.`) to correctly bind nested properties in edit templates.

The following example demonstrates how to edit complex nested data. The "FirstName" and "LastName" properties (nested under "Name") are edited using input elements with names defined as "Name___FirstName" and "Name___LastName":

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/complex-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complex.cs" %}
{% include code-snippet/grid/edit/complex-column/complex.cs %}
{% endhighlight %}
{% endtabs %}

| On Editing | After Editing |
| -------------- | ------------- |
| ![Complex column edit](../images/editing/on-complex-column-editing.png) | ![After complex column edit](../images/editing/after-complex-column-editing.png) |

## Edit foreign key column 

The Data Grid provides a powerful editing feature for foreign key columns by rendering a `DropDownList` component as the default editor during editing. This default editor can be replaced by defining the `edit` property. The `edit` property accepts either a template string or an HTML element ID and serves as the editor for a particular column.

In the following code example, the "Employee Name" is a foreign key column. When editing, the `ComboBox` component is rendered instead of `DropDownList`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/foreign-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Foreign-key.cs" %}
{% include code-snippet/grid/edit/foreign-column/foreign.cs %}
{% endhighlight %}
{% endtabs %}

| On Editing | After Editing |
| -------------- | ------------- |
| ![Foreign key column edit](../images/editing/on-foreign-key-column-editing.png) | ![After foreign key column edit](../images/editing/after-foreign-key-column-editing.png) |

## Customize delete confirmation dialog

By default, the Data Grid shows a confirmation dialog when attempting to delete a row. The appearance and content of this dialog can be customized to match application requirements. Customization can include changing the dialog header, icons, or button text.

To customize the delete confirmation dialog, utilize the [toolbarClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event. This event is triggered when a toolbar action is performed and allows modification of dialog properties.

> * Enable the confirmation dialog for deletions by setting [showDeleteConfirmDialog](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) to `true` in `editSettings`.
> * Refer to the grid [Default text](../global-local) documentation for localization options.

The following example demonstrates customizing the delete confirmation dialog in the grid by handling the `toolbarClick` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/delete-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Delete-dialog.cs" %}
{% include code-snippet/grid/edit/delete-dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Customize delete confirmation dialog](../images/editing/delete-confirm-dialog.png)

## Update boolean column value with a single click   

The grid allows boolean column values to be toggled with a single click in normal editing mode. Use the column template feature to render a CheckBox for direct interaction.

The following example demonstrates how to render a `CheckBox` component as a template in the "Verified" column to enable single-click editing:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/update-boolean-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Update-boolean.cs" %}
{% include code-snippet/grid/edit/update-boolean-value/boolean.cs %}
{% endhighlight %}
{% endtabs %}

![Update boolean value in single click](../images/editing/update-boolean.gif)

## Performing CRUD actions externally 

By default, the grid provides built-in editing through toolbars and inline editing. However, CRUD operations can also be triggered programmatically from external controls (custom buttons, forms, or panels outside the grid). This allows full control over when and how data operations occur.

### Using separate toolbar 

To perform CRUD operations externally, use the following methods:

| Method | Purpose |
|--------|---------|
| `addRecord` | Add a new record (shows edit form if no data provided) |
| `startEdit` | Begin editing the selected row |
| `deleteRecord` | Delete the selected row |
| `endEdit` | Save changes when grid is in edit state |
| `closeEdit` | Cancel editing without saving |

The following example demonstrates external CRUD operations with a custom toolbar.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/separate-toolbar-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separate-toolbar-edit.cs" %}
{% include code-snippet/grid/edit/separate-toolbar-edit/separate-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Edit using separate toolbar](../images/editing/edit-with-seprate-toolbar.gif)

### Using external form 

Performing the edit operation in a custom external form in the Data Grid is a valuable feature when customization of the edit operation is required within a separate form rather than the default in‑grid editing.

To enable the use of an external form for editing in the grid, the [rowSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event can be used. This event specifies whether the edit operation should be triggered when a row is selected.

In the following example, the edit operation is demonstrated using an external form by utilizing the `rowSelected` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/external-form-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Form-edit.cs" %}
{% include code-snippet/grid/edit/external-form-edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

| On Editing | After Editing |
| -------------- | ------------- |
| ![External form edit](../images/editing/on-external-form-editing.png) | ![After form edit](../images/editing/after-external-form-editing.png) |

## Make a grid column always editable

To keep a column editable at all times, use a column template and handle input through the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) method.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/column-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-edit.cs" %}
{% include code-snippet/grid/edit/column-edit/column-edit.cs %}
{% endhighlight %}
{% endtabs %}

![Editable column](../images/editing/editable-column.gif)

## Troubleshooting: Editing works only for the first row

If editing or deleting only works for the first row in the grid, the `isPrimaryKey` property is likely not configured. The primary key is essential for identifying which row to edit or delete. Without it, the grid cannot distinguish between rows.

**Solution**: Set `isPrimaryKey` to `true` on the column that contains unique identifiers:

```html
<ejs-grid id="Grid" dataSource="@ViewBag.data">
    <e-grid-columns>
        <e-grid-column 
            field="OrderID" 
            headerText="Order ID" 
            width="100" 
            isPrimaryKey="true">
        </e-grid-column>
    </e-grid-columns>
</ejs-grid>

```

## See Also

[How to set custom format in edit state of Grid](https://support.syncfusion.com/kb/article/11763/how-to-set-custom-format-in-edit-state-of-grid)