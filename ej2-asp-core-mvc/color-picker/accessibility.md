---
layout: post
title: Accessibility in ##Platform_Name## Color Picker Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Color Picker component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

## ARIA attributes

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. It helps to provide information about the widget for assistive technology to the disabled person in screen reader.

ColorPicker provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices) specifications. WAI-ARIA supports is achieved through the attributes like `aria-label`and `aria-selected` applied to the color palette tiles.

To know about the accessibility of SplitButton, refer to the SplitButton [`Accessibility`](./../split-button/accessibility#accessibility) section.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | Specified as `gridcell` for the tiles in the color palette. |
| aria-label | Holds the color of the tile. |
| aria-selected | Indicates the current selected state of the tile. |

## Keyboard interaction

To know about the keyboard interaction of SplitButton, refer to the SplitButton [`Keyboard interaction`](./../split-button/accessibility#keyboard-interaction) section.

The following list of keys can be used to interact with the ColorPicker after the popup has opened.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Upper Arrow</kbd>  | Moves the handler/tile up from the current position. |
| <kbd>Down Arrow</kbd>  | Moves the handler/tile down from the current position. |
| <kbd>Left Arrow</kbd>  | Moves the handler/tile left from the current position. |
| <kbd>Right Arrow</kbd>  | Moves the handler/tile right from the current position. |
| <kbd>Enter</kbd>  | Apply the selected color value. |
| <kbd>Tab</kbd>  | To focus the next focusable element in the ColorPicker popup.  |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/color-picker/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/color-picker/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/color-picker/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/color-picker/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


