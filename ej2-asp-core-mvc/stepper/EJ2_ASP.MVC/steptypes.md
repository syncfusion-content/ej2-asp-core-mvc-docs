---
layout: post
title: Step Types in ##Platform_Name## Stepper | Syncfusion
description: Learn about the step types available in the Syncfusion ##Platform_Name## Stepper, including default, label, and indicator display modes.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Step Types in ##Platform_Name## Stepper

The Stepper control provides support for displaying steps with the following step types.

## Default type

In default type, the Stepper displays steps with a combination of both indicators and labels by setting the [StepType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Default`. By default, the Stepper displays steps in the `Default` type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/stepper/stepType/default/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Default Steptype](images/steptype-default.jpg)

## Label type

In label type, the Stepper displays the steps with only the step labels by setting the [StepType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Label`.

> When both label and text are defined, the label takes priority in displaying the steps.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/stepper/stepType/label/label.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Label Steptype](images/steptype-label.jpg)

### Label positions

You can display the label on the top, bottom, left, or right side of the steps using the [LabelPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_LabelPosition) property.

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
{% highlight c# tabtitle="LabelPosition.cs" %}
{% include code-snippet/stepper/label-position/labelPosition.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Label Position](images/stepper-labelposition.jpg)

## Indicator type

In indicator type, the Stepper displays steps with only the step indicators by setting the [StepType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepType) property as `Indicator`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/stepType/indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator.cs" %}
{% include code-snippet/stepper/stepType/indicator/indicator.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Indicator Steptype](images/steptype-indicator.jpg)