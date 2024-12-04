---
layout: post
title: Accessibility in ##Platform_Name## Diagram Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Diagram component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

Diagram provides built-in compliance with the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications. WAI-ARIA Accessibility supports are achieved through the attributes like `aria-label`. It helps to provide information about elements in a document for assistive technology.

The accessibility compliance for the diagram component is outlined below.

| Accessibility Criteria                                                              | Compatibility                                                                        |
| ----------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------ |
| WCAG 2.2 Support                 | <img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="intermediate"> |
| Section 508 Support             | <img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="intermediate"> |
| Screen Reader Support             | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Right-To-Left Support             | <img src="https://cdn.syncfusion.com/content/images/landing-page/no.png" alt="No"> |
| Color Contrast                            | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Mobile Device Support             | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Keyboard Navigation Support | <img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="intermediate"> |
| Accessibility Checker Validation  | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |
| Axe-core Accessibility Validation | <img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes"> |

<div style="display: flex; align-items: center;"><img src="https://cdn.syncfusion.com/content/images/landing-page/yes.png" alt="Yes" style="margin-right: 5px;"> - All features of the component meet the requirement.</div>

<div style="display: flex; align-items: center;"><img src="https://cdn.syncfusion.com/content/images/landing-page/intermediate.png" alt="Intermediate" style="margin-right: 5px;"> - Some features of the component do not meet the requirement.</div>

<div style="display: flex; align-items: center;"><img src="https://cdn.syncfusion.com/content/images/landing-page/no.png" alt="No" style="margin-right: 1px;"> - The component does not meet the requirement.</div>

## WAI-ARIA attributes

The Diagram component followed the [WAI-ARIA](?) patterns to meet the accessibility. The following ARIA attributes are used in the Diagram component:

| Attributes | Purpose |
| --- | --- |
| `aria-label` | Provides an accessible name for the Diagram Objects. |

## Aria-label
Attribute provides the text label with some default description for below elements in diagram.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Element</b></td>
<td><b>Default description</b></td>
</tr>
<tr>
<td>ResizeNorthWest</td>
<td>Thumb to resize the selected object on the top-left corner.</td>
</tr>
<tr>
<td>ResizeNorthEast</td>
<td>Thumb to resize the selected object on the top-right side direction.</td>
</tr>
<tr>
<td>ResizeSouthWest</td>
<td>Thumb to resize the selected object on the bottom-left side direction.</td>
</tr>
<tr>
<td>ResizeSouthEast</td>
<td>Thumb to resize the selected object on the bottom-right side direction.</td>
</tr>
<tr>
<td>ResizeNorth</td>
<td>Thumb to resize the selected object on the top side direction.</td>
</tr>
<tr>
<td>ResizeSouth</td>
<td>Thumb to resize the selected object on the bottom side direction.</td>
</tr>
<tr>
<td>ResizeWest</td>
<td>Thumb to resize the selected object on the left side direction.</td>
</tr>
<tr>
<td>ResizeEast</td>
<td>Thumb to resize the selected object on the right side direction.</td>
</tr>
<tr>
<td>ConnectorSourceThumb</td>
<td>Thumb to move the source point of the connector.</td>
</tr>
<tr>
<td>ConnectorTargetThumb</td>
<td>Thumb to move the target point of the connector.</td>
</tr>
<tr>
<td>RotateThumb</td>
<td>Thumb to rotate the selected object.</td>
</tr>
</table>

### Mobile device support

Syncfusion<sup style="font-size:70%">&reg;</sup> Diagram component are more user-friendly and accessible to individuals using mobile devices, including those with disabilities. These are designed to be responsive, adaptable to various screen sizes and orientations, and touch-friendly.

### Screen Reader Support

The Diagram component supports and its information was dictated properly by the screen readers based on the ARIA attributes and content.

### Keyboard navigation support

Syncfusion<sup style="font-size:70%">&reg;</sup> Diagram component support keyboard navigation, allowing users who rely on alternate methods to effortlessly navigate and interact with the component.

## Keyboard interaction

The Diagram component followed the [keyboard interaction](https://www.w3.org/WAI/WCAG21/Understanding/keyboard.html) guideline, making it easy for people who use assistive technologies (AT) and those who completely rely on keyboard navigation. The following keyboard shortcuts are supported by the Diagram component.

| **Command** | **Action** |
| --- | --- |
| Ctrl + A | Select All |
| Ctrl + X | Cut |
| Ctrl + C |Copy |
| Ctrl + V | Paste |
| Ctrl + Z | Undo |
| Ctrl + Y | Redo |
| Delete | Delete |
| <kbd>Up Arrow </kbd> | Move selected object to up |
| <kbd>Down Arrow</kbd> | Move selected object to down |
| <kbd>Left Arrow</kbd> | Move selected object to left |
| <kbd>Right Arrow</kbd> | Move selected object to right |
| <kbd>Enter</kbd> | Start Annotation Edit |
| <kbd>Escape</kbd> | End Annotation Edit |


## Ensuring accessibility

The Diagram component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Diagram component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/diagram.html) in a new window to evaluate the accessibility of the Diagram component with accessibility tools.

## See also

- [Accessibility in Syncfusion<sup style="font-size:70%">&reg;</sup> components](../common/accessibility)