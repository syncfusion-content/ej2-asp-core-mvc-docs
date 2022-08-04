---
layout: post
title: Editing in ##Platform_Name## Tree Grid Component
description: Learn here all about Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing

The TreeGrid component has options to dynamically insert, delete and update records.
Editing feature is enabled by using [`e-treegrid-editSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings.html) tag helper and it requires a primary key column for CRUD operations.
To define the primary key, set [`isPrimaryKey`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsPrimaryKey.html) of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to **true** in particular column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/tree-grid/editing/editing/edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit.cs" %}
{% include code-snippet/tree-grid/editing/editing/edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable editing for a particular column, by specifying [`allowEditing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowEditing.html) of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to **false**.

## Toolbar with edit option

The treegrid toolbar has the built-in items to execute Editing actions.
You can define this by using the [`toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/editing-tools/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditTools.cs" %}
{% include code-snippet/tree-grid/editing/editing-tools/editTools.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/editing-tools/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditTools.cs" %}
{% include code-snippet/tree-grid/editing/editing-tools/editTools.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Adding row position

The TreeGrid control provides the support to add the new row in the top, bottom, above selected row, below selected row and child position of tree grid content using [`newRowPosition`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~NewRowPosition.html) property of [`e-treegrid-editsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings.html) tag helper. By default, a new row will be added at the top of the treegrid.

The following examples shows how to set new row position as **Child** in treegrid.

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



## Confirmation messages

### Delete confirmation

The delete confirm dialog can be shown when deleting a record by defining the [`showDeleteConfirmDialog`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~ShowDeleteConfirmDialog.html) as **true**.

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



> The **showDeleteConfirmDialog** supports all type of edit modes.



## Default column values on add new

The treegrid provides an option to set the default value for the columns when adding a new record in it.
To set a default value for the particular column by defining the [`defaultValue`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DefaultValue.html) in [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

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

You can disable editing for particular columns by using the [`allowEditing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowEditing.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

In the following demo, editing is disabled for the **Start Date** column.

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
If [`isPrimaryKey`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsPrimaryKey.html) is not defined in the treegrid, then edit or delete action take places the first row.



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.