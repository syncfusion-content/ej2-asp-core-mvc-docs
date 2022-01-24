---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Member Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Member Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Member filtering

Member filtering allows you to view pivot table with particular records based on filter criteria. You can disable the member filter by setting the `allowMemberFilter` property to **false**. By default, this property is set as **true**.

## Filtering through UI

Filtering can also be performed through UI option available in [`grouping bar`](./grouping-bar) and [`field list`](./field-list) at run time.

## Filtering through code

It can be configured using the `filterSettings` option through code-behind. The settings required to filter at initial rendering are:
* `name`: It allows to set field name.
* `type`: It allows to set filter type as either "Include" or "Exclude" to the field.
* `items`: It allows to set the filter members of the field.

{% aspTab template="pivot-table/filtering/member-filtering", sourceFiles="Filtering.cs" %}

{% endaspTab %}

## See Also

* [Label Filtering](./label-filtering)
* [Value Filtering](./value-filtering)