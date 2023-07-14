---
layout: post
title: File menu in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about File menu in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# File menu in ASP.NET Core Ribbon Control

The Ribbon control provides a built-in file menu that allows you to add menu items for performing specific actions. The file menu can be enabled by setting the [fileMenu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_FileMenu) property.

## Visibility state

You can show the file menu by setting the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Visible) property to `true`. By default, the file menu is hidden.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with visible file menu](./images/ribbon-visible.png)

## Adding menu items

The menu items can be added to the file menu using the [menuItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_MenuItems) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/filemenu/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with file menu items](./images/ribbon-filemenu.png)

## Open submenu on click

You can open the submenu on menu item click by setting the [showItemOnClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_ShowItemOnClick) property to `true`. By default, the submenu will open on mouse hover.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/submenu/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with submenu opening on click](./images/ribbon-submenu.png)

## Custom header text

You can define the file menu header text content by using the [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Text) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/custom-header/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with custom header for file menu](./images/ribbon-custom-header.png)
