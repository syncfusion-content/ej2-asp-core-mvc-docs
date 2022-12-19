---
layout: post
title: Read By Default in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about read by default in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Read By Default
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open a document in read only mode by default in Document Editor

This article explains how to open a document in read only mode by default in Document Editor & Document Editor Container.

## Opening a document in read only mode by default in Document Editor

Using [`isReadOnly`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_IsReadOnly) property in Document editor allows to enable or disable read only mode in the document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Opening a document in ready only mode by default in Document Editor Container

Using [`restrictEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_RestrictEditing) property in Document editor container allows to enable or disable read only mode in the document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/read-only/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Read-only.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



N> You can use the [`restrictEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_RestrictEditing) in [`DocumentEditorContainerComponent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html) and [`isReadOnly`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_IsReadOnly) in [`DocumentEditorComponent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html) based on your requirement to change component to read only mode.