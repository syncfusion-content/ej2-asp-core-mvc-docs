---
layout: post
title: Accessibility in ##Platform_Name## Spreadsheet Component
description: "Documentation for the accessibility in the Essential JS2 Spreadsheet, featuring WAI-ARIA standards."
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in Spreadsheet

The practice of making information and activities usable for as many people as possible is accessibility. Accessibility in spreadsheet component is achieved through `WAI-ARIA`. Spreadsheet features are effectively accessed through assistive technologies such as screen readers.

## ARIA

`WAI-ARIA` (Web Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with Ajax, HTML, JavaScript, and related technologies. ARIA is a set of roles and attributes that define ways to make web content and web applications more accessible to people with disabilities. Screen readers work with regular HTML, but adding ARIA can provide screen reader users greater context and interactivity with the content on the page.

`WAI-ARIA` support in spreadsheet is achieved using roles and attributes such as,

| Roles and Attributes | Functionalities |
|-------|---------|
| `grid` (role) | This role is added to the spreadsheet element and describes the table that contains collection of rows. |
| `gridcell` (role) | This role is added to the cell element and describes the rows `<td>` element. |
| `rowheader` (role) | This role is added to the row header and describes the header of the rows. |
| `colheader` (role) | This role is added to the column header and describes the header of the columns. |
| `menu` (role) | This role has been added to the menu and describes the menu items. |
| `textbox` (role) | This role is assigned to the textbox that accepts text input. |
| `aria-rowindex` (attribute) | This attribute describes the table's row index in the spreadsheet. |
| `aria-colindex` (attribute) | This attribute describes the table's column index in the spreadsheet.|
| `aria-selected` (attribute) | This attribute describes an item's (cell, menu, check-box, etc.) current selected state in the spreadsheet. |
| `aria-expanded` (attribute) | This attribute describes the control (for example, dropdown) is expanded or collapsed. |
| `aria-rowcount` (attribute) | This attribute describes the total number of rows in the table. |
| `aria-colcount` (attribute) | This attribute describes the total number of columns in the table. |
| `aria-busy` (attribute) | This attribute describes a currently updated or modified element. |
| `aria-label` (attribute) | This attribute describes the accessible name for the interactive elements. |

