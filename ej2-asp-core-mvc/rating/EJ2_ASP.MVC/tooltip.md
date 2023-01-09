---
layout: post
title: Tooltip in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in Asp.Net MVC Rating Control

The Asp.Net MVC rating component supports tooltip to show additional information in rating items by setting the [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ShowTooltip) property. If enabled, the tooltip appears when the user hovers over a rating item.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Tooltip](./images/rating-tooltip.png)

## Tooltip template

You can use the [TooltipTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_TooltipTemplate) tag directive to specify a custom template for the `Tooltip` of the rating. The current value of the rating will be passed as the `context` when building the content of the tooltip. This allows you to include dynamic information about the rating in the template.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Tooltip Template](./images/rating-tooltip-template.png)


## Tooltip customization

You can customize the appearance of the tooltips using the `CssClass` property of the Asp.Net MVC Rating component and by defining the custom styles for tooltip elements like the below example.

N> You can find more information about customizing the appearance of the tooltip in the [Tooltip Customization](https://ej2.syncfusion.com/aspnetmvc/documentation/tooltip/style) documentation.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FabPosition.cs" %}
{% include code-snippet/rating/Tooltip/bottom-left-position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Component with Tooltip Customization](./images/rating-custom-tooltip.png)