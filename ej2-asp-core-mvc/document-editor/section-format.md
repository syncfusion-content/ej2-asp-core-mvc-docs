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

When the maximum Margin value of limit is reached, an alert will appear, as follow 

![Margin Limit Alert](images/Margin_Limit_Alert.PNG) 

>Note: The maximum value of Margin is 1584, as per Microsoft Word application and you can set any value less than 1584 to this property. If you set any value greater than 1584, then Syncfusion Document editor will automatically reset as 1584.

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

## See Also

* [Pagesetup dialog](../document-editor/dialog#page-setup-dialog)