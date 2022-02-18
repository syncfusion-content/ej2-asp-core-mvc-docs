---
layout: post
title: Columns Core in ##Platform_Name## Tree Grid Component
description: Learn here all about Columns Core in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Columns Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns

The column definitions are used as the dataSource schema in the TreeGrid. This plays a vital role in rendering column values in the required format.
The treegrid operations such as sorting, filtering and searching etc. are performed based on column definitions. The [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property of [`e-treegrid-columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) tag helper
is necessary to map the data source values in TreeGrid columns.

> 1. If the column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the dataSource, the column values will be empty.
> 2. If the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) name contains “dot” operator, it is considered as complex binding.

[`treeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) property denotes the column that is used to expand and collapse child rows.

## Header Template

You can customize the header element by using the [`headerTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderTemplate.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/header-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header text

By default, column header title is displayed from column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) value. To override the default header title, you have to define the [`headerText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If both the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) and [`headerText`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html)
are not defined in the column, the column renders with **empty** header text.

## Format

To format cell values based on specific culture, use the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper. The TreeGrid uses [`Internalization`](../../common/internationalization/) library to format the number values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/format-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/tree-grid/columns-core/format-columns/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/tree-grid/columns-core/format-columns/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the number and date values are formatted in **en-US** locale.

### Number formatting

The number or integer values can be formatted using the below format strings.

Format |Description |Remarks
-----|-----
N | Denotes numeric type. | The numeric format is followed by integer value as N2, N3. etc which denotes the number of precision to be allowed.
C | Denotes currency type. | The currency format is followed by integer value as C2, C3. etc which denotes the number of precision to be allowed.
P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 100. For example the cell value `0.2` is formatted as `20%`. The percentage format is followed by integer value as P2, P3. etc which denotes the number of precision to be allowed.

Please refer to the link to know more about [`Number formatting`](../../common/internationalization/#number-formatting).

### Date formatting

You can format date values either using built-in date format string or custom format string.

For built-in date format you can specify [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property as string   (Example: `yMd`). Please refer to the link to know more about [`Date formatting`](../../common/internationalization/#manipulating-datetime).

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
{% include code-snippet/tree-grid/columns-core/date-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dateformat.cs" %}
{% include code-snippet/tree-grid/columns-core/date-format/dateformat.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Dateformat.cs" %}
{% include code-snippet/tree-grid/columns-core/date-format/dateformat.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## AutoFit specific columns

The autoFitColumns method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataBound.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-core/auto-fit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can autofit all the columns by invoking the autoFitColumns method without column names.

## Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the treegrid. To enable reordering, set the [`allowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowReordering.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/reorder-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/reorder-columns/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/reorder-columns/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable reordering a particular column by setting the [`allowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to false.

### Reorder Multiple Columns

Multiple columns can be reordered at a time by using the **reorderColumns** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/reorder-multi-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/reorder-multi-columns/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/reorder-multi-columns/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Lock Columns

You can lock columns by using [`column.lockColumn`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~LockColumn.html) property. The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Duration column is locked and its reordering functionality is disabled.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/tree-grid/columns-core/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}

## Column resizing

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowResizing.html) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/resizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resing.cs" %}
{% include code-snippet/tree-grid/columns-core/resizing/resing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Resing.cs" %}
{% include code-snippet/tree-grid/columns-core/resizing/resing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

### Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`minWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MinWidth.html) and [`maxWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MaxWidth.html) properties of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

In the following sample, minimum and maximum width are defined for **Duration**, and **Task Name** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/tree-grid/columns-core/width/width.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/tree-grid/columns-core/width/width.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Resize Stacked Column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for particular stacked column by setting [`allowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) as **false** to its columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/stacked-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/stacked-columns/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/stacked-columns/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed.

The following screenshot represents the column resizing in touch device.

<!-- markdownlint-disable MD033 -->
<img src="../images/column-resizing.png" alt="Touch interaction" style="width:320px;height: 620px">
<!-- markdownlint-enable MD033 -->

## Column template

The column [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Template.html) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columntemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/column-template/columntemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Columntemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/column-template/columntemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the
template column, the treegrid actions cannot be performed.

### Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Approved** field value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/columnchooser/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-core/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-core/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide the column names in column chooser by defining the [`showInColumnChooser`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowInColumnChooser.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper as false.

### Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking the **openColumnChooser** method with X and Y axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/externalbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-core/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-core/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/column-menu/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/column-menu/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable column menu for a particular column by defining the [`showColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowColumnMenu.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper as false.

## Checkbox Column

To render checkboxes in existing column, you need to set [`showCheckbox`] property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as **true**.

It is also possible to select the rows hierarchically using checkboxes in TreeGrid by enabling [`autoCheckHierarchy`] property. When we check on any parent record checkbox then the child record checkboxes will get checked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive columns

You can toggle column visibility based on media queries which are defined
at the [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html).
The [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/responsive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/columns-core/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/columns-core/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Controlling TreeGrid actions

You can enable or disable treegrid action for a particular column by setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html), and [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowSorting.html) properties of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnActions.cs" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/columnActions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ColumnActions.cs" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/columnActions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show/hide columns by external button

You can show or hide treegrid columns dynamically using external buttons by invoking the **showColumns** or **hideColumns** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/tree-grid/columns-core/show-hide/showHide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/tree-grid/columns-core/show-hide/showHide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Complex data binding

You can achieve complex data binding in the treegrid by using the dot(.) operator in the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/complex-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ComplexData.cs" %}
{% include code-snippet/tree-grid/columns-core/complex-data/complexData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ComplexData.cs" %}
{% include code-snippet/tree-grid/columns-core/complex-data/complexData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## ValueAccessor

The [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) is used to access/manipulate the value of display data. You can achieve custom value formatting by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Display array type columns

You can bind an array of objects in a column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.
In this example, the name field has an array of two objects, FirstName and LastName. These two objects are joined and bound to a column using the
[`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Expression column

You can achieve the expression column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Express.cs" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/express.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Express.cs" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/express.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to render boolean values as checkbox

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisplayAsCheckBox.html) property as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.