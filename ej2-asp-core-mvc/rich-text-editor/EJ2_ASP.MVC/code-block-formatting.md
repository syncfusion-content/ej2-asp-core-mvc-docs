---
layout: post
title: Code Block Formatting in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Code Block Formatting in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Code Block Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Code Block Formatting in the ##Platform_Name## Rich Text Editor Control

The Rich Text Editor control offers a powerful feature to format text as preformatted code blocks, making it ideal for displaying programming snippets or structured contents.

### Enabling Code Block Formatting

To enable code block formatting, ensure that the Formats item is included in the toolbar items of your Rich Text Editor configuration.

Below are examples and code snippets demonstrating how to add and effectively use the code block formatting option in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-format/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-format/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [How to customize the format dropdown items](./headings#customizing-format-dropdown-items)