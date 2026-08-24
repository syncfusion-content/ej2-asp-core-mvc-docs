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

The uploader component allows you to drag and drop the files to upload. You can drag the files from file explorer and drop into the drop area.

By default, the uploader component act as drop area element. The drop area gets highlighted when you drag the files over drop area.

## Custom drop area

The uploader component allows you to set external target element as drop area using the [dropArea](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_DropArea) property. The element can be represented as HTML element or element’s id.

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



## Customize drop area

You can customize the appearance of drop area by overriding the default drop area styles. The class “” and “” is available to handle this customization.

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


