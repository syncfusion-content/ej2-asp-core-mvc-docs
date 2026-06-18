---
layout: post
title: Accessibility in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in ##Platform_Name## Gantt component

The [ASP.NET Core Gantt Chart](https://www.syncfusion.com/aspnet-core-ui-controls/gantt-chart) component followed the accessibility guidelines and standards, including [ADA](https://www.ada.gov/), [Section 508](https://www.section508.gov/), [WCAG 2.2](https://www.w3.org/TR/WCAG22/) standards, and [WCAG roles](https://www.w3.org/TR/wai-aria/#roles) that are commonly used to evaluate accessibility.

The accessibility compliance for the Gantt component is outlined below.

| Accessibility Criteria | Compatibility |
| -- | -- |
| [WCAG 2.2](https://www.w3.org/TR/WCAG22/) Support | AA |
| [Section 508](https://www.section508.gov/) Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Screen Reader Support | <img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> |
| Right-To-Left Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Color Contrast | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Mobile Device Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| Keyboard Navigation Support | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |
| [Accessibility Checker](https://www.npmjs.com/package/accessibility-checker) Validation | <img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> |

<style>
    .post .post-content img {
        display: inline-block;
        margin: 0.5em 0;
    }
</style>
<div><img src="https://cdn.syncfusion.com/content/images/documentation/full.png" alt="Yes"> - All features of the component meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/partial.png" alt="Intermediate"> - Some features of the component do not meet the requirement.</div>

<div><img src="https://cdn.syncfusion.com/content/images/documentation/not-supported.png" alt="No"> - The component does not meet the requirement.</div>

## WAI-ARIA attributes

The Gantt component followed the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns) patterns to meet the accessibility. The following ARIA attributes are used in the Gantt component:

The following ARIA attributes are used in Gantt:

| Attributes | Purpose |
| --- | --- |
| `grid (role)` | This attribute is added to the `e-table` element present in the Gantt, which represents Grid part |
| `gridcell (role)` | This attribute is added to the `td` elements present within the `e-table`, which represents the work cells of Gantt |
| `columnheader (role)` | This attribute is added to the `th` elements within the `e-table`, which represents the header cells of Grid table |
| `separator (role)` | This attribute is added to the `e-split-bar` element, which represents the splitter between the Grid table and Chart |
| `dialog (role)` | This attribute is added to the `e-dialog` element, which represents the pop-up dialog |
| `toolbar (role)` | This attribute is added to the `e-gantt-toolbar` element, which represents the toolbars of Gantt |
| `aria-label` | It indicates the element's information`<br>` It is assigned to the Gantt UI elements such as timeline cell, taskbar, left label, right label, dependency line, and event markers. |
| `aria-selected` | This attribute is assigned to the Gantt chart row, and it defaults to `false`. The value is changed to `true` when the user selects a grid cell or task |
| `aria-expanded` | This attribute is assigned to the Gantt chart parent task row. The value is changed to `true` when the user clicks a parent taskbar to expand. After the user clicked a parent taskbar to collapse, the attribute value is changed to `false` |
| `aria-grabbed` | This attribute is assigned to the taskbars of Gantt when the user tries to achieve taskbar editing |

The Syncfusion ##Platform_Name## Gantt Chart component is structured using a combined TreeGrid and chart architecture for rendering its grid (table) and timeline sections. To enhance accessibility for screen readers, roles and ARIA attributes are incorporated for the treegrid parent and all its child elements. Although this architectural approach may have some limitations with accessibility checker tools, it is important to note that these limitations do not affect the readability or usability of the Gantt content in screen readers.

The accessibility checker tools highlight the following known issues:

* The `<table>` element with `role="presentation"` or `role="none"` contains structural elements such as `<th>`.
* Verify that the table is not being used solely to format text content in columns unless the table can be properly linearized.  
* Content is not placed within a landmark element.  
* Verify that the `<div>` element with `role="grid"` provides proper keyboard access.  
* The element with `role="grid"` contains child elements with roles such as `"generic"` and `"textbox"`, which are not allowed. Only `"row"` or `"rowgroup"` roles are permitted as direct children.  
* Interactive component with ARIA role `treegrid` does not have a programmatically associated accessible name.  
* None of the descendant elements with `role="row"` are tabbable.  
* The explicitly assigned ARIA role `"rowgroup"` is redundant with the implicit role of the `<tbody>` element.  
* The explicitly assigned ARIA role `"row"` is redundant with the implicit role of the `<tr>` element.  
* The explicitly assigned ARIA role `"gridcell"` is redundant with the implicit role of the `<td>` element.  
* The tabbable element with role `"columnheader"` is not a widget role.  
* The explicitly assigned ARIA role `"columnheader"` is redundant with the implicit role of the `<th>` element.  
* The element with `role="rowgroup"` does not contain required child elements with role `"row"`.  
* The ARIA attribute `aria-valuenow` is not valid for a `<div>` element with `role="separator"`.  
* The `cellspacing` attribute is deprecated for the `<table>` element in HTML5.  
* The ARIA attribute `aria-label` is not valid for a `<div>` element with `role="term"`.  
* The ARIA attribute `aria-label` is not valid for a `<div>` element with the implicit `"generic"` role.

## Keyboard navigation

The Gantt component follows the [keyboard interaction](https://www.w3.org/WAI/ARIA/apg/patterns) guideline, ensuring accessibility for users of assistive technologies (AT) and those who rely solely on keyboard navigation. The following keyboard shortcuts are supported by the Gantt component:

| **Press** | **To do this** |
| --- | --- |
| <kbd>Alt + J</kbd> | Focus Gantt component. |
| <kbd>Tab / Shift + Tab</kbd> | Focus the next or previous element. |
| <kbd>Home</kbd> | Selects the first row. |
| <kbd>End</kbd> | Selects the last row. |
| <kbd>DownArrow</kbd> | Moves the row selection downward. |
| <kbd>UpArrow</kbd> | Moves the row  selection upward. |
| <kbd>LeftArrow</kbd> | Moves the cell focus/cell selection left side. |
| <kbd>RightArrow</kbd> | Moves the cell focus/cell selection right side. |
| <kbd>Ctrl + Up Arrow</kbd> | Collapses all tasks. |
| <kbd>Ctrl + Down Arrow</kbd> | Expands all tasks. |
| <kbd>Ctrl + Shift + Up Arrow</kbd> | Collapses the selected row. |
| <kbd>Ctrl + Shift + Down Arrow</kbd> | Expands the selected row. |
| <kbd>Enter</kbd> | Saves request. |
| <kbd>Esc</kbd> | Cancels request. |
| <kbd>Insert</kbd> | Adds a new row. |
| <kbd>Ctrl + Insert</kbd> | Opens addRowDialog. |
| <kbd>Ctrl + F2</kbd> | Opens editRowDialog. |
| <kbd>Delete</kbd> | Deletes the selected row. |
| <kbd>Shift + F5</kbd> | FocusTask |
| <kbd>Ctrl + Shift + F</kbd> | Focus search |
| <kbd>Shift + DownArrow</kbd> | Extends the cell selection downwards. |
| <kbd>Shift + UpArrow</kbd> | Extends the cell selection upwards. |
| <kbd>Shift + LeftArrow</kbd> | Extends the cell selection to the left side. |
| <kbd>Shift + RightArrow</kbd> | Extends the cell selection to the right side. |
| <kbd>Ctrl + Z</kbd> | Undo the last action. |
| <kbd>Ctrl + Y</kbd> | Redo the last action. |

**Navigate between toolbar items using keyboard**

In the Gantt component, follow these steps to navigate between toolbar items using the keyboard:

**Step 1**: Press `ALT + J` to focus on the gantt component.
**Step 2**: Press the `Tab` key to navigate to the first item in the toolbar.
**Step 3**: Use the `LeftArrow` or `RightArrow` keys to move between toolbar items.
**Step 4**: Press `Tab` key again to remove focus from the toolbar and return focus to the Gantt component.

## Ensuring accessibility

The Gantt component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Gantt component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/gantt.html) in a new window to evaluate the accessibility of the Gantt component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/gantt.html" %}

## See also

* [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> ##Platform_Name## components](../common/accessibility)
