---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Levels of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Levels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Levels

TreeMap supports **n** number of levels and each level is separated by using the `groupPath` property.

<!-- markdownlint-disable MD036 -->

## Group path

The `groupPath` property is used to separate each level of the TreeMap by specifying the property from the data source.

In the following example, three levels are added and each level is configured using the `groupPath` property.

{% aspTab template="treemap/levels/group_path", sourceFiles="group_path.cs" %}

{% endaspTab %}

![TreeMap with multiple levels](images/Levels/grouppath.png)

<!-- markdownlint-disable MD036 -->

## Group gap

The `groupGap` property is used to separate an item from each group or another item to differentiate the levels mentioned in the TreeMap.

{% aspTab template="treemap/levels/group_gap", sourceFiles="group_gap.cs" %}

{% endaspTab %}

![TreeMap levels with group gap](images/Levels/groupgap.png)

<!-- markdownlint-disable MD036 -->

## Header format and Alignment

Customize header using the `headerFormat` property in which fields are mapping from the dataSource and align header using the `headerAlignment` property.

{% aspTab template="treemap/levels/header_format", sourceFiles="header_format.cs" %}

{% endaspTab %}

## Header height and style

Customize the font color, family, weight, opacity and size using the `headerStyle`. Based on the font settings, the header height is given using the `headerHeight` property in `levels`.

{% aspTab template="treemap/levels/header_height", sourceFiles="header_height.cs" %}

{% endaspTab %}

## Header template and position

The TreeMap header supports to customize header of each item using the `headerTemplate` property. It uses Essential JS2 Template engine to render the elements. You can position the template using the `templatePosition` property.

{% aspTab template="treemap/levels/template", sourceFiles="template.cs" %}

{% endaspTab %}

![TreeMap with customized header](images/Levels/headeralignment.png)