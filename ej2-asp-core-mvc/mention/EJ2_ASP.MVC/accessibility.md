---
layout: post
title: Accessibility in ##Platform_Name## Mention Component | Syncfusion
description: Learn here all about accessibility in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in Mention component

Web accessibility makes web contents and applications more accessible to people with disabilities. The Mention control provides built-in compliance with `WAI-ARIA` specifications. The `WAI-ARIA` support is achieved using attributes such as `aria-selected` and `aria-activedescendent`.

## ARIA attributes

The Mention control uses the `Listbox` role where each list item has an `option` role. The following `ARIA attributes` denote the Mention state.

| **Properties** | **Functionalities** |
| --- | --- |
| aria-selected | Indicates the selected option.|
| aria-activedescendent | This attribute holds the ID of the active list item  to focus its descendant child element. |
| aria-owns | This attribute contains the ID of the popup list to indicate popup as a child element. |

## Keyboard interaction

You can use the following key shortcuts to access the Mention without interruptions.

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Arrow Down</kbd> | Selects the first item in the Mention list. Otherwise, selects the item next to the currently selected item. |
| <kbd>Arrow Up</kbd> | Selects the item previous to the currently selected one. |
| <kbd>Esc(Escape)</kbd> | Closes the popup list when it is in an open state. |
| <kbd>Enter</kbd> | Selects the focused item, and when it is in an open state the popup list closes. |
| <kbd>Tab</kbd> | Focuses on the next TabIndex element on the page when the popup is closed. Otherwise, inserts the selected popup list item and closes the popup list. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/accessibility/keyboard-intraction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/accessibility/keyboard-intraction/Employees.cs %}
{% endhighlight %}
{% endtabs %}