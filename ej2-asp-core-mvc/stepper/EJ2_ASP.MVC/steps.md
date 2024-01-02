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

You can define the Stepper steps by using the [Steps](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Steps) property. You can configure each step which provides options such as `IconCss`, `Text`, `Label` and more.

## Steps

You can customize the icon, text and label of the steps by using the `IconCss`, `Text` and `Label` properties.

### Defining step icons

You can display only icons for each step by using the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/stepper/steps/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

### Defining step content

You can display only text for each step by setting the [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property. You can show only label for each step by setting the [Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Label) property.

> Depending on the `StepType`, if both label and text are defined, the label takes priority to diplay the content.
In the below sample, the Stepper is rendered with texts.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/stepper/steps/text/text.cs %}
{% endhighlight %}
{% endtabs %}

In the below sample, the Stepper is rendered with labels.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/stepper/steps/label/label.cs %}
{% endhighlight %}
{% endtabs %}

## Optional steps

You can determine whether the step can be skipped or not by setting the `Optional` property. By default, the `Optional` property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/optional/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Optional.cs" %}
{% include code-snippet/stepper/steps/optional/optional.cs %}
{% endhighlight %}
{% endtabs %}

## Enable or disable steps

You can make any step active or in-active by setting the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property. By default, the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/stepper/steps/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

## Defining active step

You can specify the currently focused or user-selected step by using the [ActiveStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ActiveStep) property. By default, the ActiveStep is `0`.

The following example showcases how to utilize the active step property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/activeStep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActiveStep.cs" %}
{% include code-snippet/stepper/steps/activeStep/activeStep.cs %}
{% endhighlight %}
{% endtabs %}

## Steps status

The progress states of each activeStep can be updated by using the [Status](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

## Customization

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/stepper/steps/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper CssClass](images/stepper-cssclass.jpg)

## Steps validation

Specifes whether the step is valid or not. By default, the [IsValid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property is `null`.

> To know more about Stepper validation, refer the [Validation](./stepper-validation.md) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/stepper/steps/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Validation](images/stepper-validation.jpg)