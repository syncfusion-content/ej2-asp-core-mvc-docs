---
title: "Accessibility"
component: "Spreadsheet"
description: "Documentation for accessibility in Essential JS 2 Spreadsheet, featuring WAI-ARIA standards"
---

# Accessibility

The practice of making information and activities usable for as many people as possible is accessibility. Accessibility in spreadsheet component is achieved through `WAI-ARIA`. Spreadsheet features are effectively accessed through assistive technologies such as screen readers.

## ARIA

`WAI-ARIA` (Web Accessibility Initiative – Accessible Rich Internet Applications) defines a way to increase the accessibility of web pages, dynamic content, and user interface components developed with Ajax, HTML, JavaScript, and related technologies. ARIA is a set of roles and attributes that define ways to make web content and web applications more accessible to people with disabilities. Screen readers work with regular HTML, but adding ARIA can provide screen reader users greater context and interactivity with the content on the page.

`WAI-ARIA` support in spreadsheet is achieved using roles and attributes such as,
* `grid` (role)
* `gridcell` (role)
* `rowheader` (role)
* `colheader` (role)
* `menu` (role)
* `textbox` (role)
* `aria-rowindex` (attribute)
* `aria-colindex` (attribute)
* `aria-selected` (attribute)
* `aria-expanded` (attribute)
* `aria-rowcount` (attribute)
* `aria-colcount` (attribute)
* `aria-busy` (attribute)
* `aria-label` (attribute)
