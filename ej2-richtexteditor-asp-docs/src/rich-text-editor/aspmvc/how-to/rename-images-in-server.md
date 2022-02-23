---
title: "How To rename uploaded images before inserting in RTE"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains on how to rename images in server and get the updated name for the image."
---

# Rename uploaded images in server before inserting it in the Rich Text Editor

By using the [`InsertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertImageSettings) property, you can specify the server handler to upload the selected image. Then you can bind the [`ImageUploadSuccess`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ImageUploadSuccess) event, to receive the modified file name from the server and update it in the Rich Text Editor's insert image dialog.

Refer `rename.cs` controller file for configure the server-side.

> Note: The runnable demo application is available in this [Github](https://github.com/SyncfusionExamples/aspnet-mvc-richtexteditor-rename-image) repository.

{% aspTab template="rich-text-editor/how-to/rename", sourceFiles="rename.cs" %}

{% endaspTab %}