---
title: "Dialog"
component: "DocumentEditor"
description: "Learn the built-in dialog support in ASP.NET CORE document editor and how to open it."
---

# Dialog

Documenteditor provides dialog support to major operations such as insert or edit hyperlink, formatting text, paragraph, style, list and table properties.

## Font Dialog

Font dialog allows you to modify all text properties for selected contents at once such as bold, italic, underline, font size, font color, strikethrough, subscript and superscript.

>To enable font dialog for a document editor instance, set ‘enableFontDialog’ to true.

Refer to the following example.

{% aspTab template="document-editor/dialog", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Paragraph dialog

This dialog allows modifying the paragraph formatting for selection at once such as text alignment, indentation, and spacing.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/paragraph-dialog" %}

{% endaspTab %}

## Table dialog

This dialog allows creating and inserting a table at cursor position by specifying the required number of rows and columns.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/table-dialog" %}

{% endaspTab %}

## Bookmark dialog

This dialog allows you to perform the following operations:

* View all bookmarks.
* Navigate to a bookmark.
* Create a bookmark at current selection.
* Delete an existing bookmark.
To open this dialog, refer to the following example.

{% aspTab template="document-editor/bookmark-dialog" %}

{% endaspTab %}

## Hyperlink dialog

This dialog allows editing or inserting a hyperlink at cursor position.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/hyperlink-dialog" %}

{% endaspTab %}

## Table of contents dialog

This dialog allows creating and inserting table of contents at cursor position. If the table of contents already exists at cursor position, you can customize its properties.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/table-of-contents-dialog" %}

{% endaspTab %}

## Styles Dialog

This dialog allows managing the styles in a document. It will display all the styles in the document with options to modify the properties of the existing style or create new style with the help of ‘Style dialog’. Refer to the following example.

{% aspTab template="document-editor/styles-dialog" %}

{% endaspTab %}

## Style dialog

You can directly use this dialog for modifying any existing style or add new style by providing the style name.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/style-dialog" %}

{% endaspTab %}

## List dialog

This dialog allows creating a new list or modifying existing lists in the document.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/list-dialog" %}

{% endaspTab %}

## Borders and shading dialog

This dialog allows customizing the border style, border width, and background color of the table or selected cells.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/borders-and-shading-dialog" %}

{% endaspTab %}

## Table options dialog

This dialog allows customizing the default cell margins and spacing between each cells of the selected table.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/table-options-dialog" %}

{% endaspTab %}

## Table properties dialog

This dialog allows customizing the table, row, and cell properties of the selected table.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/table-properties-dialog" %}

{% endaspTab %}

## Page setup dialog

This dialog allows customizing margins, size, and layout options for pages of the section.

To open this dialog, refer to the following example.

{% aspTab template="document-editor/page-setup-dialog" %}

{% endaspTab %}

## See Also

* [Feature module](../../document-editor/feature-module/)
