---
layout: post
title: Audio in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Audio in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Audio
publishingplatform: ##Platform_Name##
documentation: ug
---

# Audios in ##Platform_Name## Rich text editor Control

The Rich Text Editor allows you to insert audio from online sources and local computers and then insert them into your content. You can insert the audio with the following list of options in the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings) property.

## Configuring the Audio Tool in the Toolbar

You can add an `Audio` tool in the Rich Text Editor toolbar using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To configure the `Audio` toolbar item, refer to the below code.

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

## Audio Save Formats

The audio files can be saved as `Blob` or `Base64` URL by using the [InsertAudioSettings.SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveFormat) property, which is of enum type, and the generated URL will be set to the `src` attribute of the `<source>` tag.

> The default `SaveFormat` property is set to `Blob` format.

```typescript

<audio>
    <source src="blob:http://ej2.syncfusion.com/3ab56a6e-ec0d-490f-85a5-f0aeb0ad8879" type="audio/mp3" >
</audio>

<audio>
    <source src="data:audio/mp3;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHA" type="audio/mp3" >
</audio>

```

## Insert Audio from the Web

You can insert audio from either the hosted link or the local machine, by clicking the audio button in the editor's toolbar. On clicking the audio button, a dialog opens, which allows you to insert audio from the web URL.

### Inserting Audio from Web URLs

By default, the audio tool opens the audio dialog, allowing you to insert audio from an online source. Inserting the URL will be added to the `src` attribute of the `<source>` tag.

![Rich Text Editor Audio insert](../../images/aspcore-richtexteditor-audio-web.png)

## Uploading Audio from Local Machine

You can use the `browse` option on the audio dialog, to select the audio from the local machine and insert it into the Rich Text Editor content.

If the path field is not specified in the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings), the audio will be converted into the `Blob` URL or `Base64` and inserted inside the Rich Text Editor.

### Server-Side Action

The selected audio can be uploaded to the required destination using the controller action below. Map this method name in [InsertAudioSettings.SaveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveUrl) and provide the required destination path through [InsertAudioSettings.Path](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_Path) properties.

> If you want to insert lower-sized audio files in the editor and don't want a specific physical location for saving the audio, you can opt to save the format as `Base64`.

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

## Saving Audio to the Server 

[SaveFormat](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveFormat) Sets the default save format of the audio element when inserted. Possible options are: `Blob` and `Base64`.

[SaveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_SaveUrl) provides URL to map the action result method to save the audio.

[RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_RemoveUrl) provides URL to map the action result method to remove the audio.

### Renaming Audio Before Inserting

You can use the [InsertAudioSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertAudioSettings) property, to specify the server handler to upload the selected audio. Then by binding the [FileUploadSuccess](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileUploadSuccess) event, you can receive the modified file name from the server and update it in the Rich Text Editor's insert audio dialog.

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


### Restricting Audio by Size

You can restrict the audio uploaded from the local machine when the uploaded audio file size is greater than the allowed size by using the [FileUploading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileUploading) event.

> The file size in the argument will be returned in `bytes`.

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

### Uploading Audio with Authentication

You can add additional data with the audio uploaded from the Rich Text Editor on the client side, which can even be received on the server side by using the [FileUploading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FileUploading) event and its `customFormData` argument, you can pass parameters to the controller action. On the server side, you can fetch the custom headers by accessing the form collection from the current request, which retrieves the values sent using the POST method.

N> By default, it doesn't support the `UseDefaultCredentials` property; we need to manually append the default credentials with the upload request.

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

## Audio Replacement Functionality

Once an audio file has been inserted, you can change it using the Rich Text Editor [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Audio) `AudioReplace` option. You can replace the audio file using the web URL or the browse option in the audio dialog.

![Rich Text Editor Audio replace](../../images/aspcore-richtexteditor-audio-replace.png)

## Deleting Audios

To remove audio from the Rich Text Editor content, select the audio and click the `audioRemove` button from the quick toolbar. It will delete the audio from the Rich Text Editor content as well as from the service location if the [InsertAudioSettings.RemoveUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_RemoveUrl) is given.

Once you select the audio from the local machine, the URL for the audio will be generated. You can remove the audio from the service location by clicking the cross icon.

![Rich Text Editor Audio delete](../../images/aspcore-richtexteditor-audio-del.png)

## Configuring Audio Display Position

Sets the default display property for audio when it is inserted in the Rich Text Editor using the [InsertAudioSettings.LayoutOption](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorAudioSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorAudioSettings_LayoutOption) property. It has two possible options: `Inline` and `Break`. When updating the display positions, it updates the audio elements’ layout position.

> The default `layoutOption` property is set to `Inline`.

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

## Customizing the Audio Quick Toolbar

The Rich Text Editor enables customization of the audio quick toolbar, allowing you to tailor its functionality with essential tools such as AudioReplace, Remove, and AudioLayoutOption.

By configuring these options in the [QuickToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorQuickToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorQuickToolbarSettings_Audio) property, you enhance the editor's capabilities, facilitating seamless management and editing of audio directly within your content. This customization ensures a user-friendly experience for manipulating audio elements efficiently.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-quick-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/audio-quick-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/audio-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Quick Toolbars in the Toolbar](../toolbar/quick-toolbar)
* [How to Use the Video Editing Option in Toolbar Items](./video)
* [How to Use the Image Editing Option in Toolbar Items](./insert-images)