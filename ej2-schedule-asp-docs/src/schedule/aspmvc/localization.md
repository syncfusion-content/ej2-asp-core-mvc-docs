---
title: "Globalization in ASP.Net MVC Scheduler"
component: "Scheduler"
description: "This section explains how the Scheduler adapts to various languages and culture by parsing and formatting the date or number appropriately."
---

# Globalization and Localization

The Scheduler integrates different date-time formats and cultures, which allows it to function globally, thus meeting the diverse needs of different regions.

You can adapt the Scheduler to various languages by parsing and formatting the date or number ([`Internationalization`](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization/)), adding culture specific customization and translation to the text ([`Localization`](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization/)).

## Globalization

The Internationalization library provides support for formatting and parsing the number, date, and time by using the official [`Unicode CLDR`](http://cldr.unicode.org/) JSON data and also provides the `loadCldr` method to load the culture specific CLDR JSON data.

By default, Scheduler is set to follow the English culture ('en-US'). If you want to go with different culture other than English, follow the below steps.

Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). For more information about CLDR-Data, refer to this [link](http://cldr.unicode.org/index/cldr-spec/json).

```cmd
npm install cldr-data --save
```

Once the package is installed, you can find the culture specific JSON data under the location `node_modules\cldr-data`.

Once the `CLDR-Data` installed create a folder `cldr-data` inside the `Scripts` folder. Then create the folder directory like shown below in the structure inside the `Scripts` folder.

* `Scripts\cldr-data\supplemental`
* `Scripts\cldr-data\main`

The files named as below are required to setup the specific culture to the Schedule.

* numberingSystems.json
* ca-gregorian.json
* numbers.json
* timeZoneNames.json
* ca-islamic.json

The file named `numberingSystems.json` is available in the location `node_modules\cldr-data\supplemental` which is common for all the cultures. Now you can move this file to the location `Scripts\cldr-data\supplemental`.

The other required files mentioned above are available in the location `node_modules\cldr-data\main\culture_code`. In this location every culture having the culture files inside the folder named as its language culture code. For example if we are loading the German culture we can find the German culture files inside the location `node_modules\cldr-data\main\de`. Now create a folder named `de` inside the location `Scripts\cldr-data\main` and move the files inside it.

Now use the `loadCultureFiles` method to load the culture specific CLDR JSON data.

```sh
    loadCultureFiles('de');
    function loadCultureFiles(name) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            ajax = new ej.base.Ajax(location.origin + '/../Scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
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

Set the culture to Scheduler by using the `Locale` property.

{% aspTab template="schedule/localization/internationalization", sourceFiles="data.cs"  %}

{% endaspTab %}

## Localizing the static Scheduler text

[`Localization`](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization/) library allows to display all the static text, date content, and time mode of the Scheduler following the localized language. To achieve this, set the `Locale` property of Scheduler, as well as define the translation text of static words of Scheduler through the `load` method of `L10n` class.

For example, the following code example lets you to define the Hungarian translation words for all the static words used in Scheduler.

{% aspTab template="schedule/localization/localization", sourceFiles="data.cs"  %}

{% endaspTab %}

## Setting date format

Scheduler can be used with all valid date formats and by default it follows the universal date format "MM/dd/yyyy". If the `DateFormat` property is not specified particularly, then it will work based on the locale that is assigned to the Scheduler. As the default locale applied on Scheduler is "en-US", this makes it to follow the "MM/dd/yyyy" pattern.

{% aspTab template="schedule/localization/dateformat", sourceFiles="data.cs"  %}

{% endaspTab %}

## Setting the time format

Time formats is a way of representing the time value in different string formats in the Scheduler. By default, the time mode of the Scheduler can be either 12 or 24 hours format which is completely based on the `locale` set to the Scheduler. Since the default `locale` value of the Scheduler is en-US, the time mode will be set to 12 hours format automatically. You can also customize the format by using the `timeFormat` property. To know more about the time format standards, refer to the [Date and Time Format](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization/#custom-formats) section.

The following example demonstrates the Scheduler component in 24 hours format.

{% aspTab template="schedule/localization/timeformat", sourceFiles="data.cs"  %}

{% endaspTab %}

> Note: `timeFormat` property only accepts the valid time format's.

## Displaying Scheduler in RTL mode

The Scheduler layout and its behavior can be changed as per the common RTL (Right to Left) conventions by setting `EnableRtl` to `true`. By doing so, the Scheduler will display its usual layout from right to left. It's default value is `false`.

{% aspTab template="schedule/localization/rtl", sourceFiles="data.cs"  %}

{% endaspTab %}

> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.

## See Also

* [How to change first day of the week in the Scheduler](./working-days/#setting-start-day-of-the-week)