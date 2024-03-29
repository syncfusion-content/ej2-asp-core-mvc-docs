---
layout: post
title: Managing Tasks in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Managing Tasks in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Managing Tasks in ##Platform_Name## Gantt Component

The Gantt component has options to dynamically insert, delete, and update tasks in the project. The primary key column is necessary to manage the tasks and perform CRUD operations in Gantt. To define the primary key, set the [`Columns.IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) property to `true` in the particular column.

The following code example shows you how to enable the cell editing in Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableCellEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCellEditing.cs" %}
{% include code-snippet/gantt/editing/enableCellEditing/enableCellEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableCellEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCellEditing.cs" %}
{% include code-snippet/gantt/editing/enableCellEditing/enableCellEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cell edit type and its params

The [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) is used to define the edit type for any particular column. You can set the [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) based on data type of the column.

* `numeric edit` - [`NumericTextBox`](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/ej1-api-migration) component for integers, double, and decimal data types.

* `default edit` - [`TextBox`](https://ej2.syncfusion.com/aspnetmvc/documentation/textbox/getting-started) component for string data type.

* `dropdown edit` - [`DropDownList`](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component to show all unique values related to that field.

* `boolean edit` - [`CheckBox`](https://ej2.syncfusion.com/aspnetmvc/documentation/check-box/getting-started) component for boolean data type.

* `date picker edit` - [`DatePicker`](https://ej2.syncfusion.com/aspnetmvc/documentation/datepicker/getting-started) component for date data type.

* `date time picker edit` - [`DateTimePicker`](https://ej2.syncfusion.com/aspnetmvc/documentation/datetimepicker/getting-started) component for date time data type.

Also, you can customize the behavior of the editor component through the [`columns.edit.params`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Edit).

The following table describes cell edit type component and their corresponding edit params of the column.

|Edit Type |Component |Example|
|-----|-----|-----|
|`numericedit` | [`NumericTextBox`](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/ej1-api-migration) | params: { decimals: 2, value: 5 }|
|`dropdownedit` | [`DropDownList`](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) | params: { value: 'Germany' }|
|`booleanedit` | [`Checkbox`](https://ej2.syncfusion.com/aspnetmvc/documentation/check-box/getting-started) | params: { checked: true}|
|`datepickeredit` | [`DatePicker`](https://ej2.syncfusion.com/aspnetmvc/documentation/datepicker/getting-started) | params: { format:'dd.MM.yyyy' }|
|`datetimepickeredit` | [`DateTimePicker`](https://ej2.syncfusion.com/aspnetmvc/documentation/datetimepicker/getting-started) | params: { value: new Date() }|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editParams/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditParams.cs" %}
{% include code-snippet/gantt/editing/editParams/editParams.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editParams/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditParams.cs" %}
{% include code-snippet/gantt/editing/editParams/editParams.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/editParams.png)

## Cell edit template

The cell edit template is used to create a custom component for a particular column by invoking the following functions:

* `create` - It is used to create the element at the time of initialization.

* `write` - It is used to create the custom component or assign default value at the time of editing.

* `read` - It is used to read the value from the component at the time of save.

* `destroy` - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/gantt/editing/editTemplate/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/gantt/editing/editTemplate/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/editTemplate.png)

## Disable editing for particular column

You can disable editing for particular columns, by using the [`columns.allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowEditing) property.

In the following demo, editing is disabled for the `TaskName` column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/disableEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisableEditing.cs" %}
{% include code-snippet/gantt/editing/disableEditing/disableEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/disableEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisableEditing.cs" %}
{% include code-snippet/gantt/editing/disableEditing/disableEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Read-only gantt

In Gantt, all create, update, delete operations can be disabled by setting `readOnly` property as `true`. The following sample demonstrates, render Gantt chart as read only.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/readOnly.PNG)

![Alt text](images/readOnlyEdit.png)

## Open new task dialog with default values

You can set default values when new task dialog opens using [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) event when `requestType` is `beforeOpenAddDialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Gantt new task dialog with default values](images/task-dialog-with-default-values.png)


## Customize control in add/edit dialog

In Gantt Chart, the controls such as form elements, grid and RTE in add and edit dialog can be customized by using [AdditionalParams](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogField.html#Syncfusion_EJ2_Gantt_Gantt_AdditionalParams) property.

### Customize general tab of dialog 

In the general tab of add/edit dialog, the custom input [Fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogField.html#Syncfusion_EJ2_Gantt_Gantt_Fields) can be included into fields by defining the field names either from the data source or template in [AddDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogFields.html) and [EditDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditDialogFields.html) respectively.

In the below sample, added field from the template to general tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value1/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value1/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Customize dependency, segments and resources tab of dialog 

[Grid](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html) component in the dependency, segment and resource tab of add/edit dialog can be customized, by defining grid module properties in the [AdditionalParams](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogField.html#Syncfusion_EJ2_Gantt_Gantt_AdditionalParams) property of [AddDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogFields.html) and [EditDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditDialogFields.html).

In the below code show cases, how to add additional features to dependency, segments and resources tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value2/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value2/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Customize note dialog tab

 [RTE](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html) component in notes tab of add and edit dialog can be customized, by defining RTE module properties in the [AdditionalParams](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogField.html#Syncfusion_EJ2_Gantt_Gantt_AdditionalParams) property of [AddDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttAddDialogFields.html) and [EditDialogFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditDialogFields.html).

The below code shows how to enable inline mode to RTE in notes tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value3/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value3/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Troubleshoot: Editing works only when primary key column is defined

Editing feature requires a primary key column for CRUD operations. While defining columns in Gantt using the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property, it is mandatory that any one of the columns, must be a primary column. By default, the [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column will be the primary key column.  If [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column is not defined, we need to enable [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) for any one of the columns defined in the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property.

## Touch interaction

The Gantt control editing actions can be achieved using the double tap and tap and drag actions on a element.

The following table describes different types of editing modes available in Gantt.

|Action |Description|
|-----|-----|
|[`Cell editing`](managing-tasks/#cell-editing) | To perform `double tap` on a specific cell, initiate the cell to be in edit state.|
|[`Dialog editing`](managing-tasks/#dialog-editing) | To perform `double tap` on a specific row, initiate the edit dialog to be opened.|
|[`Taskbar editing`](managing-tasks/#taskbar-editing) | Taskbar editing action is initiated using the `tap` action on the taskbar. <br> **Parent taskbar** : Once you tap on the parent taskbar, it will be changed to editing state. Perform only dragging action on parent taskbar editing. <br> ![Alt text](../images/editing-parent.PNG) <br> **Child taskbar** : Once you tap the child taskbar, it will be changed to editing state. <br> ![Alt text](../images/editing-state.PNG) <br> **Dragging taskbar** : To drag a taskbar to the left or right in editing state. <br> <br> **Resizing taskbar** : To resize a taskbar, drag the left/right resize icon. <br> <br> **Progress resizing** : To change the progress, drag the progress resize icon to the left or right direction.|

### Task dependency editing

You can `tap` the left/right connector point to initiate [`task dependencies`](managing-tasks/#task-dependencies) edit mode and again tap another taskbar to establish the dependency line between two taskbars.

The following table explains the taskbar state in dependency edit mode.

![Taskbar states](../images/taskbar-states.png)

|Taskbar state |Description|
|-----|-----|
|`Parent taskbar` | You cannot create dependency relationship to parent tasks. <br> ![Parent taskbar](../images/parent-taskbar.PNG)|
|`Taskbar without dependency` |  If you tap a valid child taskbar, it will create `FS` type dependency line between tasks, otherwise exits from task dependency edit mode. <br> ![Valid taskbar](../images/valid-taskbar.PNG)|
|`Taskbar with dependency` | If you tap the second taskbar, which has already been directly connected, it will ask to remove it. <br> ![Invalid taskbar](../images/invalid-taskbar.PNG)|
|`Removing dependency` | Once you tap the taskbar with direct dependency, then confirmation dialog will be shown for removing dependency. <br> ![Confirm dialog](../images/confirm-dialog.PNG)|

N> In mobile device, you cannot create dependency other than `FS` by taskbar editing. By using cell/dialog editing, you can add all type of dependencies.

## Taskbar editing tooltip

The taskbar editing tooltip can be customized using the [`TooltipSettings.Editing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTooltipSettings.html#Syncfusion_EJ2_Gantt_GanttTooltipSettings_Editing) property. The following code example shows how to customize the taskbar editing tooltip in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/editingTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditingTemplate.cs" %}
{% include code-snippet/gantt/tooltip/editingTemplate/editingTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/editingTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditingTemplate.cs" %}
{% include code-snippet/gantt/tooltip/editingTemplate/editingTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The below screenshot shows the output of above code example.

![Alt text](../images/editingTemplate.png)
