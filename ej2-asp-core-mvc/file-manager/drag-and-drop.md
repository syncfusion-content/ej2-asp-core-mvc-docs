---
layout: post
title: Drag And Drop in ##Platform_Name## File Manager Component
description: Learn here all about Drag And Drop in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drag And Drop

The file manager allows files or folders to be moved from one folder to another by using the [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AllowDragAndDrop.html) property. It also supports uploading a file by dragging it from Windows Explorer to  File Manager control. You can enable or disable this support by using the [allowDragAndDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AllowDragAndDrop.html) property of file manager.

The event triggered in drag and drop support are

* [fileDragStart](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~FileDragStart.html) - Triggers when the file/folder dragging is started.
* [fileDragging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~FileDragging.html) - Triggers while dragging the file/folder.
* [fileDragStop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~FileDragStop.html) - Triggers when the file/folder is about to be dropped at the target.
* [fileDropped](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~FileDropped.html) - Triggers when the file/folder is dropped.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/drag-and-drop/HomeController_mvc.cs %}
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



Output be like the below.

![Drag and drop](./images/drag_and_drop.png)