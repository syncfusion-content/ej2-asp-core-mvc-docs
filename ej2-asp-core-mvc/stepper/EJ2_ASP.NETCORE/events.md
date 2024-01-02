---
layout: post
title: Events in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Events in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events

This section describes the stepper events that will be triggered when an appropriate actions are performed. The following events are available in the stepper control.

## created

The Stepper control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Created) event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/created/razor %}
{% endhighlight %}
{% endtabs %}

## stepChanged

The Stepper control triggers the [stepChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanged) event after the active step is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanged/razor %}
{% endhighlight %}
{% endtabs %}

## stepChanging

The Stepper control triggers the [stepChanging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanging) event before the active step change.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanging/razor %}
{% endhighlight %}
{% endtabs %}

## stepClick

The Stepper control triggers the [stepClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepClick) event when the step is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepClick/razor %}
{% endhighlight %}
{% endtabs %}

## beforeStepRender

The Stepper control triggers the [beforeStepRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_BeforeStepRender) event before rendering each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/beforeStepRender/razor %}
{% endhighlight %}
{% endtabs %}