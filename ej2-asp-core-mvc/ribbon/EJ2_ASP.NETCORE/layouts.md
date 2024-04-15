---
layout: post
title: Layouts in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Layouts in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layouts in ASP.NET Core Ribbon Control

The Ribbon allows to customize the layout by using the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property. The Ribbon control supports the following layouts:

## Classic layout

In classic layout, the Ribbon control organizes the items and groups in a traditional form by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Classic](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html). By default, the Ribbon control renders in the `Classic` layout.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/classic/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Classic Layout](./images/ribbon-classic.png)

### Defining items size

You can use the [allowedSizes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property to set the allowed size for an item. The Ribbon items can be appeared in three different sizes: Large(large icon with text), Medium(small icon with text) and Small(small icon only). On resizing, the items size can be changed based on the available width of the tab content from the order of Large-> Medium-> Small and vice versa.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/itemSize/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with different Items Size](./images/ribbon-itemSize.jpg)

### Defining items orientation

The Ribbon group [orientation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Orientation) property allows to manage how the items are aligned either in a `Row` or `Column`. By default, the orientation is set to `Column`, in which the items are arranged vertically.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/orientation/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Items orientation](./images/ribbon-orientation.jpg)

>  When the orientation is set to `Row` a group may have a maximum of three collections each of which may contain any number of items. When the orientation is set to `Column` a group may have any number of collections, each of which may contain one large-sized item or three medium/small-sized items. If two large-sized items are specified, it automatically converts into two medium/small-sized items.

### Defining group header

You can use the [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Header) property to set the name for each group header.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/headerText/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with group header](./images/ribbon-header.jpg)

### Defining group icon

You can use the [groupIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_GroupIconCss) property to customize the icons in the group overflow button. When the ribbon's size is adjusted, the group popup will appear.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/groupIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with group icon](./images/ribbon-groupIcon.jpg)

### Enabling group launcher icon

You can use the [showLauncherIcon](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_ShowLauncherIcon) property to enable or disable the launcher icon for each group. By default, the property is set to `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/launcherIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with launcher icon](./images/ribbon-launcherIcon.jpg)

#### Customize launcher icon

You can use the [launcherIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LauncherIconCss) property to customize the launcher icon by applying the custom styles.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/customLauncherIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with custom launcher icon](./images/ribbon-customLauncher.jpg)

### Defining group collapsible state

You can use the [isCollapsible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_IsCollapsible) property to determine whether the group is collapsed or not during resize. By default, the property is set to `true`. To prevent the group from being collapsed, set the property to `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/collapsibleState/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with collapsible state](./images/ribbon-isCollapsible.jpg)

#### Defining priority order for group collapse or expand

You can use the [priority](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Priority) property to set the priority order for each group which should be collapsed or expanded on resizing. When collapsing, higher priority values are fetched first. When expanding, lower priority values are fetched first.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/priority/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with priority order](./images/ribbon-priority.jpg)

## Simplified layout

In simplified layout, the Ribbon control organizes the items and groups into a single row by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Simplified](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/simplified/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Simplified Layout](./images/ribbon-simplified.png)

### Enabling group overflow popup

You can use the [enableGroupOverflow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_EnableGroupOverflow) property to add a separate popup for the overflow items in the group while resizing. The overflow items will appear in the common overflow popup, located at the right end of the tab content if it is set to `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/groupOverflow/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with group overflow popup](./images/ribbon-groupOverflow.jpg)

## Minimized state

You can hide the Ribbon contents and display only the tab headers by double-clicking on the tab header. In minimized state, the Ribbon control expands to its normal state when click on the tab header.

You can use the [isMinimized](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_IsMinimized) property to change the Ribbon component to minimized state. By default, the value is `false`.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/minimize/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control in Minimized state](./images/ribbon-minimize.png)

## Show or hide the layout switcher

You can use the [hideLayoutSwitcher](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_HideLayoutSwitcher) property to show/hide the Ribbon layout switcher button. By default, the value is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/hideLayoutSwitcher/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control layout switcher](./images/ribbon-layout-switcher.png)
