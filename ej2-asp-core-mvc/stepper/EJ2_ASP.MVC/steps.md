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

The ASP.NET MVC Stepper allows you to add steps using the [Steps](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Steps) property. Each step can be configured with options such as `IconCss`, `Text`, `Label`, `CssClass` and more.

## Adding steps

You can define the icon and text content for each step using the `IconCss`, `Text` and `Label` properties.

### Defining icon CSS

You can define the CSS class to show the icon for each step using the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/stepper/steps/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

### Defining text content

You can define text instead of an icon by setting the [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Text) property and display label content for a step using the [Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Label) property.

> When both label and text are defined, the label takes priority for display based on the `StepType`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/stepper/steps/text/text.cs %}
{% endhighlight %}
{% endtabs %}

## Optional steps

You can show whether the step is optional or not by using `Optional` property. By default, the `Optional` property is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/optional/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Optional.cs" %}
{% include code-snippet/stepper/steps/optional/optional.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Optional step](images/step-optional.jpg)

## Disabling steps

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Disabled) property to disable a step, preventing user interaction when set to `true`. By default, the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/stepper/steps/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Disabled step](images/step-disabled.png)

## Setting readonly

You can use [ReadOnly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ReadOnly) property to disable the user interactions in the stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/readonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Readonly.cs" %}
{% include code-snippet/stepper/steps/readonly/readonly.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Readonly](images/step-readonly.jpg)

## Setting active step

You can set the active step by specifying its index using the [ActiveStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_ActiveStep) property. The default value is `0`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/activeStep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActiveStep.cs" %}
{% include code-snippet/stepper/steps/activeStep/activeStep.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Active step](images/stepper-activestep.jpg)

## Step status

Each step's progress state can be specified using the [Status](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_Status) property. The possible values are `NotStarted`, `InProgress` and `Completed`. By default, the value is `NotStarted.`

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/status/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Status.cs" %}
{% include code-snippet/stepper/steps/status/status.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Status](images/step-status.jpg)

## Step styling

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_CssClass) property to customize the appearance of the each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/stepper/steps/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper CssClass](images/step-cssclass.jpg)

## Step validation

You can set the validation state for each step to displaying a success or error icon by using [IsValid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Step.html#Syncfusion_EJ2_Navigations_Step_IsValid) property.

> To know more about Stepper validation, refer the [Validation](./steps-validation.md) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steps/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation.cs" %}
{% include code-snippet/stepper/steps/validation/validation.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Validation](images/stepper-validation.jpg)