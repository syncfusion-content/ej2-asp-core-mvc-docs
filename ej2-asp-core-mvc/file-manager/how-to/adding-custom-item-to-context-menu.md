---
layout: post
title: Adding Custom Item To Context Menu in ##Platform_Name## File Manager Component
description: Learn here all about Adding Custom Item To Context Menu in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Adding Custom Item To Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom menu item in context menu

The context menu can be customized using the [contextMenuSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ContextMenuSettings.html),[`menuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~MenuOpen.html), and [`menuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~MenuClick.html) events.

The following example shows adding a custom item in the context menu.

The [`menuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~MenuOpen.html) event is used to add the new menu item. The [`menuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~MenuClick.html) event is used to add event handler to the new menu item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/how-to/context-menu/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/how-to/context-menu/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![FileManager adding custom item in context menu](../images/custom_contextmenu.png)