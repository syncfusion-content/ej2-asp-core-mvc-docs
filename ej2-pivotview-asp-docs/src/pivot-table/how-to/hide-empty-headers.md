# Hide empty headers

If the raw data for a particular field is not defined, it will be shown as 'Undefined' in the pivot table headers. You can hide those headers by setting the `showHeaderWhenEmpty` property to **false** in the pivot table.

For example, if the raw data for the field 'Country' is defined as **"United Kingdom"** and **"State"** is not defined means, it will be shown as **"United Kingdom >> Undefined"** in the header section. Here, you can hide those 'Undefined' header using the `showHeaderWhenEmpty` property.

> By default, this property is set as **true**.

{% aspTab template="pivot-table/hide-headers", sourceFiles="fieldlist.cs" %}

{% endaspTab %}
