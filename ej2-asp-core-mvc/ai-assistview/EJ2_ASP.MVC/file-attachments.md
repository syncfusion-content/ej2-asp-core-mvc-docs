---
layout: post
title: Attachments in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Attachments in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Attachments
publishingplatform: ##Platform_Name##
documentation: ug
---

# Attachments in ##Platform_Name## AI AssistView control

The `Attachment` support in AI AssistView specifies user to include file attachments along with their prompts in the AI AssistView. This enhances the interaction by allowing users to provide additional context through files. You can enable this feature using the `EnableAttachments` property, and customize its behavior using the `AttachmentSettings` property.

## Enable attachment

You can enable the attachment by using the `EnableAttachments` property. By default, it is set to `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/file-attachments/enable-attachments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-attachments.cs" %}
{% include code-snippet/ai-assistview/file-attachments/enable-attachments/enable-attachments.cs %}
{% endhighlight %}
{% endtabs %}

![EnableAttachments](images/enable-attachments.png)

## Configuring attachments

You can use the `AttachmentSettings` tag to configure the attachments in the AI AssistView.

### Setting saveUrl and removeUrl

You can use the `SaveUrl` and `RemoveUrl` property to add the save and remove the URL for the file uploaded in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/file-attachments/save-remove-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Save-remove-url.cs" %}
{% include code-snippet/ai-assistview/file-attachments/save-remove-url/save-remove-url.cs %}
{% endhighlight %}
{% endtabs %}

![SaveRemoveUrl](images/save-remove-url.png)

### Setting file type

You can use the `AllowedFileType` property to upload the specific file types in the attachment.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/file-attachments/file-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="File-type.cs" %}
{% include code-snippet/ai-assistview/file-attachments/file-type/file-type.cs %}
{% endhighlight %}
{% endtabs %}

![FileType](images/file-type.png)

### Setting file size

You can use the  `MaxFileSize` property to allowed a maximum file size of the upload file in the AI AssistView. By default, it is set to `2000000` bytes.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/file-attachments/file-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="File-size.cs" %}
{% include code-snippet/ai-assistview/file-attachments/file-size/file-size.cs %}
{% endhighlight %}
{% endtabs %}

![FileSize](images/file-size.png)