---
layout: post
title: Audio in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Audio in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Audio
publishingplatform: ##Platform_Name##
documentation: ug
---

# Insert Audio

The Rich Text Editor allows inserting audio files from online sources and the local computer where you want to insert the audio in your content. For inserting the audio to the Rich Text Editor, the following list of options have been provided in the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings).

| Options | Description |
|----------------|---------|
| AllowedTypes | Specifies the extensions of the audio types allowed to insert on bowering and passing the extensions with comma separators. For example, pass allowedTypes as `.mp3`, `.wav`, `.m4a` and `.wma` |
| LayoutOption | Sets the default display for audio when it is inserted into the Rich Text Editor. Possible options are: `Inline` and `Break`.|
| SaveFormat | Sets the default save format of the audio element when inserted. Possible options are: `Blob` and `Base64`.|
| SaveUrl | Provides URL to map the action result method to save the audio.|
| RemoveUrl | Provides URL to map the action result method to remove the audio.|
| Path | Specifies the location to store the audio.|

## Configure audio tool in the toolbar

To include the audio tool in the Rich Text Editor, you can add the toolbar item `Audio` to the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To configure `Audio` toolbar item, refer to the below code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-import/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-import/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Insert audio from web

To insert audio from the hosted link or local machine, you should enable the audio tool on in the editor’s toolbar.

## Insert from web URL

By default, the audio tool opens the audio dialog, allowing you to insert audio from an online source. Inserting the URL will be added to the `src` attribute of the `<source>` tag.

![Rich Text Editor Audio insert](./images/audio-web.png)

## Upload and insert audio

In the audio dialog, using the `browse` option, select the audio from the local machine and insert it into the Rich Text Editor content.

If the path field is not specified in the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings), the audio will be converted into `Blob` url or `Base64` and inserted inside the Rich Text Editor.

### Restrict audio upload based on size

Using the Rich Text Editor `FileUploading` event, you can restrict the audio to upload when the given audio size is greater than the allowed fileSize. Also, the audio size in the argument will be returned in `bytes`.

In the following illustration, the audio size has been validated before uploading, and it is determined whether the audio has been uploaded or not.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-audio-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-audio-size/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/check-audio-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/check-audio-size/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Server-side action

The selected audio can be uploaded to the required destination using the controller action below. Map this method name in [InsertAudioSettings.SaveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveUrl) and provide the required destination path through [InsertAudioSettings.Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_Path) properties.

> If you want to insert lower-sized audio files in the editor and don't want a specific physical location for saving audio, you can opt to save the format as `Base64`.

In the following code blocks, you can insert the audio files which are saved in the specified path.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-save/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-save/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-save/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFile.cs" %}
{% include code-snippet/rich-text-editor/audio-save/saveFile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Audio save format

The audio files can be saved as `Blob` or `Base64` url by using the [InsertAudioSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveFormat) property, which is of enum type and the generated url will be set to the `src` attribute of the `<source>` tag.

> By default, the files are saved in the `Blob` format.

```typescript

<audio>
    <source src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" type="audio/mp3" >
</audio>

<audio>
    <source src="data:audio/mp3;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHA" type="audio/mp3" >
</audio>

```

## Replacing audio

Once an audio file has been inserted, you can change it using the Rich Text Editor [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Audio) `audioReplace` option. You can replace the audio file using the web URL or the browse option in the audio dialog.

![Rich Text Editor Audio replace](./images/audio-replace.png)

## Delete audio

To remove audio from the Rich Text Editor content, select the audio and click the `audioRemove` tool from the quick toolbar. It will delete the audio from the Rich Text Editor content as well as from the service location if the [InsertAudioSettings.RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_RemoveUrl) is given.

Once you select the audio from the local machine, the URL for the audio will be generated. You can remove the audio from the service location by clicking the cross icon.

![Rich Text Editor Audio delete](./images/audio-del.png)

The following sample explains how to configure `InsertAudioSettings.RemoveUrl` to remove saved audio from the remote service location when the following audio removal actions are performed:

* `delete` key action.
* `backspace` key action.
* Removing uploaded audio file from the insert audio dialog.
* Deleting audio using the quick toolbar `audioRemove` option.

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

## Display Position

Sets the default display for an audio when it is inserted in the Rich Text Editor using the `InsertAudioSettings.LayoutOption`. It has two possible options: `Inline` and `Break`. When updating the display positions, it updates the audio elements’ layout position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-settings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Rename audio before inserting

Using the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings) property, you can specify the server handler to upload the selected audio. Then by binding the `FileUploadSuccess` event, you can receive the modified file name from the server and update it in the Rich Text Editor's insert audio dialog.

Refer `rename.cs` controller file for configure the server-side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-rename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-rename/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-rename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rename.cs" %}
{% include code-snippet/rich-text-editor/audio-rename/rename.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Upload audio with authentication

The Rich Text Editor control allows you to add additional data with the File Upload, which can be received on the server side. By using the `FileUploading` event and its `customFormData` argument, you can pass parameters to the controller action. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

> By default it doesn't support `UseDefaultCredentials` property, we need to manually append the default credentials with the upload request.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-authenticate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-authenticate/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-authenticate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFile.cs" %}
{% include code-snippet/rich-text-editor/audio-authenticate/saveFile.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [How to edit the quick toolbar settings](./toolbar/#quick-inline-toolbar)
* [How to use link editing option in the toolbar items](./link/)