---
layout: post
title: Virtualization in ##Platform_Name## Syncfusion File Manager Control | Syncfusion
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in File Manager Control

File Manager's UI virtualization allows for the dynamic loading of a large number of directories and files in both the detailsView and largeIconsView without degrading performance.

## Enable Virtualization

The virtualization of the File Manager control is based on the height and width of the viewport. The items will be loaded in both [largeIconsView](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_View) and [detailsView](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManagerDetailsViewSettings.html) based on the viewport size.

In order to enable `virtualization`, you must set the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnableVirtualization) property to true.

The example below shows a large collection of files in the **Documents** and **Text Documents** folders.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/virtualization/tagHelper %}
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



The output will look like the image below.

![Virtualization](./images/virtualization.gif)

## Limitations for Virtualization

* Programmatic selection using the **selectAll** method is not supported with virtual scrolling.

* The keyboard shortcut **CTRL+A** will only select the files and directories that are currently visible within the viewport, rather than selecting all files and directories in the entire directory tree.

* Selected file items are not maintained while scrolling to ensure optimal control performance.
