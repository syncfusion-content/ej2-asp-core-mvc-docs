---
layout: post
title: Events in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Events in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stepper
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Stepper control

This section describes the Stepper events that will be triggered when an appropriate actions are performed. The following events are available in the Stepper control.

## Created

The Stepper control triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Created) event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/stepper/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

## StepChanged

The Stepper control triggers the [StepChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanged) event after the active step is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanged/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepChanged.cs" %}
{% include code-snippet/stepper/events/stepChanged/stepChanged.cs %}
{% endhighlight %}
{% endtabs %}

## StepChanging

The Stepper control triggers the [StepChanging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepChanging) event before the active step change.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepChanging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepChanging.cs" %}
{% include code-snippet/stepper/events/stepChanging/stepChanging.cs %}
{% endhighlight %}
{% endtabs %}

## StepClick

The Stepper control triggers the [StepClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_StepClick) event when the step is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/stepClick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StepClick.cs" %}
{% include code-snippet/stepper/events/stepClick/stepClick.cs %}
{% endhighlight %}
{% endtabs %}

## BeforeStepRender

The Stepper control triggers the [BeforeStepRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_BeforeStepRender) event before rendering each step.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/events/beforeStepRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeStepRender.cs" %}
{% include code-snippet/stepper/events/beforeStepRender/beforeStepRender.cs %}
{% endhighlight %}
{% endtabs %}