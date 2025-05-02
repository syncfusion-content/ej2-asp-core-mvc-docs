---
layout: post
title: Adding Custom Item To Toolbar in ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Adding Custom Item To Toolbar in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adding Custom Item To Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom item in toolbar

You can modify the items displayed in the toolbar by utilizing the [toolbarItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarItems.html) API. To display both default and customized items, it's essential to assign a unique **name** to each item. Additionally, you have the flexibility to alter the default items by adjusting properties such as **tooltipText, iconCss, Text, suffixIcon** and more. This level of customization allows you to tailor the toolbar to your specific requirements and design preferences. The names used in the code example below serve as unique identifiers for default toolbar items, while custom items can be assigned any unique name value to distinguish them from the defaults.

For instance, here's an example of how to add a custom checkbox to the toolbar using the **template** property. Here we have modified the default `New Folder` item and added a custom toolbar item for selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


The output will look like the image below.

![File Manager custom toolbar item](../images/custom_toolbar.png)