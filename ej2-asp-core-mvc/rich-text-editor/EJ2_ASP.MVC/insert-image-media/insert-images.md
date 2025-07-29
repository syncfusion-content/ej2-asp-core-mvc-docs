---
layout: post
title: Image in ##Platform_Name## Rich Text Editor control  | Syncfusion
description: Learn here all about Image in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Image
publishingplatform: ##Platform_Name##
documentation: ug
---

# Images in ##Platform_Name## Rich Text Editor Control

Rich Text Editor allows to insert images in your content from online sources as well as local computer. For inserting an image to the Rich Text Editor, the following list of options have been provided in the [InsertImageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_)

## Configuring Image Tool in the Toolbar

You can add an `Image` tool in the Rich Text Editor toolbar using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To configure the `Image` toolbar item, refer to the below code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Supported Image Save Formats

The images can be saved as `Blob` or `Base64` URL by using the [InsertImageSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveFormat) property, which is of enum type, and the generated URL will be set to the `src` attribute of the `<source>` tag.

```HTML

<img src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" >

<img src="data:image/jpeg;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHA" >

```

The code snippet below illustrates the configuration of the [InsertImageSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveFormat) property in the Rich Text Editor.

> The default `SaveFormat` property is set to `Blob` format.

## Inserting Images from Web URLs

To insert an image from an online source, click the `Image` tool in the toolbar. By default, this tool opens a dialog box with an input field where you can provide the image URL from the web to insert the image.

## Uploading Images from Local Machine

To insert an image from your local machine, click the `Image` tool in the toolbar. By default, this tool opens a dialog box where you can browse and select an image to insert from your local machine.

## File Manager Integration for Image Insertion

To insert images from a file manager, enable the `FileManager` tool on the editor's toolbar. This tool initiates a dialog where you can upload new images and choose from existing ones, facilitating smooth image insertion into your content.

To integrate the file manager into the Rich Text Editor, follow these steps:

* Configure the `FileManager` toolbar item in the `ToolbarSettings` API `Items` property.
* Set the [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFileManagerSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFileManagerSettings_Enable) property to `true` in the [FileManagerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileManagerSettings) property to ensure the file browser appears upon clicking the `FileManager` toolbar item.

## Saving Image to Server

Upload the selected image to a specified destination using the controller action specified in [InsertImageSettings.SaveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveUrl). Ensure to map this method name appropriately and provide the required destination path through the [InsertImageSettings.Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_Path) properties.

Configure [InsertImageSettings.RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_RemoveUrl) to point to the endpoint responsible for deleting image files.

Set the [InsertImageSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveFormat) property to determine whether the image should be saved as Blob or Base64, aligning with your application's requirements.

N> The runnable demo application is available in this [Github](https://github.com/SyncfusionExamples/aspnet-core-richtexteditor-image-upload) repository.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/save/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/save/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Image Renaming Feature

You can use the [InsertImageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings) property, to specify the server handler to upload the selected image. Then by binding the [ImageUploadSuccess](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ImageUploadSuccess) event, you can receive the modified file name from the server and update it in the Rich Text Editor's insert image dialog.

Refer the section [Rename images before inserting it in Rich Text Editor](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/how-to/rename-images-in-server) for code snippets and examples.

### Secure Image Upload with Authentication

You can add additional data with the image uploaded from the Rich Text Editor on the client side, which can even be received on the server side. By using the [ImageUploading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ImageUploading) event and its `CustomFormData` argument, you can pass parameters to the controller action. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

> By default, it doesn't support the `UseDefaultCredentials` property, you can manually append the default credentials with the upload request.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-authenticate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image-authenticate/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-authenticate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFile.cs" %}
{% include code-snippet/rich-text-editor/image-authenticate/saveFile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Maximum file size restriction

You can restrict the image uploaded from the local machine when the uploaded image file size is greater than the allowed size by using the [InsertImageSettings.MaxFileSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_MaxFileSize) property. By default, the maximum file size is 30000000 bytes. You can configure this size as follows.

In the following example, the image  size has been validated before uploading and determined whether the image has been uploaded or not.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-image-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-image-size/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-image-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-image-size/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Image Replacement Functionality

Once a image file has been inserted, you can replace it using the Rich Text Editor [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings) `ImageReplace` option. You can replace the image file either by using the web URL or the browse option in the image dialog.

## Deleting Images

To remove an image from the Rich Text Editor content, select the image and click `Remove` tool from the quick toolbar. It will delete the image from the Rich Text Editor content as well as from the service location if the `RemoveUrl` is given.

Once you select the image from the local machine, the URL for the image will be generate. From there, you can remove the image from the service location by clicking the cross icon.

![Rich Text Editor Image delete](../images/image-del.png)

The following sample explains, how to configure `RemoveUrl` to remove a saved image from the remote service location, when the following image remove actions are performed:

* `delete` key action.
* `backspace` key action.
* Removing uploaded image file from the insert image dialog.
* Deleting image using the quick toolbar `Remove` option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/remove-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/remove-url/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/remove-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/remove-url/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Adjusting Image Dimensions

Sets the default width and height of the image when it is inserted in the Rich Text Editor using [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_Width) and [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_Height) of the [InsertImageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings) property.

Through the quick toolbar, change the width and height using `Change Size` option. Once you click, the Image Size dialog box will open as follows. In that you can specify the width and height of the image in pixel.

![Rich Text Editor Image dimension](../images/image-size.png)

## Adding Captions and Alt Text to Images

Image caption and alternative text can be specified for the inserted image in the Rich Text Editor through the [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings) property. It has following two options,

* Image Caption
* Alternative Text.

Through the Alternative Text option, set the alternative text for the image, when the image is not upload successfully into the Rich Text Editor.

By clicking the Image Caption, the image will get wrapped in an image element with a caption. Then, you can type caption content inside the Rich Text Editor.

## Configuring Image Display Position

Sets the default display for an image when it is inserted in the Rich Text Editor using [Display](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_Display) field in [InsertImageSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings). It has two possible options: 'inline' and 'block'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-settings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Hyperlinking Images

The hyperlink itself can be an image in Rich Text Editor. If the image given as hyperlink, remove, edit and open link will be added to the quick toolbar of image. For further details about link, see the [`link documentation`](./link) documentation.

![Rich Text Editor image with link](../images/image-link.png)

## Image Resizing Tools

Rich Text Editor has a built-in image inserting support.  The resize points will be appearing on each corner of image when focus. So, users can resize the image using mouse points or thumb through the resize points easily. Also, the resize calculation will be done based on aspect ratio.

![Rich Text Editor image resize](../images/image-resize.png)

## Configuring Allowed Image Types

You can allow the specific images alone to be uploaded using the the allowedTypes property. By default, the Rich Text Editor allows the JPG, JPEG, and PNG formats. You can configure this formats as follows.

``` cshtml

    InsertImageSettings(e=>e.AllowedTypes(new []{".jpg"}))

```

## Drag and Drop Image Insertion

By default, the Rich Text Editor allows you to insert images by drag-and-drop from the local file system such as Windows Explorer into the content editor area. And, you can upload the images to the server before inserting into the editor by configuring the saveUrl property. The images can be repositioned anywhere within the editor area by dragging and dropping the image.

In the following sample, you can see feature demo.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/drag-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/drag-drop/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/drag-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/drag-drop/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Disabling Drag and Drop for Images

You can prevent drag-and-drop action by setting the actionBegin argument cancel value to true. The following code shows how to prevent the drag-and-drop.

<script>

    function actionBegin(args) {
        if(args.type === 'drop' || args.type === 'dragstart') {
            args.cancel =true;
        }
    }

</script>

## Customizing the Image Quick Toolbar

The Rich Text Editor allows you to customize the image quick toolbar, providing essential tools such as 'Replace', 'Align', 'Caption', 'Remove', 'InsertLink', 'Display', 'AltText', and 'Dimension'.

By configuring these options in the [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings) property, you can enhance the editor's functionality, enabling seamless image management and editing directly within your content. This customization ensures a user-friendly experience for efficiently manipulating image elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-quick-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/image-quick-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/image-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Image Quick toolbar](../toolbar/quick-toolbar#image-quick-toolbar)
* [Hyperlink Management](../link)