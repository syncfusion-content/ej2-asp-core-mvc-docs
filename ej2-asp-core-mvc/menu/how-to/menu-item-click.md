---
layout: post
title: How to open sub menus on click in ##Platform_Name## Menu | Syncfusion
description: Make Syncfusion ##Platform_Name## Menu sub menus open only on item click by setting showItemOnClick to true instead of the default hover behavior.
platform: ej2-asp-core-mvc
control: Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to open sub menus on click in ##Platform_Name## Menu

You can open menu items and sub menu on menu item click by setting [`showItemOnClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_ShowItemOnClick) property of the Menu. To open sub menu items only on item click, should be set as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/rounded/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded.cs" %}
{% include code-snippet/menu/how-to/rounded/Rounded.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/rounded/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rounded.cs" %}
{% include code-snippet/menu/how-to/rounded/Rounded.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


