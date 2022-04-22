---
layout: post
title: Customize Custom Thumbnail in ##Platform_Name## File Manager Component
description: Learn here all about how to customize Custom Thumbnail in Syncfusion ##Platform_Name## File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Custom Thumbnail
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom thumbnail in file manager

The default appearance of the file manager can be customized with your own icon by using [showThumbnail](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ShowThumbnail.html) property.


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




![FileManager custom thumbnail ](../images/custom_thumbnail.PNG)