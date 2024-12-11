---
layout: post
title: Accessiblility in Syncfusion ##Platform_Name## Kanban Control
description: Learn here all about Accessiblility in Syncfusion ##Platform_Name## Kanban control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessiblility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ASP.NET Core Kanban control

The Kanban control has been designed, keeping in mind the WAI-ARIA specifications, and applies the WAI-ARIA roles, states, and properties. This control is characterized by complete ARIA accessibility support that makes it easy for people who use assistive technologies (AT) or those who completely rely on keyboard navigation.

The accessibility compliance for the Kanban control is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| WCAG 2.2 Support | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| [Section 508 Support](../common/accessibility#accessibility-standards) | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| Screen Reader Support | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| Right-To-Left Support | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| Color Contrast | ![Intermediate](https://cdn.syncfusion.com/content/images/documentation/partial.png) |
| Mobile Device Support | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| [Keyboard Navigation Support](../common/accessibility#keyboard-navigation-support) | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |
| Accessibility Checker Validation | ![Intermediate](https://cdn.syncfusion.com/content/images/documentation/partial.png) |
| Axe-core Accessibility Validation | ![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
![Yes](https://cdn.syncfusion.com/content/images/documentation/full.png) - All features of the control meet the requirement.

![Intermediate](https://cdn.syncfusion.com/content/images/documentation/partial.png)  - Some features of the control do not meet the requirement.

![No](https://cdn.syncfusion.com/content/images/documentation/not-supported.png)  - The control does not meet the requirement.

## WAI-ARIA attributes

The Kanban control followed the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/alert/) patterns to meet the accessibility. The following ARIA attributes are used in the Kanban control:

| Attributes | Purpose |
| --- | --- |
| `aria-label` |  It helps to provides information about elements in a kanban control for assistive technology. |
| `aria-expanded` | Attributes indicate the state of a collapsible element. |
| `aria-selected` | This attribute is assigned to the Kanban control for the selection of elements, and its default value is `false`. The value changes to true when the user selects a Kanban card. |
| `aria-grabbed` | Indicates whether the attribute is set to true. It has been selected for dragging. If this attribute is set to false, the element can be grabbed for a drag-and-drop operation but will not be currently grabbed. |
| `aria-describedby` | This attribute contains the ID of the Kanban header column to indicate that the attribute establishes an association between the Kanban header column and the Kanban column body. |
| `aria-roledescription` | This attribute is assigned to the Kanban control and is used to provide alternative descriptions for card elements. |

## Keyboard interaction

The Kanban control followed the [keyboard interaction](https://www.w3.org/WAI/ARIA/apg/patterns/alert/#keyboardinteraction) guideline, making it easy for people who use assistive technologies (AT) and those who completely rely on keyboard navigation. The following keyboard shortcuts are supported by the Kanban control.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Home</kbd> | To select the first card in the kanban |
| <kbd>End</kbd> | To select the last card in the kanban |
| <kbd>Arrow Up</kbd> | Select the card through the up arrow |
| <kbd>Arrow Down</kbd> | Select the card through the down arrow |
| <kbd>Arrow Right</kbd> | Move the column selection to the right |
| <kbd>Arrow Left</kbd> | Move the column selection to the left |
| <kbd>Ctrl</kbd> + <kbd>Enter</kbd> | Used to select the multi cards |
| <kbd>Ctrl</kbd> + <kbd>Space</kbd> | Used to select the multi cards |
| <kbd>Shift</kbd> + <kbd>Arrow Up</kbd> | Used to select the multiple cards towards up |
| <kbd>Shift</kbd> + <kbd>Arrow Down</kbd> | Used to select the multiple cards towards down |
| <kbd>Shift</kbd> + <kbd>Tab</kbd> | Reverse order of the tab action |
| <kbd>Enter</kbd> | Open the selected cards |
| <kbd>Tab</kbd> | To navigate the Kanban column |
| <kbd>Delete</kbd> | To delete the selected cards |
| <kbd>ESC</kbd> | Escape from the modified details |
| <kbd>Space</kbd> | Used to open the card edit dialog based on the column selection |

## Disable keyboard interaction

Disables all the functionalities in the Kanban board performed using keyboard by setting the `AllowKeyboard` properties to `False`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/keyboard-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/keyboard-disable/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/keyboard-disable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/keyboard-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/keyboard-disable/datasource.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/kanban/keyboard-disable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Ensuring accessibility

The Kanban control accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Kanban control is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/kanban.html) in a new window to evaluate the accessibility of the Kanban control with accessibility tools.

{% previewsample "<https://ej2.syncfusion.com/accessibility/kanban.html>" %}

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core control](../common/accessibility)