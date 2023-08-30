---
layout: post
title: Hide the default tool bar and properties pane in ##Platform_Name## Document Editor Component
description: Learn how to hide the default tool bar properties pane from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Hide The Default Tool Bar And Properties Pane
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to hide the default tool bar and properties pane in Document Editor component

**Document editor container** provides the main document view area along with the built-in toolbar and properties pane.

**Document editor** provides just the main document view area. Here, the user can compose, view, and edit the Word documents. You may prefer to use this component when you want to design your own UI options for your application.

## Hide the properties pane

By default, Document editor container has built-in properties pane which contains options for formatting text, table, image and header and footer. You can use [`showPropertiesPane`] API in `DocumentEditorContainer` to hide the properties pane.

The following example code illustrates how to hide the properties pane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-the-default-propertiespane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-the-default-propertiespane.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-the-default-propertiespane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-the-default-propertiespane.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> Positioning and customizing the properties pane in Document editor container is not possible. Instead, you can hide the exiting properties pane and create your own pane using public API's.

## Hide the toolbar

You can use [`enableToolbar`] API in `DocumentEditorContainer` to hide the existing toolbar.

The following example code illustrates how to hide the existing toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-the-default-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-the-default-toolbar.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-the-default-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-the-default-toolbar.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

## See Also

* [How to customize the toolbar](../../document-editor/how-to/customize-tool-bar)