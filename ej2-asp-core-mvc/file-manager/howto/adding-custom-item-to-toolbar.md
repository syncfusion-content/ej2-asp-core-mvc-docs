---
layout: post
title: Adding Custom Item To Toolbar in ##Platform_Name## File Manager Component
description: Learn here all about Adding Custom Item To Toolbar in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Adding Custom Item To Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom button in toolbar

The toolbar items can be customized using the [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html) API and [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarClick.html) event.

The following example shows adding a custom item in the toolbar.

The new toolbar button is added using [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html). The [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarClick.html) event is used to add an event handler to the new toolbar button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/file-manager/how-to/toolbar/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![FileManager getting started](../images/custom_toolbar.png)