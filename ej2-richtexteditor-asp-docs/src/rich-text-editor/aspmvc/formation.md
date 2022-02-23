---
title: "Rich Text Editor Formation"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET MVC Rich Text Editor control explains the markdown editing and HTML editing of the content through out the page."
---

# Formation

The Rich Text Editor control used to create and edit the content and return valid HTML markup or markdown (MD) of the content. It supports the following two editing formation.

* HTML Editor
* Markdown Editor

## HTML Editor

Rich Text Editor is a WYSIWYG editing control for formatting the word content as HTML.
The HTML editing mode is the default mode in Rich Text Editor to format the content through the available toolbar items to return the valid HTML markup. Set the [`EditorMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) property as `HTML`.

{% aspTab template="rich-text-editor/html-editor", sourceFiles="controller.cs" %}

{% endaspTab %}

## Markdown Editor

Set the [`EditorMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) property as Markdown, to create or edit the content and apply formatting to view markdown formatted content.

* The Supported Tags are  `h6`,`h5`,`h4`,`h3`,`h2`,`h1`,`blockquote`,`pre`,`p`,`ol`,`ul`.
* The Supported Selection Tags are `Bold`, `Italic`, `StrikeThrough`, `InlineCode`, `SubScript`, `SuperScript`, `UpperCase`, `LowerCase`.
* The supported insert commands are `Image`, `Link` and `Table`.

> The third-party library such as [`Marked`](https://marked.js.org/#/README.md#README.md) or any other library is used to convert markdown into HTML content.

{% aspTab template="rich-text-editor/markdown-editor", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [How to integrate the third party library](./third-party-integration/)
* [How to render the iframe](./iframe/)