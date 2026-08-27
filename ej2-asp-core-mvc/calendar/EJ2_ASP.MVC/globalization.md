---
layout: post
title: Globalization in ##Platform_Name## Calendar | Syncfusion
description: Localize the ##Platform_Name## Calendar to any culture using CLDR data, the locale property, and L10n text translations.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Calendar

Globalization involves adapting the Calendar control to various languages by means of parsing and formatting the date or number ([Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization)) and also by adding culture-specific customizations and translating the text ([localization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization)).

By default, Calendar date format, week and month names are specific to American English culture. It utilizes the [Essential JavaScript 2 Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization) package to parse and format the date object based on the culture and uses the official [UNICODE CLDR](https://cldr.unicode.org/) JSON data.

* Set the culture by using the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Locale) property.

To use a culture other than `English`, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). To know more about CLDR-Data refer the [CLDR-Data](https://cldr.unicode.org/index/cldr-spec/cldr-json-bindings) link.

```
npm install cldr-data --save
```

Once the package is installed, you can find the culture-specific JSON data under the location `\node_modules\cldr-data`.

In ASP.NET MVC refer the culture files directly from `/node_modules/cldr-data` location as like the below code examples.

```typescript

    function loadCultureFiles(de) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            ajax = new ej.base.Ajax(location.origin + location.pathname + '/../../node_modules/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
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

N> The `Localization` library allows you to localize default text content of the Calendar. The Calendar control has static text for  **today** feature that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Locale) value and translation object.

| Locale keywords |Text |
| ----- | ----- |
| today | Name of the button to choose Today date. |

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of `L10n` class.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/international/international/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="International.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/international/international/razor %}
{% endhighlight %}
{% highlight c# tabtitle="International.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Right-to-left

The Calendar supports right-to-left functionality for languages like Arabic, Hebrew, etc. To display the text in the right-to-left direction, use [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_EnableRtl) property. Ensure that the culture-specific CLDR data (for example, for Arabic) is loaded using `loadCultureFiles` as described above before applying `enableRtl`.

The following example demonstrates the Calendar in `Arabic` culture with Right-to-left direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/international/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/international/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}