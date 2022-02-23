---
title: "Accessibility"
component: "Gantt"
description: "Documentation on accessibility in the Essential JS 2 Gantt control, featuring WAI-ARIA standards and keyboard navigation."
---

# Accessibility

Accessibility is achieved in the Gantt component through the WAI-ARIA standard and keyboard navigations. The Gantt features can be effectively accessed through assistive technologies such as screen readers. It is also available with a built-in keyboard navigation support; it makes accessibility easier for the people who use assistive technologies or who completely rely on the Keyboard support.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with Ajax, HTML, JavaScript, and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components. It helps to provide information about elements in a document for assistive technology.

The following ARIA attributes are used in Gantt:

| **Attributes** | **Description** |
| --- | --- |
| grid (role) | This attribute is added to the `e-table` element present in the Gantt, which represents Grid part |
| gridcell (role) | This attribute is added to the `td` elements present within the `e-table`, which represents the work cells of Gantt |
| columnheader (role) | This attribute is added to the `th` elements within the `e-table`, which represents the header cells of Grid table |
| separator (role) | This attribute is added to the `e-split-bar` element, which represents the splitter between the Grid table and Chart |
| dialog (role) | This attribute is added to the `e-dialog` element, which represents the pop-up dialog |
| toolbar (role) | This attribute is added to the `e-gantt-toolbar` element, which represents the toolbars of Gantt |
| aria-label | It indicates the element's information`<br>` It is assigned to the Gantt UI elements such as timeline cell, taskbar, left label, right label, dependency line, and event markers. |
| aria-selected | This attribute is assigned to the Gantt chart row, and it defaults to `false`. The value is changed to `true` when the user selects a grid cell or task |
| aria-expanded | This attribute is assigned to the Gantt chart parent task row. The value is changed to `true` when the user clicks a parent taskbar to expand. After the user clicked a parent taskbar to collapse, the attribute value is changed to `false` |
| aria-grabbed | This attribute is assigned to the taskbars of Gantt when the user tries to achieve taskbar editing |

## Keyboard navigation

Gantt functionalities can be interactive with keyboard shortcuts.

The following keyboard shortcuts are supported by Gantt.

Interaction Keys |Description
-----|-----
<kbd>Home</kbd> |Selects the first row.
<kbd>End</kbd> |Selects the last row.
<kbd>DownArrow</kbd> |Moves the cell focus/row or cell selection downward.
<kbd>UpArrow</kbd> |Moves the cell focus/row or cell selection upward.
<kbd>LeftArrow</kbd> |Moves the cell focus/row or cell selection left side.
<kbd>RightArrow</kbd> |Moves the cell focus/row or cell selection right side.
<kbd>Ctrl + Up Arrow</kbd> |Collapses all tasks.
<kbd>Ctrl + Down Arrow</kbd> |Expands all tasks.
<kbd>Ctrl + Shift + Up Arrow</kbd> |Collapses the selected row.
<kbd>Ctrl + Shift + Down Arrow</kbd> |Expands the selected row.
<kbd>Enter</kbd> |Saves request.
<kbd>Esc</kbd> |Cancels request.
<kbd>Insert</kbd> |Adds a new row.
<kbd>Ctrl + Insert</kbd> |Opens addRowDialog.
<kbd>Ctrl + F2</kbd> |Opens editRowDialog.
<kbd>Delete</kbd> |Deletes the selected row.
<kbd>Shift + F5</kbd> |FocusTask
<kbd>Ctrl + Shift + F</kbd> |Focus search
<kbd>Shift + DownArrow</kbd> |Extends the row/cell selection downwards.
<kbd>Shift + UpArrow</kbd> |Extends the row/cell selection upwards.
<kbd>Shift + LeftArrow</kbd> |Extends the cell selection to the left side.
<kbd>Shift + RightArrow</kbd> |Extends the cell selection to the right side.