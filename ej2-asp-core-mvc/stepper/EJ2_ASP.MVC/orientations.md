---
layout: post
title: Orientation in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Orientation in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Orientation

You can use the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property to set `Horizontal` or `Vertical` orientations, which controls the sequence order of the steps displayed in the Stepper. By default, the orientation is set to `Horizontal`.

## Horizontal

The Stepper steps are arranged in a side-by-side manner, by setting the `Horizontal` in the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/horizontal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Horizontal.cs" %}
{% include code-snippet/stepper/horizontal/horizontal.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Horizontal](images/stepper-horizontal.jpg)

## Vertical

To display the steps vertically, use the `Vertical` in the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property, to arrange the steps one below the other.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/stepper/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}