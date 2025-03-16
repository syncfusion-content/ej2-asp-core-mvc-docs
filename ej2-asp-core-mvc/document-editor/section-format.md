---
layout: post
title: Section Format in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about section format in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Section Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Section Formatting

Document editor supports various section formatting such as page size, page margins, and more.

## Page size

You can get or set the size of a section at cursor position by using the following sample code.

```typescript
documenteditor.selection.sectionFormat.pageWidth = 500;
documenteditor.selection.sectionFormat.pageHeight = 600;
```

You can change the orientation of the page by swapping the values of page width and height respectively.

## Page margins

Left and right page margin defines the gap between the document content from left and right side of the page respectively. Top and bottom page margins defines the gap between the document content from header and footer of the page respectively.

```typescript
documenteditor.selection.sectionFormat.leftMargin = 10;
documenteditor.selection.sectionFormat.rightMargin = 10;
documenteditor.selection.sectionFormat.bottomMargin = 10;
documenteditor.selection.sectionFormat.topMargin = 10;
```

## Header distance

You can define the distance of header content from the top of the page by using the following sample code.

```typescript
documenteditor.selection.sectionFormat.headerDistance = 72;
```

## Footer distance

You can define the distance of footer content from the bottom of the page by using the following sample code.

```typescript
documenteditor.selection.sectionFormat.footerDistance = 72;
```

## Columns

You can define the number of columns, column width, and space between columns for the pages in a section.

The following code example illustrates how to define the two columns layout for the pages in a section.

```typescript
let column: SelectionColumnFormat = new SelectionColumnFormat(documenteditor.selection);
column.width = 216;
column.space = 36;
documenteditor.selection.sectionFormat.columns = [column, column];
documenteditor.selection.sectionFormat.lineBetweenColumns = true;
```

## Breaks

You can insert Column break

The following code indicate that the text following the column break will begin in the next column

```typescript
documenteditor.editor.insertColumnBreak();
```

You can insert next page section break to start the new section on the next page

The following code example illustrates how to insert a next page section break

```typescript
documenteditor.editor.insertSectionBreak(SectionBreakType.NewPage);
```

You can insert continuous section break to start the new section on the same page

The following code example illustrates how to insert a continuous section break

```typescript
documenteditor.editor.insertSectionBreak(SectionBreakType.Continuous);
```

## See Also

* [Pagesetup dialog](../document-editor/dialog#page-setup-dialog)