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

You can use the [Steps](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Steps) property to add the Stepper steps. The Steps collections represent the options for each step within the Stepper.

## Icon

You can use the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property to specify and customize an icon for each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/stepper/steps/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

## Text

You can use the [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property to specify the text content for each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/stepper/steps/text/text.cs %}
{% endhighlight %}
{% endtabs %}

## Disabled

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property to in-active any step. By default the `Disabled` property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/stepper/steps/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

## Validation

You can toggle the [IsValid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property based on the application logic to success or error states. If the current step is invalid, it prevents the user from moving on to the next one. The default value is `null`.

> Based on the stepper `StepType`, the validation icons will be displayed either in the step indicator or as part of the step label/text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/stepper/steps/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Validation](images/stepper-validation.jpg)

## Status

You can use the [Status](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property to represent the progress states of each active step. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

## CssClass

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/stepper/steps/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper CssClass](images/stepper-cssclass.jpg)