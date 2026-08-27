---
layout: post
title: Accessibility in ##Platform_Name## Dialog | Syncfusion
description: Syncfusion ##Platform_Name## Dialog follows WCAG 2.2, Section 508, and ADA standards with screen reader, keyboard, and right-to-left support.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ASP.NET MVC Dialog

The Dialog component follows the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Dialog component is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2 Support](../common/accessibility#accessibility-standards) | AA |
| [Section 508 Support](../common/accessibility#accessibility-standards) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Screen Reader Support](../common/accessibility#screen-reader-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Right-To-Left Support](../common/accessibility#right-to-left-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Color Contrast](../common/accessibility#color-contrast) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Mobile Device Support](../common/accessibility#mobile-device-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Keyboard Navigation Support](../common/accessibility#keyboard-navigation-support) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Accessibility Checker Validation](../common/accessibility#ensuring-accessibility) | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the component meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the component do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The component does not meet the requirement.</div>

## WAI-ARIA attributes

The Dialog is characterized by complete ARIA accessibility support, which makes it accessible to screen readers and other assistive technology devices. This component is designed with reference to the guidelines given in [WAI-ARIA Accessibility Practices](https://www.w3.org/WAI/ARIA/apg/).

The Dialog control uses the `dialog` role and the following ARIA properties on its element based on its state.

| **Property** | **Functionalities** |
| --- | --- |
| aria-describedby | It indicates the Dialog content description is notified to the user through assistive technologies. |
| aria-labelledby | The Dialog title is notified to the user through assistive technologies. |
| aria-modal | For modal dialogs its value is `true` and for non-modal dialogs its value is `false` |
| aria-grabbed | Enable the draggable Dialog and starts dragging it is value is true and stopping the drag its value is false |

## Keyboard interaction

The keyboard interaction of the Dialog control is designed based on [WAI-ARIA Practices](https://www.w3.org/WAI/ARIA/apg/) described for Dialog. Users can use the following shortcut keys to interact with the Dialog.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Esc</kbd></td><td>
Closes the Dialog. This functionality can be controlled by using
<a href="https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape" target="_blank" aria-label="closeOnEscape"> `closeOnEscape`</a></td></tr>
<tr>
<td>
<kbd>Enter</kbd></td><td>
When a Dialog button or any input element (except a text area) is in focus, pressing the Enter key triggers the click event associated with the primary button. The Enter key does not trigger the primary button when the Dialog content contains a text area with initial focus.</td></tr>
<tr>
<td>
<kbd>Ctrl + Enter</kbd></td><td>
When the Dialog content contains a text area and it is in focus, pressing Ctrl+Enter calls the click event function associated with the primary button.</td></tr>
<tr>
<td>
<kbd>Tab</kbd></td><td>
Moves focus between focusable elements inside the Dialog.</td></tr>
<tr>
<td>
<kbd>Shift + Tab</kbd></td><td>
Moves focus to the previous focusable element inside the Dialog. When the first focusable element has focus, Shift+Tab moves focus to the last focusable element.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Ensuring accessibility

The Dialog component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Dialog component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/dialog.html) in a new window to evaluate the accessibility of the Dialog component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/dialog.html" %}

## See also

* [Show Dialog with full-screen](https://ej2.syncfusion.com/aspnetmvc/documentation/dialog/how-to/show-dialog-with-full-screen)
* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## components](https://ej2.syncfusion.com/aspnetmvc/documentation/common/accessibility)