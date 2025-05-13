---
layout: post
title: Disable Bookmark edit in ##Platform_Name## Document Editor Component
description: Learn how to to disable Bookmark content edit in Document from the Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS2 and more.
platform: ej2-asp-core-mvc
control: Disable Bookmark content edit
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Bookmark content edit in  Document Editor component

## Bookmark content edit in DocumentEditorContainer instance

You can use [`restrictEditing`] property to Bookmark content editing based on selection context type.

RestrictEditing allows you to restrict the document modification and makes the Document read only mode. So, by using this property, and if selection inside header or footer, you can set this property as true.

The following example code illustrates how to header and footer edit in `DocumentEditorContainer` instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-bookmark-content-edit-in-documenteditor-container/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="document-editor.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-bookmark-content-edit-in-documenteditor-container/razor %}
{% endhighlight %}
{% highlight c# tabtitle="document-editor.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


## Bookmark content edit in DocumentEditor instance

Like restrictEditing, you can use [`isReadOnly`] property in Document editor to Bookmark content edit.

The following example code illustrates how to header and footer edit in `DocumentEditor` instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-bookmark-content-edit-in-document-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="document-editor.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-bookmark-content-edit-in-document-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="document-editor.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
