---
layout: post
title: Embed Blocks in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Embed Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Embed Blocks in ##Platform_Name## Block Editor control

Block Editor supports addition of embeds to help you organize, showcase contents and format your content effectively.

## Image Block

You can use the `Image` block to showcase an image content within your editor.

### Configure Image Block

You can render an `Image` block by setting the `blockType` property to `Image` in the block model. The `properties` property allows you to configure the image source, allowed file types, display dimensions, and more.

#### Global Image Settings

You can configure global settings for image blocks using the `imageBlockSettings` property in the Block Editor root configuration. This ensures consistent behavior for image uploads, resizing, and display.

The `imageBlockSettings` property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| saveFormat | Specifies the format to save the image. | `Base64` |
| allowedTypes | Specifies allowed image file types for upload. | `['.jpg', '.jpeg', '.png']` |
| width | Specifies the default display width of the image. | `auto` |
| height | Specifies the default display height of the image. | `auto` |
| enableResize | Enables or disables image resizing. | `true` |
| minWidth | Minimum width allowed for resizing. | `''` |
| maxWidth | Maximum width allowed for resizing. | `''` |
| minHeight | Minimum height allowed for resizing. | `''` |
| maxHeight | Maximum height allowed for resizing. | `''` |

#### Configure Image Block Properties

The `Image` block `properties` property in the block model supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| src | Specifies the image path. | `''` |
| width | Specifies the display width of the image. | `''` |
| height | Specifies the display height of the image. | `''` |
| altText | Specifies the alternative text to display when the image cannot be loaded. | `''` |

The below sample demonstrates the configuration of image block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/blockeditor/blocks/blockTypes/image-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/blockeditor/blocks/blockTypes/image-block/image.cs %}
{% endhighlight %}
{% endtabs %}

![Image Block](images/block-image.png)