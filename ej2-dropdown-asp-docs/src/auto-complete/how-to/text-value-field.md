---
title: "Autocomplete How to filter using both text and value field"
component: "AutoComplete"
description: "This section explains the filtering support in autocomplete control."
---

# Filter using both text and value field

The AutoComplete data can be filtered based on both text and value fields using `predicate` of dataManager through filtering event. The filtered data can be again updated through `updateData` method.

In the following example, filtering is done based on text and value fields.

{% aspTab template="autocomplete/how-to/filtering", sourceFiles="Countries.cs,filtering.cs" %}

{% endaspTab %}