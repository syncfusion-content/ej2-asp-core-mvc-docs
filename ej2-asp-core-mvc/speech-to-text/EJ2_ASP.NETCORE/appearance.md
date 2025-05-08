---
layout: post
title: Appearance in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about appearance in Syncfusion Essential ##Platform_Name## SpeechToText control, its elements, and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ##Platform_Name## SpeechToText control

## Customizing the button

You can use the [buttonSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_ButtonSettings) property to customize the appearance of the start and stop buttons in the speech to text conversion.

### Setting start content  

You can use the [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_Content) property to define text content for the listening start state in the SpeechToText button.

### Setting stop content

You can use the [stopContent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_StopContent) property to define text content for the listening stop state in the SpeechToText button.

### Setting iconcss

You can use the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_IconCss) property to apply a CSS class to customize the icon appearance for the listening start state.

### Setting stop iconcss

You can use the [stopIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_StopIconCss) property to apply a CSS class to customize the icon appearance for the listening stop state.

### Setting icon position

You can display the icon on the top, bottom, left, or right side of the button text content using the [iconPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_IconPosition) property.

### Setting primary

You can use the [isPrimary](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextButtonSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextButtonSettings_IsPrimary) property to configure the button as a primary action button.

Below code sample demonstrates how to configure the button with above mentioned properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/buttonSettings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ButtonSettings.cs" %}
{% include code-snippet/speech-to-text/appearance/buttonSettings/buttonSettings.cs %}
{% endhighlight %}
{% endtabs %}

![buttonSettings](images/buttonSettings.png)

## Customizing the tooltips

You can use the [tooltipSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextTooltipSettings.html) property to customize the content and positions of the tooltip.

### Setting start content

You can use the [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextTooltipSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextTooltipSettings_Content) property to customize the content to be displayed in the tooltip when the speech recognition begins.

### Setting stop content

You can use the [stopContent](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextTooltipSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextTooltipSettings_StopContent) property to customize the stop button tooltip text which is displayed on-hover.

### Setting tooltip position

You can use the [position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToTextTooltipSettings.html#Syncfusion_EJ2_Inputs_SpeechToTextTooltipSettings_Position) property to determine the placement of tooltips relative to the button.

Below code sample demonstrates how to configure the tooltip with above mentioned properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/tooltipSettings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TooltipSettings.cs" %}
{% include code-snippet/speech-to-text/appearance/tooltipSettings/tooltipSettings.cs %}
{% endhighlight %}
{% endtabs %}

![tooltipSettings](images/tooltipSettings.png)

## Setting button styles

The SpeechToText control supports the following predefined styles that can be defined using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_CssClass) property. You can customize by adding the cssClass property with the below defined class. 

| cssClass | Description | 
| -------- | -------- | 
| `e-primary` | Used to represent a primary action. | 
| `e-outline` |  Used to represent an appearance of button with outline. | 
| `e-info` |  Used to represent an informative action. | 
| `e-success` | Used to represent a positive action. | 
| `e-warning` | Used to represent an action with caution. | 
| `e-danger` | Used to represent a negative action. |

## Setting cssclass

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_CssClass) property to customize the appearance of the SpeechToText control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/cssclass/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cssclass.cs" %}
{% include code-snippet/speech-to-text/appearance/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

![cssclass](images/cssclass.png)
