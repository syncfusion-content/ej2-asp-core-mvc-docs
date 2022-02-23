---
title: "ListView Accessibility"
component: "ListView"
description: "ListView component has accessibility support to help access the features via keyboard, on-screen readers, or other assistive technology devices."
---

# Accessibility

## Keyboard interaction

The following key shortcuts are used to access the ListView component without any interruption.

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Arrow Up</kbd> | Move to the previous list item. |
| <kbd>Arrow Down</kbd> | Move to the next list item. |
| <kbd>Select</kbd> | Select the targeted list from the whole list. |
| <kbd>Back</kbd> | Get back to the previous lists if it is in nested list. |

{% aspTab template="listview/accessibility", sourceFiles="ListController.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core ListView - Accessibility](./images/nestedlist.png)

## ARIA attributes

The following ARIA attributes are applicable for ListView component based on its state.

| Properties | Functionality |
| ------------ | ----------------------- |
| aria-selected | It indicates the selected list from the whole list. |
| aria-level | It defines the hierarchical structure of a list item. |
