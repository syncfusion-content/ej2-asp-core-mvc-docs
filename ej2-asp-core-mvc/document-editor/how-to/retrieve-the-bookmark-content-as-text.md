---
layout: post
title: Retrieve the whole document and bookmark content as text in ##Platform_Name## Document Editor Component
description: Learn how to retrieve the whole document and bookmark content as text from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Retrieve The Whole Document And Bookmark Content As Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to retrieve the whole document and bookmark content as text in  Document Editor component

You can get the bookmark or whole document content from the Document Editor component as plain text and SFDT (rich text).

## Get the bookmark content as plain text

You can [`selectBookmark`] API to navigate to the bookmark and use [`text`] API to get the bookmark content as plain text from Document Editor component.

The following example code illustrates how to get the bookmark content as plain text.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

To get the bookmark content as SFDT (rich text), check this [`link`](../../document-editor/how-to/get-the-selected-content/#get-the-selected-content-as-sfdt-rich-text)

## Get the whole document content as text

You can use [`text`] API to get the whole document content as plain text from Document Editor component.

The following example code illustrates how to get the whole document content as plain text.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Get the whole document content as SFDT(rich text)

You can use [`serialize`] API to get the whole document content as SFDT string from Document Editor component.

The following example code illustrates how to get the whole document content as SFDT.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Get the header content as text

You can use [`goToHeader`] API to navigate the selection to the header and then use [`text`] API to get the content as plain text.

The following example code illustrates how to get the header content as plain text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

Similarly, you can use [`goToFooter`] API to navigate the selection to the footer and then use [`text`] API to get the content as plain text.