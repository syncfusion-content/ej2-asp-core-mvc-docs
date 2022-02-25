---
layout: post
title: Edit in ##Platform_Name## Grid Component
description: Learn here all about Edit in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
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



## Disable editing for a particular row or cell

You can disable the editing for a particular row by using the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of Grid.

In the below demo, the rows which are having the value for **ShipCountry** column as Denmark is prevented from editing.

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



For batch mode of editing, you can use [`CellEdit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event of Grid. In the below demo, the cells which are having the value as Denmark is prevented from editing.

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

You can edit the template column value by defining the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) for that particular column.

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

The Editing functionalities can be performed based upon the primary key value of the selected row.
If [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) is not defined in the grid, then edit or delete action take places the first row.

## See Also

* [Update column value based on other column values in ASP.NET MVC Grid](https://www.syncfusion.com/forums/144466/update-column-value-based-on-other-column-values-in-asp-net-mvc-grid)
* [Populate field depending the value selected from another field in ASP.NET MVC Grid](https://www.syncfusion.com/forums/154658/populate-field-depending-the-value-selected-from-another-field-in-asp-net-mvc-grid)
* [How to apply two different validation in same column in ASP.NET MVC Grid](https://www.syncfusion.com/forums/154038/how-to-apply-two-different-validation-in-same-column-in-asp-net-mvc-grid)
* [Using Uploader and Textarea in the Grid when edit record in ASP.NET MVC Grid](https://www.syncfusion.com/forums/139251/using-uploader-and-textarea-in-the-grid-when-edit-record-in-asp-net-mvc-grid)