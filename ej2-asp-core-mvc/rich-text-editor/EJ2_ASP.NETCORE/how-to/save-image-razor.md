---
layout: post
title: Save Image Server in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Save Image Server in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Save Image Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Save and Remove action in ASP.NET Core Razor

The save action handler upload the image that needs to be specified in the [`saveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveUrl) property. The save handler receives the submitted image and manages the save process in server.

Enabled the Cros and configured it with the Antiforgery token to provide proper security using the [`ImageUploading`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ImageUploading) and [`ImageRemoving`]() events. Set the [`SaveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_SaveUrl) and [`RemoveUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorImageSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorImageSettings_RemoveUrl) to the respective methods.

Anti-forgery token is used between the client and server to prevent cross-site request forgery (CSRF) attack. For more information on preventing CSRF attack, refer to the [`link.`](https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-7.0&viewFallbackFrom=aspnetcore-2.1#authentication-fundamentals)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/save-image-razor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/save-image-razor/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Server-side configuration for startup page:
This section explains how to add the anti forgery tokens header in startup page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Server-side configuration for save action and remove action:
This section explains how to handle the server-side action for saving and removing the image from server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}