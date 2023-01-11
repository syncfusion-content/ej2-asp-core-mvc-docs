---
layout: post
title: Handle No Color Support in ##Platform_Name## Color Picker Control | Syncfusion
description: Learn here all about Handle No Color Support in Syncfusion ##Platform_Name## Color Picker control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Handle No Color Support
publishingplatform: ##Platform_Name##
documentation: ug
---

# Handle no color support in Color Picker Control

The ColorPicker component supports no color functionality. By clicking the no color tile from palette, the selected color becomes `empty` and considered as no color has been selected from color picker.

## Default no color

To achieve this, set [noColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_NoColor) property as `true`.

In the following sample, the first tile of the color palette represents the no color tile. By clicking the no color tile you can achieve the above functionalities.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/nocolor/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/nocolor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nocolor.cs" %}
{% include code-snippet/color-picker/nocolor/nocolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom no color

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-nocolor/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-nocolor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-nocolor.cs" %}
{% include code-snippet/color-picker/custom-nocolor/custom-nocolor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ColorPicker/ColorPickerSample).