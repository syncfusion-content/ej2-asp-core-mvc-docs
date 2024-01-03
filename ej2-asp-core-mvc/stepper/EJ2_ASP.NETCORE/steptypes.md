---
layout: post
title: Step Type in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Step Type in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Step types in ##Platform_Name## Stepper control

The Stepper control provides support for displaying steps with the following step types.

## Default type

In default type, the Stepper displays steps with a combination of both indicators and labels by setting the [stepType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Default`. By default, the Stepper displays steps in the `Default` type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/default/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Default Steptype](images/steptype-default.jpg)

## Label type

In label type, the Stepper displays the steps with only the step labels by setting the [stepType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Label`.

> When both label and text are defined, the label takes priority in displaying the steps.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/label/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Label Steptype](images/steptype-label.jpg)

### Label positions

You can display the label on the top, bottom, left, or right side of the steps using the [labelPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_LabelPosition) property.

The following label positions are supported in Stepper:

| Value | Description |
|-----|-----|
| `Top` | Positions the label at the top of each step. |
| `Bottom` | Positions the label at the bottom of each step. |
| `Start` | Positions the label to the left side of each step. |
| `End` | Positions the label to the right side of each step. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/label-position/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Label Position](images/stepper-labelposition.jpg)

## Indicator type

In indicator type, the Stepper displays steps with only the step indicators by setting the [stepType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Indicator`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/indicator/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Indicator Steptype](images/steptype-indicator.jpg)