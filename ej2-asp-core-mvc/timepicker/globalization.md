---
layout: post
title: Globalization in ##Platform_Name## Timepicker Component
description: Learn here all about Globalization in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization

Globalization is the combination of internalization and localization. You can adapt the control to
various languages by parsing and formatting the date or
number [internationalization](../common/internationalization/) and also add culture
specific customization and translation to the text [localization](../common/localization/).

By default, TimePicker time format and meridian names are specific to the `American English` culture.
It utilizes the
[Essential JavaScript 2 Internationalization](../common/internationalization)
package to parse and format the date object based on the culture by using the official [UNICODE CLDR](http://cldr.unicode.org/)
JSON data. It provides the `loadCldr` method to load culture specific CLDR JSON data.

* Set the culture by using the
[locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Locale)
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

In ASP.NET MVC refer the culture files directly from `\node_modules\cldr-data` location. But in ASP.NET Core, the static file contents are should present under `wwwroot` folder. For this, manually copy the `CLDR-Data` from the `node_modules` folder and place inside the `wwwroot` folder and refer from the `\wwwroot\scripts\cldr-data` location.

* TimePicker displayed `Sunday` as the first day of week based on default culture ("en-US"). If you want to display the TimePicker with loaded culture's first day of week, you need to import `weekdata.json` file as given in the code example.

Example for ASP.NET Core

```typescript

function loadCultureFiles(name) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json', 'weekdata.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            ajax = new ej.base.Ajax(location.origin + location.pathname + '/../../scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false)
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

Example for ASP.NET MVC

```typescript

    function loadCultureFiles(name) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json', 'weekdata.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            ajax = new ej.base.Ajax(location.origin + location.pathname + '/../node_modules/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
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

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript
     var L10n = ej.base.L10n;
        L10n.load({
            'de': {
                'timepicker': { placeholder: 'Wählen Sie Zeit' }
            }
        });
```

The following example demonstrates the TimePicker in `German` culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/globalization/globalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/globalization/globalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Globalization.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Right-To-Left

The TimePicker supports RTL (right-to-left) functionality for languages like Arabic and Hebrew to displays the
text in the right-to-left direction. Use
[`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_EnableRtl)
property to set the RTL direction.

The following code example demonstrates the TimePicker component in `Arabic` culture. It also explains how to set localized text to
the placeholder using [`L10n.load`](http://ej2.syncfusion.com/documentation/base/api/l10n/) method.

The following example demonstrates TimePicker in `Arabic` culture with right-to-left direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/globalization/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

