---
layout: post
title: How to render palette in ##Platform_Name## Color Picker | Syncfusion
description: Render only the palette area in Syncfusion ##Platform_Name## Color Picker by setting mode to Palette and disabling modeSwitcher and showButtons.
platform: ej2-asp-core-mvc
control: Render Palette Alone
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to render palette in ##Platform_Name## Color Picker

To render the `Palette` alone in ColorPicker, specify the [mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Mode) property as `Palette`, and set the [modeSwitcher](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ModeSwitcher) property to `false`.

In the following sample, the [showButtons](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowButtons) property is disabled to hide the control buttons and it renders only the `Palette` area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/palette-alone/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/palette-alone/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Palette-alone.cs" %}
{% include code-snippet/color-picker/palette-alone/palette-alone.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> To render `Picker` alone specify the [mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Mode) property as 'Picker'.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).