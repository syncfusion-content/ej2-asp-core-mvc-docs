---
layout: post
title: Selection in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Selection in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection in ASP.NET Core Rating Control

The ASP.NET Core Rating control allows users to rate something using a visual scale, and the selection state can be changed by the user clicking or tapping on the stars in the rating scale or through code. The Rating control has a minimum value and a reset button, and provides customization options for the selected rating value and selection behavior.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/selection/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Selction](./images/rating-selection.png)

## Min value

You can use the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Min) property of the ASP.NET Core Rating control to set the minimum possible rating value the user can select. If you set the `min` property to 2, then you will not be able to select a rating lower than 2.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/min/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Minimum Value](./images/rating-min.png)

## Single selection
You can use the [enableSingleSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_EnableSingleSelection) property of the ASP.NET Core Rating control to select only one item at a time. When the `enableSingleSelection` property is set to `true`, only the selected item will be considered to be in the selected state, while all other items will be unselected.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/single-selection/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Single Selection](./images/rating-single-selection.png)

## Show or hide reset button

You can reset the rating value to its default by using the [allowReset](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_AllowReset) property of the ASP.NET Core Rating control. When the `allowReset` property is set to `true`, a reset button will be shown that allows the user to reset the rating value to its default.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/allow-reset/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Rating Control with Reset button](./images/rating-allow-reset.png)