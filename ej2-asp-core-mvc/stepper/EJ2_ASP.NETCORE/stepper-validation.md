---
layout: post
title: Validation in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Validation in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validating steps 

Use the [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property in the Stepper to check the status of a specific step.

When [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) is set to `true`, the step meets the required criteria. If set to `false`, the step needs attention or completion. It provides clear feedback on the status of individual steps within the Stepper, enhancing the user interaction.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Validation](images/stepper-validation.jpg)