---
layout: post
title: Appearance in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ASP.NET MVC Rating Control

You can also customize the appearance of rating control.

## Items count

You can specify the number of rating items using the [ItemsCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ItemsCount) property.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/items-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemsCount.cs" %}
{% include code-snippet/rating/appearance/items-count/itemscount.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with Items count](images/rating-items-count.png)

## Disabled

You can disable the Syncfusion ASP.NET MVC Rating control by using the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Disabled) property. When the `Disabled` property is set to `true`, the rating control will be disabled and the user will not be able to interact with it and a disabled rating control may have a different visual appearance than an enabled one.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/rating/appearance/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with Disabled](images/rating-disabled.png)

## Visible

You can use the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Visible) property of the ASP.NET MVC Rating control to control the visibility of the control. When the `Visible` property is set to `true`, the rating control will be visible on the page. When it is set to `false`, the control will be hidden.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/rating/appearance/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with Visible](images/rating-full-precision.png)

## Read only

You can use the [ReadOnly](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ReadOnly) property of the ASP.NET MVC Rating control to make the control non-interactive and prevent the user from changing the rating value.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/read-only/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomPosition.cs" %}
{% include code-snippet/rating/appearance/read-only/readonly.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with ReadOnly](images/rating-full-precision.png)

## CssClass

You can customize the appearance of the rating control, such as by changing its colors, fonts, sizes, or other visual aspects by using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_CssClass) property. 

### Changing rating symbol border color

You can change the rating icon border color in ASP.NET MVC Rating control, you can use the `CssClass` property and set the `text-stroke` CSS property of `.e-rating-icon` to your desired border color.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/border-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BorderColor.cs" %}
{% include code-snippet/rating/appearance/css-class/border-color/bordercolor.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with rating symbol border color](images/rating-border-color.png)

### Changing rated/un-rated symbol fill color 

You can customize the fill colors of rated and un-rated icons in the Rating control using the `CssClass` property and the `linear-gradient` color-stops in the `background` CSS property of `.e-rating-icon`. The **first** color-stop defines the rated fill color and the **second** defines the un-rated fill color.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/fill-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FillColor.cs" %}
{% include code-snippet/rating/appearance/css-class/fill-color/fillcolor.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

This will customize the rated fill color to `#ffe814` and un-rated fill color to `#d8d7d4`. `--rating-value` in the linear-gradient provides the current value of the rating item.

![ASP.NET MVC Rating Control with custom fill color for icons](images/rating-fill-color.png)

### Changing the item spacing

You can change the space between the rating items in ASP.NET MVC Rating control, by using the `CssClass` property and setting the `margin` / `padding` CSS property of `.e-rating-item-container` to your desired size. 

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/item-spacing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemsSpacing.cs" %}
{% include code-snippet/rating/appearance/css-class/item-spacing/itemspacing.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with custom space between rating items](images/rating-custom-space.png)

## Changing icon using CssClass

You can change the rating item icon in ASP.NET MVC Rating control, you can use the `CssClass` property and set the `content` CSS property of `.e-icons.e-star-filled:before` to your desired font icon.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/change-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeIcon.cs" %}
{% include code-snippet/rating/appearance/css-class/change-icon/changeicon.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![ASP.NET MVC Rating Control with change icon using CssClass](images/rating-cssclass-icon.png)