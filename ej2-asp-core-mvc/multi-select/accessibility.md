---
layout: post
title: Accessibility in ##Platform_Name## Multi Select Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The MultiSelect control has been designed, keeping in mind the `WAI-ARIA` specifications, and applies
the WAI-ARIA roles, states, and properties along with `keyboard support`. This control is characterized
by complete keyboard interaction support and ARIA accessibility support that makes it easy for people who
use assistive technologies (AT) or those who completely rely on keyboard navigation.

## ARIA attributes

The MultiSelect control uses the `Listbox` role, and each list item has an `option` role. The following
`ARIA attributes` denote the MultiSelect state.

| **Properties** | **Functionalities** |
| --- | --- |
| aria-haspopup | Indicates whether the MultiSelect input element has a popup list or not. |
| aria-expanded | Indicates whether the popup list has expanded or not. |
| aria-selected | Indicates the selected option. |
| aria-readonly | Indicates the readonly state of the MultiSelect element. |
| aria-disabled | Indicates whether the MultiSelect control is in a disabled state or not. |
| aria-activedescendent | This attribute holds the ID of the active list item  to focus its descendant child element. |
| aria-owns | This attribute contains the ID of the popup list to indicate popup as a child element. |

## Keyboard interaction

You can use the following key shortcuts to access the MultiSelect without interruptions.

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Arrow Down</kbd> | Set focus at the first item in the MultiSelect when no item selected. Otherwise, moves focus next to the currently selected item. |
| <kbd>Arrow Up</kbd> | Moves focus previous to the currently selected one. |
| <kbd>Page Down</kbd> | Scrolls down to the next page and set focus to the first item when popup list opens. |
| <kbd>Page Up</kbd> | Scrolls up to the previous page and set focus to the first item when popup list opens. |
| <kbd>Enter</kbd> | Selects the focused item, and popup list closes when it is in open state. |
| <kbd>Tab</kbd> | Focuses on the next TabIndex element on the page when the popup is closed. Otherwise, closes the popup list and remains the focus of the control. |
| <kbd>Shift + tab </kbd> | Focuses on the previous TabIndex element on the page when the popup is closed. Otherwise, closes the popup list and remains the focus of the control. |
| <kbd>Alt + Down</kbd> | Opens the popup list. |
| <kbd>Alt + Up</kbd> | Closes the popup list. |
| <kbd>Esc(Escape)</kbd> | Closes the popup list when it is in an open state and the currently selected item remains the same. |
| <kbd>Home</kbd> | set focus to the first item. |
| <kbd>End</kbd> | set focus to the last item. |

> In the below sample, focus the MultiSelect control using <kbd>alt+t</kbd> keys.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/multiselect/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/multiselect/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


