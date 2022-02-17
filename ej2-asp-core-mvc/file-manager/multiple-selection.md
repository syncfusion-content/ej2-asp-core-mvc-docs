---
layout: post
title: Multiple Selection in ##Platform_Name## File Manager Component
description: Learn here all about Multiple Selection in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Multiple Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple Selection

The file manager allows you to select multiple files by enabling the [`allowMultiSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AllowMultiSelection.html) property (enabled by default). The multiple selection can be done by pressing the `Ctrl` key or `Shift` key and selecting the files. The check box can also be used to do multiple selection. `Ctrl + A` can be used to select all files in the current directory. The [`fileSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~FileSelect.html) event will be triggered when the items of file manager control is selected or unselected.

The below example shows File manager allows you to select multiple files using [`allowMultiSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AllowMultiSelection.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/multiple-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/multiple-selection/HomeController_mvc.cs %}
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



Output be like the below.

![FileManager multiselection](./images/detailsview.png)