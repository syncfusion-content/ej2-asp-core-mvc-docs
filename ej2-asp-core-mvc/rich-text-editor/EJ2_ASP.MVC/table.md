---
layout: post
title: Table in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Table in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Table
publishingplatform: ##Platform_Name##
documentation: ug
---


# Table

Rich Text Editor allows to insert table of content in edit panel and provide options to add, edit, and remove the table as well as perform other table related action. For inserting the table to the Rich Text Editor, the following list of options have been provided in the [`TableSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_TableSettings)

| Options | Description | Default Value |
|----------------|---------|-----------------------------|
| minWidth | Sets the default minWidth of the table. | 0 |
| maxWidth | Sets the default maxWidth of the table. | null |
| resize | Enable resize feature in table.| true |
| styles | This is an array of key value pair, on each pair, key should be name of styling and value is class name. this list will be shown on quick toolbar options to change the styles of table on designing like dashed, double bordered. | `TableStyleItems` |
| width | Sets the default width of the table. | 100% |

## Insert Table

Using the `table` toolbar option, select a number of rows and columns to be inserted over the table grid and insert table into Rich Text Editor content using the mouse.

Tables can also be inserted through the `Insert Table` option in the pop-up where the number of rows and columns can be provided manually, and this is the default way in devices.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/table/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/table/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Quick Toolbar

Quick toolbar is opened by clicking the table. It has different sets of commands to be performed on
the table which increases the feasibility to edit the table easily.

## Table Header

`Table Header` command is available with quick toolbar option through which the header row can be added or removed from the inserted table. The following image illustrates the table header.

![Rich Text Editor table header](./images/table_header.png)

## Insert Rows

`Rows` can be inserted above or below the required table cell through the quick toolbar. Also, focused row can be deleted. The following screenshot shows the available options of the row item.

![Rich Text Editor table row](./images/table_rows.png)

## Insert Columns

`Columns` can be inserted to the left or right side of the required table cell through the quick toolbar. Also, the focused column can be deleted. The following screenshot shows the available options of the column item.

![Rich Text Editor table column](./images/table_column.png)

## Set Color

The background color can be set for each table cell through the `background color` command available with quick toolbar.

![Rich Text Editor table background color](./images/table_bg_color.png)

## Delete Table

Using the delete item in the quick toolbar, users can delete the entire table.

## Vertical Align

Text inside the table can be aligned to top, middle, or bottom using the `tableCellVerticalAlign`
tool of the quick toolbar.

![Rich Text Editor table vertical alignment](./images/table_vertical.png)

## Horizontal Align

Text inside the table can be aligned left, right, or center using the `tableCellHorizontalAlign` tool
of the quick toolbar.

![Rich Text Editor table horizontal alignment](./images/table_horizontal.png)

## Table Styles

Table styles provided for class name should be appended to a table element. It helps to design the table in specific CSS styles when inserting in the editor.

By Default, provides Dashed border and Alternate rows.

**Dashed border**: Applies the dashed border to the table.

**Alternate border**: Applies the alternative background to the table.

![Rich Text Editor table styles](./images/table_style.png)

## Table Properties

Sets the default width of the table when it is inserted in the Rich Text Editor using the width of
[`TableSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_TableSettings).

Using the quick toolbar, users can change the width, cell padding, and cell spacing in the selected table using the properties option.

![Rich Text Editor table settings](./images/table_properties.png)

## Table cell merge and split

The Rich Text Editor allows users to change the appearance of the tables by splitting or merging the table cells.

`TableCell` item should be configured in the Table [quickToolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Table) Property to show the merge/split icons while selecting the table cells

### Table cell merge

The table cell merge feature allows you to merge two or more row and column cells into a single cell with its contents.

The following image explains the table merge action.

![RTE table cell merge](./images/table_merge.png)

### Table cell split

The table cell split feature allows you to split the merged cells both horizontally and vertically.

The following image explains the table split action.

![RTE table cell split](./images/table_split.png)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/table-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/table-cell/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/table-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/table-cell/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


