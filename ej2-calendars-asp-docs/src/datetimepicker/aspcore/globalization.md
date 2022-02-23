---
title: "Globalization"
component: "DateTimePicker"
description: "Learn about how to globalize the date time picker component and how to localize the culture related content."
---

# Globalization

Globalization is the combination of  adapting the control to
various languages by means of parsing and formatting the date or
number [Internationalization](../common/internationalization/) and also by adding cultural specific customizations and translating the text
[localization](../common/localization/).

By default, the date format, week,time format ,month and meridian names are specific to the `American English` culture. It utilizes the
[Essential JavaScript 2 Internationalization](../common/internationalization/)
package to parse and format the date object based on the culture by using the official [UNICODE CLDR](http://cldr.unicode.org/)
JSON data. It provides the `loadCldr` method to load culture specific CLDR JSON data.

* Set the culture by using the
[locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Locale)
property.

To go with the different culture other than `English`, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). To
know more about CLDR-Data refer the
[`CLDR-Data`](http://cldr.unicode.org/index/cldr-spec/json) link.

```cmd
npm install cldr-data --save
```

Once the package installed, you can find the culture
specific JSON data under the location `\node_modules\cldr-data`.

In ASP.NET Core, the static file contents are should present under `wwwroot` folder. For this, manually copy the `CLDR-Data` from the `node_modules` folder and place inside the `wwwroot` folder and refer from the `\wwwroot\scripts\cldr-data` location as like the below code examples

```typescript

function loadCultureFiles(name) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            ajax = new ej.base.Ajax(location.origin + location.pathname + '/../../scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
            ajax.onSuccess = function (value) {
                val = value;
            };
            ajax.send();
            loader(JSON.parse(val));
        };
        for (var prop = 0; prop < files.length; prop++) {
            loadCulture(prop);
        }
    }

```

> The `Localization` library allows you to localize default text content of the DateTimePicker. The DateTimePicker control has static text for  **today** feature that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the
[locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Locale) value and translation object.

Locale keywords |Text
-----|-----
today | Name of the button to choose Today date.
placeholder | Hint to describe expected value in input element.

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript
     var L10n = ej.base.L10n;
        L10n.load({
            'de': {
                'datetimepicker': { placeholder: "Wählen Sie ein Datum und eine Uhrzeit aus",
                 today:"heute"
                }
            }
        });
```

The following example demonstrates the DateTimePicker in `German` culture.

{% aspTab template="datetimepicker/globalization/globalization" %}

{% endaspTab %}

## Right-To-Left

The DateTimePicker supports RTL (right-to-left) functionality for languages like Arabic and Hebrew to displays
the text in the right-to-left direction. Use [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_EnableRtl)
property to set the RTL direction.

The following code example initialize the DateTimePicker control in `Arabic` culture and
also explains how to set the localized text to
the placeholder using `load` method of `L10n` class.

The following example demonstrates DateTimePicker in `Arabic` culture with right-to-left direction.

{% aspTab template="datetimepicker/globalization/rtl" %}

{% endaspTab %}