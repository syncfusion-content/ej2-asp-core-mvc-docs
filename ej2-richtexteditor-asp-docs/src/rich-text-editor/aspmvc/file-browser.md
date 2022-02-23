---
title: "Rich Text Editor File Browser"
component: "Rich Text Editor"
description: "This section for  explains about  how to enable the file browser feature in the Syncfusion ASP.NET MVC Rich Text Editor control."
---

# File Browser

Rich Text Editor allows to browse and insert images in the edit panel using the file browser. File browser allows the users to  browse and select a file or folder from the file system and it supports various cloud services.

The following example explains how to configure the file browser within the Rich Text Editor component.

* Configure the `FileManager` toolbar item in the `ToolbarSettings` API `Items` property.
* Set [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFileManagerSettings_Enable) property as `true` on [`FileManagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html) property to make the file browser in the Rich Text Editor to appear on the `FileManager` toolbar click action.

{% aspTab template="rich-text-editor/file-browser", sourceFiles="controller.cs" %}

{% endaspTab %}