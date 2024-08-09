---
layout: post
title: Insert HTML ##Platform_Name## Document Editor Component
description: Learn how to Insert HTML from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Insert HTML
publishingplatform: ##Platform_Name##
documentation: ug
---

# Insert HTML in Document Editor component

The Document Editor allows you to insert HTML content, which is then seamlessly integrated into your document.

The following example code illustrates how to insert html content in document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-html/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-html.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-html/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-html.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}