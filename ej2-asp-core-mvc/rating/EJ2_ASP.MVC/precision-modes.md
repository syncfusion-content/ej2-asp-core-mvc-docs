---
layout: post
title: Precision Modes in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Precision Modes in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Precision Modes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Precision Modes in Asp.Net MVC Rating Control

You can use the [Precision](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Precision) property of the Asp.Net MVC Rating control to provide ratings with varying levels of precision.

The precision types of Rating are as follows:

* Full: The rating is increased in whole number increments. For example, if the current rating is 2, the next possible ratings are 3, 4, and so on.
* Half: The rating is increased in increments of 0.5 (half). For example, if the current rating is 2.5, the next possible ratings are 3, 3.5, 4, and so on. 
* Quarter: The rating is increased in increments of 0.25 (quarter). For example, if the current rating is 3.75, the next possible ratings are 4, 4.25, 4.5, and so on. 
* Exact: The rating is increased in increments of 0.1. For example, if the current rating is 3.9, the next possible ratings are 4, 4.1, 4.2, and so on.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/precision-modes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PrecisionModes.cs" %}
{% include code-snippet/rating/precision-modes/precisionmodes.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Asp.Net MVC Rating Control with different Precision Types](./images/rating-precision-types.png)