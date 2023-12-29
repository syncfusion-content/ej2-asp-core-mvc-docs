---
layout: post
title: Step Type in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Step Type in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# StepType

The [StepType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property in the Stepper determines whether steps should be displayed using only with indicators, only labels, or a combination of both. The available values for this property are `Default`, `Label`, and `Indicator`.

## Default

Steps are displayed with icons and the labels when defined.

## Label

Steps are displayed with their defined labels only.

### Label positions

The Stepper control allows you to place the label on the top, bottom, left, or right side of the stepper using the [LabelPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_LabelPosition) property.

The following label positions are supported in stepper:

* Top: Positions the label at the top of the stepper.
* Bottom: Positions the label at the bottom of the stepper.
* Start: Positions the label to the left side of the stepper.
* End: Positions the label to the right side of the stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/label-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelPosition.cs" %}
{% include code-snippet/stepper/label-position/labelPosition.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Label Position](images/stepper-labelposition.jpg)

## Indicator

Steps are displayed with only indicators.

The example below showcases the various types of steps available in the stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/steptype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepType.cs" %}
{% include code-snippet/stepper/steptype/steptype.cs %}
{% endhighlight %}
{% endtabs %}