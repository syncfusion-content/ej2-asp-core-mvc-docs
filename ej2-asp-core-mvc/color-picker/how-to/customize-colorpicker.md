---
layout: post
title: Customize Colorpicker in ##Platform_Name## Color Picker Component
description: Learn here all about Customize Colorpicker in Syncfusion ##Platform_Name## Color Picker component and more.
platform: ej2-asp-core-mvc
control: Customize Colorpicker
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize ColorPicker

## Custom palette

By default, the Palette will be rendered with default colors. To load custom colors in the palette, specify the colors in the [`presetColors`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_PresetColors) property. To customize the color palette, add a custom class to palette tiles using [`beforeTileRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_BeforeTileRender) event.

The following sample demonstrates the above functionalities.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-palette/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-palette.cs" %}
{% include code-snippet/color-picker/custom-palette/custom-palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-palette/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-palette.cs" %}
{% include code-snippet/color-picker/custom-palette/custom-palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hide input area from picker

By default, the input area will be rendered in ColorPicker. To hide the input area from it, add `e-hide-value` class to ColorPicker using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_CssClass) property.

In the following sample, the ColorPicker is rendered without input area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/hide-input/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-input.cs" %}
{% include code-snippet/color-picker/hide-input/hide-input.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/hide-input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-input.cs" %}
{% include code-snippet/color-picker/hide-input/hide-input.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom handle

Color picker handle shape and UI can be customized. Here, we have customized the handle as `svg icon`. The same way you can customize the handle based on your requirement.

The following sample show the customized color picker handle.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-handle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-handle.cs" %}
{% include code-snippet/color-picker/custom-handle/custom-handle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/custom-handle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-handle.cs" %}
{% include code-snippet/color-picker/custom-handle/custom-handle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom primary button

By default, the applied color will be updated in primary button of the color picker. You can customize that as `icon`.

In the following sample, the `picker` icon is added to primary button and using [`change`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Change) event the selected color will be updated in bottom portion of the icon.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/color-picker/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/color-picker/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element. You can also use third party icon to customize the primary button.

## Display hex code in input

The color picker input element can be showcased in the place of primary button. The applied color hex code will be updated in the primary button input.

The following sample shows the color picker with input.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/input/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Input.cs" %}
{% include code-snippet/color-picker/input/input.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Input.cs" %}
{% include code-snippet/color-picker/input/input.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom UI

The color picker UI can be customized in all possible ways. The following sample shows the excel like UI customization with help of SplitButton and Dialog component. In that by clicking the more colors option from color palette, the dialog contains color picker will open.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/excel-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-ui.cs" %}
{% include code-snippet/color-picker/excel-ui/excel-ui.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/excel-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excel-ui.cs" %}
{% include code-snippet/color-picker/excel-ui/excel-ui.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


