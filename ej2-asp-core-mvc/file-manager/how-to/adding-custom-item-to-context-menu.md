---
layout: post
title: Adding custom item to context menu in ##Platform_Name## File Manager | Syncfusion
description: Learn how to add a custom item to the context menu in the ##Platform_Name## File Manager with custom icons and click handlers.
control: File Manager
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add custom item to context menu in ##Platform_Name## File Manager

The context menu can be customized using the `contextMenuSettings`,`menuOpen`, and `menuClick` events.

The following example shows adding a custom item in the context menu.

The `menuOpen` event is used to add the new menu item. The `menuClick` event is used to add event handler to the new menu item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/how-to/context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/how-to/context-menu/HomeController_core.cs %}
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



The output will look like the image below.

![File Manager adding custom item in context menu](../images/custom_contextmenu.png)