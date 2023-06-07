---
layout: post
title: File Menu in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about File Menu in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# File Menu in ASP.NET MVC Ribbon Control

The Ribbon control provides a built-in file menu that allows you to add menu items for performing specific actions. The file menu can be enabled by setting the [FileMenu](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_FileMenu) property.

## Visibility

You can show the file menu by setting the [Visible](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Visible) property to `true`. By default, the file menu is hidden.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/visible/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with visible file menu](images/ribbon-visible.png)

## Adding Menu Items

The menu items can be added to the file menu using the [MenuItems](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_MenuItems) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/filemenu/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with file menu items](images/ribbon-filemenu.png)

## Open Submenu on click

You can open the submenu on menu item click by setting the [ShowItemOnClick](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_ShowItemOnClick) property to `true`. By default, the submenu will open on mouse hover.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/submenu/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with submenu opening on click](images/ribbon-submenu.png)

## Custom Header text

You can define the file menu header text content by using the [Text](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Text) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/file-menu/custom-header/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with custom header for file menu](images/ribbon-custom-header.png)
