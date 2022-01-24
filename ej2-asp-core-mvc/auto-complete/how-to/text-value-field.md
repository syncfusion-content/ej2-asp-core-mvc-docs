---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Text Value Field of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Text Value Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filter using both text and value field

The AutoComplete data can be filtered based on both text and value fields using `predicate` of dataManager through filtering event. The filtered data can be again updated through `updateData` method.

In the following example, filtering is done based on text and value fields.

{% aspTab template="autocomplete/how-to/filtering", sourceFiles="Countries.cs,filtering.cs" %}

{% endaspTab %}