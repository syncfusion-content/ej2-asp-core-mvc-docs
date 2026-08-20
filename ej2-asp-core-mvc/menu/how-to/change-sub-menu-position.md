---
layout: post
title: How to change sub menu position in ##Platform_Name## Menu | Syncfusion
description: Reposition Syncfusion ##Platform_Name## Menu sub menu popup by overriding top and left in the beforeOpen event args before the sub menu opens.
platform: ej2-asp-core-mvc
control: Change Sub Menu Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change sub menu position in ##Platform_Name## Menu

The submenu position can be changed by using the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_BeforeOpen) event. Assign the top and left position where you want to open the submenu to the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_BeforeOpen) event arguments `args.top` and `args.left` respectively.

In the below sample, the sub menu opens above the parent menu item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/menu/how-to/position/Position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/menu/how-to/position/Position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> For custom positioning, set both `top` and `left` position in the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_BeforeOpen) event.