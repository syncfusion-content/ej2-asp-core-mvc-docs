---
layout: post
title: Code Block in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Code Block with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Code Blocks in ##Platform_Name## Block Editor control

You can render Code blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Code](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Code). By setting the `properties` property, you can configure the default language. The default language is `plainText`.

## Global Code Settings

You can configure global settings for code blocks using the [CodeBlockSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_CodeBlockSettings) property in the Block Editor root configuration. This ensures consistent behavior for syntax highlighting and language options across all code blocks.

The [CodeBlockSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_CodeBlockSettings) property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| `languages` | Specifies the array of language options for syntax highlighting. | [] |
| `defaultLanguage`| Defines the default language to use for syntax highlighting. | 'plaintext' |

Each language object in the `languages` array should have:
- `language`: The language value used for syntax highlighting
- `label`: The display name shown in the language selector

## Configure code properties

For Individual Code blocks, you can configure default language using the `properties` property in the block model.

The property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| language | The default language to use for syntax highlighting | '' |

Below example illustrates how to render the code block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/blockeditor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Code.cs" %}
{% include code-snippet/blockeditor/blocks/blockTypes/code-block/code.cs %}
{% endhighlight %}
{% endtabs %}

![Code Block](./../../images/block-code.png)
