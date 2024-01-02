---
layout: post
title: Steps in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Steps in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Steps in ##Platform_Name## Stepper control

You can define the Stepper steps by using the [steps](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Steps) property. You can configure each step which provides options such as `iconCss`, `text`, `label` and more.

## Steps

You can customize the icon, text and label of the steps by using the `iconCss`, `text` and `label` properties.

### Defining step icons

You can display only icons for each step by using the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/razor %}
{% endhighlight %}
{% endtabs %}

### Defining step content

You can display only text for each step by setting the [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property. You can show only label for each step by setting the [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Label) property.

> Depending on the `stepType`, if both label and text are defined, the label takes priority to diplay the content.
In the below sample, the Stepper is rendered with texts.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/razor %}
{% endhighlight %}
{% endtabs %}

In the below sample, the Stepper is rendered with labels.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/label/razor %}
{% endhighlight %}
{% endtabs %}

## Optional steps

You can determine whether the step can be skipped or not by setting the `optional` property. By default, the `optional` property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/optional/razor %}
{% endhighlight %}
{% endtabs %}

## Enable or disable steps

You can make any step active or in-active by setting the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property. By default, the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/razor %}
{% endhighlight %}
{% endtabs %}

## Defining active step

You can specify the currently focused or user-selected step by using the [activeStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ActiveStep) property. By default, the activeStep is `0`.

The following example showcases how to utilize the active step property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/activeStep/razor %}
{% endhighlight %}
{% endtabs %}

## Steps status

The progress states of each activeStep can be updated by using the [status](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

## Customization

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper CSSClass](images/stepper-cssclass.jpg)

## Steps validation

Specifes whether the step is valid or not. By default, the [isValid](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property is `null`.

> To know more about Stepper validation, refer the [Validation](./stepper-validation.md) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Validation](images/stepper-validation.jpg)