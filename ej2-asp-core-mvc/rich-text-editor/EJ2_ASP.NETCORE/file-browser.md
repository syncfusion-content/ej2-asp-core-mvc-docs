---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about File Browser of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: File Browser
publishingplatform: ##Platform_Name##
documentation: ug
---


# File Browser

Rich Text Editor allows to browse and insert images in the edit panel using the file browser. File browser allows the users to browse and select a file or folder from the file system and it supports various cloud services.

The following example explains how to configure the file browser within the Rich Text Editor component.

* Configure the `FileManager` toolbar item in the `toolbarSettings` API `items` property.
* Set [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFileManagerSettings_Enable) property as `true` on [`fileManagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html) property to make the file browser in the Rich Text Editor to appear on the `FileManager` toolbar click action.

{% aspTab template="rich-text-editor/file-browser", sourceFiles="controller.cs" %}

{% endaspTab %}