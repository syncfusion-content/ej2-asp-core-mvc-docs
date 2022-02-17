---
layout: post
title: Mode And Value in ##Platform_Name## Color Picker Component
description: Learn here all about Mode And Value in Syncfusion ##Platform_Name## Color Picker component and more.
platform: ej2-asp-core-mvc
control: Mode And Value
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mode and Value

## Rendering palette at initial load

By default, the `Picker` area will be rendered at initial load. To render the Palette area while opening the ColorPicker pop-up, and specify the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Mode) property as `Palette`.

In the following sample, it will render the `Palette` at initial load.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/palette/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/color-picker/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/palette/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/color-picker/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Color value

The [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Value) property can be used to specify the color value to the
ColorPicker. It supports either `three` or `six` digit hex codes. To include `opacity`, set the color value as `four` or `eight` digit hex code.

In the following sample, the color value sets as `four` digit hex code, the last digit represents the `opacity` value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/color-picker/value/value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/color-picker/value/value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>> The [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Value) property supports hex code with or without `#` prefix.

## See Also

* [How to render palette alone](./how-to/render-palette-alone)
* [Custom palette](./how-to/customize-colorpicker#custom-palette)
* [No color support in palette](./how-to/handle-no-color-support)