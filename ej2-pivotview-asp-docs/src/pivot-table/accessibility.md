---
title: "Accessibility"
component: "Pivot Table"
description: "Pivot Table provides access to all the features through keyboard, on-screen reader, or other assertive technology devices."
---

# Accessibility

Accessibility is achieved in the pivot table component through WAI-ARIA standard and keyboard navigation. The pivot table features can be effectively accessed through assistive technologies such as screen readers.

## WAI-ARIA

WAI-ARIA (Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with Ajax, HTML, JavaScript,and related technologies. ARIA provides additional semantics to describe the role, state, and functionality of web components.

The following ARIA attributes are used in the pivot table:

* grid (role)
* row (role)
* gridcell (role)
* aria-selected (attribute)
* aria-expanded (attribute)
* aria-sort (attribute)
* aria-busy (attribute)
* aria-invalid (attribute)
* aria-grabbed (attribute)
* aria-owns (attribute)
* aria-label (attribute)

## Keyboard Navigation

All the pivot table actions can be controlled via keyboard keys. The applicable key combinations and their relative functionalities are listed below for the appropriate UI features available in the component.

### Pivot Table

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves the cell focus right side. If no cells are focused, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves the cell focus left side. If no cells are focused, it moves to the previous active element in the browser page.
<kbd>DownArrow</kbd> |Moves the cell focus downwards. If the selection is enabled in the pivot table, then it will move downwards to select next row or column or individual cell.
<kbd>UpArrow</kbd> |Moves the cell focus upwards. If the selection is enabled in the pivot table, then it will move upwards to select previous row or column or individual cell.
<kbd>LeftArrow</kbd> |Moves the cell focus left side. If the selection is enabled in the pivot table, then it will move left side to select previous row or column or individual cell.
<kbd>RightArrow</kbd> |Moves the cell focus right side. If the selection is enabled in the pivot table, then it will move right side to select next row or column or individual cell.
<kbd>Shift + DownArrow</kbd> |Extends the cell selection downwards.
<kbd>Shift + UpArrow</kbd> |Extends the cell selection selection upwards.
<kbd>Shift + LeftArrow</kbd> |Extends the cell selection to the left side.
<kbd>Shift + RightArrow</kbd> |Extends the cell selection to the right side.
<kbd>Ctrl + A</kbd> |Selects all cells.
<kbd>Esc</kbd> |Deselects all cells. If the current active element is a context menu, then the context menu popup will be closed.
<kbd>Home</kbd> |Goes to the first cell in the current row.
<kbd>End</kbd> |Goes to the last cell in the current row.
<kbd>Ctrl + Home</kbd> |Goes to the first cell in the table.
<kbd>Ctrl + End</kbd> |Goes to the last cell in the table.
<kbd>Enter</kbd> |If the current cell is an expand/collapse cell, it performs expand/collapse operation (drill operation). If the current row/column header is in value sort state, it performs value sorting. If the current cell is in selection state, it moves to the next row, column or individual cell. If drill-through or editing is enabled in the pivot table, the drill-through dialog will be opened based on the selected value cell. If the current active element is a context menu popup, menu selection will be performed.
<kbd>Shift + Enter</kbd> |If value sorting is enabled in the pivot table and the current cell is a header with respect to its value axis, it performs value sorting to either ascending or descending order. If the current cell is in selection state, it moves to the previous row, column or individual cell.
<kbd>Ctrl + Enter</kbd> |If hyperlink is enabled in the current cell, it performs hyperlink selection.
<kbd>Shift + F10</kbd> or <kbd>Menu</kbd> |If context menu is enabled in the pivot table, the context menu popup will be opened in the current cell.

### Field List

Interaction Keys |Description
-----|-----
<kbd>Shift + Ctrl + F</kbd> |If the popup field list is enabled in either the pivot table or the pivot chart, the field list dialog will be opened.
<kbd>Tab</kbd> |Moves to the next active element in the field list. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the field list. If no active elements present, it moves to the previous active element in the browser page.
<kbd>Shift + F</kbd> |If the current active element is a field's button and if it has a filter icon, the filter dialog will open to perform filtering.
<kbd>Shift + S</kbd> |If the current active element is a field's button and if it has a sort icon, the sorting will be performed to the selected field.
<kbd>Shift + E</kbd> |If the current active element is a calculated field's button and if it has an edit icon, the calculated field dialog will be opened to perform editing the selected calculated field.
<kbd>Enter</kbd> |Performs the selection operation of the current active element. If the current active element is a field's button and it has a dropdown icon, the aggregation menu will open to perform calculations using aggregation options to the selected value field.
<kbd>Delete</kbd> |If the current active element is a field's button, the selected field will be removed from the current report.
<kbd>DownArrow</kbd> |If the current active element is a tree node, it moves to the next node.
<kbd>UpArrow</kbd> |If the current active element is a tree node, it moves to the previous node.
<kbd>LeftArrow</kbd> |If the current active element is a tree node, it collapses the current node.
<kbd>RightArrow</kbd> |If the current active element is a tree node, it expands the current node.
<kbd>Home</kbd> |If the current active element is a tree node, it goes to the first node.
<kbd>End</kbd> |If the current active element is a tree node, it goes to the last node.
<kbd>Space</kbd> |If the current active element is a tree node or a checkbox element, it will be either checked or unchecked.
<kbd>Esc or Escape</kbd> |Closes the popup field list dialog.

### Grouping Bar

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next active element (field's button) in the grouping bar. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element (field's button) in the grouping bar. If no active elements present, it moves to the previous active element in the browser page.
<kbd>Shift + F</kbd> |If the current active element is a field's button and if it has a filter icon, the filter dialog will be opened to perform filtering.
<kbd>Shift + S</kbd> |If the current active element is a field's button and if it has a sort icon, the sorting will be performed to the selected field.
<kbd>Shift + E</kbd> |If the current active element is a calculated field's button and if it has an edit icon, the calculated field dialog will be opened to perform editing the selected calculated field.
<kbd>Enter</kbd> |Performs the selection operation of the current active element. If the current active element is a field's button and if it has a dropdown icon, the aggregation menu will be opened to perform calculations using aggregation options to the selected value field.
<kbd>Delete</kbd> |If the current active element is a field's button, the selected field will be removed from the current report.
<kbd>DownArrow</kbd> |If the current active element is a dropdown list, the next item will be selected.
<kbd>UpArrow</kbd> |If the current active element is a dropdown list, the previous item will be selected.
<kbd>Home</kbd> |If the current active element is a dropdown list, the first item will be selected.
<kbd>End</kbd> |If the current active element is a dropdown list, the last item will be selected.
<kbd>Alt + Down</kbd> |If the current active element is a dropdown list, the popup will be opened.
<kbd>Alt + Down</kbd> |If the current active element is a dropdown list, the popup will be closed.
<kbd>Esc or Escape</kbd> |Closes the dropdown list.

### Filter Dialog

Interaction Keys |Description
-----|-----
<kbd>Shift + F</kbd> |If the current active element is a field's button and if it has a filter icon in either the field list or grouping bar UI, the filter dialog will be opened to perform filtering.
<kbd>Tab</kbd> |Moves to the next active element in the filter dialog. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the filter dialog. If no active elements present, it moves to the previous active element in the browser page.
<kbd>DownArrow</kbd> |If the current active element is a tree node, it moves to the next node.
<kbd>UpArrow</kbd> |If the current active element is a tree node, it moves to the previous node.
<kbd>LeftArrow</kbd> |If the current active element is a tree node, it collapses the current node. If the current active element is a tab, it moves focus to the previous tab element.
<kbd>RightArrow</kbd> |If the current active element is a tree node, it expands the current node. If the current active element is a tab, it moves focus to the next tab element.
<kbd>Home</kbd> |If the current active element is a tree node, it goes to the first node.
<kbd>End</kbd> |If the current active element is a tree node, it goes to the last node.
<kbd>Space</kbd> |If the current active element is a tree node or a checkbox element, it will be either checked or unchecked.
<kbd>Alt + Down</kbd> |If the current active element is a DropDownList or DatePicker or DateTimePicker, the popup will be opened.
<kbd>Alt + Up</kbd> |If the current active element is a DropDownList or DatePicker or DateTimePicker, the popup will be closed.
<kbd>Enter</kbd> |Performs the selection operation of the current active element. If the current active element is a tab, the current tab element will be selected. If the current active element is a tree node, the current node will be either checked or unchecked. If the current active element is DropDownList, the focus item will be selected, and the popup list will close when it is open. Otherwise, toggles the popup list.
<kbd>Esc or Escape</kbd> |Closes the filter dialog.

### Calculated Field Dialog

Interaction Keys |Description
-----|-----
<kbd>Shift + E</kbd> |If the current active element is a field's button and if it has an edit icon in either the field list or grouping bar UI, the calculated field dialog will be opened to perform editing the selected calculated field.
<kbd>Tab</kbd> |Moves to the next active element in the calculated field dialog. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the calculated field dialog. If no active elements present, it moves to the previous active element in the browser page.
<kbd>DownArrow</kbd> |If the current active element is a tree node, it moves to the next node.
<kbd>UpArrow</kbd> |If the current active element is a tree node, it moves to the previous node.
<kbd>LeftArrow</kbd> |If the current active element is a tree node, it collapses the current node.
<kbd>RightArrow</kbd> |If the current active element is a tree node, it expands the current node. If the current active element is a tree node and has a menu icon, the aggregation menu will be opened to select appropriate aggregation type to the selected field.
<kbd>Home</kbd> |If the current active element is a tree node, it goes to the first node.
<kbd>End</kbd> |If the current active element is a tree node, it goes to the last node.
<kbd>Enter</kbd> |Performs the selection operation of the current active element. If the current active element is a tree node, it copies the selected field name/formula to the formula text area to perform calculations.
<kbd>Esc or Escape</kbd> |Closes the calculated field dialog.

### Formatting Dialog

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next active element in the formatting dialog. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the formatting dialog. If no active elements present, it moves to the previous active element in the browser page.
<kbd>DownArrow</kbd> |If the current active element is a DropDownList, the next item will be selected.
<kbd>UpArrow</kbd> |If the current active element is a DropDownList, the previous item will be selected.
<kbd>Home</kbd> |If the current active element is a DropDownList, the first item will be selected.
<kbd>End</kbd> |If the current active element is a DropDownList, the last item will be selected.
<kbd>Alt + Down</kbd> |If the current active element is a DropDownList or ColorPicker, the popup will be opened.
<kbd>Alt + Down</kbd> |If the current active element is a DropDownList or ColorPicker, the popup will be closed.
<kbd>Enter</kbd> |Performs the selection operation of the current active element.
<kbd>Esc or Escape</kbd> |Closes the formatting dialog.

### Toolbar

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next active option in the toolbar. If no active elements present, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active option in the toolbar. If no active elements present, it moves to the previous active element in the browser page.
<kbd>Enter</kbd> |Performs the selection operation of the current active element.

### Drill-Through Dialog

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next active element in the drill-through dialog. If the current active element is a Grid cell, it moves the cell focus to right side. If no active elements present, then it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the drill-through dialog. If the current active element is a Grid cell, it moves the cell focus to left side, If no active elements present, then it moves to the previous active element in the browser page.
<kbd>DownArrow</kbd> |Moves the row/cell focus downwards.
<kbd>UpArrow</kbd> |Moves the row/cell focus upwards.
<kbd>LeftArrow</kbd> |Moves the cell focus left side.
<kbd>RightArrow</kbd> |Moves the cell focus right side.
<kbd>Home</kbd> |Goes to the first cell in the current row.
<kbd>End</kbd> |Goes to the last cell in the current row.
<kbd>Ctrl + Home</kbd> |Goes to the first cell in the table.
<kbd>Ctrl + End</kbd> |Goes to the last cell in the table.
<kbd>Enter</kbd> |Performs the selection operation of the current active element.
<kbd>Esc or Escape</kbd> |If the cell is in selected state, the it deselects all rows/cells. If the row/cell is in edit state, it cancels the current entries in the row/cell. If the current active element is not a row/cell, it closes the drill-through dialog.
<kbd>F2</kbd> |Initiate editing a row/cell in the data grid.
<kbd>Insert</kbd> |Adds a new row/cell in the data grid.
<kbd>Delete</kbd> |Removes the selected row in the data grid.

Some commonly used applicable key combinations and their relative functionalities in all dialogs are listed below.

Interaction Keys |Description
-----|-----
<kbd>Tab</kbd> |Moves to the next active element in the dialog. If either no active elements present in the dialog or an overlay is not present in the dialog, it moves to the next active element in the browser page.
<kbd>Shift + Tab</kbd> |Moves to the previous active element in the dialog. If either no active elements present in the dialog or an overlay is not present in the dialog, it moves to the previous active element in the browser page.
<kbd>Space</kbd> |If the current active element is a tree node or a checkbox element, it will be either checked or unchecked.
<kbd>Enter</kbd> |When the Dialog button or any input (except text area) is in focus state, when pressing the <kbd>Enter</kbd> key, the click event associated with the primary button or button will be triggered. The <kbd>Enter</kbd> key will not be worked, when the dialog content contains any text area with initial focus.
<kbd>Esc or Escape</kbd> |Closes the dialog.