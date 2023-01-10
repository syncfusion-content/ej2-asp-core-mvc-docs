---
layout: post
title: Selection in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Selection in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection in Asp.Net MVC Rating Control

The Asp.Net MVC Rating component allows users to rate something using a visual scale, and the selection state can be changed by the user clicking or tapping on the stars in the rating scale or through code. The Rating component has a minimum value and a reset button, and provides customization options for the selected rating value and selection behavior.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/rating/selection/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Selction](./images/rating-selection.png)

## Selected value

You can use the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Value) property of the Asp.Net MVC Rating component to determine the currently selected rating value and update it using two-way binding or by setting the value programmatically. The current rating value can also be used to identify the selected items.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/selected-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectedValue.cs" %}
{% include code-snippet/rating/selection/selected-value/selectedvalue.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Selected Value](./images/rating-selected-value.png)


## Min value

You can use the [Min](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Min) property of the Asp.Net MVC Rating component to set the minimum possible rating value the user can select. If you set the `Min` property to 2, then you will not be able to select a rating lower than 2.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/Selection/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/rating/Selection/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Minimum Value](./images/rating-min.png)

## Single selection

You can use the [EnableSingleSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_EnableSingleSelection) property of the Asp.Net MVC Rating component to select only one item at a time. When the `EnableSingleSelection` property is set to `true`, only the selected item will be considered to be in the selected state, while all other items will be unselected.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/selection/min/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Min.cs" %}
{% include code-snippet/rating/selection/min/min.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Single Selection](./images/rating-single-selection.png)

## Show or hide reset button

You can reset the rating value to its default by using the [AllowReset](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_AllowReset) property of the Asp.Net MVC Rating component. When the `AllowReset` property is set to `true`, a reset button will be shown that allows the user to reset the rating value to its default.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/selectionallow-reset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AllowReset.cs" %}
{% include code-snippet/rating/selection/allow-reset/allowreset.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Reset button](./images/rating-allow-reset.png)