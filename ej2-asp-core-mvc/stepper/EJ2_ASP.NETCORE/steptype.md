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

The Stepper control can be displayed in `Default`, `Label`, and `Indicator` types by using the [stepType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property. By default, the property value is `Default`.

## Default

In `Default` display mode, the Stepper will display both the indicators and the labels when defined in the [StepModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html).

## Defining label

In `Label` display mode, the Stepper will display only the labels regardless of the configured [StepModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html) options such as text and iconCss.

### Defining label positions

The Stepper control allows you to place the label on the top, bottom, left, or right side of the Stepper using the [labelPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_LabelPosition) property.

The following label positions are supported in Stepper:

* Top: Positions the label at the top of the Stepper.
* Bottom: Positions the label at the bottom of the Stepper.
* Start: Positions the label to the left side of the Stepper.
* End: Positions the label to the right side of the Stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/label-position/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Stepper Label Position](images/stepper-labelposition.jpg)

## Defining indicator

The display mode `Indicator` in the Stepper will display only the indicators irrespective of the [StepModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Step.html) options such as text and label.

The below example, showcases the various `StepType` available in the Stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steptype/razor %}
{% endhighlight %}
{% endtabs %}