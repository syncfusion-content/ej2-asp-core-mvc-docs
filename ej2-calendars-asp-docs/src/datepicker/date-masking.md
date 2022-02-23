---
title: "Date Masking"
component: "DatePicker"
description: "Miscellaneous aspects of customizing the date picker"
---

# Enable the Masked Input

DatePicker has `enableMask` property that provides the option to enable the built-in date masking support.

{% aspTab template="datepicker/mask-module/mask-input", sourceFiles="" %}

{% endaspTab %}

The mask pattern is defined based on the provided date format to the component. If the format is not specified, the mask pattern is formed based on the default format of the current culture.

| **Keys** | **Actions** |
| --- | --- |
| <kbd>Up / Down arrows</kbd> | To increment and decrement the selected portion of the date. |
| <kbd>Left / Right arrows and Tab</kbd> | To navigate the selection from one portion to next portion |

The following example demonstrates default and custom format of DatePicker component with mask.

{% aspTab template="datepicker/mask-module/mask-format", sourceFiles="date-format.cs" %}

{% endaspTab %}

## Configure Mask Placeholder

You can change mask placeholder value through property `maskPlaceholder`. By default , it takes the full name of date and time co-ordinates such as `day`, `month`, `year`, `hour` etc.

While changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through load method of L10n class for mask placeholder values like below.

```typescript

//load the locale object to set the localized mask placeholder value
L10n.load({
'de': {
    'datepicker': { day: 'Tag' , month: 'Monat', year: 'Jahr' }
}
});

```

The following example demonstrates default and customized mask placeholder value.

{% aspTab template="datepicker/mask-module/mask-placeholder", sourceFiles="mask-placeholder.cs" %}

{% endaspTab %}
