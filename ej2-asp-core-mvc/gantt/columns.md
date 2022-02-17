---
layout: post
title: Columns in ##Platform_Name## Gantt Component
description: Learn here all about Columns in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns

The column displays information from a bound data source, and you can edit the values of column to update the task details through TreeGrid. The operations such as sorting, filtering, and searching can be performed based on column definitions. To display a Gantt column, the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Field) property should be mapped from the data source to the column.

> If the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Field) is not specified in the data source, the column values will be empty.

The [`TreeColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TreeColumnIndex) property is used to define the expander column in the Gantt control to expand and collapse the child rows.

## Defining columns

Using the [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Columns) property, you can define the columns in Gantt. If the columns are not defined, then the default columns will be rendered based on the mapped data source fields in the [`TaskFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property. Refer to the following code example for defining the columns in Gantt along with their widths.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/definingColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/columns/definingColumns/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/definingColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/columns/definingColumns/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/definingColumns.png)

## Custom column header

The column header text can be defined using the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HeaderText) property, and you can customize the column headers using the [`HeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HeaderTemplate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/headerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplate.cs" %}
{% include code-snippet/gantt/columns/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/headerTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplate.cs" %}
{% include code-snippet/gantt/columns/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/headerTemplate.png)

## Format

To format the cell values based on a specific culture, use the [`Columns.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Format) property. The Gantt control uses the [`Internationalization`](../../common/internationalization/) library to format [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime) values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumn.cs" %}
{% include code-snippet/gantt/columns/formatColumn/formatColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumn.cs" %}
{% include code-snippet/gantt/columns/formatColumn/formatColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/formatColumn.png)

> By default, the [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime) values are formatted in `en-US` culture.

### Number formatting

The number or integer values can be formatted using the following format strings.

Format |Description |Remarks
-----|-----
N | Denotes numeric type. | The numeric format is followed by an integer value like N2 or N3, which denotes the number of precisions to be allowed.
C | Denotes currency type. | The currency format is followed by an integer value like C2 or C3, which denotes the number of precisions to be allowed.
P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 100. For example, the cell value `0.2` is formatted as `20%`. The percentage format is followed by an integer value like P2, P3, which denotes the number of precisions to be allowed.

### Date formatting

You can format date values either using the built-in date format string or a custom format string.

For the built-in date format, you can specify the [`Columns.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Format) property as string (example: `yMd`).

You can also use the custom format string to format the date values. Some of the custom formats and the formatted date values are given in the following table.

Format | Formatted value
-----|-----
{ type:'date', format:'dd/MM/yyyy' } | 04/07/2019
{ type:'date', format:'dd.MM.yyyy' } | 04.07.2019
{ type:'date', skeleton:'short' } | 7/4/19
{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/2019 12:00 AM
{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/2019 12:00:00 AM

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumns.cs" %}
{% include code-snippet/gantt/columns/formatColumns/formatColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumns.cs" %}
{% include code-snippet/gantt/columns/formatColumns/formatColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column reordering

The column reordering can be done by dragging a column header from one index to another index within the TreeGrid. To enable reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowReordering) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reOrdering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrdering.cs" %}
{% include code-snippet/gantt/columns/reOrdering/reOrdering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reOrdering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrdering.cs" %}
{% include code-snippet/gantt/columns/reOrdering/reOrdering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable the reordering of a particular column by setting the [`Columns.AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowReordering) property to `false`.

### Reorder Events

During the reorder action, the gantt component triggers the below three events.

1. The [`columnDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDragStart) event triggers when column header element drag (move) starts.
2. The [`columnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrag) event triggers when column header element is dragged (moved) continuously.
3. The [`columnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrop) event triggers when a column header element is dropped on the target column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reorderEvents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReorderEvents.cs" %}
{% include code-snippet/gantt/columns/reorderEvents/reorderEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reorderEvents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReorderEvents.cs" %}
{% include code-snippet/gantt/columns/reorderEvents/reorderEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Reorder multiple columns

Multiple columns can be reordered at a time by using the `reorderColumns` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reOrderMultiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrderMultiple.cs" %}
{% include code-snippet/gantt/columns/reOrderMultiple/reOrderMultiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/reOrderMultiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrderMultiple.cs" %}
{% include code-snippet/gantt/columns/reOrderMultiple/reOrderMultiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column resizing

The column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To resize the column, set the [`AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowResizing) property to true. The following code example shows how to enable the column resize feature in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/resizeColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ResizeColumns.cs" %}
{% include code-snippet/gantt/columns/resizeColumns/resizeColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/resizeColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResizeColumns.cs" %}
{% include code-snippet/gantt/columns/resizeColumns/resizeColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`Columns.AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowResizing) to `false`.

### Defining minimum and maximum column width

The column resizing can be restricted between minimum and maximum widths by defining the [`Columns->MinWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_MinWidth) and [`Columns->MaxWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_MaxWidth) properties.

In the following example, the minimum and maximum widths are defined for the `Duration`, and `Task Name` columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/minMaxWidth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinMaxWidth.cs" %}
{% include code-snippet/gantt/columns/minMaxWidth/minMaxWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/minMaxWidth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinMaxWidth.cs" %}
{% include code-snippet/gantt/columns/minMaxWidth/minMaxWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column template

A column template is used to customize the column’s look. The following code example explains how to define the custom template in Gantt using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Template) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnTemplate.cs" %}
{% include code-snippet/gantt/columns/columnTemplate/columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnTemplate.cs" %}
{% include code-snippet/gantt/columns/columnTemplate/columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/columnTemplate.png)

## Column menu

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click the Multiple icon of the column. To enable the column menu, you should set the [`ShowColumnMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ShowColumnMenu) property to true.
The default items are displayed in the following table:

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in the `filterSettings.type` property. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnMenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnMenu.cs" %}
{% include code-snippet/gantt/columns/columnMenu/columnMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/columnMenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnMenu.cs" %}
{% include code-snippet/gantt/columns/columnMenu/columnMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/columnMenu.png)

> You can disable the column menu for a particular column by setting the `Columns.ShowColumnMenu` to `false`.

### Column menu Events

During the resizing action, the gantt component triggers the below two events.

1. The [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuOpen) event triggers before the column menu opens.
2. The [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuClick) event triggers when the user clicks the column menu of the gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuEvents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuEvents.cs" %}
{% include code-snippet/gantt/columns/colMenuEvents/colMenuEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuEvents/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuEvents.cs" %}
{% include code-snippet/gantt/columns/colMenuEvents/colMenuEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Custom Column Menu Item

Custom column menu items can be added by defining the `columnMenuItems`.
Actions for this customized items can be defined in the [`columnMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuClick) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuItem/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuItem.cs" %}
{% include code-snippet/gantt/columns/colMenuItem/colMenuItem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuItem/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuItem.cs" %}
{% include code-snippet/gantt/columns/colMenuItem/colMenuItem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customize menu items for particular columns

Sometimes, you have a scenario that to hide an item from column menu for particular columns. In that case, you need to define the `columnMenuOpenEventArgs.hide` as true in the [`columnMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnMenuOpen) event.

The following sample, **Filter** item was hidden in column menu when opens for the **Task Name** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuAction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuAction.cs" %}
{% include code-snippet/gantt/columns/colMenuAction/colMenuAction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colMenuAction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColMenuAction.cs" %}
{% include code-snippet/gantt/columns/colMenuAction/colMenuAction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive columns

You can toggle the column visibility based on media queries, which are defined in the [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia). The [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia) accepts valid [Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html ).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change tree/expander column

The tree/expander column is a column in the Gantt control, that has icons to expand or collapse the parent records. You can define the tree column index in the Gantt control by using the [`TreeColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TreeColumnIndex) property and the default value of this property is `0`. The following code example shows how to use this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/treeColumnIndex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TreeColumnIndex.cs" %}
{% include code-snippet/gantt/columns/treeColumnIndex/treeColumnIndex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/treeColumnIndex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TreeColumnIndex.cs" %}
{% include code-snippet/gantt/columns/treeColumnIndex/treeColumnIndex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/treeColumnIndex.png)

## Show or Hide columns Dynamically

You can show or hide gantt columns dynamically using external buttons by invoking the `showColumn` or `hideColumn` method. The **Progress** column is hidden and shown on button clicking.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/showHide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/gantt/columns/showHide/showHide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/showHide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/gantt/columns/showHide/showHide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/showhidecol.png)

## Checkbox Column

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](../api/gantt/column/#displayascheckbox) property as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/gantt/columns/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/gantt/columns/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/checkbox.png)

## Controlling Grid actions

You can enable or disable gantt action for a particular column by setting the `allowFiltering`, `allowSorting`, `allowReordering`, and [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettingsBuilder.html#Syncfusion_EJ2_Gantt_GanttEditSettingsBuilder_AllowEditing_System_Boolean_) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/gridActions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GridActions.cs" %}
{% include code-snippet/gantt/columns/gridActions/gridActions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/gridActions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GridActions.cs" %}
{% include code-snippet/gantt/columns/gridActions/gridActions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column Type

Column type can be specified using the `columns.type` property. It specifies the type of data the column binds.

If the `format` is defined for a column, the column uses `type` to select the appropriate format option **number** or **date**.

Gantt column supports the following types:
* string
* number
* boolean
* date
* date-time
> If the `type` is not defined, it will be determined from the first record of the `dataSource`.
> In case if the first record of the `dataSource` is null/blank value for a column then it is necessary to define the `type` for that column.

## Column Spanning

The gantt has option to span the adjacent cells. You need to define the `colSpan` attribute to span cells in the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryCellInfo) event.

In the following demo, **Work 1** cells have been spanned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colSpan/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColSpan.cs" %}
{% include code-snippet/gantt/columns/colSpan/colSpan.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/colSpan/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColSpan.cs" %}
{% include code-snippet/gantt/columns/colSpan/colSpan.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/colspan.png)