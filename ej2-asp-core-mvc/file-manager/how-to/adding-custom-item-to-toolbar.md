---
layout: post
title: Add Item To Toolbar in ##Platform_Name## File Manager | Syncfusion
description: Learn here all about adding custom item to toolbar in Syncfusion ##Platform_Name## File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adding Custom Item To Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom button in toolbar

The toolbar items can be customized using the [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html) API and [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarClick.html) event.


The new toolbar button is added using [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html). The [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarClick.html) event is used to add an event handler to the new toolbar button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController_mvc.cs %}
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




![FileManager custom toolbar item](../images/custom_toolbar.png)