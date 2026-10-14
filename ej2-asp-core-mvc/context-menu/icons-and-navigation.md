---
layout: post
title: Icons and Navigation in ##Platform_Name## Context Menu | Syncfusion
description: Add icons to Syncfusion ##Platform_Name## Context Menu items via the iconCss property and navigate submenus with the keyboard for a polished menu UI.
platform: ej2-asp-core-mvc
control: Icons And Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons and Navigation in ##Platform_Name## Context Menu

## Icons

{% if page.publishingplatform == "aspnet-core" %}

A Context Menu item can display an icon or image to visually represent its action. To place the icon on a menu item, set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property to the icon class (For example, `e-icons`) with the required icon CSS. By default, the icon is positioned to the left side of the menu item. In the following sample, the icons for Cut, Copy and Paste menu items are added using the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

A Context Menu item can display an icon or image to visually represent its action. To place the icon on a menu item, set the [`iconCss`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property to the icon class (For example, `e-icons`) with the required icon CSS. By default, the icon is positioned to the left side of the menu item. In the following sample, the icons for Cut, Copy and Paste menu items are added using the [iconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/context-menu/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/context-menu/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

N> The Essential<sup style="font-size:70%">&reg;</sup> JS 2 provides a set of icons that can be loaded by applying the `e-icons` class name to the element. You can also use third-party icons on the context menu items using the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

N> The Essential<sup style="font-size:70%">&reg;</sup> JS 2 provides a set of icons that can be loaded by applying the `e-icons` class name to the element. You can also use third-party icons on the context menu items using the [iconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_IconCss) property.

{% endif %}

## Navigation

{% if page.publishingplatform == "aspnet-core" %}

Navigation in ContextMenu is used to navigate to another web page when a menu item is clicked. This can be achieved by providing a link to the menu item using the [`url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Url) property. In the following sample, Navigation URLs for the Flipkart, Amazon, and Snapdeal menu items are added using the `url` property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Navigation in ContextMenu is used to navigate to another web page when a menu item is clicked. This can be achieved by providing a link to the menu item using the [`url`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ContextMenuItem.html#Syncfusion_EJ2_Navigations_ContextMenuItem_Url) property. In the following sample, Navigation URLs for the Flipkart, Amazon, and Snapdeal menu items are added using the `url` property.

{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/context-menu/navigation/navigation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Navigation.cs" %}
{% include code-snippet/context-menu/navigation/navigation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

