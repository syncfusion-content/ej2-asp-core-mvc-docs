---
layout: post
title: How to disable Color Picker in ##Platform_Name## Color Picker | Syncfusion
description: Disable Syncfusion ##Platform_Name## Color Picker by setting the disabled property to true so the popup cannot be opened.
platform: ej2-asp-core-mvc
control: Disabled
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to disable Color Picker in ##Platform_Name## Color Picker

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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).