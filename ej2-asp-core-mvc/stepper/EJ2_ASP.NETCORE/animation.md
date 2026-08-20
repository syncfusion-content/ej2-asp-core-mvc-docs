---
layout: post
title: Animation in ##Platform_Name## Stepper | Syncfusion
description: Learn how to configure animation in the Syncfusion ##Platform_Name## Stepper by customizing transition duration, delay, and animation behavior.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation in ##Platform_Name## Stepper

The Stepper progress state can be animated, smoothly transitioning from one step to another. You can customize the animation's [duration](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Duration) and [delay](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Delay), by using the `e-stepper-animation` tag helper.

You can disable the animation by setting the [enable](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Enable) property to `false`. By default, the value is `true`.

| Fields | Type | Description |
|------|------|-------------|
| [duration](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Duration) | `number` | Specifies the duration of the animated transition for each step. The default value is `2000` milliseconds. |
| [delay](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.StepperAnimationSettings.html#Syncfusion_EJ2_Navigations_StepperAnimationSettings_Delay) | `number` | Specifies the delay to initiate the animated transition for each step in milliseconds. The default value is `0`. |

The example demonstrates the animation `Duration` and `Delay` settings for the Stepper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/animation/tagHelper %}
{% endhighlight %}
{% endtabs %}