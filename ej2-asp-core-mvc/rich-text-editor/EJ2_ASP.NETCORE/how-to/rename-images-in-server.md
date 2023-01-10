---
layout: post
title: Rename Images In Server in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Rename Images In Server in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Rename Images In Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rename uploaded images in server before inserting it in the Rich Text Editor

By using the [`insertImageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InsertImageSettings) property, you can specify the server handler to upload the selected image. Then you can bind the [`imageUploadSuccess`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ImageUploadSuccess) event, to receive the modified file name from the server and update it in the Rich Text Editor's insert image dialog.

Refer `controller` file for configure the server-side.

N> The runnable demo application is available in this [Github](https://github.com/SyncfusionExamples/aspnet-core-richtexteditor-rename-image) repository.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/rename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/rename/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/rename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/rename/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

