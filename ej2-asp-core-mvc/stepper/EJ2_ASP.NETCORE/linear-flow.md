---
layout: post
title: Linear Flow in ##Platform_Name## Stepper | Syncfusion
description: Learn how to enable linear flow in the Syncfusion ##Platform_Name## Stepper to enforce sequential navigation between steps.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Linear Flow in ##Platform_Name## Stepper

The Stepper control enables users to progress sequentially through each step, ensuring navigation from one step to the next in a linear way by setting the [linear](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Linear) property to `true`. The default value is `false` allowing navigation between any steps and vice versa.

The example demonstrates the functionality of both linear and non-linear flow in the Stepper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/linear/tagHelper %}
{% endhighlight %}
{% endtabs %}