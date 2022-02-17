---
layout: post
title: Icons And Navigation in ##Platform_Name## Context Menu Component
description: Learn here all about Icons And Navigation in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Icons And Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Icons and Navigation

## Icons

The ContextMenu item have an icon/image in it to provide visual representation of the action.
To place the icon on a menu item, set the [`iconCss`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~IconCss.html)
property to e-icons with the required icon CSS. By default, the icon is positioned to the left
side of the menu item. In the following sample, the icons for Cut, Copy and Paste menu items are
added using the `iconCss` property.

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



> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the contextmenu menuItems using the `iconCss`property.

## Navigation

Navigation in ContextMenu is usage to navigate to the other web page when menu item is
clicked. This can be achieved by providing link to the menu item using the
[`url`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Url.html) property. In the following sample, Navigation URL for Flipkart, Amazon, and Snapdeal menu items
are added using the `url` property.

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

