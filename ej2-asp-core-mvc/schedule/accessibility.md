---
layout: post
title: Accessibility in ##Platform_Name## Schedule Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

Accessibility is achieved in the Schedule component through WAI-ARIA standard and keyboard navigation. The Schedule features can be effectively accessed through assistive technologies such as screen readers.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with Ajax, HTML, JavaScript,and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

The following ARIA attributes are used in the Schedule:

| Property | Functionalities |
|-------|---------|
| role | It  gives assistive technologies about how to handle each element in a widget. |
| aria-disabled | It indicates the disabled state of the Schedule. |
| aria-selected | It indicates the currently selected cell of the Schedule. |
| aria-live | It indicates a string value that labels the Schedule element. |
| aria-label | It indicates the disabled state of the Schedule and its items. |
| aria-labelledby | It indicates editor dialog title to the user through assistive technologies. |
| aria-describedby | It indicates editor dialog content description to the user through assistive technologies. |

## Keyboard navigation

All the Schedule actions can be controlled via keyboard keys and is availed by using `allowKeyboardInteraction` property which is set to true by default. The applicable key combinations and its relative functionalities are listed below.

Interaction Keys |Description
-----|-----
<kbd>Alt</kbd> + <kbd>j</kbd> |Focuses the Schedule [Provided from application end].
<kbd>Tab</kbd> |Focuses the first or active item on the schedule header bar and then move the focus to the next available event elements. If no events present, then focus moves out of the component.
<kbd>Shift</kbd> + <kbd>Tab</kbd> |Reverse focusing of the Tab functionality. Inverse focusing of event elements from the last one and then move onto the first or active item on Schedule header bar and then moves out of the component.
<kbd>Enter</kbd> |Opens the quick popup on the selected cells or events.
<kbd>Escape</kbd> |Closes any of the popup that are in open state.
<kbd>Arrow</kbd> |To move onto the next available cells in either of the needed directions (left, right, top and right)
<kbd>Shift</kbd> + <kbd>Arrow</kbd> |For multiple cell selection on either direction.
<kbd>Delete</kbd> |Deletes one or more selected events.
<kbd>Ctrl</kbd> + <kbd>Click</kbd> on events |To select multiple events.
<kbd>Alt</kbd> + <kbd>Number</kbd> (from 1 to 6) |To switch between the views on Schedule.
<kbd>Ctrl</kbd> + <kbd>Left Arrow</kbd> |To navigate to the previous date period.
<kbd>Ctrl</kbd> + <kbd>Right Arrow</kbd> |To navigate to the next date period.
<kbd>Left</kbd> or <kbd>Right Arrow</kbd> |On pressing any of these keys when focus is currently on the Schedule header bar, moves the focus to the previous or next items in the header bar.
<kbd>Space</kbd> or <kbd>Enter</kbd> |It activates any of the focused items.
<kbd>Page Up</kbd> & <kbd>Page Down</kbd> |To scroll through the work cells area.
<kbd>Home</kbd> |To move the selection to the first cell of Schedule.