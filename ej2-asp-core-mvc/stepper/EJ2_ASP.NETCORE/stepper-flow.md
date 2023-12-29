---
layout: post
title: Stepper Flow in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Stepper Flow in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Stepper Flow

The Stepper control provides control over the flow of steps through the utilization of the [linear](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Linear) property.

## Linear flow

When the [linear](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Linear) property is set to `true`, it enables a linear progression. You can move through steps one after another. By default, the linear property value is `false`.

## Non-Linear flow

In non-liner flow, the users can skip or complete steps in any order they like.

![ASP.NET Core Stepper Flow](images/stepper-flow.jpg)

## Configure ActiveStep

The [activeStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ActiveStep) in the Stepper represents the step currently in the focus or selected by the user. You can set the active step of the Stepper by assigning a value to the activeStep property. By default the activeStep is `0`.

The following example highlights the difference between linear and non-linear steppers, showcasing how to utilize the activeStep property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/activeStep/razor %}
{% endhighlight %}
{% endtabs %}