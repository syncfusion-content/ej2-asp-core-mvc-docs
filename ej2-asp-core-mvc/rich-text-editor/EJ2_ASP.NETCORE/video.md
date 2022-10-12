---
layout: post
title: Video in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Video in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Video
publishingplatform: ##Platform_Name##
documentation: ug
---

# Insert Video

The Rich Text Editor allows you to insert videos from online sources and local computers where you want to insert the video in your content. For inserting the video to the Rich Text Editor, the following list of options have been provided in the [insertVideoSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings).

| Options | Description |
|----------------|---------|
| AllowedTypes | Specifies the extensions of the video types allowed to insert on bowering and passing the extensions with comma separators. For example, pass allowedTypes as `.mp4`, `.mov`, `.wmv` and `.avi`.|
| LayoutOption | Sets the default display for an video when it is inserted in to the Rich Text Editor. Possible options are: `Inline` and `Break`.|
| SaveFormat | Sets the default save format of the video element when inserted. Possible options are: `Blob` and `Base64`.|
| Width | Sets the default width of the video when it is inserted in the Rich Text Editor.|
| MinWidth | Sets the minWidth of the video element when it is inserted in the Rich Text Editor.|
| MaxWidth | Sets the maxWidth of the video element when it is inserted in the Rich Text Editor.|
| Height | Sets the default height of the video when it is inserted in the Rich Text Editor.|
| MinHeight | Sets the minHeight of the video element when it is inserted in the Rich Text Editor.|
| MaxHeight | Sets the maxHeight of the video element when it is inserted in the Rich Text Editor.|
| SaveUrl | Provides URL to map the action result method to save the video.|
| RemoveUrl | Provides URL to map the action result method to remove the video.|
| Path | Specifies the location to store the video.|
| Resize | Sets the resizing action for the video element.|
| ResizeByPercent | Sets the percentage values for the video element with the resizing action.|

## Configure video tool in the toolbar

To include the video tool in the Rich Text Editor, you can add the toolbar item `Video` to the `toolbarSettings` [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To configure `Video` toolbar item, refer to the below code.

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

## Insert video from web

To insert a video from the hosted link or local machine, you should enable the video tool on the editor’s toolbar. By default, the video tool opens the dialog, allowing you to insert a video as an embedded URL. You can switch to a web URL to insert the video file from the online source.

## Insert from web URL

The video tool default opens the video dialog, allowing you to insert an embedded URL.

![Rich Text Editor Embed URL Video insert](./images/video-embed.png)

### Insert from web URL

Switching the option to the web URL in the video dialog allows you to insert a video from the online source. Inserting the URL will be added to the `src` attribute of the `<source>` tag.

![Rich Text Editor Video insert](./images/video-web.png)

## Upload and insert video

In the video dialog, by using the `browse` option, select the video from the local machine and insert it into the Rich Text Editor content.

If the path field is not specified in the [insertVideoSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings), the video will be converted into `Blob` url or `Base64` and inserted inside the Rich Text Editor.

### Restrict video upload based on size

Using the Rich Text Editor `fileUploading` event, you can restrict the video to upload when the given video size is greater than the allowed fileSize. Also, the video size in the argument will be returned in `bytes`.

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

### Server-side action

The selected video can be uploaded to the required destination using the controller action below. Map this method name in [insertVideoSettings.saveUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_SaveUrl) and provide required destination path through [insertVideoSettings.path](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Path) properties.

> If you want to insert lower-sized video files in the editor and don't want a specific physical location for saving the video, you can save the format as `Base64`.

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

### Video save format

The video files can be saved as `Blob` or `Base64` url by using the [insertVideoSettings.saveFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_SaveFormat) property, which is of enum type and the generated url will be set to the `src` attribute of the `<source>` tag.

> By default, the files are saved in the `Blob` format.

```typescript

<video>
    <source src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" type="video/mp4" >
</video>

<video>
    <source src="data:video/mp4;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHA" type="video/mp4" >
</video>

```

## Replacing video

Once a video file has been inserted, you can replace it using the Rich Text Editor [quickToolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Video) `videoReplace` option. You can replace the video file either by using the embedded URL or the web URL and the browse option in the video dialog.

![Rich Text Editor Embed Video replace](../images/video-replace-embed.png)

![Rich Text Editor Web Video replace](./images/video-replace-web.png)

## Delete video

To remove a video from the Rich Text Editor content, select the video and click the `videoRemove` tool from the quick toolbar. It will delete the video from the Rich Text Editor content as well as from the service location if the [insertVideoSettings.removeUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_RemoveUrl) is given.

Once you select the video from the local machine, the URL for the video will be generated. You can remove the video from the service location by clicking the cross icon.

![Rich Text Editor Video delete](../images/video-del.png)

The following example explains how to configure `insertVideoSettings.removeUrl` to remove a saved video from the remote service location when the following video remove actions are performed:

* `delete` key action.
* `backspace` key action.
* Removing uploaded video file from the insert video dialog.
* Deleting video using the quick toolbar `videoRemove` option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/remove-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Home-controller.cs" %}
{% include code-snippet/rich-text-editor/remove-url/home-controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/remove-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Home-controller.cs" %}
{% include code-snippet/rich-text-editor/remove-url/home-controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Dimension

Set the default Width, MinWidth, Height and MinHeight of the video element, when it is inserted in the Rich Text Editor using the [width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Width), [minWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinWidth), [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Height), [minHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinHeight) properties.

Through the [quickToolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Video),  also you can change the width and height using `Change Size` option. Once you click on the option, the video size dialog will open as below. In that, specify the width and height of the video in pixels.

![Rich Text Editor Video dimension](../images/video-size.png)

## Display Position

Sets the default display for an video when it is inserted in the Rich Text Editor using the `insertVideoSettings.layoutOption`. It has two possible options: `Inline` and `Break`. When updating the display positions, it updates the video elements’ layout position.

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

## Resize video

The Rich Text Editor has built-in video resizing support, which is enabled for the video elements added. The resize points will appear on each corner of the video when focusing so users can easily resize the video using mouse points or thumb through the resize points. Also, the resize calculation will be done based on the aspect ratio.

You can disable the resize action by configuring `false` for the [insertVideoSettings.resize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_Resize) property.

> If the [MinWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinWidth) and [MinHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorVideoSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorVideoSettings_MinHeight) properties are configured the video resizing does not shrink below the specified values.

![Rich Text Editor video resize](../images/video-resize.png)

## Rename video before inserting

By using the [insertVideoSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertVideoSettings) property, you can specify the server handler to upload the selected video. Then by binding the `fileUploadSuccess` event, you can receive the modified file name from the server and update it in the Rich Text Editor's insert video dialog.

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

## Upload video with authentication

The Rich Text Editor control allows you to add additional data with the File Upload, which can be received on the server side. By using the `fileUploading` event and its `customFormData` argument, you can pass parameters to the controller action. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

> By default it doesn't support `UseDefaultCredentials` property, we need to manually append the default credentials with the upload request.

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

## See Also

* [How to edit the quick toolbar settings](./toolbar/#quick-inline-toolbar)
* [How to use link editing option in the toolbar items](./link/)