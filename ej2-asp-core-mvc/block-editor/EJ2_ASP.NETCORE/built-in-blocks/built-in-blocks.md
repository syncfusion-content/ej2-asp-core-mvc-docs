---
layout: post
title: Blocks in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Blocks in ##Platform_Name## Block Editor control

The Block Editor control enables you to create block-based content editing solution using various types of blocks. The [blocks](../api/blockeditor/#blocks) property allows you to define and manage the content structure of your editor.

## Blocks

Blocks are the fundamental building elements of the Block Editor. Each block represents a distinct content unit such as a `paragraph`, `heading`, `list`, or specialized content like `code snippets` or `images`. The Block Editor organizes content as a collection of `blocks`, allowing for better structure and formatting options.

You can configure blocks with various properties such as [id](../api/blockeditor/blockModel/#id), [type](../api/blockeditor/blockModel/#type), [content](../api/blockeditor/blockModel/#content), [children](../api/blockeditor/blockModel/#children) and more to create rich, structured editor.

## Block types

The Block Editor supports multiple block types. Each block type offers different formatting and functionality options:

| Built-in Block Types                    | Description                                       |
|-----------------------------------------|---------------------------------------------------|
| Paragraph                               | Default block type for regular text content.      |
| Heading1 to Heading4                    | Different levels of headings for document structure.|
| Checklist                               | Interactive to-do lists with checkable items.     |
| BulletList                              | Unordered lists with bullet points.               |
| NumberedList                            | Ordered lists with sequential numbering.          |
| Code                                    | Formatted code blocks with syntax highlighting.   |
| Quote                                   | Styled block for quotations.                      |
| Callout                                 | Highlighted block for important information.      |
| Divider                                 | Horizontal separator line.                        |
| CollapsibleParagraph and CollapsibleHeading1-4    | Collapsible content blocks.                       |
| Image                                   | Block for displaying images.                      |
| Template                                | Predefined custom templates.                      |

## Configure indent

You can specify the indentation level of a block using the [indent](../api/blockeditor/blockModel/#indent) property. This property accepts a numeric value that determines how deeply a block is nested from the left margin.

By default, the [indent](../api/blockeditor/blockModel/#indent) property is set to `0`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/indent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indent.cs" %}
{% include code-snippet/block-editor/blocks/indent/indent.cs %}
{% endhighlight %}
{% endtabs %}

![Block Indent](images/block-indent.png)

## Configure CSS Class

You can apply custom styling to individual blocks using the [cssClass](../api/blockeditor/blockModel/#cssclass) property. This property accepts a string containing one or more CSS class names.

Custom CSS classes allow you to define specialized styling for specific blocks in your editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/block-editor/blocks/cssClass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

![Block cssClass](images/block-cssClass.png)

## Configure templates

The Block Editor allows you to use custom templates for specialized content using the [template](../api/blockeditor/blockModel/#template) property. Templates can be defined as strings, functions, or HTML elements.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/template-block/template.cs %}
{% endhighlight %}
{% endtabs %}

![Template Block](images/block-template.png)