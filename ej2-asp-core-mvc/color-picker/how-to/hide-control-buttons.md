---
layout: post
title: Hide Control Buttons in ##Platform_Name## Color Picker Control | Syncfusion
description: Learn here all about Hide Control Buttons in Syncfusion ##Platform_Name## Color Picker control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hide Control Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hide control buttons in Color Picker Control

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

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).