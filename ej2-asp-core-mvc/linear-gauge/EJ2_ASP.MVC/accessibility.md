---
layout: post
title: Accessibility in ##Platform_Name## Linear Gauge Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Linear Gauge component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility in ASP.NET MVC Linear Gauge

## WAI-ARIA attributes

The Linear Gauge component followed the [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/patterns/alert/) patterns to meet the accessibility. The following ARIA attributes are used in the Linear Gauge component:

| Attributes | Purpose |
| --- | --- |
| `role=region` | It is specified in the pointer where the interactive drag and drop function is supported to update the pointer value. |
| `aria-label` | Provides an accessible name for the title. |

## Ensuring accessibility

The Linear Gauge component's accessibility levels are ensured through an [accessibility-checker](https://www.npmjs.com/package/accessibility-checker) and [axe-core](https://www.npmjs.com/package/axe-core) software tools during automated testing.

The accessibility compliance of the Linear Gauge component is shown in the following sample. Open the [sample](https://ej2.syncfusion.com/accessibility/linear-gauge.html) in a new window to evaluate the accessibility of the Linear Gauge component with accessibility tools.

{% previewsample "https://ej2.syncfusion.com/accessibility/linear-gauge.html" %}

## See also

* [Accessibility in Syncfusion Linear Gauge components](../common/accessibility)