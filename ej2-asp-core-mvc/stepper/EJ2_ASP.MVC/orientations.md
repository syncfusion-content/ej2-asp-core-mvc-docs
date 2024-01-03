---
layout: post
title: Orientation in ##Platform_Name## Stepper Control | Syncfusion
description: Checkout and learn about Orientation in ##Platform_Name## Stepper control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Orientation in ##Platform_Name## Stepper control

The Stepper control supports the display of steps in both horizontal and vertical orientations by using the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property.

## Horizontal

In horizontal orientation, the steps are displayed in a side-by-side manner by setting the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property to `Horizontal`. By default, the steps are displayed in the horizontal orientation.

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

You can display the steps one below the other vertically by setting the [Orientation](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.Stepper.html#Syncfusion_EJ2_Navigations_Stepper_Orientation) property to `Vertical`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stepper/vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/stepper/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Stepper Vertical](images/stepper-vertical.jpg)