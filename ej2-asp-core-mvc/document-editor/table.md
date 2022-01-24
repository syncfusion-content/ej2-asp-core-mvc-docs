---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Table of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Table
publishingplatform: ##Platform_Name##
documentation: ug
---

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

{% aspTab template="document-editor/table" %}

{% endaspTab %}

## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Insert table dialog](../../document-editor/dialog/#table-dialog)