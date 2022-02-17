---
layout: post
title: Resize Document Editor in ##Platform_Name## Document Editor Component
description: Learn here all about Resize Document Editor in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Resize Document Editor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to change height and width of Document Editor component

In this article, we are going to see how to change height and width of Documenteditor.

## Change height of Document Editor

DocumentEditorContainer initially render with default height. You can change height of documenteditor using `height` property, the value which is in pixel.

The following example code illustrates how to change height of Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/change-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Change-height.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/change-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Change-height.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Similarly, you can use `height` property for DocumentEditor also.

## Change width of Document Editor

DocumentEditorContainer initially render with default width. You can change width of documenteditor using `width` property, the value which is in percent.

The following example code illustrates how to change width of Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/change-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Change-width.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/change-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Change-width.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



Similarly, you can use `width` property for DocumentEditor also.

## Resize Document Editor

Using `resize` method, you change height and width of Document editor.

The following example code illustrates how to fit Document Editor to browser window size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resize.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

