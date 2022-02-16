---
layout: post
title: Disable Optimized Text Measuring in ##Platform_Name## Document Editor Component
description: Learn here all about Disable Optimized Text Measuring in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Disable Optimized Text Measuring
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable optimized text measuring in Document Editor component

Starting from v19.3.0.x, the accuracy of text size measurements in Document editor is improved such as to match Microsoft Word pagination for most Word documents. This improvement is included as default behavior along with an optional API `enableOptimizedTextMeasuring` in Document editor settings.  

If you want the Document editor component to retain the document pagination (display page-by-page) behavior like v19.2.0.x and older versions. Then you can disable this optimized text measuring improvement, by setting `false` to `enableOptimizedTextMeasuring` property of Document Editor component.

## Disable optimized text measuring in `DocumentEditorContainer` instance

The following example code illustrates how to disable optimized text measuring improvement in `DocumentEditorContainer` instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/optimized-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Optimized-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/optimized-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Optimized-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Disable optimized text measuring in `DocumentEditor` instance

The following example code illustrates how to disable optimized text measuring improvement in `DocumentEditor` instance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/optimized-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Optimized-text.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/optimized-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Optimized-text.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

