---
layout: post
title: How to hide buttons in ##Platform_Name## Color Picker | Syncfusion
description: Hide the Apply and Cancel control buttons in Syncfusion ##Platform_Name## Color Picker by setting showButtons to false so colors apply on selection.
platform: ej2-asp-core-mvc
control: Hide Control Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to hide buttons in ##Platform_Name## Color Picker

ColorPicker can be rendered without control buttons (Apply/Cancel). In this case, while selecting a color, the ColorPicker pop-up is closed and selected colors can be applied directly. To hide control buttons, set the [showButtons](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowButtons) property to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/show-buttons/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/show-buttons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-buttons.cs" %}
{% include code-snippet/color-picker/show-buttons/show-buttons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).