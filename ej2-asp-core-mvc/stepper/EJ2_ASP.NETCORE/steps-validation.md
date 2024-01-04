---
layout: post
title: Validation in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Validation in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Steps validation in ##Platform_Name## Stepper control

The Stepper control allows you to set the validation state for each step, displaying either a success or error icon. You can define the success state of a step by setting the [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property to `true`. If set to `false`, the step will display an error state. By default, the `isValid` property is `null`.

> Based on the [stepType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType), the validation state icon will be displayed either as an indicator or as part of the step label/text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Validation](images/stepper-validation.jpg)