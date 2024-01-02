---
layout: post
title: Getting Started with ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in ##Platform_Name## Stepper control

The Stepper progressbar can be animated for each step transition. You can enable/disable the animation by setting the [Enable](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Enable) property. By default, the property value is `true`.

You can also customize the animation's [Duration](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Duration) & [Delay](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Delay), by using the [Animation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Animation) property.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
delay</td><td>
The Stepper animation will start with the mentioned delay. The default value is `0` milliseconds.</td></tr>
<tr>
<td>
duration</td><td>
Specifies the animation duration to complete with one animation cycle. By default, the value is `1000` milliseconds.</td></tr>
</table>

In the below sample, animation is enabled and the `Duration`, `Delay` are configured for the Stepper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/animation/tagHelper %}
{% endhighlight %}
{% endtabs %}