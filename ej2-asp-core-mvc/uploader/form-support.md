---
layout: post
title: Form Support in ##Platform_Name## File Upload | Syncfusion
description: Use the Syncfusion ##Platform_Name## File Upload inside an HTML form with disabled autoUpload and a name attribute to post files on submit.
platform: ej2-asp-core-mvc
control: Form Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form Support in ##Platform_Name## File Upload

The [Uploader](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) control works with HTML forms like a default file input. The following configurations are required for the Uploader to work inside a form.

* [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_SaveUrl) and [`removeUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderAsyncSettings.html#Syncfusion_EJ2_Inputs_UploaderAsyncSettings_RemoveUrl) must be null.
* [`autoUpload`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_AutoUpload) must be disabled.
* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.UploaderUploadedFiles.html#Syncfusion_EJ2_Inputs_UploaderUploadedFiles_Name) attribute must be added on the input element.

The selected or dropped files are received as a collection in the form action when the form is submitted. The form action handles the server-side operations that manage the file upload process. When you reset the form, the file list and data will be cleared.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/form-support/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/form-support/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/form-support/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/form-support/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}


