---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Searching of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---

startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the `SearchSettings.Operator` value is `contains`.

## Search by external button

To search grid records from an external button, invoke the `search` method.

{% aspTab template="grid/search/external-btn", sourceFiles="initial-search.cs" %}

{% endaspTab %}

## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the `SearchSettings.Fields` property.

{% aspTab template="grid/search/search-a-column", sourceFiles="search-a-column.cs" %}

{% endaspTab %}

## Clear search by external button

To clear the searched grid records from the external button, set [`searchSettings.key`](./api-searchSettings.html#key-string) property as `empty` string.

{% aspTab template="grid/search/clear-search", sourceFiles="clear-search.cs" %}

{% endaspTab %}
