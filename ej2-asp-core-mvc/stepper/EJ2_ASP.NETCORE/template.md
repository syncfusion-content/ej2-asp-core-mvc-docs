---
layout: post
title: Template in ##Platform_Name## Stepper | Syncfusion
description: Learn how to customize step content and appearance in the Syncfusion ##Platform_Name## Stepper, including labels, icons, templates, and styling options.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ##Platform_Name## Stepper

The Stepper control allows you to customize the default appearance and content of each step, creating a personalized experience for the user. You can use the [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Template) propety to set the template content for the steps.

The [StepModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html) and current step index are passed as `step` and `currentStep` properties in the template context for customization.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Template](images/stepper-template.jpg)