---
layout: post
title: File Browser in ##Platform_Name## Rich Text Editor Component
description: Learn here all about File Browser in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: File Browser
publishingplatform: ##Platform_Name##
documentation: ug
---


# File Browser

Rich Text Editor allows to browse and insert images in the edit panel using the file browser. File browser allows the users to  browse and select a file or folder from the file system and it supports various cloud services.

The following example explains how to configure the file browser within the Rich Text Editor component.

* Configure the `FileManager` toolbar item in the `ToolbarSettings` API `Items` property.
* Set [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFileManagerSettings_Enable) property as `true` on [`FileManagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html) property to make the file browser in the Rich Text Editor to appear on the `FileManager` toolbar click action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/file-browser/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/file-browser/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/file-browser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/file-browser/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

