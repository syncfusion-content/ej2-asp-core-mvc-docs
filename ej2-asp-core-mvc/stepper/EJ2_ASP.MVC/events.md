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

## Created

The [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Created) event is triggered when the Stepper control is initially created.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/stepper/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

## StepChanged

The [StepChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanged) event occurs when the active step in the Stepper changes.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanged/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepChanged.cs" %}
{% include code-snippet/stepper/events/stepChanged/stepChanged.cs %}
{% endhighlight %}
{% endtabs %}

## StepChanging

The [StepChanging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanging) event is triggered before the active step changes in the Stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepChanging.cs" %}
{% include code-snippet/stepper/events/stepChanging/stepChanging.cs %}
{% endhighlight %}
{% endtabs %}

## StepClick

The [StepClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepClick) event is triggered when a step in the Stepper is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepClick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepClick.cs" %}
{% include code-snippet/stepper/events/stepClick/stepClick.cs %}
{% endhighlight %}
{% endtabs %}

## BeforeStepRender

The [BeforeStepRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_BeforeStepRender) event occurs before a step is rendered in the Stepper.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/beforeStepRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeStepRender.cs" %}
{% include code-snippet/stepper/events/beforeStepRender/beforeStepRender.cs %}
{% endhighlight %}
{% endtabs %}