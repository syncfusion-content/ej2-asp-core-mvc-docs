---
layout: post
title: Multiple Selection in ##Platform_Name## Syncfusion File Manager Control | Syncfusion
description: Learn here all about Multiple Selection in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Multiple Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple Selection in File Manager

The File Manager allows multiple file selection through the `allowMultiSelection`) property (enabled by default). The multiple selection can be done by pressing the `Ctrl` key or `Shift` key and selecting the files. The check box can also be used to do multiple selection. `Ctrl + A` can be used to select all files in the current directory. The `fileSelect` event will be triggered when the items of File Manager control is selected or unselected.

The example below demonstrates how the File Manager allows multiple file selection using the `allowMultiSelection` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/multiple-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/multiple-selection/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/multiple-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/multiple-selection/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


The output will look like the image below.

![File Manager multiselection](./images/detailsview.png)

## Range Selection

The File Manager supports selecting files and folders in specific ranges through mouse drag, similar to File Explorer. This is particularly useful in scenarios where users need to select a large group of files quickly without manually clicking each one. 

### Enabling Range Selection

{% if page.publishingplatform == "aspnet-core" %}

To enable range selection, you need to set the [enableRangeSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnableRangeSelection) property to `true` and ensure that multi-selection is allowed using the [allowMultiSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AllowMultiSelection) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/range-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/range-selection/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

To enable range selection, you need to set the [enableRangeSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_EnableRangeSelection) property to `true` and ensure that multi-selection is allowed using the [allowMultiSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_AllowMultiSelection) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/range-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/range-selection/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output will look like the image below.

![File Manager rangeselection](./images/rangeselection.png)

## Disable Multi selection

{% if page.publishingplatform == "aspnet-core" %}

Setting the [`allowMultiSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_AllowMultiSelection) property to false will prevent you from selecting multiple files or folders with standard selection methods. However, you can still select multiple items if checkboxes are visible. To fully disable all multi-selection capabilities, you must also set the [`showItemCheckBoxes`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_ShowItemCheckBoxes) property to false. This ensures that you cannot use checkboxes for multiple selections.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/disablemultiselection/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Setting the [`allowMultiSelection`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_AllowMultiSelection) property to false will prevent you from selecting multiple files or folders with standard selection methods. However, you can still select multiple items if checkboxes are visible. To fully disable all multi-selection capabilities, you must also set the [`showItemCheckBoxes`](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.filemanager.filemanager.html#Syncfusion_EJ2_FileManager_FileManager_ShowItemCheckBoxes) property to false. This ensures that you cannot use checkboxes for multiple selections.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/disablemultiselection/razor %}
{% endhighlight %}
{% endtabs %}

{% endif %}

The output will look like the image below.

![File Manager disable Multiselection](./images/disablemultiselection.png)