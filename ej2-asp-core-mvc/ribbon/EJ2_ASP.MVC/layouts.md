---
layout: post
title: Layouts in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Layouts in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Layouts in ASP.NET MVC Ribbon Control

The Ribbon offers to customize the layout by using the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property. The Ribbon control supports the following layouts:

## Classic layout

In classic layout, the Ribbon control organize the items and groups in a traditional form by setting the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Classic](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html). By default, the Ribbon control renders in `Classic` layout.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/classic/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Classic Layout](images/ribbon-classic.png)

### Defining items size

The Ribbon items can be appeared in three different sizes: Large(large icon with text), Medium(small icon with text) and Small(small icon only) on resizing the ribbon. You can define the allowed size for an item using the [AllowedSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/itemSize/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with different Items Size](./images/ribbon-itemSize.jpg)

### Defining items orientation

The [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Orientation) property in a group allows you to control how the items in a ribbon group are aligned. By default, the orientation is set to `Column`, which means the items are arranged vertically.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/orientation/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Items Orientation](./images/ribbon-orientation.jpg)

N> When the orientation is set to `Row`, a group can have maximum of three collections in which each collection inside a group can contain any number of items.
When the orientation is set to `Column`, a group can have any number of collections, but each collection inside a group can have either a single large-sized item or three medium/small-sized items. If two large-sized items are specified, then it will automatically be converted into two medium/small-sized items.
### Defining group header

You can define the name for each group header using the [Header](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Header) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/headerText/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with group header](./images/ribbon-header.jpg)
### Defining group icon

You can make use of the [GroupIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_GroupIconCss) property to define the CSS class for the icons to be shown in the group overflow button. The overflow popup will appear on resizing the ribbon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/groupIcon/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with group icon](./images/ribbon-groupIcon.jpg)
### Enabling group launcher icon

You can enable or disable the launcher icon for each group using the [ShowLauncherIcon](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_ShowLauncherIcon) property. By default, the property is set to `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/launcherIcon/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with launcher icon](./images/ribbon-launcherIcon.jpg)
#### Customize launcher icon

You can customize the launcher icon for the groups using the [LauncherIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LauncherIconCss) property which allows you to define a CSS class and apply custom styles to the launcher icon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/customLauncherIcon/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with custom launcher icon](./images/ribbon-customLauncher.jpg)
### Defining group collapsible state

You can control whether a group can be collapsed or not during resize using the [IsCollapsible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_IsCollapsible) property. By default, the property is set to `true`. If you want to prevent the group from being collapsed, you can set this property to `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/collapsibleState/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with collapsible state](./images/ribbon-isCollapsible.jpg)
#### Defining priority order for group collapse or expand

You can define the priority order for each group by setting the [Priority](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_Priority) property which allows you to specify the order in which groups should be collapsed or expanded on resizing. Higher priority values are fetched first when collapsing, whereas lower priority values are fetched first when expanding.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/priority/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with priority order](./images/ribbon-priority.jpg)

## Simplified layout

In simplified layout, the Ribbon control organize the items and groups into a single row by setting the [ActiveLayout](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_ActiveLayout) property to [Simplified](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonLayout.html).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/simplified/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Simplified Layout](images/ribbon-simplified.png)

### Enabling group overflow popup

The [EnableGroupOverflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroup.html#Syncfusion_EJ2_Ribbon_RibbonGroup_EnableGroupOverflow) property defines whether to add a separate popup for the overflow items in the group while resizing. If it is set to false, the overflow items will be shown in the common overflow popup present at the right end of the tab content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/groupOverflow/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with group overflow popup](./images/ribbon-groupOverflow.jpg)

## Minimized state

You can hide the Ribbon contents and display only the tab headers by double-clicking on the tab header. In minimized state, the Ribbon control expands to its normal state when click on the tab header.

Also, you can render or programmatically change the Ribbon control to minimized state by setting the [IsMinimized](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_IsMinimized) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/layouts/minimize/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control in Minimized state](images/ribbon-minimize.png)