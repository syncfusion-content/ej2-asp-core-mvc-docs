---
layout: post
title: Localization in ##Platform_Name## Uploader Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The Localization library allows you to localize static text content of the uploader.
The static text contains default text content of action buttons, file status, clear icon title, tooltips,
and text content of drag area. Define the locale object for a culture and assign it to L10n load method.

The following are the list of keys and its values used in the uploader control:

| Key | Description |
|------------------------|---------|
| Browse | To customize the browse button text.|
| Clear | To customize the clear button text.|
| Upload | To customize the upload button text. |
| dropFilesHint | To customize the drop area text. |
| uploadFailedMessage | To customize the status text when  the file is failed to upload.|
| uploadSuccessMessage | To customize the status text when  the file is uploaded successfully.|
| removedSuccessMessage | To customize the status text when  the file is removed the successfully from the serve.|
| removedFailedMessage | To customize the status text while the file is failed to remove.|
| inProgress | To customize the status text while the upload is in progress.|
| pauseUpload | To customize the status text while the uploading is paused.|
| fileUploadCancel | To customize the status text when uploading is cancelled.|
| readyToUploadMessage | To customize the status text when the file is selected and ready to upload.|
| invalidMaxFileSize | To customize the status text when the file size is greater than the maximum file size.|
| invalidFileType | To customize the status text when the file type is invalid.|
| invalidMinFileSize | To customize the status text when the file size is less than the minimum file size. |
| remove | To customize tooltip text for remove icon. |
| cancel | To customize tooltip text for cancel icon. |
| delete | To customize tooltip text for delete icon. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/uploader/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/uploader/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![uploader](./images/uploader-locale.png)
