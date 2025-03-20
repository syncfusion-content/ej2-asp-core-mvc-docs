---
layout: post
title: Steps in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Steps in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Steps in ##Platform_Name## Stepper control

The ASP.NET Core Stepper allows you to add steps using the `e-stepper-step` tag helper. Each step can be configured with options such as `iconCss`, `text`, `label`, `cssClass` and more.

## Adding steps

You can define the icon and text content for each step using the `iconCss`, `text` and `label` properties.

### Defining icon CSS

You can define the CSS class to show the icon for each step using the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/tagHelper %}
{% endhighlight %}
{% endtabs %}

### Defining text content

You can define text instead of an icon by setting the [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property and display label content for a step using the [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Label) property.

> When both label and text are defined, the label takes priority for display based on the `stepType`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Optional steps

You can show whether the step is optional or not by using `optional` property. By default, the `optional` property is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/optional/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Optional step](images/step-optional.jpg)

## Disabling steps

You can use the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property to disable a step, preventing user interaction when set to `true`. By default, the value is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Disabled step](images/step-disabled.jpg)

## Setting readonly

You can use [readOnly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ReadOnly) property to disable the user interactions in the stepper.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/readonly/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Readonly](images/step-readonly.jpg)

## Setting active step

You can set the active step by specifying its index using the [activeStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ActiveStep) property. The default value is `0`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/activeStep/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Active step](images/stepper-activestep.jpg)

## Step status

Each step's progress state can be specified using the [status](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/status/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Status](images/step-status.jpg)

## Step styling

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the each step.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper CSSClass](images/step-cssclass.jpg)

## Step validation

You can set the validation state for each step to displaying a success or error icon by using [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property.

> To know more about Stepper validation, refer the [Validation](./steps-validation.md) section.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Validation](images/stepper-validation.jpg)