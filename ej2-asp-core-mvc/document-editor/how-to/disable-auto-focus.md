layout: post
title: How to disable auto-focus in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about How to disable and enable auto-focus in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: How to disable auto-focus
publishingplatform: ##Platform_Name##
documentation: ug

# How to disable auto focus in Syncfusion JavaScript Document Editor component

Document Editor gets focused automatically when the page loads. If you want the Document editor not to be focused automatically it can be customized.

The following example illustrates to disable the auto focus in DocumentEditorContainer.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-auto-focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/disable-auto-focus/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/disable-auto-focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor-container/disable-auto-focus/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>Note: Default value of [`enableAutoFocus`] property is `true`.

The following example illustrates to disable the auto focus in DocumentEditor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/disable-auto-focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/disable-auto-focus/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/disable-auto-focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/disable-auto-focus/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>Note: Default value of [`enableAutoFocus`]property is `true`.