---
layout: post
title: Taskbar editing in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about taskbar editing in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Taskbar editing

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



## Prevent editing for specific tasks

On taskbar edit action, the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event will be triggered. You can prevent the taskbar from editing using the [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event. This can be done by setting cancel property of [`TaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskbarEditing) event argument to true. And we can hide the taskbar editing indicators like taskbar resizer, progress resizer and connector points by using [`QueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryTaskbarInfo) event. The following code example shows how to achieve this.

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



## Task dependencies

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

> When the edit mode is set to `Auto`, on performing double-click action on TreeGrid side, the cells will be changed to editable mode and on performing double-click action on chart side, the edit dialog will appear for editing the task details.

## Update task values using method

Tasks value can be dynamically updated by using the `updateRecordById` method. You can call this method on any custom action. The following code example shows how to use this method to update a task.

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



## Cell edit type and its params

The [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) is used to define the edit type for any particular column. You can set the [`columns.editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_EditType) based on data type of the column.

* `numericedit` - [`NumericTextBox`](../numerictextbox) component for integers, double, and decimal data types.

* `defaultedit` - [`TextBox`](../textbox) component for string data type.

* `dropdownedit` - [`DropDownList`](../drop-down-list) component to show all unique values related to that field.

* `booleanedit` - [`CheckBox`](../check-box) component for boolean data type.

* `datepickeredit` - [`DatePicker`](../datepicker) component for date data type.

* `datetimepickeredit` - [`DateTimePicker`](../datetimepicker) component for date time data type.

Also, you can customize the behavior of the editor component through the [`columns.edit.params`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Edit).

The following table describes cell edit type component and their corresponding edit params of the column.

|Edit Type |Component |Example|
|-----|-----|-----|
|`numericedit` | [`NumericTextBox`](../numerictextbox) | params: { decimals: 2, value: 5 }|
|`dropdownedit` | [`DropDownList`](../drop-down-list) | params: { value: 'Germany' }|
|`booleanedit` | [`Checkbox`](../check-box) | params: { checked: true}|
|`datepickeredit` | [`DatePicker`](../datepicker) | params: { format:'dd.MM.yyyy' }|
|`datetimepickeredit` | [`DateTimePicker`](../datetimepicker) | params: { value: new Date() }|

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

## Cell Edit Template

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