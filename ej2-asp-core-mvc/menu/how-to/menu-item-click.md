---
layout: post
title: Open menu item on click only in ##Platform_Name## Menu Component
description: This section helps to learn how to open sub menu on menu item click ##Platform_Name## Menu component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open menu and sub menu on click only

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


