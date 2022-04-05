---
layout: post
title: Open Default Document in ##Platform_Name## Document Editor Component
description: Learn here all about how to open default document in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open Default Document
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open a default document in DocumentEditor when initialized

This article explains how to open a default document when DocumentEditor & DocumentEditorContainer is initialized.

## Opening a default document in DocumentEditor

Using `open` method in Document editor allows to open the Document in sfdt format. To open the document by default, call the open method in the `created` event of Document editor which gets triggered once the control is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/open-default-document/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/open-default-document/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/open-default-document/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/open-default-document/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opening a default document in DocumentEditorContainer

To open the document by default, call the open method in the `created` event of Document editor container which gets triggered once the control is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-default-document/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-default-document/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/open-default-document/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/open-default-document/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

