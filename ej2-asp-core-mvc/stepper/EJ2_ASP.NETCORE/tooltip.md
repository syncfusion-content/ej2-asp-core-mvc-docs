---
layout: post
title: Tooltip in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Tooltip in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in ##Platform_Name## Stepper control

The Stepper control supports tooltip to show additional information in the steps by setting the [showTooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ShowTooltip) property to `true`.

The tooltip appears when the user hovers over the step, providing the information such as the label or text. By default, the `showTooltip` property is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Tooltip](images/stepper-tooltip.jpg)

## Tooltip template

You can use the [tooltipTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_TooltipTemplate) property to specify a custom template for the tooltips, providing detailed information about the steps.

When hovering over the step, the current step model is passed in the template context, allowing you to include dynamic information about the step.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/tooltip-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Tooltip Template](images/stepper-tooltip-template.jpg)