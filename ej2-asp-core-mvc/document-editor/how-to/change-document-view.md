---
layout: post
title: Change Document View in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about how to change document view in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Change Document View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change document view

## How to change the document view in DocumentEditor component

DocumentEditor allows to change the view to web layout and print using the [`layoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_LayoutType) property with the supported [`LayoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.LayoutType.html)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/web-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Web-layout.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/web-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Web-layout.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



N> Default value of [`layoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_LayoutType) in DocumentEditor component is [`Pages`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.LayoutType.html).

## How to change the document view in DocumentEditorContainer component

DocumentEditorContainer component allows to change the view to web layout and print using the [`layoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_LayoutType) property with the supported [`LayoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.LayoutType.html)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/web-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Web-layout.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/web-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Web-layout.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



N> Default value of [`layoutType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_LayoutType) in DocumentEditorContainer component is [`Pages`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.LayoutType.html).