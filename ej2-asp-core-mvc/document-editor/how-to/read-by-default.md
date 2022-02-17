---
layout: post
title: Read By Default in ##Platform_Name## Document Editor Component
description: Learn here all about Read By Default in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Read By Default
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open a document in read only mode by default in Document Editor

In this article, we are going to see how to open a document in read only mode by default in Document Editor & Document  Editor Container.

## Opening a document in read only mode by default in Document Editor

Using `isReadOnly` property in Document editor allows us to enable/disable read only mode in the document editor.

The following example illustrates how to open the document in read-only mode by default.

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

Using `restrictEditing` property in Document editor container allows us to enable/disable read only mode in the document editor.

The following example illustrates how to open the document in read only mode by default.

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



> You can use the `restrictEditing` in `DocumentEditorContainerComponent` and `isReadOnly` in `DocumentEditorComponent` based on your requirement to change component to read only mode.