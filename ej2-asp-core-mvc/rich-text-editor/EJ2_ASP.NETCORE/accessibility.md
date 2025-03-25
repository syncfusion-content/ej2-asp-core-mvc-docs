---
layout: post
title: Accessibility in ##Platform_Name## Rich Text Editor Component | Sycnfusion
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in the ##Platform_Name## Rich Text Editor Control

The Rich Text Editor control is designed with accessibility in mind, adhering to WAI-ARIA specifications and implementing ARIA roles, states, and properties. This ensures full accessibility support, making it user-friendly for people who rely on assistive technologies (AT) or keyboard navigation.

The accessibility compliance for the Rich Text Editor control is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| WCAG 2.2 Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Section 508 Support](../common/accessibility#section-508) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Screen Reader Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Right-To-Left Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Color Contrast | <img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> |
| Mobile Device Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Keyboard Navigation Support](../common/accessibility#keyboard-navigation) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Accessibility Checker Validation | <img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> |
| Axe-core Accessibility Validation | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the control meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the control do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The control does not meet the requirement.</div>

## ARIA Attributes

The toolbar in the Rich Text Editor is assigned the role of 'Toolbar' and includes the following attributes.

| **Property**  | **Functionalities** |
| --- | --- |
| role="toolbar" | This attribute added to the toolbar element describes the actual role of the element. |
| aria-orientation | Indicates the toolbar orientation. Default value is horizontal. |
| aria-haspopup | Indicates the popup mode of the toolbar. The default value is false. When popup mode is enabled, attribute value has to be changed to true. |
| aria-disabled | Indicates the disabled state of the toolbar. |
| aria-owns | Identifies an element to define a visual, functional, or contextual parent/child relationship between DOM elements when the DOM hierarchy cannot represent the relationship. In the Rich Text Editor, the attribute contains the ID of the Rich Text Editor to indicate the popup as a child element. |

For more details on Toolbar ARIA attributes, refer to the [`Accessibility of Toolbar`](../toolbar/accessibility) documentation.

* The Rich Text Editor element is assigned the role of `application`.

| **Property** | **Functionalities** |
| --- | --- |
| role="application" | This attribute added to the Rich Text Editor element describes the actual role of the element. |
| aria-disabled | Indicates the disabled state of the Rich Text Editor. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Keyboard Navigation

The Rich Text Editor control followed the [keyboard interaction](https://www.w3.org/WAI/ARIA/apg/patterns/alert/#keyboardinteraction) guideline, making it easy for people who use assistive technologies (AT) and those who completely rely on keyboard navigation. The following keyboard shortcuts are supported by the Rich Text Editor control.

For more details on keyboard navigation, refer to the [Keyboard support](https://ej2.syncfusion.com/aspnetcore/documentation/markdown-editor/keyboard-support) documentation.

## Ensuring accessibility

The Rich Text Editor control's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Rich Text Editor control is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/rich-text-editor.html) in a new window to evaluate the accessibility of the Rich Text Editor control with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/rich-text-editor.html" %}

## See Also

* [General Accessibility Guidelines](../common/accessibility)
