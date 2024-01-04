---
layout: post
title: Accessibility in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Maps Component

## WAI-ARIA attributes

To meet accessibility standards, the Maps component follows to the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/alert/) patterns. In the Maps component, the following ARIA attributes are used:

| Attributes | Purpose |
| --- | --- |
| `role=region` | It specifies the Maps areas that do not support interactive functions like selection and highlight. |
| `role=button` | It specifies the Maps areas where interactive functions such as selection and highlight are available. |
| `aria-label` | Provides an accessible name for the Maps container, title, subtitle and legend title. |

## Keyboard Navigation

All the Maps actions can be controlled via keyboard keys. The applicable key combinations and their relative functionalities are listed below for the appropriate UI features available in the component.

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next focusable element on the map, such as the legend or shape.
<kbd>Shift</kbd> + <kbd>Tab</kbd> |Moves to the previous focusable element on the map, such as the legend or shape.
<kbd> + </kbd> |When zooming is enabled, zoom in operation can be performed.
<kbd> - </kbd> |When zooming is enabled, zoom out operation can be performed.
<kbd>Left arrow</kbd> |When zoomed in, the map can be scrolled to the left.
<kbd>Right arrow</kbd> |When zoomed in, the map can be scrolled to the right.
<kbd>Up arrow</kbd> |When zoomed in, the map can be scrolled upward.
<kbd>Down arrow</kbd> |When zoomed in, the map can be scrolled downward.
<kbd> R </kbd> |When zooming is enabled, reset operation can be performed.
<kbd>Enter</kbd> |The page can be navigated to the next and previous states in legend. Similarly, the selection can be made while navigating over the shape.

## Ensuring accessibility

The Maps component's accessibility levels are ensured using an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Maps component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/maps.html) in a new window to evaluate the accessibility of the Maps component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/maps.html" %}

## See also

* [Accessibility in Syncfusion Maps components](../common/accessibility)
