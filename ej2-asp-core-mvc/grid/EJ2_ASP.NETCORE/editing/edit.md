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

![Inline Editing](../images/Editing/inline-edit.gif)

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

![Edit with toolbar](../images/Editing/edit-with-toolbar.gif)

## Disable editing for particular column

In Grid component, you have an option to disable editing for a specific column. This feature is useful when you want to prevent editing certain columns, such as columns that contain calculated values or read-only data.

To disable editing for a particular column, you can use the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing)  property of the **columns** object. By setting this property to **false**, you can prevent editing for that specific column.

Here's an example that demonstrates how to disable editing for the column in the Grid:


## Toolbar with edit option

The grid toolbar has the [Built-in items](./tool-bar/#built-in-toolbar-items) to execute Editing actions. You can define this by using the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property.

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



## Disable editing for particular column

You can disable editing for particular columns by using the [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper.

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



## Disable editing for a particular row or cell

You can disable the editing for a particular row by using the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of Grid.

In the below demo, the rows which are having the value for **ShipCountry** column as **Denmark** is prevented from editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-edit.cs" %}
{% include code-snippet/grid/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-edit.cs" %}
{% include code-snippet/grid/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For batch mode of editing, you can use **CellEdit** event of Grid. In the below demo, the cells which are having the value as "Denmark" is prevented from editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-edit-batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-edit-batch.cs" %}
{% include code-snippet/grid/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-edit-batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-edit-batch.cs" %}
{% include code-snippet/grid/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Editing template column

You can edit the template column value by defining the **Field** for that particular column.

In the below demo, the **ShipCountry** column is rendered with the template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-temp.cs" %}
{% include code-snippet/grid/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Troubleshoot editing works only for first row

The Editing functionalities can be performed based upon the primary key value of the selected row. If **primaryKey** is not defined in the grid, then edit or delete action take places the first row.

## How to make a Grid column always editable

Make the Grid column always editable using the column template feature of the Grid.

In the following example, the textbox is rendered in the Freight column using a column template. The keyup event for the Grid is bound using the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event of the Grid, and the edited changes are saved in the data source using the `updateRow` method of the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/column-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-edit.cs" %}
{% include code-snippet/grid/edit/column-edit/column-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/column-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-edit.cs" %}
{% include code-snippet/grid/edit/column-edit/column-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to set custom format in edit state of Grid](https://support.syncfusion.com/kb/article/11763/how-to-set-custom-format-in-edit-state-of-grid)