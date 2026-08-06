---
layout: post
title: Drag and Drop in ##Platform_Name## File Manager | Syncfusion
description: Learn how to enable drag and drop in the ##Platform_Name## File Manager to move or upload files between folders using built-in drag events.
control: File Manager
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag and Drop in ##Platform_Name## File Manager

The File Manager allows moving files or folders between directories using the `allowDragAndDrop` property. It also supports uploading a file by dragging it from Windows Explorer to the File Manager control. You can enable or disable this support by using the `allowDragAndDrop` property of File Manager.

The events triggered in drag and drop support are:

* `fileDragStart` - Triggers when the file/folder dragging is started.
* `fileDragging` - Triggers while dragging the file/folder.
* `fileDragStop` - Triggers when the file/folder is about to be dropped at the target.
* `fileDropped` - Triggers when the file/folder is dropped.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/drag-and-drop/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/drag-and-drop/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below.

![Drag and drop](./images/drag_and_drop.png)