---
layout: post
title: How to change orientation of ##Platform_Name## Menu | Syncfusion
description: Switch Syncfusion ##Platform_Name## Menu item orientation between horizontal and vertical by setting the orientation property to Horizontal or Vertical.
platform: ej2-asp-core-mvc
control: Change Orientation
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change orientation of ##Platform_Name## Menu

Orientation in menu items can be changed horizontally or vertically using the [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_Orientation) property. By default, it is horizontally aligned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/menu/how-to/orientation/Orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/menu/how-to/orientation/Orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


