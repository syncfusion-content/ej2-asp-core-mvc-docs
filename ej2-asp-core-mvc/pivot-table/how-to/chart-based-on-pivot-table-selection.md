---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Chart Based On Pivot Table Selection of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Chart Based On Pivot Table Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render chart control based on cell selection

The cell selection support is enabled using the `allowSelection` property and its type and mode are configured using the `selectionSettings` property. The `cellSelected` event gets fired on every selection operation performed in the pivot table. This event returns the selected cell informations, like row header name, column header name, measure name, and value. Based on this information, the `chart` control will be plotted.

{% aspTab template="pivot-table/field-list/chart", sourceFiles="Popup.cs" %}

{% endaspTab %}

![output](images/chart-selection.png)