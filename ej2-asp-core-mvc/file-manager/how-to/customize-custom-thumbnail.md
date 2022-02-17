---
layout: post
title: Customize Custom Thumbnail in ##Platform_Name## File Manager Component
description: Learn here all about Customize Custom Thumbnail in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Customize Custom Thumbnail
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom thumbnail in file manager

The default appearance of the file manager can customize with your own icon by using [showThumbnail](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ShowThumbnail.html) property.

The following example demonstrate how to add a custom icon in largeicons view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/show-thumbnail/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/show-thumbnail/HomeController_mvc.cs %}
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



Output be like the below.

![FileManager custom thumbnail ](../images/custom_thumbnail.PNG)