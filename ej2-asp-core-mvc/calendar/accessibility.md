---
layout: post
title: Accessibility in ##Platform_Name## Calendar Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The web accessibility makes web content and web applications more accessible for disabled people. It especially helps in dynamic content change and development of advanced user interface controls  with AJAX, HTML, JavaScript, and related technologies.

Calendar provides built-in compliance with
[WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices) specifications. WAI-ARIA support is achieved through attributes like `aria-label`, `aria-selected`, `aria-disabled`, and `aria-activedescendant`
applied for navigation buttons, and disable and active day cells.

It helps disabled persons by providing information about the widget for assistive technology  in the screen readers. Calendar control contains grid role and grid cell for each day cell.

* **Aria-label**: This attribute provides text labels for an object for the previous and next month's elements. It helps the screen reader object to read.

* **Aria-selected**: Indicates the currently selected date of the Calendar control.

* **Aria-disabled**: Indicates the disabled state of the Calendar control.

* **Aria-activedescendent**: Helps in managing the current active child of the Calendar control.

* **Role**: Gives information to assistive technologies about how to handle each element in a widget.

* **Grid-cell**: Defines the individual cell that can be focussed and selected.

## Keyboard interaction

You can use the following keys to interact with the Calendar. This control implements keyboard navigation support by following the [WAI-ARIA practices](http://www.w3.org/WAI/PF/aria-practices).

It supports the following list of shortcut keys:

| **Press** | **To do this** |
| --- | --- |
| <kbd>Upper Arrow</kbd>  | Focuses the same day of the previous week. |
| <kbd>Down Arrow</kbd>  | Focuses the same day of the next week. |
| <kbd>Left Arrow</kbd>  | Focuses the day before. |
| <kbd>Right Arrow</kbd>  | Focuses the next day. |
| <kbd>Home</kbd>  | Focuses the first day of the month. |
| <kbd>End</kbd>  | Focuses the last day of the month. |
| <kbd>Page Up</kbd>  | Focuses the same date of the previous month. |
| <kbd>Page Down</kbd>  | Focuses the same date of the next month. |
| <kbd>Enter</kbd>  | Selects the currently focused date. |
| <kbd>Shift + Page Up</kbd>  | Focuses the same date for the previous year. |
| <kbd>Shift + Page Down</kbd>  | Focuses the same date for the next year. |
| <kbd>Control + Upper Arrow</kbd>  | Moves to the inner level of view like month to year and year to decade. |
| <kbd>Control + Down Arrow</kbd>  | Moves out from the depth level view like decade to year and year to month. |
| <kbd>Control + Home</kbd>  | Focuses the first date of the current year. |
| <kbd>Control + End</kbd>  | Focuses the last date of the current year. |

> To focus the Calendar control, use `alt+t` keys.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/calendar/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/calendar/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

