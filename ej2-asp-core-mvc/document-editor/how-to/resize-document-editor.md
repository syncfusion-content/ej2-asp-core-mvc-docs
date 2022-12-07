---
layout: post
title: Resize Document Editor in ##Platform_Name## Document Editor Component
description: Learn here all about how to resize Document Editor in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resize Document Editor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to change height and width of Document Editor component

This article explains how to change height and width of Document editor.

## Change height of Document Editor

DocumentEditorContainer initially renders with default height. You can change the height of document editor using [`height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_Height) property, the value which is in pixel.

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



Similarly, you can use [`height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_Height) property for DocumentEditor also.

## Change width of Document Editor

DocumentEditorContainer initially renders with default width. You can change the width of document editor using [`width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_Width) property, the value which is in percent.


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



Similarly, you can use [`width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_Width) property for DocumentEditor also.

## Resize Document Editor

Using `resize` method, you change height and width of Document editor.

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

