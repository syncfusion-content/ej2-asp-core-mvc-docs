---
layout: post
title: Open and Save in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Open and Save in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open and Save
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open and Save in the ##Platform_Name## Image Editor control

To import an image into the canvas, it must first be converted into a blob object. The Uploader component can be used to facilitate the process of uploading an image from the user interface. Once the image has been uploaded, it can then be converted into a blob and drawn onto the canvas. 

To save an edited image in the Image Editor control, use the toBlob method to convert it to a blob object. This will save the image with any annotations or filters that have been applied during the editing process. The saved image can be stored as raw image data or as an image file. 

## Supported image formats 

The Image Editor control supports five common image formats: PNG, JPEG, SVG, WEBP, and BMP. These formats allow you to work with a wide range of image files within the Image Editor. 

When it comes to saving the edited image, the default file type is set as PNG. This means that when you save the edited image without specifying a different file type, it will be saved as a PNG file. However, it's important to note that the Image Editor typically provides options or methods to specify a different file type if desired. This allows you to save the edited image in formats other than the default PNG, such as JPEG, SVG, and WEBP, based on your specific requirements or preferences. 

## Open an Image

The `open` method in the Image Editor control offers the capability to open an image by providing it in different formats. This method accepts various types of arguments, such as a base64-encoded string, raw image data, or a hosted/online URL. You can pass either the file name or the actual image data as an argument to the `open` method, and it will load the specified image into the Image Editor control. This flexibility allows you to work with images from different sources and formats, making it easier to integrate and manipulate images within the Image Editor control. 

### Opening local images in the Image Editor

Users can easily open local images in the Image Editor. Simply place the image in the same folder as the sample. By specifying the local file name directly in the `open` method, the image will be loaded seamlessly into the editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-open.jpg)

### Open an image from base64 format

Users can easily open images in the Image Editor using a Base64-encoded string. This method allows you to load images directly from their Base64 representation, ensuring seamless integration and flexibility in your application. Simply pass the Base64 string to the `open` method, and the image will be loaded into the editor.

**Note:**: You can obtain the Base64 representation of an image from the Image Editor using the `getImageData` method. This process will be explained in the upcoming section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs1/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs1/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-save-base.png)

### Open an image from Blob storage

User can easily open images in the Image Editor from Blob storage. This method allows you to load images directly from Blob storage, ensuring seamless integration and flexibility in your application. Simply retrieve the image Blob from storage and pass it to the `open` method, and the image will be loaded into the editor.

**Note:**: You can obtain the Blob URL representation of an image from the Image Editor using the `getImageData` method. This process will be explained in the upcoming section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs2/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs2/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-open-blob.jpg)

### Open an image from File Uploader

User can easily open images in the Image Editor using a file uploader. This method allows users to upload an image file from their device and load it directly into the editor. Once the image is selected through the file uploader, pass the file to the `open` method, and the image will be seamlessly loaded into the editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs4/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs4/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-ie-uploader.png)

### Open an image from File Manager

User can easily open images in the Image Editor using the File Manager. This method allows you to browse and select an image file directly from the File Manager and load it into the editor. Once the image is selected, pass the file to the `open` method, and the image will be seamlessly loaded into the editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/default.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/default.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs5/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-ie-file-manager.png)

### Open an image from Treeview

Users can open images in the Syncfusion Image Editor by selecting a node from a tree view. When a user clicks on an image node, the corresponding image is loaded into the editor using the `open` method. This allows for a seamless image editing experience directly from the TreeView component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/default.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/default.cs %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs6/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-ie-treeview.png)


### Add watermarks while opening an image

You can utilize the [`FileOpened`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_FileOpened) event, which triggers once the image is loaded into the image editor. After this event, you can use the ‘drawText’ method to add a watermark. This approach allows the watermark to be automatically drawn on the canvas every time an image is opened in the editor, making it useful for handling copyright-related content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs3/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs3/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-watermark.jpeg)

### Opening Images with Custom Width and Height

Users can now open images with specific width and height values using the `imageSettings` parameter in the `open` method. This enhancement introduces three additional properties: `width`, `height`, and `isAspectRatio`. These options allow precise control over the image dimensions, with the flexibility to preserve the original aspect ratio if needed. This feature is especially useful when rendering high-resolution images or when fitting images into fixed-size layouts or canvas areas.
 
The following behaviors are supported through these properties:
- Contains behavior: By specifying only one dimension (either `width` or `height`) and enabling `isAspectRatio`, the other dimension is automatically calculated to maintain the image's original proportions.
- Cover behavior: When both `width` and `height` are specified with `isAspectRatio` set to `true`, the image scales proportionally to fit within the given dimensions while preserving its aspect ratio.
- Stretch or Shrink behavior: Setting `isAspectRatio` to `false` forces the image to strictly follow the specified `width` and `height`, allowing it to stretch or shrink regardless of its original aspect ratio.

The following example showcases how all three behaviors can be achieved using the open method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs7/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs7/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/open-image-cs7/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/open-image-cs7/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-width-height.jpg)

## Save as image

The `export` method in the Image Editor control enables you to save the modified image as a file on the local device. This method accepts two parameters: the file name and the file type. 

By providing a file name, you can specify the desired name for the saved image file. Additionally, you can also specify the quality and file type to determine the format in which the image should be saved. This allows you to save the image according to your specific requirements or preferences, such as PNG, JPEG, SVG, and WEBP.

By utilizing the `export` method with the appropriate file name and file type, you can conveniently save the modified image as a file on the local device, ensuring that it is easily accessible and shareable.

In the following example, the `export` method is used in the button click event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-save.jpg)

### Save the image as base64 format

To save an image as a base64 format, use the `getImageData` method of the editor to retrieve the image data and convert it into a Data URL, which contains the base64-encoded string. By invoking the `open` method on the Syncfusion<sup style="font-size:70%">&reg;</sup> Image Editor instance, you can load this Data URL into the editor. The resulting base64 string can then be embedded directly in HTML or CSS or transmitted over data channels without requiring an external file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs1/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs1/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-save.jpg)

### Save the image as byte[]

To save an image as a byte array (byte[]), use the `getImageData` method of the editor to retrieve the image data and convert it into a byte array. You can then invoke the `open` method on the Syncfusion<sup style="font-size:70%">&reg;</sup> Image Editor instance to load this byte array into the editor. The resulting byte array can be stored in a database for data management and maintenance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs4/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs4/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-byte-array.png)

### Save the image as Blob

To save an image as a blob, use the `getImageData` method of the editor to retrieve the image data and convert it into a blob. You can then invoke the `open` method on the Syncfusion<sup style="font-size:70%">&reg;</sup> Image Editor instance to load this byte array into the editor. The resulting byte array can be stored in a database for data management and maintenance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs2/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs2/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-save.jpg)

### Add watermarks while saving the image

You can utilize the [`FileOpened`]((https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_FileOpened)) event, which triggers once the image is loaded into the image editor. After this event, you can use the [`drawText`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.imageeditor.imageeditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_DrawText) method to add a watermark. This approach allows the watermark to be automatically drawn on the canvas every time an image is opened in the editor, making it useful for handling copyright-related content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs3/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/open-save/save-image-cs3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/open-save/save-image-cs3/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/image-editor-watermark.jpeg)

### Remove default Save button and add custom button to save the image to server

User can leverage the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.imageeditor.imageeditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_Toolbar) property to replace the default save button with a custom one. By doing so, you can use the `getImageData` method to retrieve the image data, convert it to base64 format, and then save it to the server. This approach gives you more control over the image-saving process.

### Prevent default save option and save the image to specific location

User can make use of the [`BeforeSave`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.imageeditor.imageeditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_BeforeSave) event, which triggers just before the image is downloaded, to override the default save option by setting `args.cancel` to true. Afterward, you can utilize the getImageData method to retrieve the current image data and convert it into a format like byte[], blob, or base64 for further processing. This gives you greater flexibility in handling the image data.

## Events to handle save actions

The Image Editor provides several events related to opening and saving images. These events offer detailed control over the image handling process. For comprehensive information about these events, including their triggers and usage, please refer to the dedicated section on open and save support. This section will provide you with the specifics needed to effectively utilize these events in your application.

### File opened event

The [`FileOpened`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_FileOpened) event is triggered in the Image Editor control after an image is successfully loaded. It provides the `FileOpenEventArgs` as the event argument, which contains two specific arguments: 

* FileName: This argument is a string that contains the file name of the opened image. It represents the name of the file that was selected or provided when loading the image into the Image Editor. 

* FileType: This argument is a string that contains the type of the opened image. It specifies the format or file type of the image that was loaded, such as PNG, JPEG, SVG, WEBP, and BMP. 

By accessing these arguments within the FileOpened event handler, you can retrieve information about the loaded image, such as its file name and file type. This can be useful for performing additional actions or implementing logic based on the specific image that was opened in the Image Editor control.

### Saving event 

The [`saving`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_Saved) event is triggered in the Image Editor control when an image is being saved to the local disk. It provides the `SaveEventArgs` as the event argument, which includes the following specific arguments: 

* FileName: This argument is a string that holds the file name of the saved image. It represents the name of the file that will be used when saving the image to the local disk. 

* FileType: This argument is a string indicating the type or format of the saved image. It specifies the desired file type in which the image will be saved, such as PNG, JPEG, SVG, and WEBP. 

* Cancel: This argument is a boolean value that can be set to true in order to cancel the saving action. By default, it is set to false, allowing the saving process to proceed. However, if you want to prevent the saving action from occurring, you can set Cancel to true within the event handler. 

By accessing these arguments within the Saving event handler, you can retrieve information about the file name and file type of the image being saved. Additionally, you have the option to cancel the saving action if necessary.

### Created event 

The [`created`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_Created) event is triggered once the Image Editor control is created. This event serves as a notification that the component has been fully initialized and is ready to be used. It provides a convenient opportunity to render the Image Editor with a predefined set of initial settings, including the image, annotations, and transformations. 

### Destroyed event

The [`destroyed`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ImageEditor.ImageEditor.html#Syncfusion_EJ2_ImageEditor_ImageEditor_Destroyed) event is triggered once the Image Editor control is destroyed or removed from the application. This event serves as a notification that the component and its associated resources have been successfully cleaned up and are no longer active.
