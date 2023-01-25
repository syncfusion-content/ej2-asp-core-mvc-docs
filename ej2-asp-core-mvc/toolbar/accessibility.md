---
layout: post
title: Accessibility in ASP.NET Core and MVC Toolbar Component | Syncfusion
description: Learn here all about Accessibility in Syncfusion ASP.NET Core and MVC Toolbar component and more deatails.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ASP.NET Core and MVC
documentation: ug
---


# Accessibility in ASP.NET MVC Toolbar control

The Toolbar component has been designed,  keeping in mind the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications, and applying the WAI-ARIA roles, states and properties along with keyboard support for people who use assistive devices. WAI-ARIA accessibility support is achieved through attributes like `aria-label` and `aria-orientation`, It provides information about elements in a document for assistive technology.  The component implements keyboard navigation support by following the [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/), and has been tested in major screen readers.

## ARIA attributes

The Toolbar element is assigned the role of `toolbar`.

| **Property** | **Functionalities** |
| --- | --- |
| role="toolbar" | Attribute is set to the ToolBar element describes the actual role of the element. |
| aria-orientation |  Attribute is set to the ToolBar element to indicates the ToolBar orientation. Default value is `horizontal`. |
| aria-label | Attribute is set to ToolBar element describes the purpose of the set of toolbar. |
| aria-expanded | Attribute is set to the ToolBar Popup  element to indicates the expanded state of the popup.|
| aria-haspopup | Attribute is set to the popup element to indicates the popup mode of the Toolbar. Default value is false. When popup mode is enabled, attribute value has to be changed to `true`. |
| aria-disabled | Attribute set to the ToolBar element to indicates the disabled state of the ToolBar. |

## Keyboard interaction

Keyboard navigation is enabled, by default. Possible keys are:

| Key           | Description                                                                         |
|---------------|-------------------------------------------------------------------------------------|
| <kbd>Left</kbd>    | Focuses the previous element.                                               |
| <kbd>Right</kbd>   | Focuses the next element.                                                            |
| <kbd>Enter</kbd>         | When focused on a ToolBar command, clicking the key triggers the click of Toolbar element. When popup drop-down icon is focused, the popup opens. |
| <kbd>Esc(Escape)</kbd>           | Closes popup.                                                                     |
| <kbd>Down</kbd>   | Focuses the next popup element.                                                  |
| <kbd>Up</kbd>      | Focuses the previous popup element.                                                |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/toolbar/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/toolbar/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


