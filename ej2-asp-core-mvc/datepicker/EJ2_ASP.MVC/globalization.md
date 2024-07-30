---
layout: post
title: Globalization in ##Platform_Name## Datepicker Control | Syncfusion
description: Learn here all about Globalization in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization in ASP.NET MVC Datepicker Control

Globalization is the combination of  adapting the control to various languages by means of parsing and formatting the date or number [Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization), and also by adding cultural specific customizations and translating the text [localization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization).

By default, DatePicker date format, week and month names are specific to the `American English` culture. It utilizes the [Essential JavaScript 2 Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization) package to parse and format the date object based on the culture by using the official [UNICODE CLDR](https://cldr.unicode.org/) JSON data. It provides the `loadCldr` method to load culture specific CLDR JSON data.

* Set the culture by using the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Locale) property.

To go with the different culture other than `English`, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). To know more about CLDR-Data refer the [CLDR-Data](https://cldr.unicode.org/index/cldr-spec/cldr-json-bindings) link.

```
npm install cldr-data --save
```

Once the package installed, you can find the culture specific JSON data under the location `/node_modules/cldr-data`.

In ASP.NET MVC refer the culture files directly from `/node_modules/cldr-data` location.

```typescript

    function loadCultureFiles(name) {
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

N> The `Localization` library allows you to localize default text content of the DatePicker. The DatePicker control has static text for **today** feature that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Locale) value and translation object.

| Locale keywords | Text |
| ----- | ----- |
| today | Name of the button to choose Today date. |
| placeholder | Hint to describe expected value in input element. |

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of `L10n` class.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/globalization/globalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/globalization/globalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Right-To-Left

The DatePicker supports RTL (right-to-left) functionality for languages like Arabic and Hebrew to displays the text in the right-to-left direction. Use [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_EnableRtl) property to set the RTL direction.

The following code example initialize the DatePicker control in `Arabic` culture and also explains how to set the localized text to the placeholder using `load` method of `L10n` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/globalization/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

