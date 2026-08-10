---
layout: post
title: File Menu in ##Platform_Name## Ribbon | Syncfusion
description: Learn how to add a built-in file menu in the ##Platform_Name## Ribbon with configurable menu items for actions like creating, opening, and saving documents.
control: Ribbon
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# File Menu in ##Platform_Name## Ribbon

The Ribbon control provides a built-in file menu that allows you to add menu items for performing specific actions. The file menu can be enabled by setting the [fileMenu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_FileMenu) property.

## Visibility

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

You can open the submenu on menu item click, by setting the [showItemOnClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_ShowItemOnClick) property to `true`. By default, the submenu will open on mouse hover.

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
