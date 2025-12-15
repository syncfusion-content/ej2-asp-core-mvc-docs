---
layout: post
title: Attachments in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Attachments in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chat UI
publishingplatform: ##Platform_Name##
documentation: ug
---

# File Attachments in ##Platform_Name## Chat UI control

The Chat UI control supports message attachments, enabling users to upload and send files (images, documents, and more) alongside messages for richer, more contextual conversations. Enable this functionality using the `enableAttachments` property and customize the behavior through the `attachmentSettings` configuration.

## Enable file attachments

Enable file attachment support by setting the `enableAttachments` property to `true`. By default, it is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/enableAttachments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableAttachments.cs" %}
{% include code-snippet/chat-ui/file-attachments/enableAttachments/enableAttachments.cs %}
{% endhighlight %}
{% endtabs %}

## Configure attachment settings

Use the `e-chatui-attachmentsettings` tag directive to customize file attachment behavior, including upload endpoints, file type restrictions, and size limits.

### Setting saveUrl and removeUrl

Set the `saveUrl` and `removeUrl` properties to specify server endpoints for handling file uploads and removals. The `saveUrl` processes file uploads, while the `removeUrl` handles file deletion requests.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/save-remove-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="saveRemoveUrl.cs" %}
{% include code-snippet/chat-ui/file-attachments/save-remove-url/save-remove-url.cs %}
{% endhighlight %}
{% endtabs %}

### Setting file type

Use the `allowedFileTypes` property to specify which file types users can upload. This property accepts file extensions (e.g., '.pdf', '.docx') or MIME types to control the types of files that can be attached.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/allowedFileTypes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllowedFileTypes.cs" %}
{% include code-snippet/chat-ui/file-attachments/allowedFileTypes/allowedFileTypes.cs %}
{% endhighlight %}
{% endtabs %}

### Setting file size

Configure the `maxFileSize` property to define the maximum file size allowed for uploads. Specify the size in bytes. The default value is `30000000` bytes (approximately 30 MB). Files exceeding this limit will not be uploaded.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/maxFileSize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MaxFileSize.cs" %}
{% include code-snippet/chat-ui/file-attachments/maxFileSize/maxFileSize.cs %}
{% endhighlight %}
{% endtabs %}

![MaxFileSize](images/maxFileSize.png)

### Setting save format

Control the format used to send files to the server using the `saveFormat` property when path is not set. It does not change how files are uploaded. The default value is `Blob`.

 - `Blob`: Used for fast, memory‑efficient local previews.
 - `Base64`: Reads the file as a Base64 data URL, useful when you need an inline data URL.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/saveFormat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SaveFormat.cs" %}
{% include code-snippet/chat-ui/file-attachments/saveFormat/saveFormat.cs %}
{% endhighlight %}
{% endtabs %}

### Setting server path

The `path` property to specifies the public base URL where uploaded files are (or will be) hosted. When set, it takes precedence over saveFormat.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/path/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Path.cs" %}
{% include code-snippet/chat-ui/file-attachments/path/path.cs %}
{% endhighlight %}
{% endtabs %}

### Enabling drag-and-drop

Toggle drag-and-drop support for attachments via `enableDragAndDrop` property. The default value is `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/drag-and-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DragAndDrop.cs" %}
{% include code-snippet/chat-ui/file-attachments/drag-and-drop/drag-and-drop.cs %}
{% endhighlight %}
{% endtabs %}

### Setting maximum count

Restrict how many files can be attached at once using `maximumCount`. The default value is `10`. If users select more than the allowed count, the maxfileSize error will be displayed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/maximumCount/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MaximumCount.cs" %}
{% include code-snippet/chat-ui/file-attachments/maximumCount/maximumCount.cs %}
{% endhighlight %}
{% endtabs %}

![MaximumCount](images/maximumCount.png)

## Templates

### Customizing the file preview

Provide a custom UI for previewing selected files using `previewTemplate`. Use this to render thumbnails, filenames, progress, remove buttons, or any additional metadata prior to sending.

### Customizing the attachments

Control how attachments appear inside message bubbles with `attachmentTemplate`. Use this to tailor the display of images, documents, or custom file types once the message is posted.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/file-attachments/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chat-ui/file-attachments/template/template.cs %}
{% endhighlight %}
{% endtabs %}

![AttachmentTemplate](images/attachmentTemplate.png)
![PreviewTemplate](images/previewTemplate.png)
