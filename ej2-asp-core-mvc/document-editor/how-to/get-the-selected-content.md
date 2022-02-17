---
layout: post
title: Get The Selected Content in ##Platform_Name## Document Editor Component
description: Learn here all about Get The Selected Content in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Get The Selected Content
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to get the selected content in Document Editor component

You can get the selected content from the React Document Editor component as plain text and SFDT (rich text).

## Get the selected content as plain text

You can use `text` API to get the selected content as plain text from React Document Editor component.

The following example code illustrates how to add search in google option in context menu for the selected text.

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



You can add the following custom options using this API,

* Save or export the selected text as text file.
* Search the selected text in Google or other search engines.
* Show synonyms for the selected word in context menu and replace with selected synonym using the setter method of same API.

## Get the selected content as SFDT (rich text)

You can use `sfdt` API to get the selected content as plain text from React Document Editor component.

The following example code illustrates how to get the content of a bookmark and export it as SFDT.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-sfdt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Get-sfdt.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/get-sfdt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Get-sfdt.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



You can add the following custom options using this API,

* Save or export the selected content as SFDT file.
* Get the content of a bookmark in Word document as SFDT by selecting a bookmark using `selectbookmark` API.
* Create template content that can be inserted to multiple documents in cursor position using `paste` API.