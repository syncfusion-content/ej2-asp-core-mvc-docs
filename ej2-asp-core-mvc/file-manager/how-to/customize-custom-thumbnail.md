---
layout: post
title: Customize thumbnails in ##Platform_Name## File Manager | Syncfusion
description: Learn how to customize thumbnails in the ##Platform_Name## File Manager by adding your own icons for file types and folders in the LargeIcons view.
control: File Manager
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize thumbnails in ##Platform_Name## File Manager

The default appearance of the File Manager can be customized with your own icon by using the `showThumbnail` property.

The following example demonstrates how to add a custom icon in the largeicons view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/show-thumbnail/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/show-thumbnail/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/show-thumbnail/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/show-thumbnail/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below.

![File Manager custom thumbnail ](../images/custom_thumbnail.PNG)