---
layout: post
title: How to insert text or image in table programmatically in ##Platform_Name## Document Editor Component
description: Learn how to insert text or image in table programmatically in ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Insert Text Or Image In Table
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to insert text or image in table programmatically in  Document Editor component

Using Document editor API's, you can insert [`text`] or [`image`] in [`table`] programmatically based on your requirement.

Use [`selection`] API's to navigate between rows and cells.

The following example illustrates how to create 2*2 table and then add text and image programmatically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-text-image-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-text-image-table" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-text-image-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-text-image-table" %}
{% endhighlight %}{% endtabs %}
{% endif %}

The output will be like below.
![Insert text or image in table programmatically](../images/table-image.png)
