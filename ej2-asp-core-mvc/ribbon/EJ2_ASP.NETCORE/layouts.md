---
layout: post
title: Layouts in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Layouts in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Layouts
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layouts in ASP.NET Core Ribbon Control

The Ribbon offers to customize the layout by using the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property. The Ribbon control supports the following layouts:

## Classic layout

In classic layout, the Ribbon control organize the items and groups in a traditional form by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Classic](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html). By default, the Ribbon control renders in `Classic` layout.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/classic/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Classic Layout](./images/ribbon-classic.png)

### Defining items size

You have the ability to specify the size of an item using the Allowed Sizes property. To define the size of an item, you can use [allowedSizes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemSize.html) property. The supported sizes include: Large, Medium, and Small.

### Defining items orientation

The [orientation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.ItemOrientation.html) property allows you to control how the items in a ribbon group are aligned. By default, the orientation is set to "column", which means the items are arranged vertically.

N> When the orientation is set to "row", a group can have a maximum of three collections, but each collection inside a group can contain any number of items.
When the orientation is set to "column", a group can have any number of collections, but each collection inside a group can only have either a single large-sized item or three medium/small-sized items. If two large-sized items are specified, they will automatically be converted into two medium/small-sized items.

### Defining group header

To define a name for the group, you can make use of the [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Header) property. This property allows you to provide a descriptive header that represents the purpose or category of the items in the group.
### Defining group icon

You can make use of the [groupIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_GroupIconCss) property to define the CSS class for the icons to be shown in the group overflow dropdown button in classic mode. During overflow, the entire group will be shown in a popup of a dropdown button which appears in the place of the group in ribbon tab.
### Enabling group launcher icon

You can control the visibility of the launcher icon in a group header using the [showLauncherIcon](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_ShowLauncherIcon) property. This property allows you to determine whether the launcher icon should be displayed or hidden for the group.
#### Customize launcher icon

You have the flexibility to customize the launcher icon in a group header using the [launcherIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LauncherIconCss) property. This property allows you to define a CSS class and apply custom styles to the launcher icon.
### Defining group collapsible state

You can control whether a group can be collapsed during resize in classic mode using the [isCollapsible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_IsCollapsible) property. If the property is set to "true", the group can be collapsed on resize during classic mode. If you want to prevent the group from being collapsed, you can set this property to "false".
#### Defining priority order for group collapse or expand

You can determine the priority order for collapsing or expanding groups using the [priority](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Priority) property. This property allows you to specify the order in which groups should be collapsed or expanded. Lower priority values are fetched first for collapsing, while higher priority values are fetched first for expanding.

## Simplified layout

In simplified layout, the Ribbon control organize the items and groups into a single row by setting the [activeLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Simplified](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/simplified/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Simplified Layout](./images/ribbon-simplified.png)

### Enabling group overflow popup

The [enableGroupOverflow](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_EnableGroupOverflow) property defines whether to add a separate popup for the overflow items in the group. If it is set to false, the overflow items will be shown in the common overflow popup present at the right end of the tab content.

## Minimized state

You can hide the Ribbon contents and display only the tab headers by double-clicking on the tab header. In minimized state, the Ribbon control expands to its normal state when click on the tab header.

Also, you can render or programmatically change the Ribbon control to minimized state by setting the [isMinimized](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_IsMinimized) property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/minimize/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control in Minimized state](./images/ribbon-minimize.png)
