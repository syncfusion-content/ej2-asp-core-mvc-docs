---
layout: post
title: Managing Tasks in ##Platform_Name## Gantt Component
description: Learn here all about Managing Tasks in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Managing Tasks

The Gantt component has options to dynamically insert, delete, and update tasks in the project. The primary key column is necessary to manage the tasks and perform CRUD operations in Gantt. To define the primary key, set the [`Columns.IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) property to `true` in the particular column.

## Adding new tasks

Tasks can be dynamically added to the Gantt project by enabling the [`EditSettings.AllowAdding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowAdding) property.

### Toolbar

A row can be added to the Gantt component from the toolbar while the [`EditSettings.AllowAdding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowAdding) property is set to true. On clicking the toolbar add icon, you should provide the task information in the add dialog.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/addingRow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AddingRow.cs" %}
{% include code-snippet/gantt/rows/addingRow/addingRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/addingRow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AddingRow.cs" %}
{% include code-snippet/gantt/rows/addingRow/addingRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/addingRow.png)

> By default, the new row will be added to the top most row in the Gantt control.

### Context menu

A row can also be added above, below or child of the selected row by using context menu support. For this, we need to enable the property[`enableContextMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableContextMenu) and inject the `ContextMenu` module into the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/contextMenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ContextMenu.cs" %}
{% include code-snippet/gantt/rows/contextMenu/contextMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/contextMenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ContextMenu.cs" %}
{% include code-snippet/gantt/rows/contextMenu/contextMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/contextMenuAdd.png)

### Using method

You can add rows to the Gantt control dynamically using the `addRecord` method and you can define the add position of the default new record by using the [`RowPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.RowPosition.html) property. You can also pass the `RowIndex` as an additional parameter.

* Top of all the rows.
* Bottom to all the existing rows.
* Above the selected row.
* Below the selected row.
* As child to the selected row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/addRow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AddRow.cs" %}
{% include code-snippet/gantt/rows/addRow/addRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/addRow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AddRow.cs" %}
{% include code-snippet/gantt/rows/addRow/addRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/addRow.png)

## Editing tasks

The editing feature can be enabled in the Gantt control by enabling the [`EditSettings.AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowEditing) and [`EditSettings.AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) properties.

The following editing options are available to update the tasks in the Gantt chart:
* Cell
* Dialog
* Taskbar
* Dependency links

### Cell editing

By setting the edit mode to auto using the [`EditSettings.Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_Mode) property, the tasks can be edited through TreeGrid cells by double-clicking.

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



`Note:` When the edit mode is set to `Auto`, on performing double-click action on TreeGrid side, the cells will be changed to editable mode and on performing double-click action on chart side, the edit dialog will appear for editing the task details.

![Alt text](images/enableCellEditing1.png)

double click action on TreeGrid side

![Alt text](images/enableCellEditing2.png)

double click action on chart side

### Dialog editing

Modify the task details through the edit dialog by setting the edit mode to `Dialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableDialogEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDialogEditing.cs" %}
{% include code-snippet/gantt/editing/enableDialogEditing/enableDialogEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableDialogEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDialogEditing.cs" %}
{% include code-snippet/gantt/editing/enableDialogEditing/enableDialogEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



`Note:` In dialog editing mode, the edit dialog appears when performing double-click action on both TreeGrid or Gantt chart sides.

![Alt text](images/enableDialogEditing.png)

#### Sections or tabs in dialog

In the Gantt dialog, you can define the required tabs or editing sections using the [`AddDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AddDialogFields) and [`EditDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EditDialogFields) properties. Every tab is defined using the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.DialogFieldType.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-edit-dialogtab.cs" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/add-edit-dialogtab.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-edit-dialogtab.cs" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/add-edit-dialogtab.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/add-edit-dialogtab.png)

Tabs in Edit Dialog

![Alt text](images/add-dialogtab.png)

Tabs in Add Dialog

#### Limiting data fields in general tab

In the Gantt dialog, you can make only specific data source fields visible for editing by using the [`AddDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AddDialogFields) and [`EditDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EditDialogFields) properties. The data fields are defined with `Type` and `Fields` properties.

`Note:` You can also define the custom fields in the add/edit dialog General tab using the `Fields` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customfields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customfields.cs" %}
{% include code-snippet/gantt/editing/customfields/customfields.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customfields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customfields.cs" %}
{% include code-snippet/gantt/editing/customfields/customfields.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot show the output of above code example.

![Alt text](images/customfields.png)

### Taskbar editing

Modify the task details through user interaction such as resizing and dragging the taskbar by enabling the [`AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/enableTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/enableTaskbarEditing/enableTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Prevent editing for specific tasks

On taskbar edit action, the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event will be triggered. You can prevent the taskbar from editing using the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event. This can be done by setting cancel property of [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event argument to true. And we can hide the taskbar editing indicators like taskbar resizer, progress resizer and connector points by using [`QueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryTaskbarInfo) event.  The following code example shows how to achieve this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PreventTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/preventTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PreventTaskbarEditing.cs" %}
{% include code-snippet/gantt/editing/preventTaskbarEditing/preventTaskbarEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Task dependencies

In the Gantt control, you can update the dependencies between the tasks and link the tasks interactively. The task dependencies can be mapped from the data source using the [`Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property.

You can update the task dependencies using the following ways:

* Mouse interactions: Using connector points in the taskbar, you can perform drag and drop action to create task dependency links.
* Edit dialog: Create or remove the task dependencies using the `Dependency` tab in the edit dialog.
* Cell editing: Create or remove the task links using cell editing.

The following code example demonstrates how to enable task dependency editing in the Gantt chart using the [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EditSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/mouse-interactions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mouse-interactions.cs" %}
{% include code-snippet/gantt/editing/mouse-interactions/mouse-interactions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/mouse-interactions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mouse-interactions.cs" %}
{% include code-snippet/gantt/editing/mouse-interactions/mouse-interactions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/mouse-interactions.png)

Updating with mouse interaction action

![Alt text](images/cell-editing.png)

Updating with cell Edit

![Alt text](images/edit-dialog.png)

Updating with Dialog

`Note:` When the edit mode is set to `Auto`, on performing double-click action on TreeGrid side, the cells will be changed to editable mode and on performing double-click action on chart side, the edit dialog will appear for editing the task details.

### Update task values using method

Tasks' value can be dynamically updated by using the `updateRecordById` method. You can call this method on any custom action. The following code example shows how to use this method to update a task.

> Using the `updateRecordById` method, you cannot update the task ID value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/updateRecordById/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateRecordById.cs" %}
{% include code-snippet/gantt/editing/updateRecordById/updateRecordById.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/updateRecordById/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UpdateRecordById.cs" %}
{% include code-snippet/gantt/editing/updateRecordById/updateRecordById.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Cell edit type and its params

The [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) is used to define the edit type for any particular column.
You can set the [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) based on data type of the column.

* `numericedit` - [`NumericTextBox`](../numerictextbox) component for integers, double, and decimal data types.

* `defaultedit` - [`TextBox`](../textbox) component for string data type.

* `dropdownedit` - [`DropDownList`](../drop-down-list) component to show all unique values related to that field.

* `booleanedit` - [`CheckBox`](../check-box) component for boolean data type.

* `datepickeredit` - [`DatePicker`](../datepicker) component for date data type.

* `datetimepickeredit` - [`DateTimePicker`](../datetimepicker) component for date time data type.

Also, you can customize the behavior of the editor component through the [`columns.edit.params`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Edit).

The following table describes cell edit type component and their corresponding edit params of the column.

Edit Type |Component |Example
-----|-----|-----
`numericedit` | [`NumericTextBox`](../numerictextbox) | params: { decimals: 2, value: 5 }
`dropdownedit` | [`DropDownList`](../drop-down-list) | params: { value: 'Germany' }
`booleanedit` | [`Checkbox`](../check-box) | params: { checked: true}
`datepickeredit` | [`DatePicker`](../datepicker) | params: { format:'dd.MM.yyyy' }
`datetimepickeredit` | [`DateTimePicker`](../datetimepicker) | params: { value: new Date() }

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

### Cell Edit Template

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

### Disable editing for particular column

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



## Maintaining data in server

All the modified data in Gantt control can be maintained in the database using RESTful web services.

All the CRUD operations in the gantt are done through DataManager. The DataManager has an option to bind all the CRUD related data in server-side.

In the below section, we have explained how to get the edited data details on the server-side using the `UrlAdaptor`.

### URL Adaptor

In Gantt, we can fetch data from SQL database using `ADO.NET` Entity Data Model and update the changes on CRUD action to the server by using `DataManager` support. To communicate with the remote data we are using `UrlAdaptor` of DataManager property to call the server method and get back resultant data in JSON format. We can know more about `UrlAdaptor` from [`here`](https://ej2.syncfusion.com/javascript/documentation/data/adaptors/?no-cache=1).

> Please refer the [link](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/creating-model-classes-with-the-entity-framework-cs) to create the `ADO.NET` Entity Data Model in Visual studio,

We can define data source for Gantt as instance of DataManager using `url` property of DataManager. Please Check the below code snippet to assign data source to Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/urlAdaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/urlAdaptor/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/urlAdaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/urlAdaptor/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



We can also do CRUD operations over Gantt data and save the changes to database. By using `BatchUrl` property of DataManager, we can communicate with the controller method to update the data source on CRUD operation. In gantt CRUD actions on task are dependent with other tasks. For example on editing the child record on chart side, corresponding parent item also will get affect and predecessor dependency task as well get affected. So in Gantt all the CRUD operations are considered to be batch editing where you will get all the affected records as collection. Please check the below code snippet to assign controller method to this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/batchUrl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/batchUrl/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/batchUrl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/batchUrl/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



This server method will be triggered for all the CRUD operations like adding, editing and deleting actions. We can handle those each operations separately inside this method with corresponding data received in this method argument. Also, when using the `UrlAdaptor`, you need to return the data as JSON from the controller action and the JSON object must contain a property as result with dataSource as its value and one more property count with the dataSource total records count as its value.

### Insert action

Using the `added` argument of the `BatchUrl` method we can insert the newly added row to database and return the same to client side. please find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/adding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/adding/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/adding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/adding/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Editing action

Using the `changed` argument of the `BatchUrl` method we can update the modified records to database and return the same to client side. please find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editingData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/editingData/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/editingData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/editingData/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Delete action

Using the `deleted` argument of the `BatchUrl` method we can remove the deleted records from database and return the same to client side. on deleting the record we need to remove its corresponding child records as well if it exist from the data base. please find the below code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/deleting/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UrlAdaptor.cs" %}
{% include code-snippet/gantt/editing/deleting/UrlAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can find the full sample at our [GitHub repository](https://github.com/SyncfusionExamples/EJ2-Gantt-MVC-CRUD-URL-ADAPTOR).

## Deleting tasks

A task delete option in the Gantt control can be enabled by enabling the [`EdiSettings.AllowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowDeleting) property. Tasks can be deleted by clicking the delete toolbar item or using the `deleteRow` method. You can call this method dynamically on any custom actions like button click. The following code example shows how to enable the delete option in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteRecord/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRecord.cs" %}
{% include code-snippet/gantt/editing/deleteRecord/deleteRecord.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteRecord/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRecord.cs" %}
{% include code-snippet/gantt/editing/deleteRecord/deleteRecord.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You should select any one of the rows in the Gantt control to perform task delete action.
> You should set the [`AllowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowDeleting) value to `true` to delete the record dynamically.

### Delete confirmation message

Delete confirmation message is used to get the confirmation from users before deleting a task. This confirmation message can be enabled by setting the [`EditSettings.ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_ShowDeleteConfirmDialog) property to true.

The following code snippet explains how to enable the delete confirmation message in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirmationDialog.cs" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/deleteConfirmationDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirmationDialog.cs" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/deleteConfirmationDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/deleteConfirmationDialog.png)

## Indent and Outdent

Indent and Outdent of a task are used to update the level of the task in hierarchical order of the task. It can be performed bu enabling the [`editSettings.allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettingsBuilder.html#Syncfusion_EJ2_Gantt_GanttEditSettingsBuilder_AllowEditing_System_Boolean_) property.

`Indent` - Selected task can be indented to the level of task to the hierarchical order. It can be performed by using in-built context menu or toolbar items. It can also be invoked by using the `indent` method dynamically on any action like external button click. The following code example shows how to enable indent option in the Gantt chart.

`Outdent` - Selected task can be outdented to the level of task from the hierarchical order. It can be performed by using in-built context menu or toolbar items. It can also be invoked by using the `outdent` method dynamically on any action like external button click. The following code example shows how to enable outdent option in the Gantt chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/indent-outdent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indentoutdent.cs" %}
{% include code-snippet/gantt/editing/indent-outdent/indentoutdent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/indent-outdent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indentoutdent.cs" %}
{% include code-snippet/gantt/editing/indent-outdent/indentoutdent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Read-only Gantt

In Gantt, all create, update, delete operations can be disabled by set `readOnly` property as `true`. The following sample demonstrates, render Gantt chart as read only.

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

## Splitting and Merging tasks

### Splitting task at load time

To split task at load time, we can define segment details in both hierarchical and self-referential way.
Refer below link for more details.

* [Split task at load time](./data-binding/#split-task)

### Split task dynamically

The task can be split dynamically, either by using the context menu or dialog.

* `Dialog`: `Segments` tab is rendered in add/edit dialog, when the [`TaskFields.Segments`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) or [`TaskFields.segmentId`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) property is mapped. Using this tab, we can split the task based on the original start and end date of a particular task.

* `Context menu`: When the [`TaskFields.Segments`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) or [`TaskFields.SegmentId`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SegmentData) property is mapped and the [`EnableContextMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableContextMenu) property is enabled, `Split Task` item will be included in the context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/split-tasks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tasks.cs" %}
{% include code-snippet/gantt/editing/split-tasks/split-tasks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/split-tasks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tasks.cs" %}
{% include code-snippet/gantt/editing/split-tasks/split-tasks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/split-tasks.png)

![Alt text](images/split-contextmenu.png)

![Alt text](images/merge-contextmenu.png)

![Alt text](images/segment-tab.png)

### Merge tasks

The split tasks can be merged either by using the `Merge Task` item of the Context menu or by using the dialog. We can also merge the tasks, by simply dragging the segments together in the UI.

### Limitations of Split tasks

1. Parent and milestone tasks cannot be split into segments.
2. The task must have a width greater than the timeline unit cell in order to be split.
3. Split task is not supported in the `Resource view`.

## Troubleshoot: Editing works only when primary key column is defined

Editing feature requires a primary key column for CRUD operations.
While defining columns in Gantt using the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property, it is mandatory that any one of the columns, must be a primary column. By default, the [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column will be the primary key column.  If [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column is not defined, we need to enable [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) for any one of the columns defined in the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property.