---
title: "Web Accessibility in Kanban"
component: "Kanban"
description: "This section describes how the Kanban has been built keeping web accessibility in mind, thus allowing to interact with assistive technologies."
---

# Accessibility

## Keyboard interaction

All the Kanban actions can be controlled by keyboard keys using the `AllowKeyboard` property, which is set to `True` by default. The following are the standard keys that work on Kanban:

Keys | Description |
|-----|-----|
| <kbd>Alt</kbd> + <kbd>j</kbd> | Focuses the Kanban element [provided from application end]. |
| <kbd>Home</kbd> | Moves the selection to the first card of Kanban. |
| <kbd>End</kbd> | Moves the selection to the last card of Kanban. |
| <kbd>Left</kbd> or <kbd>Right Arrow</kbd> or <kbd>Page Up</kbd> or <kbd>Page Down</kbd> | Moves the selection to the previous, next, top, or bottom cards in the Kanban board on pressing any of these keys. |
| <kbd>Ctrl</kbd> + <kbd>Up Arrow</kbd> | Collapses all the swimlane rows. |
| <kbd>Ctrl</kbd> + <kbd>Down Arrow</kbd> | Expands all the swimlane rows. |
| <kbd>Ctrl</kbd> + <kbd>Left Arrow</kbd> | Collapses the selected card column. |
| <kbd>Ctrl</kbd> + <kbd>Right Arrow</kbd> | Expands the selected card column. |
| <kbd>Alt</kbd> + <kbd>Up Arrow</kbd> | Collapses the selected card swimlane row. |
| <kbd>Alt</kbd> + <kbd>Down Arrow</kbd> | Expands the selected card swimlane row. |
| <kbd>Shift</kbd> + <kbd>Up Arrow</kbd> | Selects the multiple cards on top direction. [Selects multiple cards within the swimlanes]  |
| <kbd>Shift</kbd> + <kbd>Down Arrow</kbd> | Selects the multiple cards on bottom direction. [Selects multiple cards within the swimlanes] |
| <kbd>Shift</kbd> + <kbd>Left Arrow</kbd> | Selects the multiple cards on left direction. [Selects multiple cards within the swimlanes] |
| <kbd>Shift</kbd> + <kbd>Right Arrow</kbd> | Selects the multiple cards on right direction. [Selects multiple cards within the swimlanes] |

## Disable keyboard interaction

Disables all the functionalities in the Kanban board performed using keyboard by setting the `AllowKeyboard` properties to `False`.

{% aspTab template="kanban/cards/multiple-selection", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}