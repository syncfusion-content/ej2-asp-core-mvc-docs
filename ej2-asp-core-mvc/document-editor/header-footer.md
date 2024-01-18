---
layout: post
title: Header Footer in ##Platform_Name## Document Editor Component
description: Learn here all about Header Footer in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Header Footer
publishingplatform: ##Platform_Name##
documentation: ug
---


# Headers and Footers

Document editor supports headers and footers in its document. Each section in the document can have the following types of headers and footers:

* First page: Used only on the first page of the section.
* Even pages: Used on all even numbered pages in the section.
* Default: Used on all pages of the section, where the first or even pages are not applicable or not specified.

You can define this by setting format properties of the corresponding section using the following sample code.

```typescript
//Defines whether different header footer is required for first page of the section
documenteditor.selection.sectionFormat.differentFirstPage= true;
//Defines whether different header footer is required for odd and even pages in the section
documenteditor.selection.sectionFormat.differentOddAndEvenPages= true;
```

## Go to header footer region

Double click in header or footer region to move the selection into it.

```typescript
documenteditor.selection.goToHeader();
```

```typescript
documenteditor.selection.goToFooter();
```

## Link to previous

Link to previous is enabled by default when document has more than one section. If you're using different headers and footers such as different first page or different odd and even pages, they can't be linked together because they're all separate.

Before setting or getting the link to previous value, use the ['goToHeader'](../api/document-editor/selection/#gotoheader) or ['goToFooter'](../api/document-editor/selection/#gotofooter) API to move the current selection to the header or footer region.

You can get or set the default header footer link to previous value of a section at cursor position by using the following sample code.

```typescript
container.documentEditor.selection.sectionFormat.oddPageHeader.linkToPrevious = false;
container.documentEditor.selection.sectionFormat.oddPageFooter.linkToPrevious = false;
```

In case the document has different header and footer types, such as different first page, odd, and even pages.

```typescript
// Different first page
container.documentEditor.selection.sectionFormat.firstPageHeader.linkToPrevious = false;
container.documentEditor.selection.sectionFormat.firstPageFooter.linkToPrevious = false;
//Even page
container.documentEditor.selection.sectionFormat.firstPageHeader.linkToPrevious = false;
container.documentEditor.selection.sectionFormat.firstPageFooter.linkToPrevious = false;
```

N> When there is more than one section in the document, the Link to Previous option becomes available. By default, this feature is disabled state in UI and set to return false for the first section.

## Header and footer distance

You can define the distance of header region content from the top of the page.

```typescript
documenteditor.selection.sectionFormat.headerDistance= 36;
```

Same way, you can define the distance of footer region content from the bottom of the page.

```typescript
documenteditor.selection.sectionFormat.footerDistace=36;
```

## Close header footer region

Move the selection to the document body from header or footer region by double clicking or tapping the document area.

```typescript
documenteditor.selection.closeHeaderFooter()
```

## See Also

* [Working with Section Formatting](../document-editor/section-format)
