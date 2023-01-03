---
layout: post
title: Select and retrieve current word and Paragraph in ##Platform_Name## Document Editor Component
description: Learn how to select and retrieve current word and Paragraph from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Get The Current Word And Paragrapgh
publishingplatform: ##Platform_Name##
documentation: ug 
---

# How to select and retrieve the word and paragraph in current cursor position in Document Editor component

You can get the current word or paragraph content from the  Document Editor component as plain text and SFDT (rich text).

## Select and get the word in current cursor position

You can use [`selectCurrentWord`] API in selection module to select the current word at cursor position and use [`text`] API to get the selected content as plain text from Document Editor component.

The following example code illustrates how to select and get the current word as plain text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-word/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-word.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-word/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-word.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


To get the bookmark content as SFDT (rich text), check this [`link`](../../document-editor/how-to/get-the-selected-content/#get-the-selected-content-as-sfdt-rich-text)

## Select and get the paragraph in current cursor position

You can use [`selectParagraph`] API in selection module to select the current paragraph at cursor position and use [`text`] API or [`sfdt`] API to get the selected content as plain text or SFDT from Document Editor component.

The following example code illustrates how to select and get the current paragraph as SFDT.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-paragraph/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-paragraph.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-paragraph/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-paragraph.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
