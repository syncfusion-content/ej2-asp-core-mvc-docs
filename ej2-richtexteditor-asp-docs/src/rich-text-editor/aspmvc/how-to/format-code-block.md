---
title: "Rich Text Editor how to format code block using toolbar button"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains how about how to format code block using toolbar button."
---

# Format code block using toolbar button

You can configure code block formatting as a separate toolbar button by adding the **InsertCode** keyword within the [`ToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_ToolbarSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_) items property.

The InsertCode button has a toggle state to apply code block formatting to the editor and remove code block formatting from the editor.

The following sample demonstrates how to config the InsertCode button in toolbar and set the background color to “pre” tag for highlighting the code block.

{% aspTab template="rich-text-editor/how-to/format-code-block", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![Code Format](../../rich-text-editor/images/format-code-block.png)