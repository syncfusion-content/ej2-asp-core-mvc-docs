---
layout: post
title: Placeholder Text in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Placeholder Text in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Placeholder Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Quotation formatting in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor facilitates quotation formatting through the `Blockquote` tool available in the toolbar. Blockquotes are designed to visually highlight significant text, emphasizing key information or quotations by setting them apart from the main content for added emphasis and clarity.

To format text as a quotation, select the desired text and click on the `Blockquote` icon in the toolbar. The selected text will be formatted as a blockquote, typically indented and styled differently from the surrounding content.

Use the `Blockquote` tool in the editor below to see the feature in action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/quotation-formatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/quotation-formatting/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/quotation-formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/quotation-formatting/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> In a markdown editor, blockquotes are represented using the `>` symbol.

## See Also

* [How to Customize Format Dropdown Items in Headings](./headings#customizing-format-dropdown-items)