---
layout: post
title: Tooltip in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Tooltip in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltips in Stepper

Improve user interaction and offer extra information with tooltips in the Stepper control. You can customize tooltips using the following properties:

## Show tooltip

The [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ShowTooltip) property allows you to control the visibility of tooltip within the Stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/stepper/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Tooltip](images/stepper-tooltip.jpg)

## Tooltip template

The [TooltipTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_TooltipTemplate) property enables you to customize the content and appearance of tooltips. It can be used based on your specific tooltip requirements.