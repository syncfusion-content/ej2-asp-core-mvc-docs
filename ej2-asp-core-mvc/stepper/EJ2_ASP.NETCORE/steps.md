---
layout: post
title: Steps in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Steps in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Adding Stepper Steps

You can use the [steps](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Steps) property to add the Stepper steps. The steps collections represent the options for each step within the Stepper.

## Icon

You can use the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property to specify and customize an icon for each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/razor %}
{% endhighlight %}
{% endtabs %}

## Text

You can use the [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property to specify the text content for each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/razor %}
{% endhighlight %}
{% endtabs %}

## Disabled

You can use the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_disabled) property to in-active any step. By default the `disabled` property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/razor %}
{% endhighlight %}
{% endtabs %}

## Validation

You can toggle the [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property based on the application logic to success or error states. If the current step is invalid, it prevents the user from moving on to the next one. The default value is `null`.

> Based on the stepper `stepType`, the validation icons will be displayed either in the step indicator or as part of the step label/text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Validation](images/stepper-validation.jpg)

## Status

You can use the [status](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property to represent the progress states of each active step. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

## CssClass

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper CssClass](images/stepper-cssclass.jpg)