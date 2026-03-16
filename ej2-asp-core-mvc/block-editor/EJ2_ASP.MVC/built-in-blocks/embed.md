---
layout: post
title: Embed Blocks in ASP.NET MVC Block Editor control | Syncfusion
description: Checkout and learn about Embed Blocks with ASP.NET MVC Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-javascript
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Embed Blocks in ASP.NET MVC Block Editor control

Block Editor supports addition of embeds to help you organize, showcase contents and format your content effectively.

## Adding an image block

You can use the [Image](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Image) block to showcase an image content within your editor.

### Configure image block

You can render an [Image](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Image) block by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property to [Image](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Image) in the block model. The `properties` property allows you to configure the image source, allowed file types, display dimensions, and more.

#### Global image settings

You can configure global settings for image blocks using the [ImageBlockSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_ImageBlockSettings) property in the Block Editor root configuration. This ensures consistent behavior for image uploads, resizing, and display.

The [ImageBlockSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_ImageBlockSettings) property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| saveUrl | Specifies the server endpoint URL for uploading images. | `''` |
| maxFileSize | Specifies the maximum file size allowed for image uploads in bytes. | `30000000` |
| path | Specifies the base path for storing and displaying images on the server. | `''` |
| saveFormat | Specifies the format to save the image. | `Base64` |
| allowedTypes | Specifies allowed image file types for upload. | `['.jpg', '.jpeg', '.png']` |
| width | Specifies the default display width of the image. | `auto` |
| height | Specifies the default display height of the image. | `auto` |
| enableResize | Enables or disables image resizing. | `true` |
| minWidth | Minimum width allowed for resizing. | `''` |
| maxWidth | Maximum width allowed for resizing. | `''` |
| minHeight | Minimum height allowed for resizing. | `''` |
| maxHeight | Maximum height allowed for resizing. | `''` |

#### Maximum file size restriction

You can restrict the image uploaded from the local machine when the uploaded image file size is greater than the allowed size by using the `MaxFileSize` property. By default, the maximum file size is 30000000 bytes. You can configure this size as follows.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Height("300px").ImageBlockSettings((ImageBlockSettings)ViewData["ImageBlockSettings"]).Render()
</div>
....

{% endhighlight %}
{% highlight C# tabtitle="Index.cs" hl_lines="3 11" %}

public ImageBlockSettings ImageBlockSettings { get; set; }
public ActionResult Index()
{
    ImageBlockSettings = new ImageBlockSettings()
    {
        MaxFileSize = 10000000
    };
    ViewData["ImageBlockSettings"] = ImageBlockSettings;
    return View();
}
....

{% endhighlight %}
{% endtabs %}

#### Configuring allowed image types

You can allow the specific images alone to be uploaded using the the allowedTypes property. By default, the Block Editor allows the JPG, JPEG, and PNG formats. You can configure this formats as follows.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Height("300px").ImageBlockSettings((ImageBlockSettings)ViewData["ImageBlockSettings"]).Render()
</div>
....

{% endhighlight %}
{% highlight C# tabtitle="Index.cs" hl_lines="3 11" %}

public ImageBlockSettings ImageBlockSettings { get; set; }
public ActionResult Index()
{
    ImageBlockSettings = new ImageBlockSettings()
    {
        AllowedTypes = new string[] { ".jpg", ".jpeg", ".png" }
    };
    ViewData["ImageBlockSettings"] = ImageBlockSettings;
    return View();
}
....

{% endhighlight %}
{% endtabs %}

#### Configure image block properties

The [Image](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Image) block `properties` property in the block model supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| src | Specifies the image path. | `''` |
| width | Specifies the display width of the image. | `''` |
| height | Specifies the display height of the image. | `''` |
| altText | Specifies the alternative text to display when the image cannot be loaded. | `''` |

### Block type & properties

The following example demonstrates how to pre-configure an [Image](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Image) block in the editor.

```typescript
// Adding image block
 {
    blockType = "Image",
    properties = new
    {
        src = "https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png",
        width = '200px',
        height = '100px',
        altText = '',
    }
}
```

The below sample demonstrates the configuration of image block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/image.cs %}
{% endhighlight %}
{% endtabs %}

![Image Block](./../../images/block-image.png)

## Uploading images from local machine

To insert an image from your local machine, render the `Image` block. It opens a popup where you can browse and select an image to insert from your local machine.

## Saving images to server

Upload the selected image to a specified destination using the controller action specified in `ImageBlockSettings.saveUrl`. Ensure to map this method name appropriately and provide the required destination path through the `ImageBlockSettings.path` properties.

Set the `ImageBlockSettings.saveFormat` property to determine whether the image should be saved as Blob or Base64, aligning with your application's requirements.

### Secure image upload with authentication

You can add additional data with the image uploaded from the Block Editor on the client side, which can even be received on the server side. By using the `FileUploading` event and it's arguments you can access the current request and set the request header within these event. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

## Inserting images from web URLs

To insert an image from an online source, render the `Image` block. Switch to the `Embed Link` tab containing an input field where you can provide the image URL from the web to insert the image.

## Image resizing

Block Editor has a built-in image inserting support. The resize points will be appearing on each corner of image when focus. So, users can resize the image using mouse points or thumb through the resize points easily. Also, the resize calculation will be done based on aspect ratio.

![Image resize](./../../images/image-resize.png)
