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

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript
      var L10n = ej.base.L10n;
       L10n.load({
            "de": {
                "calendar": {
                    "today": "heute"
                }
            }
        });
```

The following example demonstrates the Calendar in `German` culture.

{% aspTab template="calendar/international/international" %}

{% endaspTab %}

## Right-To-Left

The Calendar supports right-to-left functionality for languages like Arabic, Hebrew, etc. To display
the text in the right-to-left direction, use
[enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_EnableRtl)
property.

The following example demonstrates the Calendar in `Arabic`
culture with Right-To-Left direction.

{% aspTab template="calendar/international/rtl" %}

{% endaspTab %}