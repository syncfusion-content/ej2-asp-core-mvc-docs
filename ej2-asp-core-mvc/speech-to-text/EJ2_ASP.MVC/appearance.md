---
layout: post
title: Appearance in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about Appearance in Syncfusion ##Platform_Name## SpeechToText control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ##Platform_Name## SpeechToText control

## Customizing the button

You can use the `ButtonSettings` property to customize the appearance of the start and stop buttons in the speech to text conversion.

### Setting start content

You can use the `Content` property to define text content for the listening start state in the SpeechToText button.

### Setting stop content

You can use the `StopContent` property to define text content for the listening stop state in the SpeechToText button.

### Setting iconcss

You can use the `IconCss` property to apply a CSS class to customize the icon appearance for the listening start state.

### Setting stop iconcss

You can use the `StopIconCss` property to apply a CSS class to customize the icon appearance for the listening stop state.

### Setting icon position

You can display the icon on the top, bottom, left, or right side of the button text content using the `iconPosition` property.

### Setting primary

You can use the `IsPrimary` property to configure the button as a primary action button.

Below code sample demonstrates how to configure the button with above mentioned properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/buttonSettings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ButtonSettings.cs" %}
{% include code-snippet/speech-to-text/appearance/buttonSettings/buttonSettings.cs %}
{% endhighlight %}
{% endtabs %}

![buttonSettings](images/buttonSettings.png)

## Customizing the tooltips

You can use the `TooltipSettings` property to customize the content and positions of the tooltip.

### Setting start content

You can use the `Content` property to customize the content to be displayed in the tooltip when the speech recognition begins.

### Setting stop content

You can use the `StopContent` property to customize the stop button tooltip text which is displayed on-hover.

### Setting tooltip position

You can use the `Position` property to determine the placement of tooltips relative to the button.

Below code sample demonstrates how to configure the tooltip with above mentioned properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/tooltipSettings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TooltipSettings.cs" %}
{% include code-snippet/speech-to-text/appearance/tooltipSettings/tooltipSettings.cs %}
{% endhighlight %}
{% endtabs %}

![tooltipSettings](images/tooltipSettings.png)

## Setting button styles

The SpeechToText control supports the following predefined styles that can be defined using the `CssClass` property. You can customize by adding the cssClass property with the below defined class. 

| cssClass | Description | 
| -------- | -------- | 
| `e-primary` | Used to represent a primary action. | 
| `e-outline` |  Used to represent an appearance of button with outline. | 
| `e-info` |  Used to represent an informative action. | 
| `e-success` | Used to represent a positive action. | 
| `e-warning` | Used to represent an action with caution. | 
| `e-danger` | Used to represent a negative action. |

## Setting cssclass

You can use the `cssClass` property to customize the appearance of the SpeechToText control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/appearance/cssclass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cssclass.cs" %}
{% include code-snippet/speech-to-text/appearance/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

![cssclass](images/cssclass.png)
