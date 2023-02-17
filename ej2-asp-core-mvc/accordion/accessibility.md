---
layout: post
title: Accessibility in ##Platform_Name## Accordion Control | Syncfusion
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Accordion control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in ##Platform_Name## Accordion Control

The Accordion component has been designed keeping in mind the [WAI-ARIA](https://www.w3.org/TR/wai-aria-practices/) specifications, by applying the prompt WAI-ARIA roles, states and properties along with the keyboard support. Thus, making it usable for people who use assistive WAI-ARIA Accessibility supports that is achieved through the attributes like `aria-labelledby`, It helps to provide information about the elements in a document for assistive technology. The component implements the keyboard navigation support by following the [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and tested in major screen readers.

## ARIA attributes

| Property | Functionality |
|----------|---------------|
| role                 |**Button:** Attribute is set to the Accordion header elements to indicate that the element can be used to toggle the visibility of the associated content section, describing the actual role of the element.<br> **Region:** Attribute is set to the Accordion panel elements to create a landmark region that contains the currently expanded accordion panel, describing the actual role of the element. <br/>  | 
| aria-labelledby      | Attribute is set to content (panel) and it points to the corresponding Accordion header.|
| aria-controls        | Attribute is set to the header and it points to the corresponding Accordion content.  |
| aria-expanded        | Attribute is set to the Accordion header elements to indicates the expand state of the Accordion Item. Default value of this attribute is `false`. If an item is expanded, the attribute value changes to ‘true’. |
| aria-hidden          | Attribute is set to the Accordion panel elements to indicates the content visible state of the Accordion Item. Default value of this attribute is `true`. If an item content is visible, the attribute value changes to `false`. |
| aria-disabled        | It indicates the disabled state of the Accordion and its items.  |

## Keyboard interaction

Keyboard navigation is enabled by default. Possible keys are:

| Key           | Description                                                                         |
|---------------|-------------------------------------------------------------------------------------|
| <kbd>Space or Enter</kbd>    | When focus is on the Accordion header, click on the focused element makes the element to expand and collapse.                                                  |
| <kbd>Down Arrow</kbd>   | Focus the next Accordion header.                                                            |
| <kbd>Up Arrow</kbd>         | Focus the previous Accordion header. |
| <kbd>Home</kbd>           | Focus the first Accordion header.                                                                     |
| <kbd>End</kbd>   | Focus the last Accordion header.                                                |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/accessibility/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/accordion/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


