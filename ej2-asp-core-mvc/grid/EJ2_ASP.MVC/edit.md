---
layout: post
title: Edit in ##Platform_Name## Grid Component
description: Learn here all about Edit in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Edit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing

The Grid component has options to dynamically insert, delete and update records.
Editing feature requires a primary key column for CRUD operations.
To define the primary key, set [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to **true** in particular column.

You can start the edit action either by double clicking the particular row or by selecting the required row and click on **Edit** button in the toolbar. Similarly, you can add a new record to grid either by clicking on **Add** button in the toolbar or on an external button which is bound to invoke the [`addRecord`](https://ej2.syncfusion.com/documentation/api/grid/#addrecord) method of the grid, **Save** and **Cancel** while in edit mode is possible using respective toolbar icon in grid.

Deletion of the record is possible by selecting the required row and click on **Delete** button in the toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/edit/edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/grid/edit/edit/edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If [`IsIdentity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) is enabled, then it will be considered as a read-only column when editing and adding a record.
> You can disable editing for a particular column, by specifying
[`AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) to **false**.

## Toolbar with edit option

The grid toolbar has the [built-in items](./tool-bar/#built-in-toolbar-items) to execute Editing actions.
You can define this by using the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edittoolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edittoolbar.cs" %}
{% include code-snippet/grid/edit/edittoolbar/edittoolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edittoolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edittoolbar.cs" %}
{% include code-snippet/grid/edit/edittoolbar/edittoolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cell edit type and its params

The [`EditType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) is used to define the editor component for any particular column.

You can set the [`EditType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) based on data type of the column.

* **NumericTextBox** component for integers, double, and decimal data types.

* **TextBox** component for string data type.

* **DropDownList** component to show all unique values related to that field.

* **CheckBox** component for boolean data type.

* **DatePicker** component for date data type.

* **DateTimePicker** component for date time data type.

Also, you can customize the behavior of the editor component through **Params** of [`Edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property in [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

The following table describes cell edit type and their corresponding edit params of the column.

Component |Example
-----|-----
`NumericTextBox` | params: { decimals: 2, value: 5 }
`DropDownList` | params: { value: 'Germany' }
`Checkbox` | params: { checked: true}
`DatePicker` | params: { format:'dd.MM.yyyy' }
`DateTimePicker` | params: { value: new Date() }

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celleditparams/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Celleditparams.cs" %}
{% include code-snippet/grid/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celleditparams/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Celleditparams.cs" %}
{% include code-snippet/grid/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If edit type is not defined in the column, then it will be considered as the **stringedit** type (Textbox component) .

## Cell Edit Template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create the custom component or assign default value at the time of editing.

* **read** - It is used to read the value from the component at the time of save.

* **destroy** - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celledittemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Celledittemplate.cs" %}
{% include code-snippet/grid/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celledittemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Celledittemplate.cs" %}
{% include code-snippet/grid/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Edit Modes

Grid supports the following types of edit modes, they are:

* Normal
* Dialog
* Batch

### Normal

In Normal edit mode, when you start editing the currently selected record is changed to edit state.
You can change the cell values and save edited data to the data source.
To enable Normal edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Normal**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/grid/edit/inline/inline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/inline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/grid/edit/inline/inline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Normal edit mode is default mode of editing.

### Automatically update the column based on another column edited value

You can update the column value based on another column edited value by using the Cell Edit Template feature.

In the below demo, we have update the `TotalCost` column value based on the `UnitPrice` and `UnitInStock` column value while editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/autoupdate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autoupdate.cs" %}
{% include code-snippet/grid/edit/autoupdate/autoupdate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/autoupdate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autoupdate.cs" %}
{% include code-snippet/grid/edit/autoupdate/autoupdate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Cancel edit based on condition

You can prevent the CRUD operations of the Grid by using condition in the `actionBegin` event with requestType as `beginEdit` for editing, `add` for adding and `delete` for deleting actions.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditinline.cs" %}
{% include code-snippet/grid/edit/cancel-edit-inline/canceleditinline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-inline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditinline.cs" %}
{% include code-snippet/grid/edit/cancel-edit-inline/canceleditinline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Perform CRUD action programmatically

Grid methods can be used to perform CRUD operations programmatically. The `addRecord`, `deleteRecord`, and `startEdit` methods are used to perform CRUD operations in the following demo.

* To add a new record to the Grid, use the `addRecord` method. In this method, you can pass the data parameter to add a new record to the Grid, and the index parameter to add a record at a specific index. If you call this method with no parameters, it will create an empty row in the Grid.

* To change the selected row to the edit state, use the `startEdit` method.

* If you need to update the row data in the Grid’s datasource, you can use the `updateRow` method. In this method, you need to pass the index value of the row to be updated along with the updated data.

* If you need to update the particular cell in the row, you can use the `setCellValue` method. In this method, you need to pass the primary key value of the data source, field name, and new value for the particular cell.

* To remove a selected row from the Grid, use the `deleteRecord` method. For both edit and delete operations, you must select a row first.

> In both normal and dialog editing modes, these methods can be used.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/programmatic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Programmatic.cs" %}
{% include code-snippet/grid/edit/programmatic/programmatic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/programmatic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Programmatic.cs" %}
{% include code-snippet/grid/edit/programmatic/programmatic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dialog

In dialog edit mode, when you start editing the currently selected row data will be shown on a dialog.
You can change the cell values and save edited data to the data source.
To enable Dialog edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Batch

In batch edit mode, when you double-click on the grid cell, then the target cell changed to edit state.
You can bulk save (added, changed and deleted data in the single request) to data source by click on the toolbar's **Update** button or by externally calling the **batchSave** method.
To enable Batch edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Batch**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batch/batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batch/batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Cancel edit based on condition in Batch mode

You can prevent the CRUD operations of the Batch edit Grid by using condition in the `cellEdit`, `beforeBatchAdd` and `beforeBatchDelete` events for Edit, Add and Delete actions respectively.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditbatch.cs" %}
{% include code-snippet/grid/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cancel-edit-batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Canceleditbatch.cs" %}
{% include code-snippet/grid/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dialog/Inline template

The dialog template editing provides an option to customize the default behavior of dialog editing. Using the dialog template, you can render your own editors by defining the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog/Inline** and [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

In some cases, you need to add the new field editors in the dialog which are not present in the column model. In that situation, the template will help you to customize the default edit dialog.

In the below code example, demonstrate the usage of binding a partial view in the dialog template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialogtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Addpatial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="AddpatialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogtemplatemodel.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogtemplatemodel.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartialMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialogtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Addpatial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="AddpatialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogtemplatemodel.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogtemplatemodel.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartialMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The Dialog/Inline template form editors should have **name** attribute.

### Reading Values From Editors

You can read, format and update the current editor value in the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin)event at the time of **requestType** as **save**.

In the below code example, we have format and updated the **freight** value.

``` typescript
    function actionBegin(args) {
        if (args.requestType === 'save') {
            // cast string to integer value.
            args.data['Freight'] = parseFloat(args.form.querySelector("#Freight").value);
        }
    }

```

### Set focus to editor

By default, the first input element in the dialog will be focused while opening the dialog.
If the first input element is in disabled or hidden state, focus the valid input element in the
[`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete)
event based on **requestType** as **beginEdit**.

```typescript

    function actionComplete(args) {
        // Set initail Focus
        if (args.requestType === 'beginEdit') {
            (args.form.elements.namedItem('CustomerID')).focus();
        }
    }

```

### Adding validation rules for custom editors

If you have used additional fields that are not present in the column model, then add the validation rules to the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

```typescript

    function actionComplete(args) => {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Add Validation Rules
            args.form.ej2_instances[0].addRules('Freight', {max: 500});
        }
    }

```

## Adding a new row at the Bottom of the Grid

By default, a new row will be added at the top of the grid. You can change it by setting [`NewRowPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Bottom**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/rowposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowposition.cs" %}
{% include code-snippet/grid/edit/rowposition/rowposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/rowposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowposition.cs" %}
{% include code-snippet/grid/edit/rowposition/rowposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Add newRowPostion is supported for **Normal** and **Batch** editing modes.

## Command column

The command column provides an option to add CRUD action buttons in a column. This can be defined by the [`Commands`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Commands) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

The available built-in command buttons are:

| Command Button | Actions |
|----------------|---------|
| Edit | Edit the current row.|
| Delete | Delete the current row.|
| Save | Update the edited row.|
| Cancel | Cancel the edited state. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/commandcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/grid/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/commandcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/grid/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Custom command

The custom command buttons can be added in a column by using the [`Commands`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Commands) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) and
the action for the custom buttons can be defined using **commandClick** event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customcommand/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/grid/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customcommand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/grid/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Confirmation messages

### Delete confirmation

The delete confirm dialog can be shown when deleting a record by defining the [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/deleteconfirm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Deleteconfirm.cs" %}
{% include code-snippet/grid/edit/deleteconfirm/deleteconfirm.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/deleteconfirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Deleteconfirm.cs" %}
{% include code-snippet/grid/edit/deleteconfirm/deleteconfirm.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) supports all type of edit modes.

### Batch confirmation

By default, grid will show the confirm dialog when saving or cancelling or performing any actions like filtering, sorting, etc.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchconfirm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batchconfirm.cs" %}
{% include code-snippet/grid/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchconfirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batchconfirm.cs" %}
{% include code-snippet/grid/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html)requires the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) to be **Batch**.
> If [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) set to **false**, then confirmation dialog does not display in batch editing.

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data. Grid uses **Form Validator** component for column validation.
You can set validation rules by defining the [`ValidationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ValidationRules).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/columnvalid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvalid.cs" %}
{% include code-snippet/grid/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/columnvalid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvalid.cs" %}
{% include code-snippet/grid/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Persisting data in server

Edited data can be persisted in the database using the RESTful web services.

All the CRUD operations in the grid are done through **DataManager**. The **DataManager** has an option to bind all the CRUD related data in server-side.

> For your information, the ODataAdaptor persists data in the server as per OData protocol.

In the below section, we have explained how to get the edited data details on the server-side using the **UrlAdaptor**.

### URL adaptor

You can use the **UrlAdaptor** of **DataManager** when binding data source from remote data.
In the initial load of grid, data are fetched from remote data and bound to the grid using **url** property of **DataManager**.
You can map The CRUD operation in grid can be mapped to server-side Controller actions using the properties **InsertUrl**, **RemoveUrl**, **UpdateUrl**, **CrudUrl** and **BatchUrl**.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Also, when using the **UrlAdaptor**, you need to return the data as JSON from the controller action and the JSON object must contain a property as **result** with dataSource as its value and one more property **count** with the dataSource total records count as its value.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrladaptorMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Insert record

Using the **InsertUrl** property, you can specify the controller action mapping URL to perform insert operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InsertMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InsertMVC.cs" %}
{% include code-snippet/grid/edit/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The newly added record details are bound to the **Object** parameter. Please refer to the following screenshot.

![insert](./images/insertURL.jpg)

### Update record

Using the **UpdateUrl** property, the controller action mapping URL can be specified to perform save/update operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Update.cs" %}
{% include code-snippet/grid/edit/urladaptor/update.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Update.cs" %}
{% include code-snippet/grid/edit/urladaptor/update.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The updated record details are bound to the **Object** parameter. Please refer to the following screenshot.

![update](./images/updateURL.jpg)

### Delete record

Using the **RemoveUrl** property, the controller action mapping URL can be specified to perform delete operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Delete.cs" %}
{% include code-snippet/grid/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Delete.cs" %}
{% include code-snippet/grid/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The deleted record primary key value is bound to the **key** parameter. Please refer to the following screenshot.

![delete](./images/deleteURL.jpg)

### CRUD URL

Using the **CrudUrl** property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The action parameter of **CrudUrl** is used to get the corresponding CRUD action.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/crudurl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Crudurl.cs" %}
{% include code-snippet/grid/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/crudurl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Crudurl.cs" %}
{% include code-snippet/grid/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Please refer to the following screenshot to know about the action parameter.

![crudupdate](./images/crudURL.jpg)

> If you specify **InsertUrl** along with **CrudUrl**, then while adding **InsertUrl** only will be invoked.

### Batch URL

The **BatchUrl** property supports only for batch editing mode.
You can specify the controller action mapping URL to perform batch operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchurl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batchurl/batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchurl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batchurl/batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```typescript
public ActionResult BatchUpdate([FromBody]string action, List<EditableOrder> added, List<EditableOrder> changed, List<EditableOrder> deleted, int? key)
{
//Save the batch changes in database
}
```

![batch](./images/batchURL.jpg)

## Default column values on add new

The grid provides an option to set the default value for the columns when adding a new record in it.
To set a default value for the particular column by defining the [`DefaultValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DefaultValue) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/defaultcolumnvalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultcolumnvalue.cs" %}
{% include code-snippet/grid/edit/defaultcolumnvalue/defaultcolumnvalue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/defaultcolumnvalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultcolumnvalue.cs" %}
{% include code-snippet/grid/edit/defaultcolumnvalue/defaultcolumnvalue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom validation

You can define your own custom validation rules for the specific columns by using **Form Validator custom rules**.

In the below demo, custom validation applied for **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customvalidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalidation.cs" %}
{% include code-snippet/grid/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customvalidation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalidation.cs" %}
{% include code-snippet/grid/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Disable editing for particular column

You can disable editing for particular columns by using the [`AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

In the following demo, editing is disabled for the **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/disableeditforcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disableeditforcolumn.cs" %}
{% include code-snippet/grid/edit/disableeditforcolumn/disableeditforcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/disableeditforcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disableeditforcolumn.cs" %}
{% include code-snippet/grid/edit/disableeditforcolumn/disableeditforcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Troubleshoot: Editing works only for first row

The Editing functionalities can be performed based upon the primary key value of the selected row.
If [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) is not defined in the grid, then edit or delete action take places the first row.

## See also

* [Editing with template column](./how-to/editing-with-template-column)
* [Customize dialog when editing](./how-to/customize-the-edit-dialog)
* [Cascading DropDownList with Grid Editing](./how-to/provide-custom-data-source-and-enabling-filtering-to-drop-down-list)
* [Access Editor components](./how-to/access-editor-components)
* [Customize the Edit Dialog](./how-to/customize-the-edit-dialog)
* [Wizard Like Editing](./how-to/use-wizard-like-dialog-editing)
* [Tab Inside the Dialog Template](./how-to/using-tab-inside-the-dialog-editing)
* [Restrict to type decimal points in a NumericTextBox while editing the numeric column](./how-to/restrict-decimal-points-while-grid-editing)
* [Update column value based on other column values in ASP.NET MVC Grid](https://www.syncfusion.com/forums/144466/update-column-value-based-on-other-column-values-in-asp-net-mvc-grid)
* [Populate field depending the value selected from another field in ASP.NET MVC Grid](https://www.syncfusion.com/forums/154658/populate-field-depending-the-value-selected-from-another-field-in-asp-net-mvc-grid)
* [How to apply two different validation in same column in ASP.NET MVC Grid](https://www.syncfusion.com/forums/154038/how-to-apply-two-different-validation-in-same-column-in-asp-net-mvc-grid)
* [Using Uploader and Textarea in the Grid when edit record in ASP.NET MVC Grid](https://www.syncfusion.com/forums/139251/using-uploader-and-textarea-in-the-grid-when-edit-record-in-asp-net-mvc-grid)
