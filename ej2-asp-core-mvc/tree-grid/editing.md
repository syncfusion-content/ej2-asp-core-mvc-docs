---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Editing of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

[`NumericTextBox`](../numerictextbox) | params: { decimals: 2, value: 5 }
[`TextBox`](../textbox) | -
[`DropDownList`](../drop-down-list) | params: { value: 'Germany' }

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/tree-grid/editing/edit-type/editType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/tree-grid/editing/edit-type/editType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If edit type is not defined in the column, then it will be considered as the `stringedit` type (Textbox component).

## Cell Edit Template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* `create` - It is used to create the element at the time of initialization.

* `write` - It is used to create the custom component or assign default value at the time of editing.

* `read` - It is used to read the value from the component at the time of save.

* `destroy` - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/tree-grid/editing/edit-template/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/tree-grid/editing/edit-template/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Edit Modes

TreeGrid supports the following types of edit modes, they are:

* Cell
* Row
* Dialog

### Cell

In Cell edit mode, when you double click on a cell, it is changed to edit state.
You can change the cell value and save to the data source.
To enable Cell edit, set the [`EditSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as `Cell`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditCell.cs" %}
{% include code-snippet/tree-grid/editing/edit-cell/editCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditCell.cs" %}
{% include code-snippet/tree-grid/editing/edit-cell/editCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Cell edit mode is default mode of editing.

### Row

In Row edit mode, when you start editing the currently selected record, the entire row is changed to edit state.
You can change the cell values of the row and save edited data to the data source.
To enable Row edit, set the [`EditSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as `Row`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditRow.cs" %}
{% include code-snippet/tree-grid/editing/edit-row/editRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditRow.cs" %}
{% include code-snippet/tree-grid/editing/edit-row/editRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dialog

In Dialog edit mode, when you start editing the currently selected row, data will be shown on a dialog.
You can change the cell values and save edited data to the data source.
To enable Dialog edit, set the [`EditSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as `Dialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditDialog.cs" %}
{% include code-snippet/tree-grid/editing/edit-dialog/editDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditDialog.cs" %}
{% include code-snippet/tree-grid/editing/edit-dialog/editDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Batch

In Batch edit mode, when you double-click on the treegrid cell, the target cell goes into edit state.
You can bulk save (added, changed and deleted data in the single request) to data source by clicking on the toolbar's **Update** button or by externally invoking the [`batchSave`](../api/treegrid/#batchsave) method.
To enable Batch edit, set the [`EditSettings.Mode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as **Batch**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/batch-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batchedit.cs" %}
{% include code-snippet/tree-grid/editing/batch-edit/batchedit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batchedit.cs" %}
{% include code-snippet/tree-grid/editing/batch-edit/batchedit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dialog template

The dialog template editing provides an option to customize the default behavior of dialog editing. Using the dialog template, you can render your own editors by defining the [`EditSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as `Dialog` and [`Template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Template.html) as SCRIPT element ID or HTML string which holds the template.

In some cases, you need to add the new field editors in the dialog which are not present in the column model. In that situation, the dialog template will help you to customize the default edit dialog.

In the following sample, treegrid enabled with dialog template editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/dialog-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DialogTemplate.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/dialogTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="TemplateModel.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/templateModel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/dialog-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogTemplate.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/dialogTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="TemplateModel.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/templateModel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The template form editors should have **name** attribute.

### Get value from editor

You can read, format, and update the current editor value in the [`ActionBegin`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionBegin.html) event at the time of setting `requestType` to `save`.

In the following code example, the `progress` value has been formatted and updated.

``` typescript
    function actionBegin(args) {
        if (args.requestType === 'save') {
            // cast string to integer value.
            args.data['progress'] = parseFloat(args.form.querySelector("#progress").value);
        }
    }

```

### Set focus to editor

By default, the first input element in the dialog will be focused while opening the dialog.
If the first input element is in disabled or hidden state, focus the valid input element in the
[`ActionComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionComplete.html)
event based on `requestType` as `beginEdit`.

```typescript

    function actionComplete(args) {
        // Set initail Focus
        if (args.requestType === 'beginEdit') {
            (args.form.elements.namedItem('taskName')as HTMLInputElement).focus();
        }
    }

```

### Adding validation rules for custom editors

If you have used additional fields that are not present in the column model, then add the validation rules to the [`ActionComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionComplete.html) event.

```typescript

    function actionComplete(args: DialogEditEventArgs) {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Add Validation Rules
            args.form.ej2_instances[0].addRules('progress', {max: 100});
        }
    }

```

## Adding row position

The TreeGrid control provides the support to add the new row in the top, bottom, above selected row, below selected row and child position of tree grid content using [`EditSettings.NewRowPosition`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~NewRowPosition.html) property. By default, a new row will be added at the top of the treegrid.

The following examples shows how to set new row position as `Child` in tree grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/new-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NewRow.cs" %}
{% include code-snippet/tree-grid/editing/new-row/newRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/new-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NewRow.cs" %}
{% include code-snippet/tree-grid/editing/new-row/newRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Command column

The command column provides an option to add CRUD action buttons in a column. This can be defined by the [`Column.Commands`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Commands.html) property.

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
{% include code-snippet/tree-grid/editing/command-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/tree-grid/editing/command-columns/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/command-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/tree-grid/editing/command-columns/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Custom command

 The custom command buttons can be added in a column by using the [`Column.Commands`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Commands.html) property and
the action for the custom buttons can be defined in the `ButtonOption.Click` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-command/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/tree-grid/editing/custom-command/customcommand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-command/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/tree-grid/editing/custom-command/customcommand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Confirmation messages

### Delete confirmation

The delete confirm dialog can be shown when deleting a record by defining the [`showDeleteConfirmDialog`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~ShowDeleteConfirmDialog.html) as `true`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/delete-confirm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirm.cs" %}
{% include code-snippet/tree-grid/editing/delete-confirm/deleteConfirm.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/delete-confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirm.cs" %}
{% include code-snippet/tree-grid/editing/delete-confirm/deleteConfirm.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The `showDeleteConfirmDialog` supports all type of edit modes.

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data.
TreeGrid uses `Form Validator` component for column validation.
You can set validation rules by defining the [`Columns.ValidationRules`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValidationRules.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/validation-rules/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/validation-rules/validationRule.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/validation-rules/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/validation-rules/validationRule.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom validation

You can define your own custom validation rules for the specific columns by using `Form Validator custom rules`.

In the below demo, custom validation applied for `Priority` column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/custom-validation/validationRule.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/custom-validation/validationRule.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Default column values on add new

The treegrid provides an option to set the default value for the columns when adding a new record in it.
To set a default value for the particular column by defining the [`Columns.DefaultValue`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DefaultValue.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/default-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultvalue.cs" %}
{% include code-snippet/tree-grid/editing/default-value/defaultvalue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/default-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Defaultvalue.cs" %}
{% include code-snippet/tree-grid/editing/default-value/defaultvalue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Disable editing for particular column

You can disable editing for particular columns by using the [`Columns.AllowEditing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowEditing.html).

In the following demo, editing is disabled for the `Start Date` column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/disable-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/tree-grid/editing/disable-editing/disable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/disable-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% include code-snippet/tree-grid/editing/disable-editing/disable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Troubleshoot: Editing works only for first row

The Editing functionalities can be performed based upon the primary key value of the selected row.
If `IsPrimaryKey` is not defined in the treegrid, then edit or delete action take places the first row.