---
layout: post
title: Edit in Syncfusion ASP.NET Core Grid Control | Syncfusion
description: Learn here all about Edit in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Edit
publishingplatform: ##Platform_Name##
documentation: ug
---

# Editing in ASP.NET Core Grid component

The Grid component provides powerful options for dynamically inserting, deleting, and updating records, enabling you to modify data directly within the grid. This feature is useful when you want to enable you to perform CRUD (Create, Read, Update, Delete) operations seamlessly.

To enable editing functionality directly within the grid, you need to configure the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing), [allowAdding](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowAdding), and [allowDeleting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowDeleting) properties within the [editSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html)  to **true**.

Editing feature requires a primary key column for CRUD operations. To define the primary key, set `columns.isPrimaryKey` to **true** in particular column.

You can start the edit action either by double clicking the particular row or by selecting the required row and click on **Edit** button in the toolbar. Similarly, you can add a new record to grid either by clicking on **Add** button in the toolbar or on an external button which is bound to invoke the `addRecord` method of the grid, **Save** and **Cancel** while in edit mode is possible using respective toolbar icon in grid. Deletion of the record is possible by selecting the required row and click on **Delete** button in the toolbar.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

![Inline Editing](../images/editing/inline-edit.gif)

> * If `columns.isIdentity` is enabled, then it will be considered as a read-only column when editing and adding a record.
> * You can disable editing for a particular column, by specifying `columns.allowEditing` to **false**.
> * You can use the **Insert** key to add a new row to the grid and use the **Delete** key to delete the selected row from the grid.

## Toolbar with edit option

The toolbar with edit option feature in the Grid component provides a [built-in toolbar](https://ej2.syncfusion.com/aspnetcore/documentation/grid/tool-bar/tool-bar-items#built-in-toolbar-items) that includes various items for executing editing actions. This feature allows you to easily perform edit operations on the grid data, such as modifying cell values, updating changes, and canceling edits. 

To enable this feature, you need to configure the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property of the Grid component. This property allows you to define the items that will be displayed in the grid toolbar. By including the relevant items like **Edit**, **Add**, **Delete**, **Update**, and **Cancel** within the `toolbar` property, you can enable the edit options in the toolbar.

Here's an example of how to enable the toolbar with edit option in the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-toolbar.cs" %}
{% include code-snippet/grid/edit/edit-toolbar/edit-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Edit with toolbar](../images/editing/edit-with-toolbar.gif)

## Disable editing for particular column

In Grid component, you have an option to disable editing for a specific column. This feature is useful when you want to prevent editing certain columns, such as columns that contain calculated values or read-only data.

To disable editing for a particular column, you can use the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing)  property of the **columns** object. By setting this property to **false**, you can prevent editing for that specific column.

Here's an example that demonstrates how to disable editing for the column in the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-column-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/prevent-column-edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

![Disable Edit for particular column](../images/editing/disable-column-editing.png)

> * If you have set the `isPrimaryKey` property to **true** for a column, editing will be automatically disabled for that column.
> * You can disble the particular row using [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event. Please refer this [link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/in-line-editing#cancel-edit-based-on-condition).
> * You can disble the particular cell using [cellEdit](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event. Please refer this [link](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/batch-editing#cancel-edit-based-on-condition-in-batch-mode).

## Editing template column

The editing template column feature in the Grid allows you to create custom editing templates for specific columns in the grid. This feature is particularly useful when you need to customize the editing experience for certain columns, such as using custom input controls or displaying additional information during editing.

To enable the editing template column feature, you need to define the `field` property for the specific column in the grid's configuration. The `field` property maps the column to the corresponding field name in the data source, allowing you to edit the value of that field.

In the below demo, the **ShipCountry** column is rendered with the template.

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

## Customize delete confirmation dialog

Customizing the delete confirmation dialog in Grid allows you to personalize the appearance, content, and behavior of the dialog that appears when you attempts to delete an item. You can modify properties like header, showCloseIcon, and height to tailor the edit dialog to your specific requirements. Additionally, you can override default localization strings to provide custom text for buttons or other elements within the dialog.

To customize the delete confirmation dialog, you can utilize the [toolbarClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event. This event is triggered when a toolbar item, such as the delete button, is clicked.

> * To enable the confirmation dialog for the delete operation in the Grid, you can set the [showDeleteConfirmDialog](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) property of the `editSettings` configuration to **true**.
> * You can refer the Grid [Default text](../global-local) list for more localization.

The following example that demonstrates how to customize the delete confirmation dialog using the `toolbarClick` event:

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

The Syncfusion Grid allows you to update a boolean column value with a single click in the normal mode of editing. This feature streamlines the process of toggling boolean values within the grid, enhancing interaction and efficiency. This can be achieved through the use of the column template feature.

In the following sample, the `CheckBox` component is rendered as a template in the **Verified** column to make it editable with a single click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/update-boolean-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Update-boolean.cs" %}
{% include code-snippet/grid/edit/update-boolean-value/boolean.cs %}
{% endhighlight %}
{% endtabs %}

![Update boolean value in single click](../images/editing/update-boolean.gif)

## Edit enum column 

The Syncfusion Grid provides a feature that allows you to edit enum type data in a grid column. This is particularly useful when you need to edit enumerated list data efficiently.

In the following example, the `DropDownList` component is rendered within the cell edit template for the Employee Feedback column using edit property.

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

The edit template for complex column in Grid is used to customize the editing experience when dealing with complex data structures. This capability is particularly useful for handling nested data objects within grid columns. By default, the grid binds complex data to column fields using the dot (.) operator. However, when you render custom elements, such as input fields, in the edit template for a complex column, you must use the (___) underscore operator instead of the dot (.) operator to bind the complex object.

In the following sample, the input element is rendered in the edit template of the FirstName and LastName column. The edited changes can be saved using the `name` property of the input element. Since the complex data is bound to the FirstName  and LastName column, The `name` property should be defined as **Name___FirstName** and **Name___LastName**, respectively, instead of using the dot notation (**Name.FirstName** and **Name.LastName**).

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

The Syncfusion Grid offers a powerful editing feature for foreign key columns, enhancing the default rendering of the DropDownList component during editing. This flexibility is particularly useful when you need to customize the editor for foreign key columns. By default, the Syncfusion Grid renders the DropDownList component as the editor for foreign key columns during editing. However, you can enhance and customize this behavior by leveraging the cell edit template for the column using edit property. The edit property allows you to specify a cell edit template that serves as an editor for a particular column.

In the following code example, the Employee Name is a foreign key column. When editing, the ComboBox component is rendered instead of DropDownList.

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

## How to perform CRUD action externally 

Performing CRUD (Create, Read, Update, Delete) actions externally in the Syncfusion Grid allows you to manipulate grid data outside the grid itself. This can be useful in scenarios where you want to manage data operations programmatically.

### Using separate toolbar 

The Syncfusion Grid enables external CRUD operations, allowing you to efficiently manage data manipulation within the grid. This capability is particularly useful when you need to manage data operations using a separate toolbar.

To perform CRUD operations externally, the following methods are available:

`addRecord` - To add a new record. If no data is passed then add form will be shown.
`startEdit` - To edit the selected row.
`deleteRecord` - To delete a selected row.
`endEdit` - If the grid is in editable state, then you can save a record by invoking this method.
`closeEdit` - To cancel the edited state.

The following example demonstrates the integration of the Syncfusion Grid with a separate toolbar for external CRUD operations. The toolbar contains buttons for Add, Edit, Delete, Update, and Cancel.

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

Performing the edit operation in a custom external form in the Syncfusion Grid is a valuable feature when you need to customize the edit operation within a separate form rather than the default in-grid editing. 

To enable the use of an external form for editing in Syncfusion Grid, you can make use of the [rowSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event. This property specifies whether the edit operation should be triggered when a row is selected.

In the following example, it demonstrates how to edit the form using an external form by utilizing the `rowSelected` event:

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

## Troubleshoot editing works only for first row

The Editing functionalities can be performed based upon the primary key value of the selected row. If `isPrimaryKey` property is not defined in the grid, then edit or delete action take places the first row. To overcome this, ensure that you establish the `isPrimaryKey` property as **true** for the relevant column responsible for holding the unique identifier for each row.

## How to make a grid column always editable

To make a Grid column always editable, you can utilize the column template feature of the Grid. This feature is useful when you want to edit a particular column's values directly within the grid.

In the following example, the textbox is rendered in the **Freight** column using a column template. The keyup event for the Grid is bound using the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event of the Grid, and the edited changes are saved in the data source using the `updateRow` method of the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/column-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-edit.cs" %}
{% include code-snippet/grid/edit/column-edit/column-edit.cs %}
{% endhighlight %}
{% endtabs %}

![Editable column](../images/editing/editable-column.gif)

## See Also

* [How to set custom format in edit state of Grid](https://support.syncfusion.com/kb/article/11763/how-to-set-custom-format-in-edit-state-of-grid)