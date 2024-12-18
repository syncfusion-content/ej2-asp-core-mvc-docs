---
layout: post
title: Batch Editing in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Batch Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Batch Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Batch editing in ASP.NET MVC Grid component

Batch editing is a powerful feature in the Grid component that allows you to edit multiple cells simultaneously. It provides a convenient way to make changes to multiple cells and save them in a single request to the data source. This feature is particularly useful when dealing with large datasets or when you need to update multiple cells at once.

In batch edit mode, when you double-click on a grid cell, the target cell changes to an editable state. You can perform bulk update of the added, changed, and deleted data by either clicking on the toolbar's **Update** button or by externally invoking the `batchSave` method.

To enable batch editing mode, you need to set the [EditSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to **Batch**. This property determines the editing mode of the Grid and allows you to activate the batch editing feature.

Here's an example how to enable batch editing in the ASP.NET MVC grid component:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batch.cs" %}
{% include code-snippet/grid/edit/batch/batch.cs %}
{% endhighlight %}
{% endtabs %}

![Batch editing](../images/editing/batch-edit.gif)

## Automatically update the column based on another column edited value

You can automatically update the value of a column based on the edited value of another column in batch mode. This feature is useful when you want to dynamically calculate and update a column's value in real-time based on the changes made in another related column. This can be achieved using the [Cell Edit Template](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/editing/edit-types#custom-editors-using-template) feature in the Grid component.

In the following example, the **TotalCost** column value is updated based on changes to the **UnitPrice** and **UnitInStock** columns during batch editing.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-autoupdate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="autoupdate.cs" %}
{% include code-snippet/grid/edit/batch-autoupdate/autoupdate.cs %}
{% endhighlight %}
{% endtabs %}

![Automatically update](../images/editing/batch-auto.gif)

> * You can utilize the `updateCell` method to update cells in batch mode.

## Cancel edit based on condition

The Grid component provides to cancel the CRUD operations (Edit, Add, Delete) for particular row or cell in batch edit mode based on specific conditions. This feature allows you to control over whether editing should be allowed or prevented for certain rows or cells in the grid.

To cancel the edit action, you need to handle the [CellEdit](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event. This event is triggered when a cell enters the edit mode. Within the event handler, you can add a condition to check whether the edit operation should be allowed or canceled. If the condition is met, set the `args.Cancel` property to **true** to cancel the edit operation.

To cancel the add action, you need to handle the [BeforeBatchAdd](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_BeforeBatchAdd) event. This event is triggered before a new record is added to the batch changes. Within the event handler, you can add a condition to determine whether the add operation should proceed or be canceled. If the condition is met, set the `args.Cancel` property to **true** to cancel the add operation.

To cancel the delete action, you need to handle the [BeforeBatchDelete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_BeforeBatchDelete) event. This event is triggered before a record is deleted from the batch changes. Within the event handler, you can add a condition to control whether the delete operation should take place or be canceled. If the condition is met, set the `args.Cancel` property to **true** to cancel the delete operation.

In the below demo, prevent the CRUD operation based on the **Role** column value. If the Role Column is **Admin**, then edit/delete action is prevented for that row.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-cancel-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="canceleditbatch.cs" %}
{% include code-snippet/grid/edit/batch-cancel-edit/canceleditbatch.cs %}
{% endhighlight %}
{% endtabs %}

![Cancel edit based on condition](../images/editing/batch-cancel.gif)

## Adding a new row at the bottom of the grid

The grid component allows you to add a new row at the bottom of the grid, allowing you to insert a new record at the end of the existing data set. This feature is particularly useful when you want to conveniently add new records without the need to scroll up or manually reposition the newly added row. To achieve this, you can make use of the [NewRowPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) property in the [EditSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) configuration and set it to **Bottom**.

>* If you set `NewRowPosition` as **Bottom**, you can use the **TAB** key to easily move between cells or rows in edit mode. As you enter data in each cell and press **TAB**, the grid will automatically create new rows below the current row, allowing you to conveniently add data for multiple rows without having to leave the edit mode.
>* If you set `NewRowPosition` as **Top**, the grid will display a blank row form at the top by default, allowing you to enter data for the new record. However, when the data is saved or updated, it will be inserted at the bottom of the grid ,ensuring the new record appears at the end of the existing data set. 
>* If the paging feature is enabled, updating the row will automatically move it to the last page based on the page size.This behavior applies to both local and remote data binding.
>* If scrolling is enabled, you can use the **TAB** key to add a new row, even if the new row is added beyond the currently visible area of the grid.
>* Add `NewRowPosition` is supported for **Normal** and **Batch** editing modes.

Here's an example that demonstrates how to enable adding new rows at the bottom of the grid using `NewRowPosition` property:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-newrow-bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="batch-position.cs" %}
{% include code-snippet/grid/edit/batch-newrow-bottom/batch-position.cs %}
{% endhighlight %}
{% endtabs %}

![Adding a new row at the bottom of the grid](../images/editing/batch-position.png)

## Confirmation dialog

Displaying a confirmation dialog provides an additional layer of confirmation when performing actions like saving a record or canceling changes in the grid. This dialog prompts for confirmation before proceeding with the action, ensuring that accidental or undesired changes are avoided. The grid component offers a built-in confirmation dialog that can be used to confirm save, cancel, and other actions.

To enable the confirmation dialog, you can set the [EditSettings.ShowConfirmDialog](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) property of the [EditSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) configuration to **true**. The default value is **true**.

> * `EditSettings.ShowConfirmDialog` requires the [EditSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) to be **Batch**
> * If `EditSettings.ShowConfirmDialog` set to **false**, then confirmation dialog does not display in batch editing.
> * While performing both update and delete operations, a separate delete confirmation dialog is shown at the time of clicking the delete button or pressing the delete key itself.

Here's an example that demonstrates how to enable/disable the confirmation dialog using the `ShowConfirmDialog` property:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchconfirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="showconfirmationdialog.cs" %}
{% include code-snippet/grid/edit/batchconfirm/showconfirmationdialog.cs %}
{% endhighlight %}
{% endtabs %}

![Confirmation dialog](../images/editing/batch-confirmation-dialog.gif)

## How to make editing in single click and arrow keys

You can enable editing in a single click and navigate between cells or rows using arrow keys without having to double-click or use the mouse for navigation. By default, in batch mode, the **TAB** key can be used to edit or move to the next cell or row and the **Enter** key is used to move to the next row cell. However, you can customize this behavior to enable editing with a single click or using arrow keys.

To enable editing in a single click, you can handle the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event of the Grid. Within the event handler,bind the click event to the grid cells and call the `editCell` method to make the clicked cell editable.

To enable editing using arrow keys, you can handle the [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event of the Grid component. Inside the event handler, you can bind the keydown event to the grid element and check for arrow key presses. Based on the arrow key pressed, you can identify the next or previous cell using the `editCell` method and make it editable.

Here's an example that demonstrates how to achieve both single-click editing and arrow key navigation using the `Created` and `Load` events in conjunction with the `editCell` method:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="batch-single.cs" %}
{% include code-snippet/grid/edit/batch-single/batch-single.cs %}
{% endhighlight %}
{% endtabs %}

![single click and arrow keys](../images/editing/batch-single-click.gif)

## Disable editing for a particular cell

You can prevent editing of specific cells based on certain conditions in the Grid component. This feature is useful when you want to restrict editing for certain cells, such as read-only data, calculated values, or protected information. It helps maintain data integrity and ensures that only authorized changes can be made in the grid.

To disable editing for a particular cell in batch mode, use the [CellEdit](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event of the grid. You can then use the **args.Cancel** property and set it to **true**  to prevent editing for that cell.

Here's an example demonstrating how you can disable editing for cells containing the value **France** using the `CellEdit` event:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-particular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="batch-particular.cs" %}
{% include code-snippet/grid/edit/batch-particular/batch-particular.cs %}
{% endhighlight %}
{% endtabs %}

![Disable editing for a particular cell](../images/editing/batch-particular.gif)

## Save or update the changes immediately

The Grid component provides a convenient way to save or update changes immediately in batch mode without the need for a separate Save button. This feature is particularly useful when you want to allow you to edit data efficiently without having to manually trigger a save action. You can achieve this by utilizing the [CellSaved](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellSaved) event and the `batchSave` method. 

By default, when you use the `batchSave` method to save or update data, a confirmation dialog is displayed. This dialog prompts for confirmation before proceeding with the save or cancel action, ensuring that accidental or undesired changes are avoided.

The `CellSaved` event is triggered when a cell is saved in the Grid. It provides a way to perform custom logic when a cell is saved or updated.

The `batchSave` method is a built-in function provided by the Grid's edit service. It is used to save multiple changes made to added, edited, and deleted records in the batch mode.

> * To avoid the confirmation dialog when using the `batchSave` method, you can set [EditSettings.ShowConfirmDialog](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowConfirmDialog) to **false**. However, please note that to use this property, the [EditSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) must be set to **Batch**. This combination of properties allows you to save or update changes immediately without the need for a confirmation dialog.

Here's an example that demonstrates how to achieve immediate saving or updating of changes using the `CellSaved` event and the `batchSave` method:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batch-save-update/razor %}
{% endhighlight %}
{% highlight c# tabtitle="save-update.cs" %}
{% include code-snippet/grid/edit/batch-save-update/save-update.cs %}
{% endhighlight %}
{% endtabs %}

![Save or update the changes immediately](../images/editing/batch-save.gif)