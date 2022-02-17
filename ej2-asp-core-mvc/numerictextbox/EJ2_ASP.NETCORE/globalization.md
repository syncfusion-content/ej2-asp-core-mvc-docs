---
layout: post
title: Globalization in ##Platform_Name## Numerictextbox Component
description: Learn here all about Globalization in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization

## Internationalization

Internationalization library provides support for formatting and parsing the number by using the
official [Unicode CLDR](http://cldr.unicode.org/) JSON data and also provides the
`loadCldr` method to load the culture specific CLDR JSON data. The NumericTextBox comes with built-in
internationalization support to adapt based on culture. For more information about internationalization,
refer to this [link](../common/internationalization).

By default, all the Essential JS 2  control are specific to English culture (en-US).
If you want to go with the different culture other than `English`, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). For more information about CLDR-Data,
refer to this [link](http://cldr.unicode.org/index/cldr-spec/json).

```
npm install cldr-data --save
```

Once the package installed, you can find the culture
specific JSON data under the location `\node_modules\cldr-data`.

In ASP.NET Core, the static file contents are should present under `wwwroot` folder. For this, manually copy the `CLDR-Data` from the `node_modules` folder and place inside the `wwwroot` folder and refer from the `\wwwroot\scripts\cldr-data` location as like the below code examples

```typescript

function loadCultureFiles(name) {
        var files = ['currencies.json', 'numbers.json' ];
        if (name === 'zh') {
            files.push('currencyData.json');
        }
        var loader = ej.base.loadCldr;
       var loadCulture = function () {
            var val, ajax;
            if (name === 'zh' && prop === files.length - 1) {
                ajax = new ej.base.Ajax(location.origin + location.pathname + '/../../scripts/cldr-data/supplemental/' + files[prop], 'GET', false);
            } else {
                ajax = new ej.base.Ajax(location.origin + location.pathname + '/../../scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
            }
            ajax.onSuccess = function (value) {
                val = value;
            };
            ajax.send();
            loader(JSON.parse(val));

        };
        for (var prop = 0; prop < files.length; prop++) {
            loadCulture();
        }
    }
loadCultureFiles('de');

```

## Localization

[Localization](../common/localization/) library allows users to localize the default text contents
of the NumericTextBox to different cultures using the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Locale) property.
In NumericTextBox, spin buttons title for the tooltip will be localized based on the culture.

| Locale key | en-US (default)  |
|------|------|
| incrementTitle |  Increment value |
| decrementTitle |  Decrement value |

* Before changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through `load` method of
  `L10n` class.

```typescript

ej.base.L10n.load({
        'en': {
            'numerictextbox': { incrementTitle: 'Increment value', decrementTitle: 'Decrement value' }
        },
        'de': {
            'numerictextbox': { incrementTitle: 'Wert erhöhen', decrementTitle: 'Dekrementwert' }
        },
        'zh': {
            'numerictextbox': { incrementTitle: '增值', decrementTitle: '遞減值' }
        }
    });

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/Internationalization/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/numeric-textbox/Internationalization/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/Internationalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/numeric-textbox/Internationalization/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](./images/localisation_sample.png)

## Right to Left

RTL provides an option to switch the text direction and layout of the NumericTextBox control from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL NumericTextBox, set the [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_EnableRtl) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/Internationalization/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/numeric-textbox/Internationalization/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/Internationalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/numeric-textbox/Internationalization/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](./images/localisation_rtl.png)
