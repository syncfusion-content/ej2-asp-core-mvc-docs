---
layout: post
title: Columns in ##Platform_Name## Grid Component
description: Learn here all about Columns in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns

The column definitions are used as the **DataSource** schema in the Grid. This plays a vital role in rendering column values in the required format.
The grid operations such as sorting, filtering and grouping etc. are performed based on column definitions. The [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column**
is necessary to map the datasource values in Grid columns.

> 1. If the column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) is not specified in the dataSource, the column values will be empty.
> 2. If the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) name contains “dot” operator, it is considered as complex binding.

## Auto generation

The [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) are automatically generated when
[`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) declaration is empty or undefined while initializing the grid. All the columns in the **DataSource** are bound as grid columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/grid/columns/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/grid/columns/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> When columns are auto-generated, the column [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) will be determined from the first record of the **DataSource**.

### Set Primary key column for auto generated columns when editing is enabled

Primary key can be defined in the declaration of column object of the grid. If you did not declare the columns, the grid will generate the columns automatically. For these auto generated columns, you can set [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property of **e-grid-column** as true by using the following ways,

If Primary key "column index" is known then refer the following example

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/primary/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/grid/columns/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/primary/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/grid/columns/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If Primary key "column fieldname" is known then you can get the column by using `var column = grid.getColumnByField('OrderID')` and then set primary key by defining [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property as true in **e-grid-column** tag helper.

### Set column options to auto generated columns

You can set column options such as [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format), [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) to the auto generated columns by using [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the grid.

In the below example, [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) is set for **OrderID** column, **date** type is set for **OrderDate** column and **numeric** type is set for **Freight** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autocolumnformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autocolumnformat.cs" %}
{% include code-snippet/grid/columns/autocolumnformat/autocolumnformat.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autocolumnformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autocolumnformat.cs" %}
{% include code-snippet/grid/columns/autocolumnformat/autocolumnformat.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Complex data binding

You can achieve complex data binding in the grid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexbinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexbinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/grid/columns/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For OData and ODataV4 adaptors, you need to add [`expand`](https://ej2.syncfusion.com/documentation/api/data/query/#expand) query to the [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property (of Grid), to eager load the complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/query/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/grid/columns/query/query.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/query/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/grid/columns/query/query.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Foreign Key Column

Foreign key column can be enabled by using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource), [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) and [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) properties of **e-grid-column** tag helper.

* [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource) - Defines the foreign data.
* [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) - Defines the mapping column name to the foreign data.
* [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) - Defines the display field from the foreign data.

In the following example, **Employee Name** is a foreign column which shows **FirstName** column from foreign data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeView.cs" %}
{% include code-snippet/grid/columns/foreign/employeeView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeView.cs" %}
{% include code-snippet/grid/columns/foreign/employeeView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * For remote data, the sorting and grouping is done based on [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) instead of [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue).
> * If [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) is not defined, then the column uses [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column** tag helper.

## Header Template

You can customize the header element by using the [`headerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderTemplate) property of **e-grid-column** tag helper. In this demo, the custom element is rendered for both EmployeeID and BirthDate column headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/grid/columns/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/grid/columns/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header text

By default, column header title is displayed from column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) value. To override the default header title, you have to define the **headerText** value in the [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext/headertext.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext/headertext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * If both the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) and [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText)
are not defined in the column, the column renders with “empty” header text.

## Format

To format cell values based on specific culture, use the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format) property of **e-grid-column** tag helper . The grid uses **Internalization** library to format **number** and **date**.
values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the **number** and **date** values are formatted in **en-US** locale.

### Number formatting

The number or integer values can be formatted using the below format strings.

Format |Description |Remarks
-----|-----|-----
N | Denotes numeric type. | The numeric format is followed by integer value as N2, N3. etc which denotes the number of precision to be allowed.
C | Denotes currency type. | The currency format is followed by integer value as C2, C3. etc which denotes the number of precision to be allowed.
P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 1. For example the cell value **0.2** is formatted as **20%**. The percentage format is followed by integer value as P2, P3. etc which denotes the number of precision to be allowed.

### Date formatting

You can format date values either using built-in date format string or custom format string.

For built-in date format you can specify [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format) property of **e-grid-column** as string (Example: **yMd**).

You can also use custom format string to format the date values. Some of the custom formats and the formatted date values are given in the below table.

Format | Formatted value
-----|-----
{ type:'date', format:'dd/MM/yyyy' } | 04/07/1996
{ type:'date', format:'dd.MM.yyyy' } | 04.07.1996
{ type:'date', skeleton:'short' } | 7/4/96
{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/1996 12:00 AM
{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/1996 12:00:00 AM

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/dateformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/dateformat/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/dateformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/dateformat/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Visibility

You can hide any particular column in Grid before rendering by defining [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of **e-grid-column** as false. In the below sample **ShipCity** column is defined as visible false.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/Visibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Visibility.cs" %}
{% include code-snippet/grid/columns/Visibility/Visibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/Visibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visibility.cs" %}
{% include code-snippet/grid/columns/Visibility/Visibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## AutoFit specific columns

The **autoFitColumns** method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event.

To use the **autoFitColumns** method, inject the **Resize** module in the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can autofit all the columns by invoking the **autoFitColumns** method without column names.

## Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the grid. To enable reordering, set the [`allowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowReordering) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/grid/columns/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/grid/columns/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable reordering a particular column by setting the [`allowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowReordering) property of **e-grid-column** as false.

### Reorder Single Column

Grid have option to reorder Columns either by Interaction or by using the **reorderColumns** method. In the below sample, **Name** column is reordered to last column position by using the method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercols/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercols/reordercols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercols/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercols/reordercols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Reorder Multiple Columns

You can reorder a single column at a time by Interaction. Sometimes we need to reorder multiple columns at the same time, It can be achieved through programmatically by using **reorderColumns** method.

In the below sample, **Ship City** and **Ship Region** column is reordered to last column position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercolumns/reordercols.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reordercolumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reordercols.cs" %}
{% include code-snippet/grid/columns/reordercolumns/reordercols.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Reorder Events

During the reorder action, the grid component triggers the below three events.

1. The [`columnDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDragStart) event triggers when column header element drag (move) starts.
2. The [`columnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrag) event triggers when column header element is dragged (moved) continuously.
3. The [`columnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrop) event triggers when a column header element is dropped on the target column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorderevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderevents.cs" %}
{% include code-snippet/grid/columns/reorderevents/reorderevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/reorderevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderevents.cs" %}
{% include code-snippet/grid/columns/reorderevents/reorderevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Lock Columns

You can lock columns by using [`lockColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_LockColumn) property of **e-grid-column** tag helper. The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Ship City column is locked and its reordering functionality is disabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/grid/columns/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/lock/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/grid/columns/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column resizing

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% include code-snippet/grid/columns/resize/resize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% include code-snippet/grid/columns/resize/resize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowResizing) property of **e-grid-column** tag helper to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

### Column Resizing by using method

To resize a column, set width to that particular column and then refresh the grid header by using the **refreshHeader** method. Please refer the below code

```javascript

var grid = document.getElementById('Grid').ej2_instances[0]; //Grid Instance

var columns = grid.columns;

columns[0].width = 150;

grid.refreshHeader();

```

### Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`minWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_MinWidth) and [`maxWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_MaxWidth) properties in  **e-grid-column** tag helper.

In the following sample, minimum and maximum width are defined for **OrderID**, **Ship Name**, and **Ship Country** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/min/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Min.cs" %}
{% include code-snippet/grid/columns/min/min.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/min/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Min.cs" %}
{% include code-snippet/grid/columns/min/min.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Resize Stacked Column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for any particular stacked column by setting [`allowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property **e-grid-column** as **false** to its columns.

In this example, we have disabled resize for **Ship City** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/stacked/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked.cs" %}
{% include code-snippet/grid/columns/stacked/stacked.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/stacked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked.cs" %}
{% include code-snippet/grid/columns/stacked/stacked.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed. You can autoFit a column by using the Column menu of the grid.

The following screenshot represents the column resizing in touch device.

![Touch interaction](./images/column-resizing.jpg)

### Resizing Events

During the resizing action, the grid component triggers the below three events.

1. The [`resizeStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ResizeStart) event triggers when column resize starts.
2. The [`resizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Resizing) event triggers when column header element is dragged (moved) continuously.
3. The [`resizeStop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ResizeStop) event triggers when column resize ends.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resizeevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resizeevents.cs" %}
{% include code-snippet/grid/columns/resizeevents/resizeevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/resizeevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resizeevents.cs" %}
{% include code-snippet/grid/columns/resizeevents/resizeevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column template

The column [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Grid actions such as editing, grouping, filtering and sorting etc. will depend upon the column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field). If the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) is not specified in the template column, the grid actions cannot be performed.

### Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Discontinued** field value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/condition-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/condition-template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/condition-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/condition-template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column type

Column type can be specified using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) property of **e-grid-column** tag helper. It specifies the type of data the column binds.

If the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format) is defined for a column, the column uses [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) to select the appropriate format option (**number**
 or **date**)).

Grid column supports the following types:
* string
* number
* boolean
* date
* datetime

> If the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) is not defined, it will be determined from the first record of the **DataSource**.
> Incase if the first record of the **DataSource** is null/blank value for a column then it is necessary to define the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) for that column.

## Column chooser

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the
[`showColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) property as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide the column names in column chooser by defining the [`showInColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowInColumnChooser) property as false in **e-grid-column** tag helper of particular column.

### Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking
the **openColumnChooser** method with **X** and **Y** axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/externalbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/grid/columns/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/externalbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/grid/columns/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column menu

The column menu has options to integrate features like sorting, grouping, filtering, column chooser, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`showColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowColumnMenu) property as true.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `Group` | Group the current column. |
| `Ungroup` | Ungroup the current column. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `ColumnChooser` | Choose the column visibility. |
| `Filter` | Show the filter option as given in `FilterSettings.Type` |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/grid/columns/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable column menu for a particular column by defining the [`showColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowColumnMenu) property of **e-grid-column** as false.
> You can customize the default items by defining the [`columnMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) with required items.

### Column menu Events

During the resizing action, the grid component triggers the below two events.

1. The [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event triggers before the column menu opens.
2. The [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event triggers when the user clicks the column menu of the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenuevents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenuevents.cs" %}
{% include code-snippet/grid/columns/columnmenuevents/columnmenuevents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnmenuevents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenuevents.cs" %}
{% include code-snippet/grid/columns/columnmenuevents/columnmenuevents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Custom Column Menu Item

Custom column menu items can be added by defining the [`columnMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuItems) as collection of
the **columnMenuItemModel**.

Actions for this customized items can be defined in the [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customcolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcolumnmenu.cs" %}
{% include code-snippet/grid/columns/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customcolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcolumnmenu.cs" %}
{% include code-snippet/grid/columns/customcolumnmenu/customcolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customize menu items for particular columns

Sometimes, you have a scenario that to hide an item from column menu for particular columns. In that case, you need to define the [`ColumnMenuOpenEventArgs.Hide`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) as true in the [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnMenuOpen) event.

The following sample, **Filter** item was hidden in column menu when opens for the **OrderID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customizecolumnmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customizecolumnmenu.cs" %}
{% include code-snippet/grid/columns/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/customizecolumnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customizecolumnmenu.cs" %}
{% include code-snippet/grid/columns/customizecolumnmenu/customizecolumnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column spanning

The grid has option to span the adjacent cells. You need to define the **colSpan** attribute to span cells in the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.

In the following demo, employee **Davolio** is doing testing from 9.00 A.M. to 10.00 A.M. so that the cells have been spanned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnspanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/columnspanning/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnspanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/columnspanning/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive columns

You can toggle column visibility based on media queries which are defined
at the [`hideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia).
The [`hideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html ). In the below sample, for **OrderID** column, [`hideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HideAtMedia) property of **e-grid-column** is set as **(min-width: 700px)** so that **OrderID** column will gets hidden when the browser screen width is lessthan 700px.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/responsivecolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsivecolumns.cs" %}
{% include code-snippet/grid/columns/responsivecolumns/responsivecolumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/responsivecolumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsivecolumns.cs" %}
{% include code-snippet/grid/columns/responsivecolumns/responsivecolumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Controlling Grid actions

You can enable or disable grid action for a particular column by setting the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering),
[`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowGrouping), [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing),[`allowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowReordering), and [`allowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowSorting) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/controllingactions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controllingactions.cs" %}
{% include code-snippet/grid/columns/controllingactions/controllingactions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/controllingactions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controllingactions.cs" %}
{% include code-snippet/grid/columns/controllingactions/controllingactions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## ValueAccessor

The **valueAccessor** is used to access/manipulate the value of display data. You can achieve custom value formatting by using the valueAccessor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/valueaccessor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valueaccessor.cs" %}
{% include code-snippet/grid/columns/valueaccessor/valueaccessor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/valueaccessor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valueaccessor.cs" %}
{% include code-snippet/grid/columns/valueaccessor/valueaccessor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show/hide columns by external button

You can show or hide grid columns dynamically using external buttons by invoking the **showColumns** or **hideColumns** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/showhide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/grid/columns/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/showhide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/grid/columns/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Render boolean value as checkbox

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DisplayAsCheckBox) property of **e-grid-column** as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/booleanascheckbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Booleanascheckbox.cs" %}
{% include code-snippet/grid/columns/booleanascheckbox/booleanascheckbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/booleanascheckbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Booleanascheckbox.cs" %}
{% include code-snippet/grid/columns/booleanascheckbox/booleanascheckbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to Change Column Header Text Dynamically](./how-to/change-header-text-dynamically)
* [Customize Column Styles](./how-to/customize-column-styles)
* [Custom Tooltip for Columns](how-to/display-custom-tool-tip-for-columns-in-grid)
* [How to Render Other Component in a Column](how-to/render-other-components-in-column)
* [How to change the Orientation of Header Text](./how-to/change-orientation-of-header-text)
* [Group Column by Format](./grouping#group-by-format)
* [How to Use Edit Template in Foreign Key Column](./how-to/use-edit-template-in-foreign-key-column)
* [How to Create and use custom Filter UI in Foreign Key Column](./how-to/customize-filter-ui-in-foreign-key)
* [How to Use Filter Bar Template in Foreign Key Column](./how-to/use-filter-bar-template-in-foreign-key-column)
* [How to Perform aggregation in Foreign Key Column](./how-to/perform-aggregation-in-foreign-key-column)
* [How to set complex column as Foreignkey column](./how-to/complex-column-as-foreign-key-column)
* [Complex Data Binding with list of Array Of Objects](./how-to/list-of-array-of-objects)
* [How to display image on the base64 Grid column](https://www.syncfusion.com/kb/11513/how-to-display-image-on-the-base64-grid-column)