---
layout: post
title: Appearance in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Appearance in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ASP.NET Core Rating Control

You can also customize the appearance of rating control.

## Items count

You can specify the number of rating items using the [itemsCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ItemsCount) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/items-count/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with Items count](images/rating-items-count.png)

## Disabled

You can disable the Syncfusion ASP.NET Core Rating control by using the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Disabled) property. When the `disabled` property is set to `true`, the rating control will be disabled and the user will not be able to interact with it and a disabled rating control may have a different visual appearance than an enabled one.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with Disabled](images/rating-disabled.png)

## Visible

You can use the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Visible) property of the ASP.NET Core Rating control to control the visibility of the control. When the `visible` property is set to `true`, the rating control will be visible on the page. When it is set to `false`, the control will be hidden.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with Visible](images/rating-full-precision.png)

## Read only

You can use the [readOnly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ReadOnly) property of the ASP.NET Core Rating control to make the control non-interactive and prevent the user from changing the rating value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/read-only/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with ReadOnly](images/rating-full-precision.png)

## CssClass

You can customize the appearance of the rating control, such as by changing its colors, fonts, sizes, or other visual aspects by using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_CssClass) property. 

### Changing rating symbol border color

You can change the rating icon border color in ASP.NET Core Rating control, you can use the `cssClass` property and set the `text-stroke` CSS property of `.e-rating-icon` to your desired border color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/border-color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with rating symbol border color](images/rating-border-color.png)

### Changing rated/un-rated symbol fill color 

You can customize the fill colors of rated and un-rated icons in the Rating control using the `cssClass` property and the `linear-gradient` color-stops in the `background` CSS property of `.e-rating-icon`. The **first** color-stop defines the rated fill color and the **second** defines the un-rated fill color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/fill-color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

This will customize the rated fill color to `#ffe814` and un-rated fill color to `#d8d7d4`. `--rating-value` in the linear-gradient provides the current value of the rating item.

![Asp.Net Core Rating Control with custom fill color for icons](images/rating-fill-color.png)

### Changing the item spacing

You can change the space between the rating items in ASP.NET Core Rating control, by using the `cssClass` property and setting the `margin` / `padding` CSS property of `.e-rating-item-container` to your desired size. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippetrating/appearance/css-class/item-spacing/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with custom space between rating items](images/rating-custom-space.png)

## Changing icon using CssClass

You can change the rating item icon in ASP.NET Core Rating control, you can use the `cssClass` property and set the `content` CSS property of `.e-icons.e-star-filled:before` to your desired font icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/appearance/css-class/change-icon/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net Core Rating Control with change icon using CssClass](images/rating-cssclass-icon.png)