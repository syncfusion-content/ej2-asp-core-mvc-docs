---
layout: post
title: Show Recent color in ##Platform_Name## Color Picker Control | Syncfusion
description: Learn here all about Show Recent color in Syncfusion ##Platform_Name## Color Picker control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Render Palette Alone
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Recent color in Color Picker Control

The [ShowRecentColors](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowRecentColors) property enables the display of recently selected colors in the ColorPicker when in palette mode. This feature helps users quickly access their most frequently used colors.

>Note: The [`ShowRecentColors`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowRecentColors) feature displays up to 10 recent colors as tiles and is available only in `palette` mode.

In the following sample, the [`ShowRecentColors`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_ShowRecentColors) property is enabled to display recent colors in the `palette` area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/show-recent-color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/show-recent-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="show-recent.cs" %}
{% include code-snippet/color-picker/show-recent-color/show-recent-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).