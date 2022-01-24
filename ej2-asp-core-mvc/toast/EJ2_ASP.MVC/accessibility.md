---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Accessibility of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The Toast control has been designed with [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications in mind by applying the prompt WAI-ARIA roles, states, and properties with the keyboard support. It helps users who use assistive WAI-ARIA accessibility support, which is achieved using attributes.

It provides information about the elements in a document for assistive technology.

The Toast control implements the keyboard navigation support by using the following [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and is tested in major screen readers.

## ARIA attributes

<!-- markdownlint-disable MD033 -->

| Class | Description |
| -------- | -------- |
| role | <b>alert:</b> <br/>   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Identifies the element as a container when alert content will be added or updated. |

{% aspTab template="toast/accessibility", sourceFiles="controller.cs" %}

{% endaspTab %}