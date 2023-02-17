---
layout: post
title: Virtualization in ##Platform_Name## Syncfusion File Manager Component
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in File Manager Component

File Manager's UI virtualization allows you for the dynamic loading of a large number of directories and files in both the details and largeicons views without degrading its performance.

## Enable Virtualization

The virtualization of the File Manager component is based on the height and width of viewport, the items will be loaded in both largeIconsViewSettings and detailsViewSettings.

In order to enable `virtualization`, you must set the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnableVirtualization) property to true.

In the instance below, a sizable collection of files can be found in the folders **Documents** and **Text Documents**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/virtualization/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/virtualization/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Virtualization](./images/virtualization.mp4)

## Limitations for Virtualization

* Programmatic selection using the **selectAll** method is not supported with virtual scrolling.

* The keyboard shortcut **CTRL+A** will only select the files and directories that are currently visible within the viewport, rather than selecting all files and directories in the entire directory tree.

* Selected file items are not maintained when scroll considering the performance of the component.
