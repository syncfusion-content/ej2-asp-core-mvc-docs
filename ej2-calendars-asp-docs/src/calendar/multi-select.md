---
title: "Multi Selection"
component: Calendar
description: "Calendar supports multiple date selection to allow users to select more than one date."
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