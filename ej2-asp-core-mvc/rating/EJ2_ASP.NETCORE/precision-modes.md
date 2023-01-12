---
layout: post
title: Precision Modes in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Precision Modes in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Precision Modes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Precision Modes in Asp.Net Core Rating Control

You can use the [precision](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Precision) property of the Asp.Net Core Rating control to provide ratings with varying levels of precision.

The precision types of Rating are as follows:

* Full: The rating is increased in whole number increments. For example, if the current rating is 2, the next possible ratings are 3, 4, and so on.
* Half: The rating is increased in increments of 0.5 (half). For example, if the current rating is 2.5, the next possible ratings are 3, 3.5, 4, and so on. 
* Quarter: The rating is increased in increments of 0.25 (quarter). For example, if the current rating is 3.75, the next possible ratings are 4, 4.25, 4.5, and so on. 
* Exact: The rating is increased in increments of 0.1. For example, if the current rating is 3.9, the next possible ratings are 4, 4.1, 4.2, and so on.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/precision-modes/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Asp.Net Core Rating Control with different Precision Types](./images/rating-precision-types.png)