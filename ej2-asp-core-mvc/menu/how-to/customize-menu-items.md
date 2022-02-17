---
layout: post
title: Customize Menu Items in ##Platform_Name## Menu Component
description: Learn here all about Customize Menu Items in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Customize Menu Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize menu items

## Add or remove menu items

Menu items can be added or removed using the `insertAfter`,
`insertBefore` and `removeItems` methods.

In the following example, the **Europe** menu items are added before the **Oceania** item,
the **Africa** menu items are added after the **Asia**, and the **South America**
and **Mexico** items are removed from menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/customize-menu-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeMenuItems.cs" %}
{% include code-snippet/menu/how-to/customize-menu-items/CustomizeMenuItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/customize-menu-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeMenuItems.cs" %}
{% include code-snippet/menu/how-to/customize-menu-items/CustomizeMenuItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> To process items with `ID` values, set `isUnique` to `true`.

## Enable or disable menu items

You can enable and disable the menu items using the `enableItems`
method in Menu. To enable menuItems, set the `enable` property in argument to `true` and vice-versa.

In the following example, the **Directory** header item, **Conferences**, and **Music** sub menu items are disabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/enable-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDisable.cs" %}
{% include code-snippet/menu/how-to/enable-disable/EnableDisable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDisable.cs" %}
{% include code-snippet/menu/how-to/enable-disable/EnableDisable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> To disable sub menu items, use the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event.

## Hide or show menu items

You can show or hide the menu items using the `showItems`
and `hideItems` methods.

In the following example, the **Movies** header item, **Workshops**, and **Music** sub menu items
are hidden in menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/hide-show/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HideShow.cs" %}
{% include code-snippet/menu/how-to/hide-show/HideShow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/hide-show/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HideShow.cs" %}
{% include code-snippet/menu/how-to/hide-show/HideShow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Using the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event, you can hide the sub menu items as in the above example since the menu supports to hide items only for headers initially.
