---
layout: post
title: Drag and Drop in ##Platform_Name## File Upload | Syncfusion
description: Enable drag-and-drop file uploads in the Syncfusion ##Platform_Name## File Upload using the dropArea property to define a custom drop target.
platform: ej2-asp-core-mvc
control: Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop in ##Platform_Name## File Upload

The Uploader control allows you to drag and drop files for upload. You can drag the files from the file explorer and drop them into the drop area.

By default, the Uploader control acts as the drop area element. The drop area gets highlighted when you drag files over it.

## Custom drop area

The uploader control allows you to set an external target element as the drop area using the [`dropArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property. You can specify the target element as an HTML element or its ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/custom-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/custom-drop/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the drop area

You can customize the appearance of the drop area by overriding the default drop area styles. The `e-file-select-wrap` and `e-upload` classes are available to customize the drop area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/customize-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-drop.cs" %}
{% include code-snippet/uploader/customize-drop/customize-drop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


