---
layout: post
title: Accessibility in ##Platform_Name## Treeview Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The TreeView control has been designed keeping in mind the `WAI-ARIA` specifications, and applies WAI-ARIA roles, states, and properties along with `keyboard support`. This control is characterized
by complete keyboard interaction support and ARIA accessibility support that makes it easy for people who use assistive technologies (AT) and those who completely rely on keyboard navigation.

## ARIA attributes

The TreeView control uses the `tree` role, and each tree parent node has a `group` role where each node has `treeitem` role. The following ARIA attributes are used in TreeView:

| **Properties** | **Functionalities** |
| --- | --- |
| aria-multiselectable | Indicates whether the TreeView enables multiple selection or not. |
| aria-expanded | Indicates whether the parent node has expanded or not. |
| aria-selected | Indicates the selected node. |
| aria-grabbed | Indicates the selected state on drag-and-drop of node. |
| aria-level | Indicates the level of node in TreeView. |

## Keyboard interaction

The TreeView functionalities can be interactive when keyboard shortcuts are used.

TreeView supports the following keyboard shortcuts.

| Interaction Keys | Description |
|------|---------|
| <kbd>Arrow Up</kbd> | Goes to the previous node. |
| <kbd>Arrow Down</kbd> | Goes to the next node. |
| <kbd>Arrow Right</kbd> | Expands the current node. |
| <kbd>Arrow Left</kbd> | Collapses the current node. |
| <kbd>Home</kbd> | Goes to the first node. |
| <kbd>End</kbd> | Goes to the last node. |
| <kbd>F2</kbd> | Edits the focused node. |
| <kbd>Esc</kbd> | Focuses out the edit state without saving the edited text. |
| <kbd>Enter</kbd> | Selects the focused node/saves the edited text. |
| <kbd>Space</kbd> | Checks the current node. |
| <kbd>Ctrl + A</kbd> | Selects all nodes. |