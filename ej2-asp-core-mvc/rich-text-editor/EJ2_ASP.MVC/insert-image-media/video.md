---
layout: post
title: Video in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Video in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Video
publishingplatform: ##Platform_Name##
documentation: ug
---

# Videos in the ##Platform_Name## Rich Text Editor Control

The Rich Text Editor allows you to insert videos from online sources and local computers into your content.  You can insert the video with the following list of options in the [InsertVideoSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings) property.

## Configuring the Video Tool in the Toolbar

You can add the `Video` tool in the Rich Text Editor toolbar using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To configure the `Video` toolbar item, refer to the below code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-import/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-import/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Video Save Formats

The video files can be saved as `Blob` or `Base64` URLs by using the [InsertVideoSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_SaveFormat) property, which is of enum type, and the generated URL will be set to the `src` attribute of the `<source>` tag.

> The default `SaveFormat` property is set to `Blob` format.

```typescript

<video>
    <source src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" type="video/mp4" >
</video>

<video>
    <source src="data:video/mp4;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHA" type="video/mp4" >
</video>

```

## Inserting Video from Web

You can insert a video from either a hosted link or your local machine by clicking the video button in the editor's toolbar. When you click the video button, a dialog opens, allowing you to insert a video using an Embedded code or Web URL.

### Inserting Video via Embed URL

The insert video dialog opens with the `Embedded code` option selected by default. This allows you to insert a video using embedded code.

![Rich Text Editor Embed URL Video insert](../images/aspcore-richtexteditor-video-embed.png)

### Inserting Video via Web URL

You can switch to the `Web URL` option by selecting the Web URL checkbox. Inserting a video using the Web URL option will add the video URL as the `src` attribute of the `<source>` tag.

![Rich Text Editor Video insert](../images/aspcore-richtexteditor-video-web.png)

## Uploading Video from Local Machine

You can use the `browse` option on the video dialog to select the video from the local machine and insert it into the Rich Text Editor content.

If the path field is not specified in the [InsertVideoSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings), the video will be converted into the `Blob` URL or `Base64` and inserted inside the Rich Text Editor.

## Saving Video to the Server

Upload the selected video to a specified destination using the controller action specified in [InsertVideoSettings.SaveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_SaveUrl). Ensure to map this method name appropriately and provide the required destination path through the [InsertVideoSettings.Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Path) properties.

Configure [InsertVideoSettings.RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_RemoveUrl) to point to the endpoint responsible for deleting video files.

Set the [InsertVideoSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_SaveFormat) property to determine whether the video should be saved as Blob or Base64, aligning with your application's requirements.

> If you want to insert lower-sized video files in the editor and don’t require a specific physical location for saving the video, you can save the format as `Base64`.

In the following code blocks, you can insert the video files which are saved in the specified path.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-save/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFile.cs" %}
{% include code-snippet/rich-text-editor/video-save/saveFile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Renaming Video Before Inserting

You can use the [InsertVideoSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings) property to specify the server handler to upload the selected video. Then, by binding the [FileUploadSuccess](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileUploadSuccess) event, you can receive the modified file name from the server and update it in the Rich Text Editor's insert video dialog.

Refer `rename.cs` controller file for configure the server-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-rename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-rename/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-rename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rename.cs" %}
{% include code-snippet/rich-text-editor/video-rename/rename.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Uploading Video with Authentication

You can add additional data with the video uploaded from the Rich Text Editor on the client side, which can even be received on the server side. By using the [FileUploading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileUploading) event and its `CustomFormData` argument, you can pass parameters to the controller action. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

N> By default, it doesn't support the `UseDefaultCredentials` property, you can manually append the default credentials with the upload request.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-authenticate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-authenticate/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-authenticate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFile.cs" %}
{% include code-snippet/rich-text-editor/video-authenticate/saveFile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Maximum file size restrictions

You can restrict the video uploaded from the local machine when the uploaded video file size is greater than the allowed size by using the [InsertVideoSettings.MaxFileSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MaxFileSize) property. By default, the maximum file size is 30000000 bytes. You can configure this size as follows.

In the following example, the video size has been validated before uploading and determined whether the video has been uploaded or not.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-video-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-video-size/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-video-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-video-size/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Video Replacement Functionality

Once a video file has been inserted, you can replace it using the Rich Text Editor [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Video) `VideoReplace` option. You can replace the video file either by using the embedded code or the web URL and the browse option in the video dialog.

![Rich Text Editor Embed Video replace](../images/video-replace-embed.png)

![Rich Text Editor Web Video replace](../images/video-replace-web.png)

## Deleting Video

To remove a video from the Rich Text Editor content, select the video and click the `VideoRemove` button from the quick toolbar. It will delete the video from the Rich Text Editor content as well as from the service location if the [InsertVideoSettings.RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_RemoveUrl) is given.

Once you select the video from the local machine, the URL for the video will be generated. You can remove the video from the service location by clicking the cross icon.

![Rich Text Editor Video delete](../images/video-del.png)


## Adjusting Video Dimensions

Set the default width, minWidth, height, and minHeight of the video element when it is inserted in the Rich Text Editor using the [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Width), [MinWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinWidth), [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Height), [MinHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinHeight) properties.

Through the [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Video), you can also change the width and height using the `Change Size` button. Once you click on the button, the video size dialog will open as below. In that, specify the width and height of the video in pixels.

![Rich Text Editor Video dimension](../images/video-size.png)

## Configuring Video Display Position

Sets the default display property for the video when it is inserted in the Rich Text Editor using the [InsertVideoSettings.LayoutOption](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_LayoutOption) property. It has two possible options: `Inline` and `Break`. When updating the display positions, it updates the video elements’ layout position.

> The default `LayoutOption` property is set to `Inline`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-settings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Video Resizing Tools

The Rich Text Editor has built-in video resizing support, which is enabled for the video elements added. The resize points will appear on each corner of the video when focusing, so users can easily resize the video using mouse points or thumb through the resize points. Also, the resize calculation will be done based on the aspect ratio.

You can disable the resize action by configuring `false` for the [InsertVideoSettings.Resize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Resize) property.

> If the [MinWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinWidth) and [MinHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinHeight) properties are configured, the video resizing does not shrink below the specified values.

![Rich Text Editor video resize](../images/aspcore-richtexteditor-video-resize.png)

## Customizing the Video Quick Toolbar

The Rich Text Editor enables customization of the video quick toolbar, allowing you to tailor its functionality with essential tools such as VideoReplace, VideoAlign, VideoRemove, VideoLayoutOption, and VideoDimension.

By configuring these options in the [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Video) property, you enhance the editor's capabilities, facilitating seamless management and editing of embedded videos directly within your content. This customization ensures a user-friendly experience for manipulating video elements efficiently.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-quick-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/video-quick-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/video-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [How to Use the Audio Editing Option in Toolbar Items](./audio)
* [How to Use the Image Editing Option in Toolbar Items](./insert-images)