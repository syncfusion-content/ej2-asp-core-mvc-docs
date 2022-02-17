---
layout: post
title: Table in ##Platform_Name## Document Editor Component
description: Learn here all about Table in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Table
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tables

Tables are an efficient way to present information. Document editor can display and edit the tables. You can select and edit tables through keyboard, mouse, or touch interactions. Document editor exposes a rich set of APIs to perform these operations programmatically.

## Create a table

You can create and insert a table at cursor position by specifying the required number of rows and columns.

Refer to the following sample code.

```typescript
 documenteditor.editor.insertTable(3,3);
```

The maximum size of row and column is limited to 32767 and 63 respectively.

## Insert rows

You can add a row (or several rows) above or below the row at cursor position by using the `insertRow` method. This method accepts the following parameters:

Parameter | Type | Description
----------|------|-------------
above(optional) | boolean | This is optional and if omitted, it takes the value as false and inserts below the row at cursor position.
count(optional) | number | This is optional and if omitted, it takes the value as 1.

Refer to the following sample code.

```typescript
//Inserts a row below the row at cursor position
documentedior.editor.insertRow();
//Inserts a row above the row at cursor position
documentedior.editor.insertRow(false);
//Inserts three rows below the row at cursor position
documentedior.editor.insertRow(true, 3)
```

## Insert columns

You can add a column (or several columns) to the left or right of the column at cursor position by using the `insertColumn` method. This method accepts the following parameters:

Parameter | Type | Description
----------|------|-------------
left(optional) | boolean| This is optional and if omitted, it takes the value as false and inserts to the right of column at cursor position.
count(optional) | number |  This is optional and if omitted, it takes the value as 1.

Refer to the following sample code.

```typescript
//Insert a column to the right of the column at cursor position.
documentedior.editor.insertColumn();
//Insert a column to the left of the column at cursor position.
documentedior.editor.insertColumn(false);
//Insert two columns to the left of the column at cursor position.
documentedior.editor.insertColumn(false, 2);
```

### Select an entire table

If the cursor position is inside a table, you can select the entire table by using the following sample code.

```typescript
documenteditor.selection.selectTable();
```

### Select row

You can select the entire row at cursor position by using the following sample code.

```typescript
documenteditor.selection.selectRow();
```

If current selection spans across cells of different rows, all these rows will be selected.

### Select column

You can select the entire column at cursor position by using the following sample code.

```typescript
documenteditor.selection.selectColumn();
```

If current selection spans across cells of different columns, all these columns will be selected.

### Select cell

You can select the cell at cursor position by using the following sample code.

```typescript
documenteditor.selection.selectCell();
```

## Delete table

Document editor allows you to delete the entire table. You can use the `deleteTable()` method of editor instance, if selection is in table. Refer to the following sample code.

```typescript
documenteditor.editor.deleteTable();
```

## Delete row

Document editor allows you to delete the selected number of rows. You can use the `deleteRow()` method of editor instance to delete the selected number of rows, if selection is in table. Refer to the following sample code.

```typescript
documenteditor.editor.deleteRow();
```

## Delete column

Document editor allows you to delete the selected number of columns. You can use the `deleteColumn ()` method of editor instance to delete the selected number of columns, if selection is in table. Refer to the following sample code.

```typescript
documenteditor.editor.deleteColumn();
```

## Merge cells

You can merge cells vertically, horizontally, or combination of both to a single cell. To vertically merge the cells, the columns within selection should be even in left and right directions. To horizontally merge the cells, the rows within selection should be even in top and bottom direction.
Refer to the following sample code.

```typescript
documenteditor.editor.mergeCells()
```

## Positioning the table

Document Editor preserves the position properties of the table and displays the table based on position properties. It does not support modifying the position properties. Whereas the table will be automatically moved along with text edited if it is positioned relative to the paragraph.

## How to work with tables

The following sample demonstrates how to delete the table row or columns, merge cells and how to bind the API with button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Insert table dialog](../../document-editor/dialog/#table-dialog)