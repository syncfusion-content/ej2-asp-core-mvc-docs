---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Icons For Pivot Table of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Icons For Pivot Table
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the icons for pivot table

You can customize the pivot button icons in the pivot table by overriding the class **.pivot-button** with a custom property content as mentioned below.

```html

<style>
#PivotView_PivotFieldList .e-icons.e-toggle-field-list::before {
    content: '\e337';
}
</style>

```

In the below sample, pivot table is rendered with a customized pivot button icons.

{% aspTab template="pivot-table/icon-customize/customize", sourceFiles="IconCustomize.cs" %}

{% endaspTab %}
