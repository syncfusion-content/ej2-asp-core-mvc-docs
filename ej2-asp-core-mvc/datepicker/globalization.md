---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Globalization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---

today | Name of the button to choose Today date.
placeholder | Hint to describe expected value in input element.

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript
      var L10n = ej.base.L10n;
      L10n.load({
            'de': {
                'datepicker': { placeholder: 'Wählen Sie ein Datum',
                  today: 'heute'
                }
            }
        });
```

The following example demonstrates the DatePicker in `German` culture.

{% aspTab template="datepicker/globalization/globalization" %}

{% endaspTab %}

## Right-To-Left

The DatePicker supports RTL (right-to-left) functionality for languages like Arabic and Hebrew to displays
the text in the right-to-left direction. Use [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_EnableRtl)
property to set the RTL direction.

The following code example initialize the DatePicker component in `Arabic` culture and
also explains how to set the localized text to
the placeholder using `load` method of `L10n` class.

{% aspTab template="datepicker/globalization/rtl" %}

{% endaspTab %}