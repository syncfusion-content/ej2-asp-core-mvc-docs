---
layout: post
title: Change Sub Menu Position in ##Platform_Name## Menu Component
description: Learn here all about Change Sub Menu Position in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Change Sub Menu Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Change sub menu position

The submenu position can be changed by using the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event. Assign the top and left position where you want to open the submenu to the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event arguments `args.top` and `args.left` respectively.

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



>> For custom positioning, set both `top` and `left` position in the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event.