---
layout: post
title: Insert Page number and Navigate to specific page ##Platform_Name## Document Editor Component
description: Learn how to Insert Page number and Navigate to specific page from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Insert Page number And Navigate To Specific Page
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to insert page number and navigate to specific page in Document Editor component

You can insert page number and navigate to specific page in Document Editor component by following ways.

## Insert page number

You can use [`insertPageNumber`] API in editor module to insert the page number in current cursor position. By default, Page number will insert in Arabic number style. You can change it, by providing the number style in parameter.

N> Currently, Documenteditor have options to insert page number at current cursor position.

The following example code illustrates how to insert page number in header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-page-number/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-page-number.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/insert-page-number/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert-page-number.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
```

Also, you use [`insertField`] API in Editor module to insert the Page number in current position

```typescript
//Current page number
container.documentEditor.editor.insertField('PAGE \* MERGEFORMAT', '1');

```

## Get page count

You can use [`pageCount`] API to gets the total number of pages in Document.

The following example code illustrates how to get the number of pages in Document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/page-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-count.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/Page-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pageCount.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## Navigate to specific page

You can use [`goToPage`] API in Selection module to move selection to the start of the specified page number.

The following example code illustrates how to move selection to specific page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/go-to-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Go-to-page.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/go-to-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Go-to-page.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}