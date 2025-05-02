---
layout: post
title: Styling tools in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Styling tools in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Styling tools
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styling Tools in the ##Platform_Name## Rich Text Editor Control

## Font family
  
The Rich Text Editor initializes with a default font family, which inherits the font family of the parent element. You can change the font for selected text using the font family dropdown in the toolbar. When the default font family is selected, the toolbar will display "Font Name". However, for other font families, the toolbar will show the name of the selected font.

To apply a different font style to a specific section of the content, follow these steps:

1. Select the text you want to change.
2. Choose the desired font style from the drop-down menu in the toolbar.

These steps will apply the selected font style to the chosen text, allowing you to customize the appearance of your content easily.

### Built-in font family

You can add the `FontName` tool in the Rich Text Editor toolbar using the `toolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/font-family/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/font-family/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/font-family/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/font-family/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The Rich Text Editor comes with a pre-configured set of [fontFamily](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.

### Custom font family

The Rich Text Editor supports providing custom fonts along with the existing list. To add additional font names to the font dropdown, you can configure the items field of the [fontFamily](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property. This allows you to extend the available font options beyond the default selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font-family/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font-family/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font-family/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font-family/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Google font support

To use web fonts in Rich Text Editor, it is not needed for the web fonts to be present in local machine. To add the web fonts to Rich Text Editor, you need to refer the web font links and add the font names in the [fontFamily](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/google-webfonts/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/google-webfonts/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/google-webfonts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/google-webfonts/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The below font style links are referred in the page.

```typescript

<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto">
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Great+Vibes">

```

N> In the above sample, you can see that we have added two Google web fonts (`Roboto` and `Great vibes`) to `Rich Text Editor`.

## Font size

The Rich Text Editor initializes with a default font size, which inherits the font size of the parent element. You can change the font for selected text using the font size dropdown in the toolbar. When the default font size is selected, the toolbar will display "Font Size". However, for other font sizes, the toolbar will show the name of the selected font.

### Built-in font size

You can add the `FontSize` tool in the Rich Text Editor toolbar using the `toolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/styling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/styling/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/styling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/styling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The Rich Text Editor includes a default set of [fontSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) property.

### Custom font size

The Rich Text Editor supports providing custom fonts along with the existing list. To add additional font names to the font dropdown, you can configure the items field of the [fontSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) property. This allows you to extend the available font options beyond the default selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-style/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-style/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Font and background color

You can add the `FontColor` and `BackgroundColor` tool in the Rich Text Editor toolbar using the `toolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/font-background-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/font-background-color/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/font-background-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/font-background-color/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Custom font and background colors

To apply `font color` or `background color` to selected content in the Rich Text Editor, use the font color and background color tools.

The Rich Text Editor offers custom font and background colors along with the existing list through the [colorCode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFontColor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFontColor_ColorCode) field of the [fontColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontColor) and [backgroundColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BackgroundColor) properties.

Both the `FontColor` and `BackgroundColor` properties offer two modes: `Picker` and `Palette`. The Palette mode provides a predefined set of colors, while the Picker mode includes a color scheme to choose custom colors. You can switch between these options using the [modeSwitcher](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFontColor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFontColor_ModeSwitcher) feature.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
