---
layout: post
title: Wai Aria Accessibility in ##Platform_Name## Uploader Component
description: Learn here all about Wai Aria Accessibility in Syncfusion ##Platform_Name## Uploader component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Wai Aria Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The Uploader component followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Uploader component is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2 Support](../common/accessibility#accessibility-standards) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Section 508 Support](../common/accessibility#accessibility-standards) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Screen Reader Support](../common/accessibility#screen-reader-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Right-To-Left Support](../common/accessibility#right-to-left-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Color Contrast](../common/accessibility#color-contrast) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Mobile Device Support](../common/accessibility#mobile-device-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Keyboard Navigation Support](../common/accessibility#keyboard-navigation-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Accessibility Checker Validation](../common/accessibility#ensuring-accessibility) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Axe-core Accessibility Validation](../common/accessibility#ensuring-accessibility) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the component meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the component do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The component does not meet the requirement.</div>

## Keyboard interaction

The uploader control characterized with complete ARIA accessibility support that helps to be accessible by on-screen readers and other assistive technology devices.

The following are the standard keys that works on uploader control:

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Tab</kbd> | Moves focus to next element. |
| <kbd>Shift + Tab</kbd> | Moves focus to previous element. |
| <kbd>Enter</kbd> | Triggers corresponding action to the button element. |
| <kbd>Esc</kbd> | Closes the file browser dialog alone and cancels the upload on drop the file. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/keyboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Keyboard.cs" %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/keyboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Keyboard.cs" %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Ensuring accessibility

The Uploader component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Uploader component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/uploader.html) in a new window to evaluate the accessibility of the Uploader component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/uploader.html" %}

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## components](../common/accessibility)