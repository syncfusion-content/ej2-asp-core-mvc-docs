---
layout: post
title: Globalization in ##Platform_Name## Daterangepicker Component
description: Learn here all about Globalization in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization

Globalization is the combination of  adapting the component to
various languages by means of parsing and formatting the date or
number [Internationalization](../common/internationalization/) and also by adding cultural specific customizations and translating the text
[localization](../common/localization/).

By default, DateRangePicker date format, week, and month names are specific to the `American English` culture. It utilizes the
[Essential JavaScript 2 Internationalization](http://ej2.syncfusion.com/documentation/base/intl.html)
package to parse and format the date object based on the culture by using the official [UNICODE CLDR](http://cldr.unicode.org/)
JSON data. It provides the `loadCldr` method to load culture specific CLDR JSON data.

* Set the culture by using the
[locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Locale)
property.

To go with the different culture other than `English`, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). To
know more about CLDR-Data refer the
[CLDR-Data](http://cldr.unicode.org/index/cldr-spec/json) link.

```
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

> The `Localization` library allows you to localize default text content of the DateRangePicker. The DateRangePicker component has static text for  **today** feature that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the
[locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Locale) value and translation object.

Locale keywords |Text
-----|-----
placeholder | Hint to describe expected value in input element.
startLabel | Label to represent the start date.
endLabel | Label to represent the end date.
applyText | Text present in the apply button.
cancelText | Text present in the cancel button.
selectedDays | Text to represent selected days.
days | Text represents days.
customRange | Text present in the custom range button in presets container.

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript
    var L10n = ej.base.L10n;
    L10n.load({
       'de': {
            'daterangepicker': {  placeholder: 'Wählen Sie einen Bereich aus',
             startLabel: 'Wählen Sie Startdatum',
             endLabel: 'Wählen Sie Enddatum',
             applyText: 'Sich bewerben',
             cancelText: 'Stornieren',
             selectedDays: 'Ausgewählte Tage',
             days: 'Tage',
             customRange: 'benutzerdefinierten Bereich'
        }
    }
});
```

The following example demonstrates the DateRangePicker in `German` culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/globalization/globalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/globalization/globalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Right-To-Left

The DateRangePicker supports RTL (right-to-left) functionality for languages like Arabic and Hebrew. To display the
text in the right-to-left direction, use
[enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_EnableRtl)
property.

The code example demonstrates the DateRangePicker component in `Arabic` culture. It also explains how to set localized text to
the placeholder using `L10n.load` method.

The following example demonstrates DateRangePicker in `Arabic` culture with right-to-left direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/globalization/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

