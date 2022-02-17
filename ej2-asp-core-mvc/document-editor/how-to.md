---
layout: post
title: How To in ##Platform_Name## Document Editor Component
description: Learn here all about How To in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: How To
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to override the keyboard shortcuts in document editor

Document editor triggers the [`keyDown`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_KeyDown) event every time when any key is entered and provides an instance of `DocumentEditorKeyDownEventArgs`. You can use the `isHandled` property to override the keyboard shortcut behaviour.

## Preventing default keyboard shortcut

The following code shows how to prevent the `CTRL + C` keyboard shortcut for copying selected content in document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/prevent-default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/prevent-default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Override or define the keyboard shortcut

Override or define a new keyboard shortcut behaviour instead of preventing the keyboard shortcut.

For example, `Ctrl + S` keyboard shortcut saves the document in SFDT format by default, and there is no behaviour for `Ctrl + Alt + S`. The following code demonstrates how to override the `Ctrl + S` shortcut to save a document in DOCX format and define `Ctrl + Alt + S` to save the document in SFDT format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/override/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Override.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/override/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Override.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

