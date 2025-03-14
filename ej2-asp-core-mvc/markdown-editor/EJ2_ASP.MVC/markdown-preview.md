---
layout: post
title: Markdown to HTML preview in ##Platform_Name## Markdown Editor Control | Syncfusion
description: Checkout and learn about Markdown to HTML preview in ##Platform_Name## Markdown Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Markdown to HTML preview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Markdown to HTML preview in ##Platform_Name## Markdown Editor Control

The Markdown Editor provides an instant preview of Markdown changes, allowing users to see the formatted output while typing or editing text. This enhances the editing experience by enabling real-time visualization of Markdown formatting.

This feature leverages the third-party library [Marked](https://marked.js.org/) to convert Markdown into HTML content. The following example demonstrates how to enable and preview Markdown changes within the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-preview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-preview/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-preview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-preview/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}