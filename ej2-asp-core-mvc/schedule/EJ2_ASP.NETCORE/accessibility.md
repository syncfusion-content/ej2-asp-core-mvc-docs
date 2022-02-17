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

The Scheduler has been designed based on the WAI-ARIA specifications, thus applying the appropriate ARIA roles, states and properties for the Scheduler elements. It is also available with a built-in keyboard navigation support, making it easier for the people who use assistive technologies or who completely rely on the Keyboard support. As per the accessibility standard, the navigated dates, views and other interactive actions performed on the Scheduler will be read out to the target users who use assistive technologies such as screen readers.

The Scheduler makes use of the most required ARIA attributes such as `aria-label` and `role` to support the accessibility in it. To be more accurate, it must be used with an ARIA compliant browser along with the screen reader running from backend.

## ARIA attributes

The Scheduler parent element is assigned with a role of `main`, to denote it as the main content of a component as well as a unique element of the entire document.

The following ARIA attributes are used in the Scheduler.

| Attributes | Description |
|-------|---------|
| role="main" | This attribute added to the Scheduler element describes the actual role of the element and denote it as a main and unique content. |
| aria-label | This attribute is assigned to the Scheduler parent element and its default value is Scheduler's current date. On every time, the date is navigated, this attribute is updated with appropriate current date values. It is also assigned to other scheduler UI elements such as previous and next date navigation buttons depicting its purpose, div element displaying date range in the header bar and appointment elements. |
| role="link" | This attribute is added to the `e-header-date` element of Scheduler, to denote that it plays an anchor link role. |
| role="row" | This attribute is added to the `tr` element present within the `e-content-table` element which holds the collection of work cell `td`s of Scheduler. |
| role="gridcell" | This attribute is assigned to the `td` elements present within the `e-content-table` which represents the work cells of Scheduler. |
| role="button" | This attribute is assigned to the appointments of Scheduler, to denote it as a clickable element. |
| aria-readonly | This attribute is assigned to the appointments of Scheduler and defaults to `false`, which indicates that the appointments are editable by default. When it's value changes to `true`, it denotes that the appointments are in a not editable state. |
| aria-selected | This attribute is assigned to both the work cells as well as appointments of Scheduler and defaults to `false`. The value changes to `true`, when the user selects a cell or an appointment by clicking on it. |
| aria-grabbed | This attribute is assigned to the appointments of Scheduler and defaults to `true`, which indicates that the appointments are allowed to move over the Scheduler. When it's value changes to `false`, it indicates that the drag and drop of appointments are not allowed. |
| aria-disabled | This attribute is assigned to the clickable elements on Scheduler such as previous and next date navigation buttons and view navigation buttons, and defaults to `false`. When changed to true, denotes that those elements on UI are in disabled state. |
| aria-atomic | This attribute is assigned to the date range element displayed on the Scheduler header bar, to indicate that when date change takes place, the entire live region (Scheduler) should be updated to the user. It is set to `true`. |
| aria-live="assertive" | This attribute is assigned to the date range element displayed on the Scheduler header bar, to indicate that it updates the date values frequently on every time the user navigates back and forth between the dates. The value `assertive` means that the newly modified date changes has a high priority, and your screen reader *should* notify you immediately regarding this.

## Keyboard interaction

All the Scheduler actions can be controlled via keyboard keys by using the `allowKeyboardInteraction` property which is set to `true` by default. The following are the standard keys that work on Scheduler.

Keys | Description |
|-----|-----|
| <kbd>Alt</kbd> + <kbd>j</kbd> | Focuses the Scheduler element [provided from application end]. |
| <kbd>Tab</kbd> | Focuses the first or active item on the Scheduler header bar and then move the focus to the next available event elements. If no events present, then focus moves out of the component. |
| <kbd>Shift</kbd> + <kbd>Tab</kbd> | Reverse focusing of the `Tab` key functionality. Inverse focusing of event elements from the last one and then move onto the first or active item on Scheduler header bar and then moves out of the component.
| <kbd>Enter</kbd> | Opens the quick info popup on the selected cells or events. |
| <kbd>Escape</kbd> | Closes any of the popup that are in open state. |
| <kbd>Arrow</kbd> | To move onto the next available cells in either of the needed directions. (left, right, top and right) |
| <kbd>Shift</kbd> + <kbd>Arrow</kbd> | For multiple cell selection on either direction. |
| <kbd>Delete</kbd> | Deletes one or more selected events. |
| <kbd>Ctrl</kbd> + <kbd>Click</kbd> on events | To select multiple events. |
| <kbd>Alt</kbd> + <kbd>Number</kbd> (from 1 to 6) |To switch between the views of Scheduler. |
| <kbd>Ctrl</kbd> + <kbd>Left Arrow</kbd> | To navigate to the previous date period. |
| <kbd>Ctrl</kbd> + <kbd>Right Arrow</kbd> | To navigate to the next date period. |
| <kbd>Left</kbd> or <kbd>Right Arrow</kbd> | On pressing any of these keys, when focus is currently on the Schedule header bar, moves the focus to the previous or next items in the header bar. |
| <kbd>Space</kbd> or <kbd>Enter</kbd> | It activates any of the focused items. |
| <kbd>Page Up</kbd> & <kbd>Page Down</kbd> | To scroll through the work cells area. |
| <kbd>Home</kbd> | To move the selection to the first cell of Scheduler. |

> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
