---
title: "Columns"
component: "Grid"
description: "Documentation on column reordering, resizing, header templates (custom header content), and column templates (custom cell content) in the Essential JS 2 DataGrid control."
---

# Columns

The column definitions are used as the **DataSource** schema in the Grid. This plays a vital role in rendering column values in the required format.
The grid operations such as sorting, filtering and grouping etc. are performed based on column definitions. The [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column**
is necessary to map the datasource values in Grid columns.

> 1. If the column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) is not specified in the dataSource, the column values will be empty.
> 2. If the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) name contains “dot” operator, it is considered as complex binding.

## Headers

### Header text

By default, column header title is displayed from column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) value. To override the default header title, you have to define the **headerText** value in the [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) property of **e-grid-column** tag helper.

{% aspTab template="grid/columns/headertext", sourceFiles="headertext.cs" %}

{% endaspTab %}

> * If both the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) and [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText)
are not defined in the column, the column renders with “empty” header text.

### Header template

You can customize the header element by using the [`headerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderTemplate) property of **e-grid-column** tag helper. In this demo, the custom element is rendered for both EmployeeID and BirthDate column headers.

{% aspTab template="grid/columns/headertemplate", sourceFiles="headertemplate.cs" %}

{% endaspTab %}

## Column types

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

## ValueAccessor

The **valueAccessor** is used to access/manipulate the value of display data. You can achieve custom value formatting by using the valueAccessor.

{% aspTab template="grid/columns/valueaccessor", sourceFiles="valueaccessor.cs" %}

{% endaspTab %}

## Format

To format cell values based on specific culture, use the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format) property of **e-grid-column** tag helper . The grid uses **Internalization** library to format **number** and **date**.
values.

{% aspTab template="grid/columns/format", sourceFiles="format.cs" %}

{% endaspTab %}

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

{% aspTab template="grid/columns/dateformat", sourceFiles="format.cs" %}

{% endaspTab %}

## Render boolean value as checkbox

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DisplayAsCheckBox) property of **e-grid-column** as **true**.

{% aspTab template="grid/columns/booleanascheckbox", sourceFiles="booleanascheckbox.cs" %}

{% endaspTab %}

## Visibility

You can hide any particular column in Grid before rendering by defining [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Visible) property of **e-grid-column** as false. In the below sample **ShipCity** column is defined as visible false.

{% aspTab template="grid/columns/Visibility", sourceFiles="Visibility.cs" %}

{% endaspTab %}

## Lock columns

You can lock columns by using [`lockColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_LockColumn) property of **e-grid-column** tag helper. The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Ship City column is locked and its reordering functionality is disabled.

{% aspTab template="grid/columns/lock", sourceFiles="lock.cs" %}

{% endaspTab %}

## Controlling Grid actions

You can enable or disable grid action for a particular column by setting the [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering),
[`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowGrouping), [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing),[`allowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowReordering), and [`allowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowSorting) properties.

{% aspTab template="grid/columns/controllingactions", sourceFiles="controllingactions.cs" %}

{% endaspTab %}

## Show or hide columns by external button

You can show or hide grid columns dynamically using external buttons by invoking the **showColumns** or **hideColumns** method.

{% aspTab template="grid/columns/showhide", sourceFiles="showhide.cs" %}

{% endaspTab %}

## See Also

* [How to Change Column Header Text Dynamically](../how-to/change-header-text-dynamically)
* [Customize Column Styles](../how-to/customize-column-styles)
* [Custom Tooltip for Columns](../how-to/display-custom-tool-tip-for-columns-in-grid)
* [How to Render Other Component in a Column](../how-to/render-other-components-in-column)
* [How to change the Orientation of Header Text](../how-to/change-orientation-of-header-text)
* [Group Column by Format](../grouping#group-by-format)
* [How to Use Edit Template in Foreign Key Column](../how-to/use-edit-template-in-foreign-key-column)
* [How to Create and use custom Filter UI in Foreign Key Column](../how-to/customize-filter-ui-in-foreign-key)
* [How to Use Filter Bar Template in Foreign Key Column](../how-to/use-filter-bar-template-in-foreign-key-column)
* [How to Perform aggregation in Foreign Key Column](../how-to/perform-aggregation-in-foreign-key-column)
* [How to set complex column as Foreignkey column](../how-to/complex-column-as-foreign-key-column)
* [Complex Data Binding with list of Array Of Objects](../how-to/list-of-array-of-objects)
* [How to display image on the base64 Grid column](https://www.syncfusion.com/kb/11513/how-to-display-image-on-the-base64-grid-column)