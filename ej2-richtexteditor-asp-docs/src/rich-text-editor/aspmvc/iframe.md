---
title: "ASP.NET MVC Rich Text Editor Iframe mode"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET MVC Rich Text Editor control demonstrates the default rendering of the Rich Text Editor in iframe mode."
---

# Iframe

When the [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) option is enabled, the Rich Text Editor creates the iframe element as the content area on control initialization; it is used to display and editing the content. In content area, the editor displays only the body tag of a `< iframe >` document.

{% aspTab template="rich-text-editor/iframe", sourceFiles="controller.cs" %}

{% endaspTab %}

## Iframe Attributes

The editor allows you to pass an additional attribute to body tag of a < iframe > element using attributes fields of the `attributes` fields of [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property. This property contains name/value pairs in string format. It is used to override the default appearance of the content area.

{% aspTab template="rich-text-editor/iframe-attributes", sourceFiles="controller.cs" %}

{% endaspTab %}

## Adding External CSS/Script File

The editor offers you to add external CSS file to style the `< iframe >` element. Easily change the appearance of editor’s content using an external CSS file using  `styles` field in [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property.

Likewise, add the external script file to the `<iframe>` element using `scripts` field of `IframeSettings` to provide the additional functionalities to the Rich Text Editor.

{% aspTab template="rich-text-editor/external-css", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [How to change the editor mode](./formation/#markdown-editor)