---
layout: post
title: Disable drag and drop in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about Disable drag and drop in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disable drag and drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to disable drag and drop in document editor
You can customize the drag and drop option (enable and disable) using [`allowDragAndDrop`] property in Document editor settings.

The following example illustrates to customize the drag and drop option.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/disable-drag-and-drop/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-drag-and-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/disable-drag-and-drop/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable Drag And Drop option in documenteditor

To enable drag and drop option in DocumentEditor, set [`allowDragAndDrop`](https://ej2.syncfusion.com/react/documentation/api/document-editor-container/documenteditorsettings/#allowDragAndDrop) property as `true` . 

```csharp
container.documentEditorSettings.allowDragAndDrop = true ;
```

## Disable Drag And Drop option in documenteditor

To disable drag and drop option in DocumentEditor, set [`allowDragAndDrop`] property as `false` .

```csharp
container.documentEditorSettings.allowDragAndDrop = false ;
```

>Note: Default value of [`allowDragAndDrop`] property is `true` .