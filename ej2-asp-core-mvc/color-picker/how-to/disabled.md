---
layout: post
title: Disabled in ##Platform_Name## Color Picker Control | Syncfusion
description: Learn here all about Disabled in Syncfusion ##Platform_Name## Color Picker control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disabled
publishingplatform: ##Platform_Name##
documentation: ug
---

# Disabled in Color Picker Control

To achieve disabled state in ColorPicker, set the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Disabled) property to `true`. The ColorPicker pop-up cannot be accessed in disabled state.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/color-picker/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).