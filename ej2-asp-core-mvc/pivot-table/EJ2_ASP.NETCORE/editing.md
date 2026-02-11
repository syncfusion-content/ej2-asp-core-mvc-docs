---
layout: post
title: Editing in ##Platform_Name## Pivot Table Control | Syncfusion
description: Learn here all about Editing in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing in ASP.NET Core Pivot Table component

> This feature is applicable only for the relational data source.

The cell editing option allows users to directly change data in the pivot table by adding, updating, or deleting raw data items within any value cell. When you double-click a value cell, the raw items appear in a data grid within a new window. In this data grid, you can perform CRUD operations by double-clicking cells or using toolbar options. After you finish editing the raw items, the pivot table automatically updates the aggregated values. To enable this option, set the [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowEditing) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to **true**.

The [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) property provides comprehensive control over editing behavior through the following options:

* [`allowAdding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowAdding): Enables adding new rows to the data grid.
* [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowEditing): Allows editing existing records in the data grid.
* [`allowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowDeleting): Enables deleting records directly from the data grid.
* [`allowCommandColumns`](hhttps://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowCommandColumns): Displays built-in command buttons (edit, delete, save, cancel) in the data grid.
* [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_Mode): Sets the editing mode.
* [`allowEditOnDblClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowEditOnDblClick): Enables users to start editing a cell by double-clicking it.
* [`showConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_ShowConfirmDialog): Shows a confirmation dialog before saving changes.
* [`showDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_ShowDeleteConfirmDialog): Shows a confirmation dialog before deleting a record.
* [`allowInlineEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowInlineEditing): Allows users to edit content directly in the cell.

The CRUD operations available in the data grid toolbar and command column are:

| Toolbar Button | Actions |
|----------------|---------|
| Add | Add a new row.|
| Edit | Edit the current row or cell.|
| Delete | Delete the current row.|
| Update | Update the edited row or cell.|
| Cancel | Cancel the edited state. |

The following are the supported edit types in the data grid:

* Normal
* Dialog
* Batch
* Command Columns

## Normal

Normal edit mode allows users to edit one row at a time in the editing dialog with simple data changes and updates. In normal edit mode, when editing begins, the selected row changes to edit state. Cell values can be modified and saved to the data source by clicking the "Update" toolbar button. To enable normal edit mode, set the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_Mode) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to **Normal**.

> The normal edit mode **Normal** is set as the default mode for editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/normal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Normal.cs" %}
{% include code-snippet/pivot-table/editing/normal/Normal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/normal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Normal.cs" %}
{% include code-snippet/pivot-table/editing/normal/Normal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/edit-normal.png)

## Dialog

The dialog edit mode provides a focused editing environment by displaying the selected row data in an exclusive dialog window, ensuring clear visibility and controlled data modification. In dialog edit mode, when editing begins, the currently selected row data appears in a dedicated dialog. Cell values can be modified and saved to the data source by clicking the "Save" button in the dialog. To enable dialog editing, set the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_Mode) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to [**Dialog**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.EditMode.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/pivot-table/editing/dialog/Dialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/pivot-table/editing/dialog/Dialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/edit-dialog.png)

## Batch

Batch editing enables users to make multiple changes to data grid cells and save them all at once, improving efficiency for bulk updates. When a user double-clicks any data grid cell in batch mode, the target cell changes to edit state. Users can perform multiple changes and save all modifications (added, changed, and deleted data) to the data source by clicking the **Update** toolbar button. To enable batch editing, set the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_Mode) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to [**Batch**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.EditMode.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/pivot-table/editing/batch/Batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/pivot-table/editing/batch/Batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/edit-batch.png)

## Command column

The command column option provides dedicated action buttons within the data grid for streamlined CRUD operations as an alternative to using toolbar options. An additional column appears in the data grid layout containing command buttons to perform the CRUD operations. To enable the command columns, set the [`allowCommandColumns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_Mode) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to **true**.

The available built-in command buttons are:

| Command Button | Actions |
|----------------|---------|
| Edit | Edit the current row.|
| Delete | Delete the current row.|
| Save | Update the edited row.|
| Cancel | Cancel the edited state. |

N>
- When the command column option is enabled, the Edit, Delete, Update, and Cancel buttons are not shown in the Data Grid's toolbar. Instead, these action buttons appear in the last column of each row within the Data Grid.
- To delete a record directly from the data grid using the **Delete** action button in the command column, you need to set the [`allowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowDeleting) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/cc/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CC.cs" %}
{% include code-snippet/pivot-table/editing/cc/CC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/cc/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CC.cs" %}
{% include code-snippet/pivot-table/editing/cc/CC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/edit-command.png)

## Inline Editing

The inline editing option provides streamlined data modification by allowing direct editing of value cells without opening an external dialog, improving workflow efficiency for quick data updates. This editing mode applies only when a single raw data item corresponds to the value of the cell and works with all editing modes including normal, batch, dialog, and column commands. Enable inline editing by setting the [`allowInlineEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html#Syncfusion_EJ2_PivotView_PivotViewCellEditSettings_AllowInlineEditing) property in [`e-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCellEditSettings.html) to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/Inline-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/pivot-table/editing/Inline-editing/Inline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/Inline-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline.cs" %}
{% include code-snippet/pivot-table/editing/Inline-editing/Inline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/inline-editting.png)

## Editing using the pivot chart

Pivot chart editing provides an alternative way to conveniently update, add, or remove underlying data associated with any chart data point. This empowers users to perform CRUD (Create, Read, Update, Delete) operations on the underlying raw items linked to visualized data points for enhanced analysis.

Clicking a data point in the pivot chart displays the underlying raw items in a data grid within a popup window. Users can then add, update, or delete these items using any of the supported edit types (normal, dialog, batch, or command column), following the same steps as for pivot table cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Chart.cs" %}
{% include code-snippet/pivot-table/editing/chart/Chart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editing/chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Chart.cs" %}
{% include code-snippet/pivot-table/editing/chart/Chart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/drillthrough-chart-before.png)
<br/>
<br/>
![output](images/editing-dialog.png)

## Events

### EditCompleted

The event [`editCompleted`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EditCompleted) triggers when values cells are edited completely. The event provides edited cell(s) information along with its previous cell value. It also helps to do the CRUD operation by manually updating the data source which is connected to the component. It has the following parameters.

* `currentData` - It holds the current raw data of the edited cells.
* `previousData` - It holds the previous raw data of the edited cells.
* `previousPosition` - It holds the index of the raw data whose values are edited.
* `cancel` - It is a boolean property and if it is set as **true**, the editing won’t be reflected in the pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editCompleted-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditCompleted.cs" %}
{% include code-snippet/pivot-table/editCompleted-event/EditCompleted.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/editCompleted-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditCompleted.cs" %}
{% include code-snippet/pivot-table/editCompleted-event/EditCompleted.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### DrillThrough

For more information [`refer`](./drill-through#drillthrough) here.

### BeginDrillThrough

For more information [`refer`](./drill-through#begindrillthrough) here.

### ActionBegin

The [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event triggers when editing actions such as add, edit, save, or delete are started through the UI (either by dialog or inline editing). This event lets users monitor the editing workflow and take action before the operation completes. The following parameters are available in the event:

- `dataSourceSettings`: Contains the current data source settings, including all input data, rows, columns, values, filters, and format settings.
- `actionName`: Shows the name of the editing action that has started. The following are the UI actions and their names:

   | Action  | Action Name         |
   |---------|--------------------|
   | Editing | Edit record        |
   | Save    | Save edited records|
   | Add     | Add new record     |
   | Delete  | Remove record      |

- `cancel`: Allows users to stop (cancel) the action by setting this option to **true**.

For example, you can restrict add and save actions by setting **args.cancel** to **true** in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-editing/actionBegin-editing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-editing/actionBegin-editing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionComplete

The [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) event triggers whenever a UI action, such as add, update, remove, or save (using dialog or inline editing), is finished. This lets users know exactly what kind of action has just been completed. The event provides the following details:

* `dataSourceSettings`: Contains the current data source settings, including input data, rows, columns, values, filters, format settings, and more.
* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

   | Action | Action Name            |
   |--------|------------------------|
   | Save   | Edited records saved   |
   | Add    | New record added       |
   | Delete | Record removed         |
   | Update | Records updated        |

* `actionInfo`: It holds the unique information about the current UI action. For example, if save action is completed, the event argument contains information such as mode of editing and saved records.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-editing/actionComplete-editing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-editing/actionComplete-editing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionFailure

The [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) event is triggered when a UI action fails to produce the expected result. This event provides detailed information about the failure through the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

   | Action | Action Name|
   |------|-------------|
   | Editing| Edit record|
   | Save| Save edited records|
   | Add| Add new record|
   | Delete| Remove record|

* `errorInfo`: It holds the error information of the current UI action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-editing/actionFailure-editing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-editing.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-editing/actionFailure-editing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}