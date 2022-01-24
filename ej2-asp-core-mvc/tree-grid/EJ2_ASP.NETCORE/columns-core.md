---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Columns Core of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Columns Core
publishingplatform: ##Platform_Name##
documentation: ug
---

{ type:'date', format:'dd/MM/yyyy' } | 04/07/1996
{ type:'date', format:'dd.MM.yyyy' } | 04.07.1996
{ type:'date', skeleton:'short' } | 7/4/96
{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/1996 12:00 AM
{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/1996 12:00:00 AM

{% aspTab template="tree-grid/columns-core/date-format", sourceFiles="dateformat.cs" %}

{% endaspTab %}

## AutoFit specific columns

The autoFitColumns method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataBound.html) event.

{% aspTab template="tree-grid/columns-core/auto-fit", sourceFiles="autofit.cs" %}

{% endaspTab %}

> You can autofit all the columns by invoking the autoFitColumns method without column names.

## Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the treegrid. To enable reordering, set the [`allowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowReordering.html) to true.

{% aspTab template="tree-grid/columns-core/reorder-columns", sourceFiles="default.cs" %}

{% endaspTab %}

> You can disable reordering a particular column by setting the [`allowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to false.

### Reorder Multiple Columns

Multiple columns can be reordered at a time by using the **reorderColumns** method.

{% aspTab template="tree-grid/columns-core/reorder-multi-columns", sourceFiles="default.cs" %}

{% endaspTab %}

## Lock Columns

You can lock columns by using [`column.lockColumn`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~LockColumn.html) property. The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Duration column is locked and its reordering functionality is disabled.

{% aspTab template="treegrid/columns-core/lock", sourceFiles="lock.cs" %}

{% endaspTab %}

## Column resizing

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowResizing.html) property to true.

{% aspTab template="tree-grid/columns-core/resizing", sourceFiles="resizing.cs" %}

{% endaspTab %}

> You can disable resizing for a particular column by setting the [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

### Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`minWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MinWidth.html) and [`maxWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MaxWidth.html) properties of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

In the following sample, minimum and maximum width are defined for **Duration**, and **Task Name** columns.

{% aspTab template="tree-grid/columns-core/width", sourceFiles="width.cs" %}

{% endaspTab %}

### Resize Stacked Column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for particular stacked column by setting [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) as **false** to its columns.

{% aspTab template="tree-grid/columns-core/stacked-columns", sourceFiles="default.cs" %}

{% endaspTab %}

### Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed.

The following screenshot represents the column resizing in touch device.

<!-- markdownlint-disable MD033 -->
<img src="../images/column-resizing.png" alt="Touch interaction" style="width:320px;height: 620px">
<!-- markdownlint-enable MD033 -->

## Column template

The column [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Template.html) has options to display custom element instead of a field value in the column.

{% aspTab template="tree-grid/columns-core/column-template", sourceFiles="columntemplate.cs" %}

{% endaspTab %}

> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the
template column, the treegrid actions cannot be performed.

### Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Approved** field value.

{% aspTab template="tree-grid/columns-core/conditional-template", sourceFiles="default.cs" %}

{% endaspTab %}

## Column type

Column type can be specified using the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper. It specifies the type of data the column binds.

If the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html)  is defined for a column, the column uses [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) to select the appropriate format option ([number](../../common/internationalization/#number-formatting)
 or [date](../../common/internationalization/#manipulating-datetime)).

TreeGrid column supports the following types:
* string
* number
* boolean
* date
* datetime

> If the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) is not defined, it will be determined from the first record of the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html).

## Column Chooser

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the
[`showColumnChooser`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnChooser.html) as true.

{% aspTab template="tree-grid/columns-core/columnchooser", sourceFiles="columnchooser.cs" %}

{% endaspTab %}

> You can hide the column names in column chooser by defining the [`showInColumnChooser`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowInColumnChooser.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper as false.

### Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking the **openColumnChooser** method with X and Y axis positions.

{% aspTab template="tree-grid/columns-core/externalbutton", sourceFiles="externalbutton.cs" %}

{% endaspTab %}

## Column menu

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`showColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnMenu.html) property as true.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in `FilterSettings.Type` |

{% aspTab template="tree-grid/columns-core/column-menu", sourceFiles="default.cs" %}

{% endaspTab %}

> You can disable column menu for a particular column by defining the [`showColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowColumnMenu.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper as false.

## Checkbox Column

To render checkboxes in existing column, you need to set [`showCheckbox`] property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as **true**.

It is also possible to select the rows hierarchically using checkboxes in TreeGrid by enabling [`autoCheckHierarchy`] property. When we check on any parent record checkbox then the child record checkboxes will get checked.

{% aspTab template="tree-grid/columns-core/checkbox", sourceFiles="checkbox.cs" %}

{% endaspTab %}

## Responsive columns

You can toggle column visibility based on media queries which are defined
at the [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html).
The [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html).

{% aspTab template="tree-grid/columns-core/responsive", sourceFiles="responsive.cs" %}

{% endaspTab %}

## Controlling TreeGrid actions

You can enable or disable treegrid action for a particular column by setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html), and [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowSorting.html) properties of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% aspTab template="tree-grid/columns-core/prevent-column-actions", sourceFiles="columnActions.cs" %}

{% endaspTab %}

## Show/hide columns by external button

You can show or hide treegrid columns dynamically using external buttons by invoking the **showColumns** or **hideColumns** method.

{% aspTab template="tree-grid/columns-core/show-hide", sourceFiles="showHide.cs" %}

{% endaspTab %}

## Complex data binding

You can achieve complex data binding in the treegrid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html).

{% aspTab template="tree-grid/columns-core/complex-data", sourceFiles="complexData.cs" %}

{% endaspTab %}

## ValueAccessor

The [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) is used to access/manipulate the value of display data. You can achieve custom value formatting by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% aspTab template="tree-grid/columns-core/value-accessor-formats", sourceFiles="valueAccessor.cs" %}

{% endaspTab %}

### Display array type columns

You can bind an array of objects in a column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.
In this example, the name field has an array of two objects, FirstName and LastName. These two objects are joined and bound to a column using the
[`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% aspTab template="tree-grid/columns-core/value-accessor", sourceFiles="valueAccessor.cs" %}

{% endaspTab %}

### Expression column

You can achieve the expression column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.

{% aspTab template="tree-grid/columns-core/expression-columns", sourceFiles="express.cs" %}

{% endaspTab %}

## How to render boolean values as checkbox

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisplayAsCheckBox.html) property as **true**.

{% aspTab template="tree-grid/columns-core/checkbox-column", sourceFiles="checkbox.cs" %}

{% endaspTab %}

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.