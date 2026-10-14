---
layout: post
title: How to add rounded corners to ##Platform_Name## Menu | Syncfusion
description: Add rounded corners to Syncfusion ##Platform_Name## Menu by setting cssClass with border-radius CSS rules to round the menu wrapper and item edges.
platform: ej2-asp-core-mvc
control: Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to add rounded corners to ##Platform_Name## Menu

The rounded corner can be achieved by using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_CssClass) property. Add a custom class to the menu component and customize it using the `border-radius` CSS property. For more information, refer to the `styles` specified in the below sample.

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


