---
title: "Accessibility"
component: "TimePicker"
description: "Time picker component support accessibility that helps to access all the features through the keyboard, on-screen readers, or other assertive technology devices."
---

# Accessibility

The web accessibility makes web applications and its content more accessible to people with disabilities
without any barriers. It especially
it tracks the dynamic value changes and DOM changes.

The TimePicker control has covered the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices)
specifications with the following list of WAI-ARIA
attributes: `aria-haspopup`, `aria-selected`, `aria-disabled`, `aria-activedescendant`,
`aria-expanded`, `aria-owns`, and `aria-autocomplete`.

Here in TimePicker, the `combobox` plays the role of input element, and the `listbox` plays the role of popup element.

* **Aria-haspopup**: Provides the information about whether this element display a pop-up window or not.

* **Aria-selected**: Indicates the current selected value of the TimePicker control.

* **Aria-disabled**: Indicates disabled state of the TimePicker control.

* **Aria-expanded**: Indicates the expanded state of the popup.

* **Aria-autocomplete**: Indicates whether user input completion suggestions are provided or not.

* **Aria-owns**: Attribute that creates a parent/child relationship between two DOM element in the accessibility layer.

* **Aria-activedescendent**: Attribute that helps in managing the current active child of the TimePicker control.

* **Role**: Attribute that gives assistive technology information for handling each element in a widget.

## Keyboard Interaction

Keyboard accessibility is one of the most important aspects of web accessibility. Disabled people like blind and those who have motor disabilities or birth defects use keyboard shortcuts more than the mouse.

The TimePicker control has built-in keyboard accessibility support by following the
[WAI-ARIA practices](http://www.w3.org/WAI/PF/aria-practices).

> It supports the following list of shortcut keys to interact with the TimePicker control.

| **Press** | **To do this** |
| --- | --- |
| <kbd>Upper Arrow</kbd> | Navigate and select the previous item. |
| <kbd>Down Arrow</kbd> | Navigate and select the next item. |
| <kbd>Left Arrow</kbd> | Move the cursor towards arrow key pressed direction. |
| <kbd>Right Arrow</kbd> | Move the cursor towards arrow key pressed direction. |
| <kbd>Home</kbd> | Navigate and select the first item. |
| <kbd>End</kbd> | Navigate and select the last item. |
| <kbd>Enter</kbd> | Select the currently focused item and close the popup. |
| <kbd>Alt + Upper Arrow</kbd> | Close the popup. |
| <kbd>Alt + Down Arrow</kbd> | Open the popup. |
| <kbd>Esc</kbd> | Close the popup. |

In the below sample use the `alt+t` keys to focus the TimePicker control.

{% aspTab template="timepicker/accessibility" %}

{% endaspTab %}