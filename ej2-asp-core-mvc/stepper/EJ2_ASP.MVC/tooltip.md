---
layout: post
title: Tooltip in ##Platform_Name## Stepper | Syncfusion
description: Learn how to display tooltips in the Syncfusion ##Platform_Name## Stepper, including custom tooltip templates and dynamic step information.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in ##Platform_Name## Stepper

The Stepper control supports tooltip to show additional information in the steps by setting the [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ShowTooltip) property to `true`.

The tooltip appears when the user hovers over the step, providing the information such as the label or text. By default, the `ShowTooltip` property is `false`.

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

You can use the [TooltipTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_TooltipTemplate) property to specify a custom template for the tooltips, providing detailed information about the steps.

When hovering over the step, the current step model is passed in the template context, allowing you to include dynamic information about the step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TooltipTemplate.cs" %}
{% include code-snippet/stepper/tooltip-template/tooltipTemplate.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Tooltip Template](images/stepper-tooltip-template.jpg)