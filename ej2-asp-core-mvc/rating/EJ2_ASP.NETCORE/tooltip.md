---
layout: post
title: Tooltip in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in Asp.Net Core Rating Control

The Asp.Net Core rating control supports tooltip to show additional information in rating items by setting the [showTooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ShowTooltip) property. If enabled, the tooltip appears when the user hovers over a rating item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/tooltip/show-tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Asp.Net Core Rating Control with Tooltip](./images/rating-tooltip.png)

## Tooltip template

You can use the [tooltipTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_TooltipTemplate) tag directive to specify a custom template for the `Tooltip` of the rating. The current value of the rating will be passed as the `value` property in the template context when building the content of the tooltip. This allows you to include dynamic information about the rating in the template.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/tooltip/tooltip-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Asp.Net Core Rating Control with Tooltip Template](./images/rating-tooltip-template.png)


## Tooltip customization

You can customize the appearance of the tooltips using the `cssClass` property of the Asp.Net Core Rating control and by defining the custom styles for tooltip elements like the below example.

N> You can find more information about customizing the appearance of the tooltip in the [Tooltip Customization](https://ej2.syncfusion.com/aspnetcore/documentation/tooltip/style) documentation.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/tooltip/custom-tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Asp.Net Core Rating Control with Tooltip Customization](./images/rating-custom-tooltip.png)