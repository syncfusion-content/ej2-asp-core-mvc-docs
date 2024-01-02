---
layout: post
title: Validation in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Validation in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Steps validation in ##Platform_Name## Stepper control

You can define the validation state of each step by setting the [IsValid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property. If the [IsValid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) is set as `true`, it shows the success state if `false` it displays the error state of the steps. The default value is `null`.

> Based on the Stepper `StepType`, the validation icons will be displayed either as an indicator or as part of the step label/text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/stepper/steps/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Validation](images/stepper-validation.jpg)