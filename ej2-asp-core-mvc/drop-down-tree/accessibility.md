---
layout: post
title: Accessibility in ##Platform_Name## DropdownTree | Syncfusion
description: Syncfusion ##Platform_Name## DropdownTree follows WAI-ARIA standards with listbox, group, and treeitem roles plus full keyboard navigation support.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in ##Platform_Name## DropdownTree

The DropdownTree is designed following the WAI-ARIA specifications and applies WAI-ARIA roles, states, and properties, along with keyboard support. This control is characterized by complete keyboard interaction support and ARIA accessibility support that makes it easy for users who use assistive technologies (AT) and those who completely rely on keyboard navigation.

## ARIA attributes

The DropdownTree control uses the `listbox` role. Each tree parent item in the popup has a `group` role and each item in the popup has a `treeitem` role. The following ARIA attributes are used in the DropdownTree control:

| **ARIA Attribute** | **Description** |
| --- | --- |
| aria-haspopup | Indicates whether the DropdownTree input element has a popup list or not. |
| aria-expanded | Indicates whether the popup list is expanded or not. |
| aria-selected | Indicates the selected option. |
| aria-readonly | Indicates the readonly state of the DropdownTree element. |
| aria-disabled | Indicates whether the DropdownTree component is in the disabled state or not. |
| aria-activedescendant | This attribute holds the ID of the active list item to focus its descendant child element. |
| aria-owns | This attribute contains the ID of the popup list to indicate popup as a child element. |

## Keyboard interaction

The DropdownTree functionalities can be used interactively with keyboard shortcuts.

DropdownTree supports the following keyboard shortcuts.

| Interaction Keys | Description |
|------|---------|
| <kbd>Alt + Down</kbd> | Opens the popup. |
| <kbd>Alt + Up</kbd> | Closes the popup. |
| <kbd>Esc(Escape)</kbd> | Closes the popup when it is in an open state. |
| <kbd>Arrow Up</kbd> | Goes to the previous item in the popup. |
| <kbd>Arrow Down</kbd> | Goes to the next item in the popup. |
| <kbd>Arrow Right</kbd> | Expands the current item. |
| <kbd>Arrow Left</kbd> | Collapses the current item in the popup. |
| <kbd>Home</kbd> | Goes to the first item in the popup. |
| <kbd>End</kbd> | Goes to the last item in the popup. |
| <kbd>Enter</kbd> | Selects the focused item in the popup. |
| <kbd>Space</kbd> | Checks the current item in the popup. |
