---
title: "Rich Text Editor Inline editing mode"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET MVC Rich Text Editor control demonstrates on how to enable the inline mode editor on demand while editing the content."
---

# Inline Mode

This is the inline example for the Rich Text Editor. For this you must set the [`InlineMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InlineMode) property.

Inline edition allows you to select any editable element or click the element on the page and edit it in-place.

Inline editing is a true WYSIWYG formation and on the contrary to Rich Text Editor HTML/MD editing, the styles that are used for edited content comes directly from the document stylesheet. This means that inline editors ignore the default Rich Text Editor content styles.

## Show on Select/Click

Enabling the `onSelection` option of inlineMode makes the inline Rich Text Editor to appear.  You can select the text in the editable area otherwise the inline Rich Text Editor will be appear once click into the editable area.

{% aspTab template="rich-text-editor/inline", sourceFiles="controller.cs" %}

{% endaspTab %}

![Rich Text Editor InlineMode](./images/inline.png)

## See Also

* [How to edit the quick toolbar settings](./toolbar/#quick-inline-toolbar)
* [How to insert link editing option in the toolbar items](./link/#insert-link)
* [How to insert image editing option in the toolbar items](./image/#upload-options)