---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Edit of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Edit
publishingplatform: ##Platform_Name##
documentation: ug
---

`NumericTextBox` | params: { decimals: 2, value: 5 }
`DropDownList` | params: { value: 'Germany' }
`Checkbox` | params: { checked: true}
`DatePicker` | params: { format:'dd.MM.yyyy' }
`DateTimePicker` | params: { value: new Date() }

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="celleditparams" %}
{% include_relative code-snippet/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="celleditparams" %}
{% include_relative code-snippet/edit/celleditparams/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="celleditparams" %}
{% include_relative code-snippet/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% highlight razor tabtitle="celleditparams" %}
{% include_relative code-snippet/edit/celleditparams/razor %}
{% endhighlight %}
{% endtabs %}



> If edit type is not defined in the column, then it will be considered as the **stringedit** type (Textbox component) .

## Cell Edit Template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create the custom component or assign default value at the time of editing.

* **read** - It is used to read the value from the component at the time of save.

* **destroy** - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="celledittemplate" %}
{% include_relative code-snippet/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="celledittemplate" %}
{% include_relative code-snippet/edit/celledittemplate/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="celledittemplate" %}
{% include_relative code-snippet/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% highlight razor tabtitle="celledittemplate" %}
{% include_relative code-snippet/edit/celledittemplate/razor %}
{% endhighlight %}
{% endtabs %}



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
{% highlight c# tabtitle="inline" %}
{% include_relative code-snippet/edit/inline/inline.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="inline" %}
{% include_relative code-snippet/edit/inline/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="inline" %}
{% include_relative code-snippet/edit/inline/inline.cs %}
{% endhighlight %}
{% highlight razor tabtitle="inline" %}
{% include_relative code-snippet/edit/inline/razor %}
{% endhighlight %}
{% endtabs %}



> Normal edit mode is default mode of editing.

### Automatically update the column based on another column edited value

You can update the column value based on another column edited value by using the Cell Edit Template feature.

In the below demo, we have update the `TotalCost` column value based on the `UnitPrice` and `UnitInStock` column value while editing.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="autoupdate" %}
{% include_relative code-snippet/edit/autoupdate/autoupdate.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="autoupdate" %}
{% include_relative code-snippet/edit/autoupdate/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="autoupdate" %}
{% include_relative code-snippet/edit/autoupdate/autoupdate.cs %}
{% endhighlight %}
{% highlight razor tabtitle="autoupdate" %}
{% include_relative code-snippet/edit/autoupdate/razor %}
{% endhighlight %}
{% endtabs %}



#### Cancel edit based on condition

You can prevent the CRUD operations of the Grid by using condition in the `actionBegin` event with requestType as `beginEdit` for editing, `add` for adding and `delete` for deleting actions.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="cancel-edit-inline" %}
{% include_relative code-snippet/edit/cancel-edit-inline/canceleditinline.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="cancel-edit-inline" %}
{% include_relative code-snippet/edit/cancel-edit-inline/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="cancel-edit-inline" %}
{% include_relative code-snippet/edit/cancel-edit-inline/canceleditinline.cs %}
{% endhighlight %}
{% highlight razor tabtitle="cancel-edit-inline" %}
{% include_relative code-snippet/edit/cancel-edit-inline/razor %}
{% endhighlight %}
{% endtabs %}



#### Perform CRUD action programmatically

Grid methods can be used to perform CRUD operations programmatically. The `addRecord`, `deleteRecord`, and `startEdit` methods are used to perform CRUD operations in the following demo.

* To add a new record to the Grid, use the `addRecord` method. In this method, you can pass the data parameter to add a new record to the Grid, and the index parameter to add a record at a specific index. If you call this method with no parameters, it will create an empty row in the Grid.

* To change the selected row to the edit state, use the `startEdit` method.

* If you need to update the row data in the Grid’s datasource, you can use the `updateRow` method. In this method, you need to pass the index value of the row to be updated along with the updated data.

* If you need to update the particular cell in the row, you can use the `setCellValue` method. In this method, you need to pass the primary key value of the data source, field name, and new value for the particular cell.

* To remove a selected row from the Grid, use the `deleteRecord` method. For both edit and delete operations, you must select a row first.

> **Note:** In both normal and dialog editing modes, these methods can be used.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="programmatic" %}
{% include_relative code-snippet/edit/programmatic/programmatic.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="programmatic" %}
{% include_relative code-snippet/edit/programmatic/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="programmatic" %}
{% include_relative code-snippet/edit/programmatic/programmatic.cs %}
{% endhighlight %}
{% highlight razor tabtitle="programmatic" %}
{% include_relative code-snippet/edit/programmatic/razor %}
{% endhighlight %}
{% endtabs %}



### Dialog

In dialog edit mode, when you start editing the currently selected row data will be shown on a dialog.
You can change the cell values and save edited data to the data source.
To enable Dialog edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="dialog" %}
{% include_relative code-snippet/edit/dialog/dialog.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="dialog" %}
{% include_relative code-snippet/edit/dialog/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="dialog" %}
{% include_relative code-snippet/edit/dialog/dialog.cs %}
{% endhighlight %}
{% highlight razor tabtitle="dialog" %}
{% include_relative code-snippet/edit/dialog/razor %}
{% endhighlight %}
{% endtabs %}



### Batch

In batch edit mode, when you double-click on the grid cell, then the target cell changed to edit state.
You can bulk save (added, changed and deleted data in the single request) to data source by click on the toolbar's **Update** button or by externally calling the **batchSave** method.
To enable Batch edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Batch**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="batch" %}
{% include_relative code-snippet/edit/batch/batch.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="batch" %}
{% include_relative code-snippet/edit/batch/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="batch" %}
{% include_relative code-snippet/edit/batch/batch.cs %}
{% endhighlight %}
{% highlight razor tabtitle="batch" %}
{% include_relative code-snippet/edit/batch/razor %}
{% endhighlight %}
{% endtabs %}



#### Cancel edit based on condition in Batch mode

You can prevent the CRUD operations of the Batch edit Grid by using condition in the `cellEdit`, `beforeBatchAdd` and `beforeBatchDelete` events for Edit, Add and Delete actions respectively.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="cancel-edit-batch" %}
{% include_relative code-snippet/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="cancel-edit-batch" %}
{% include_relative code-snippet/edit/cancel-edit-batch/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="cancel-edit-batch" %}
{% include_relative code-snippet/edit/cancel-edit-batch/canceleditbatch.cs %}
{% endhighlight %}
{% highlight razor tabtitle="cancel-edit-batch" %}
{% include_relative code-snippet/edit/cancel-edit-batch/razor %}
{% endhighlight %}
{% endtabs %}



## Dialog/Inline template

The dialog template editing provides an option to customize the default behavior of dialog editing. Using the dialog template, you can render your own editors by defining the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog/Inline** and [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

In some cases, you need to add the new field editors in the dialog which are not present in the column model. In that situation, the template will help you to customize the default edit dialog.

In the below code example, demonstrate the usage of binding a partial view in the dialog template.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="dialogtemplate" %}
{% include_relative code-snippet/edit/dialogtemplate/*dialog.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="dialogtemplate" %}
{% include_relative code-snippet/edit/dialogtemplate/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="dialogtemplate" %}
{% include_relative code-snippet/edit/dialogtemplate/*dialog.cs %}
{% endhighlight %}
{% highlight razor tabtitle="dialogtemplate" %}
{% include_relative code-snippet/edit/dialogtemplate/razor %}
{% endhighlight %}
{% endtabs %}



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
{% highlight c# tabtitle="rowposition" %}
{% include_relative code-snippet/edit/rowposition/rowposition.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="rowposition" %}
{% include_relative code-snippet/edit/rowposition/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="rowposition" %}
{% include_relative code-snippet/edit/rowposition/rowposition.cs %}
{% endhighlight %}
{% highlight razor tabtitle="rowposition" %}
{% include_relative code-snippet/edit/rowposition/razor %}
{% endhighlight %}
{% endtabs %}



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
{% highlight c# tabtitle="commandcolumn" %}
{% include_relative code-snippet/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="commandcolumn" %}
{% include_relative code-snippet/edit/commandcolumn/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="commandcolumn" %}
{% include_relative code-snippet/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% highlight razor tabtitle="commandcolumn" %}
{% include_relative code-snippet/edit/commandcolumn/razor %}
{% endhighlight %}
{% endtabs %}



### Custom command

The custom command buttons can be added in a column by using the [`Commands`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Commands) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) and
the action for the custom buttons can be defined using **commandClick** event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="customcommand" %}
{% include_relative code-snippet/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="customcommand" %}
{% include_relative code-snippet/edit/customcommand/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="customcommand" %}
{% include_relative code-snippet/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% highlight razor tabtitle="customcommand" %}
{% include_relative code-snippet/edit/customcommand/razor %}
{% endhighlight %}
{% endtabs %}



## Confirmation messages

### Delete confirmation

The delete confirm dialog can be shown when deleting a record by defining the [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) as **true**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="deleteconfirm" %}
{% include_relative code-snippet/edit/deleteconfirm/deleteconfirm.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="deleteconfirm" %}
{% include_relative code-snippet/edit/deleteconfirm/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="deleteconfirm" %}
{% include_relative code-snippet/edit/deleteconfirm/deleteconfirm.cs %}
{% endhighlight %}
{% highlight razor tabtitle="deleteconfirm" %}
{% include_relative code-snippet/edit/deleteconfirm/razor %}
{% endhighlight %}
{% endtabs %}



> The [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) supports all type of edit modes.

### Batch confirmation

By default, grid will show the confirm dialog when saving or cancelling or performing any actions like filtering, sorting, etc.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="batchconfirm" %}
{% include_relative code-snippet/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="batchconfirm" %}
{% include_relative code-snippet/edit/batchconfirm/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="batchconfirm" %}
{% include_relative code-snippet/edit/batchconfirm/batchconfirm.cs %}
{% endhighlight %}
{% highlight razor tabtitle="batchconfirm" %}
{% include_relative code-snippet/edit/batchconfirm/razor %}
{% endhighlight %}
{% endtabs %}



> [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html)requires the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) to be **Batch**.
> If [`ShowConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) set to **false**, then confirmation dialog does not display in batch editing.

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data. Grid uses **Form Validator** component for column validation.
You can set validation rules by defining the [`ValidationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ValidationRules).

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="columnvalid" %}
{% include_relative code-snippet/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="columnvalid" %}
{% include_relative code-snippet/edit/columnvalid/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="columnvalid" %}
{% include_relative code-snippet/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% highlight razor tabtitle="columnvalid" %}
{% include_relative code-snippet/edit/columnvalid/razor %}
{% endhighlight %}
{% endtabs %}



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
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% highlight razor tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/razor %}
{% endhighlight %}
{% endtabs %}



Also, when using the **UrlAdaptor**, you need to return the data as JSON from the controller action and the JSON object must contain a property as **result** with dataSource as its value and one more property **count** with the dataSource total records count as its value.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/urladaptorMVC.cs %}
{% endhighlight %}
{% highlight razor tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/razor %}
{% endhighlight %}
{% endtabs %}



### Insert record

Using the **InsertUrl** property, you can specify the controller action mapping URL to perform insert operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/insertMVC.cs %}
{% endhighlight %}
{% highlight razor tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/razor %}
{% endhighlight %}
{% endtabs %}



The newly added record details are bound to the **Object** parameter. Please refer to the following screenshot.

![insert](./images/insertURL.jpg)

### Update record

Using the **UpdateUrl** property, the controller action mapping URL can be specified to perform save/update operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/update.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/update.cs %}
{% endhighlight %}
{% highlight razor tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/razor %}
{% endhighlight %}
{% endtabs %}



The updated record details are bound to the **Object** parameter. Please refer to the following screenshot.

![update](./images/updateURL.jpg)

### Delete record

Using the **RemoveUrl** property, the controller action mapping URL can be specified to perform delete operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% highlight razor tabtitle="urladaptor" %}
{% include_relative code-snippet/edit/urladaptor/razor %}
{% endhighlight %}
{% endtabs %}



The deleted record primary key value is bound to the **key** parameter. Please refer to the following screenshot.

![delete](./images/deleteURL.jpg)

### CRUD URL

Using the **CrudUrl** property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The action parameter of **CrudUrl** is used to get the corresponding CRUD action.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="crudurl" %}
{% include_relative code-snippet/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="crudurl" %}
{% include_relative code-snippet/edit/crudurl/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="crudurl" %}
{% include_relative code-snippet/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% highlight razor tabtitle="crudurl" %}
{% include_relative code-snippet/edit/crudurl/razor %}
{% endhighlight %}
{% endtabs %}



Please refer to the following screenshot to know about the action parameter.

![crudupdate](./images/crudURL.jpg)

> If you specify **InsertUrl** along with **CrudUrl**, then while adding **InsertUrl** only will be invoked.

### Batch URL

The **BatchUrl** property supports only for batch editing mode.
You can specify the controller action mapping URL to perform batch operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="batchurl" %}
{% include_relative code-snippet/edit/batchurl/batch.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="batchurl" %}
{% include_relative code-snippet/edit/batchurl/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="batchurl" %}
{% include_relative code-snippet/edit/batchurl/batch.cs %}
{% endhighlight %}
{% highlight razor tabtitle="batchurl" %}
{% include_relative code-snippet/edit/batchurl/razor %}
{% endhighlight %}
{% endtabs %}



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
{% highlight c# tabtitle="defaultcolumnvalue" %}
{% include_relative code-snippet/edit/defaultcolumnvalue/defaultcolumnvalue.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="defaultcolumnvalue" %}
{% include_relative code-snippet/edit/defaultcolumnvalue/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="defaultcolumnvalue" %}
{% include_relative code-snippet/edit/defaultcolumnvalue/defaultcolumnvalue.cs %}
{% endhighlight %}
{% highlight razor tabtitle="defaultcolumnvalue" %}
{% include_relative code-snippet/edit/defaultcolumnvalue/razor %}
{% endhighlight %}
{% endtabs %}



## Custom validation

You can define your own custom validation rules for the specific columns by using **Form Validator custom rules**.

In the below demo, custom validation applied for **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="customvalidation" %}
{% include_relative code-snippet/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="customvalidation" %}
{% include_relative code-snippet/edit/customvalidation/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="customvalidation" %}
{% include_relative code-snippet/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% highlight razor tabtitle="customvalidation" %}
{% include_relative code-snippet/edit/customvalidation/razor %}
{% endhighlight %}
{% endtabs %}



## Disable editing for particular column

You can disable editing for particular columns by using the [`AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

In the following demo, editing is disabled for the **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="disableeditforcolumn" %}
{% include_relative code-snippet/edit/disableeditforcolumn/disableeditforcolumn.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="disableeditforcolumn" %}
{% include_relative code-snippet/edit/disableeditforcolumn/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="disableeditforcolumn" %}
{% include_relative code-snippet/edit/disableeditforcolumn/disableeditforcolumn.cs %}
{% endhighlight %}
{% highlight razor tabtitle="disableeditforcolumn" %}
{% include_relative code-snippet/edit/disableeditforcolumn/razor %}
{% endhighlight %}
{% endtabs %}



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
