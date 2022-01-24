---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Multi Select of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Multi Select
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multi Selection

Calendar provides an option to select **single** or **multiple dates** by using `isMultiSelection` and `values` properties. By default, `isMultiSelection` property will be in disabled state.

| API | Type | Description |
|------|------|----------------------|
| `isMultiSelection`| **Boolean**| Enables the multi-selection option in the Calendar control |
|`values`| **Date[]** | Gets or sets the date range values in multi-selection option |

The following example demonstrates the functionality of  `isMultiSelection` property and `values` properties in the Calendar control.

{% aspTab template="calendar/multi-select/multi", sourceFiles="multi.cs" %}

{% endaspTab %}