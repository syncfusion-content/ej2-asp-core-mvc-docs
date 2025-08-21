---
layout: post
title: Embed Blocks in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Embed Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-javascript
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Embed Blocks in ##Platform_Name## Block Editor control

Block Editor supports addition of embeds to help you organize, showcase contents and format your content effectively.

## Image Block

You can use the `image` block to showcase an image content within your editor.

### Configure image block

You can render Image blocks by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as `Image`. By setting the `Props` property, you can configure the image source, allowed file types, and display dimensions etc.

The image [Props](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html) property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| saveFormat | Specifies the format to save the image | Base64 |
| src | Specifies the image path | ' '|
| allowedTypes | Specifies the allowed image file types that can be uploaded | ['.jpg', '.jpeg', '.png'] |
| width | Specifies the display width of the image | ' ' |
| height | Specifies the display height of the image | ' '|
| minWidth | Specifies the minimum width of the image in pixels or as a string unit | 40|
| maxWidth | Specifies the maximum width of the image in pixels or as a string unit | ' '|
| minHeight | Specifies the minimum height of the image in pixels or as a string unit | 40|
| maxHeight | Specifies the maximum height of the image in pixels or as a string unit | ' '|
| altText | Specifies the alternative text to be displayed when the image cannot be loaded | ' '|
| cssClass | Specifies one or more CSS classes to be applied to the image element | ' ' |
| readOnly | Specifies whether the image is in read-only mode | false


#### Type & Props

```typescript
// Adding image block
 {
    Type = BlockType.Image,
    Props = new
    {
        src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
        altText = "Sample image"       
        saveFormat= "Base64",
        allowedTypes = ['.png', '.gif'],
        width = '200px',
        height = '100px',
        minWidth = 50,
        maxWidth = 500,
        minHeight = 50,
        maxHeight = 300,
        cssClass = 'img-custom',
        readOnly = true
    }
}
```

The below sample demonstrates the configuration of image block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/image.cs %}
{% endhighlight %}
{% endtabs %}

![Image Block](images/block-image.png)