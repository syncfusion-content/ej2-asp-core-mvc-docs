---
layout: post
title: Inline Editing in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Inline Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Inline Editing in Grid Control

In Normal edit mode, when you start editing the currently selected record is changed to edit state. You can change the cell values and save edited data to the data source. To enable Normal edit, set [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property of [`e-grid-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) tag helper as **Normal**.

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

## Automatically update the column based on another column edited value

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



## Cancel edit based on condition

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



## Perform CRUD action programmatically

Grid methods can be used to perform CRUD operations programmatically. The `addRecord`, `deleteRecord`, and `startEdit` methods are used to perform CRUD operations in the following demo.

* To add a new record to the Grid, use the `addRecord` method. In this method, you can pass the data parameter to add a new record to the Grid, and the index parameter to add a record at a specific index. If you call this method with no parameters, it will create an empty row in the Grid.

* To change the selected row to the edit state, use the `startEdit` method.

* If you need to update the row data in the Grid’s datasource, you can use the `updateRow` method. In this method, you need to pass the index value of the row to be updated along with the updated data.

* If you need to update the particular cell in the row, you can use the `setCellValue` method. In this method, you need to pass the primary key value of the data source, field name, and new value for the particular cell.

* To remove a selected row from the Grid, use the `deleteRecord` method. For both edit and delete operations, you must select a row first.

> **Note:** In both normal and dialog editing modes, these methods can be used.

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



## Confirmation dialog

The delete confirm dialog can be shown when deleting a record by defining the [`showDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) property of [`e-grid-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **true**.

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



> The [`showDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) supports all type of edit modes.

## Default column values on add new row

The grid provides an option to set the default value for the columns when adding a new record in it. To set a default value for the particular column by defining the [`defaultValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DefaultValue) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper.

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



## Adding a new row at the bottom of the Grid

By default, a new row will be added at the top of the grid. You can change it by setting [`newRowPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) property of [`e-grid-editSettings`] tag helper as **Bottom**.

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

## Move the focus to a particular cell instead of first cell while editing a row

The [`recordDoubleClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RecordDoubleClick) event allows you to move the focus to the corresponding cell (the cell that you doubled-clicked to edit a row) instead of the first cell in edit form. With the help of this event, you can focus the double-clicked column in inline edit mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

