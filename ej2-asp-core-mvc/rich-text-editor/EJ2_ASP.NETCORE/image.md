---
layout: post
title: Image in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Image in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Image
publishingplatform: ##Platform_Name##
documentation: ug
---


# Image

Rich Text Editor allows to insert images from online sources as well as local computer where you want to insert the image in your content. For inserting the image to the Rich Text Editor, the following list of options have been provided in the [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_)

| Options | Description |
|----------------|---------|
| allowedTypes | Specifies the extensions of the image types allowed to insert on bowering and passing the extensions with comma separators. For example, pass allowedTypes as .jpg and .png.|
| display | Sets the default display for an image when it is inserted in to the Rich Text Editor. Possible options are: 'inline' and 'break'.|
| width | Sets the default width of the image when it is inserted in the Rich Text Editor.|
| height | Sets the default height of the image when it is inserted in the Rich Text Editor.|
| saveUrl | Provides URL to map the action result method to save the image.|
| path | Specifies the location to store the image.|
| resize | To enable resizing for image element.|
| minWidth | Defines the maximum Width of the image.|
| maxWidth | Defines the maximum Width of the image.|
| minHeight | Defines the minimum Height of the image.|
| maxHeight | Defines the maximum Height of the image.|
| resizeByPercent | Image resizing should be done by percentage calculation.|

## Upload Options

Through the `browse` option in the Image dialog, select the image from the local machine and insert into the Rich Text Editor content.

If the path field is not specified in the [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_), the image will be converted into base 64 and blob url for the image will be created and the generated url will be set as src property of `<img>` tag as below.

```typescript

<img src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" >

```

> If you want to insert a lot of tiny images in the editor and don't want a specific physical location for saving images, you can opt to save format as Base64.

In the below sample, the image has been load from the local machine and it will be saved in the given location.

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



## Server Side Action

The selected image can be uploaded to the required destination by using the below controller action. Map this method name in `saveUrl` property of [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_) and provide required destination path through `path` property.

> The runnable demo application is available in this [Github](https://github.com/SyncfusionExamples/aspnet-core-richtexteditor-image-upload) repository.

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



## Image Delete

If you want to remove am image from the Rich Text Editor content, select the image and click “Remove” tool from quick toolbar. It will delete the image from the Rich Text Editor content.

Once you select the image from the local machine, the URL for the image will be generate, from there also you remove the image from the service location through the clicking of cross icon as below in the image.

![Rich Text Editor Image delete](./images/image-del.png)

The following sample explains, how to configure `removeUrl` to remove a saved image from the remote service location, when the following image remove actions are performed:

* `delete` key action.
* `backspace` key action.
* Removing uploaded image file from the insert image dialog.
* Deleting image using the quick toolbar `remove` option.

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



## Insert from Web

If you want to insert an image from online source like Google, Ping, etc., you need to enable images tool on the editor’s toolbar. By default, the images tool is open an image dialog which allows you to insert an image from online source.

## Dimension

Sets the default width and height of the image when it is inserted in the Rich Text Editor using `width` and `height` of [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_).

Through the `quickToolbar` also you can change the width and height using `Change Size` option. Once click into the option. The Image Size dialog will open as below. In that specify the width and height of the image in pixel.

![Rich Text Editor Image dimension](./images/image-size.png)

## Caption and Alt Text

Image caption and alternative text can be specified for the inserted image in the Rich Text Editor through the [`quickToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_QuickToolbarSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_) options such as Image Caption and Alternative Text.

Through the Alternative Text option, set the alternative text for the image, when the image is not upload successfully into the Rich Text Editor.

By clicking the Image Caption, the image will get wrapped in an image element with a caption. Then, you can type caption content inside the Rich Text Editor.

## Display Position

Sets the default display for an image when it is inserted in the Rich Text Editor using `display` field in [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_InsertImageSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_). It has two possible options: 'inline' and 'break'.

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



## Image with Link

The hyperlink itself can be an image in Rich Text Editor. If the image given as hyperlink, the remove, edit and open link will be added to the quick toolbar of image as below. For further details about link, please see the [`link documentation`](./link).

![Rich Text Editor image with link](./images/image-link.png)

## Drag and Drop

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



### Drag and drop with specific extension images

You can allow the specific images alone to be uploaded using the the allowedTypes property. By default, the Rich Text Editor allows the JPG, JPEG, and PNG formats. You can configure this formats as follows.

``` typescript
    insertImageSettings: {
      allowedTypes: ['.jpg']
    }

```

### Prevent drag and drop action

You can prevent drag-and-drop action by setting the actionBegin argument cancel value to true. The following code shows how to prevent the drag-and-drop.

``` typescript
    function actionBegin(args) {
        if(args.type === 'drop' || args.type === 'dragstart') {
            args.cancel =true;
        }
    }

```

## See Also

* [How to edit the quick toolbar settings](./toolbar/#quick-inline-toolbar)
* [How to use link editing option in the toolbar items](./link/)