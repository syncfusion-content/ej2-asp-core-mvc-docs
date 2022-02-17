---
layout: post
title: Globalization And Localization in ##Platform_Name## Pivot Table Component
description: Learn here all about Globalization And Localization in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Globalization And Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Globalization

Globalization is the combination of internalization and localization. You can adapt the component to various languages by parsing and formatting the date or number ([`Internationalization`](https://ej2.syncfusion.com/aspnetcore/documentation/base/intl.html)) & adding culture specific customization and translation to the text ([`Localization`](https://ej2.syncfusion.com/aspnetcore/documentation/base/localization.html)).

## Internationalization

Internationalization library provides support for formatting and parsing the number, date, and time by using the official [`Unicode CLDR`](http://cldr.unicode.org/) JSON data and also provides the `loadCldr` method to load the culture specific CLDR JSON data.

By default, all the Essential JS 2 component are specific to English culture ('en-US'). If you want to go with the different culture other than English, follow the below steps.

* Install the `CLDR-Data` package by using the below command (it installs the CLDR JSON data). For more information about CLDR-Data, refer to this [link](http://cldr.unicode.org/index/cldr-spec/json).

```
npm install cldr-data --save
```

Once the package installed, you can find the culture specific JSON data under the location `\scripts\cldr-data`.

* Now use the
[`loadCultureFiles`](https://ej2.syncfusion.com/aspnetcore/documentation/base/intl.html#loading-culture-data)
method
to load the culture specific CLDR JSON data.

In ASP.NET MVC refer the culture files directly from `\scripts\cldr-data` location. In ASP.NET Core refer the culture files directly from `\wwwroot\scripts\cldr-data` location as like the below code examples for both ASP.NET Core and MVC

```sh
    function loadCultureFiles(de) {
        var files = ['ca-gregorian.json', 'numbers.json', 'timeZoneNames.json'];
        var loader = ej.base.loadCldr;
        var loadCulture = function (prop) {
            var val, ajax;
            <!--For ASP.NET MVC -->
            ajax = new ej.base.Ajax(location.origin + '/../scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
            <!--For ASP.NET Core-->
            ajax = new ej.base.Ajax(location.origin + '/../wwwroot/scripts/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
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

```sh
      var L10n = ej.base.L10n;
       L10n.load({
            "de": {
                'pivotview': {
                    'grandTotal': 'Gesamtsumme',
                    'total': 'Insgesamt',
                    'value': 'Wert',
                    'noValue': 'Kein Wert',
                    'row': 'Zeile',
                    'column': 'Spalte',
                    'collapse': 'Zusammenbruch',
                    'expand': 'Erweitern',
                },
            }
        });
```

* Set the culture by using the `locale` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/internationalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/pivot-table/globalization/internationalization/Internationalization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/pivot-table/globalization/internationalization/Internationalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * By default, `locale` value is `en-US`. If you want to change the `en-US` culture to a different culture, you have to change  the `locale` accordingly.

<!-- markdownlint-disable MD009 -->

### Decimal separators

The decimal separators of pivot table values varies based on the culture applied to the component. The culture can be set by calling the method [`setCulture`](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization/?no-cache=1#setting-global-culture) with appropriate culture string as its parameter. 

The following example demonstrates the decimal separators in `Deutsch` culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/locale/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Locale.cs" %}
{% include code-snippet/pivot-table/globalization/locale/Locale.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/locale/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Locale.cs" %}
{% include code-snippet/pivot-table/globalization/locale/Locale.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/localede.png)

## Localization

The [`Localization`](https://ej2.syncfusion.com/aspnetcore/documentation/base/localization.html) library allows you to localize default text content of the Pivot Table. The pivot table component has static text on some features (like drop area text, pivot field list title, etc...) that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the `locale` value and translation object.

The following list of properties and its values are used in the pivot table.

Locale keywords |Text
-----|-----
grandTotal | Grand Total
total | Total
value | Value
noValue | No value
row | Row
column | Column
collapse | Collapse
expand | Expand
rowAxisPrompt | Drop row here
columnAxisPrompt | Drop column here
valueAxisPrompt | Drop value here
filterAxisPrompt | Drop filter here
filter | Filter
filtered | Filtered
sort | Sort
filters | Filters
rows | Rows
columns | Columns
values | Values
close | Close
cancel | Cancel
delete | Delete
calculatedField | Calculated Field
createCalculatedField | Create Calculated Field
fieldName | Enter the field name
error | Error
invalidFormula | Invalid formula.
dropText | Example: ("Sum(Order_Count)" + "Sum(In_Stock)") * 250
dropTextMobile | Add fields and edit formula here.
dropAction | Calculated field cannot be place in any other region except value axis.
alert | Alert
warning | Warning
ok | OK
search | Search
drag | Drag
remove | Remove
sum | Sum
average | Average
count | Count
min | Min
max | Max
allFields | All Fields
formula | Formula
addToRow | Add to Row
addToColumn | Add to Column
addToValue | Add to Value
addToFilter | Add to Filter
emptyData | No records to display
fieldExist | A field already exists in this name. Please enter a different name.
confirmText | A calculation field already exists in this name. Do you want to replace it?
noMatches | No matches
format | Summaries values by
edit | Edit
clear | Clear
formulaField | Drag and drop fields to formula
dragField | Drag field to formula

The following list of properties and its values are used in the pivot field list.

Locale keywords |Text
-----|-----
staticFieldList | Pivot Field List
fieldList | Field List
dropFilterPrompt | Drop filter here
dropColPrompt | Drop column here
dropRowPrompt | Drop row here
dropValPrompt | Drop value here
addPrompt | Add field here
adaptiveFieldHeader | Choose field
centerHeader | Drag fields between axes below:
add | add
drag | Drag
filter | Filter
filtered | Filtered
sort | Sort
remove | Remove
filters | Filters
rows | Rows
columns | Columns
values | Values
calculatedField | Calculated Field
createCalculatedField | Create Calculated Field
fieldName | Enter the field name
error | Error
invalidFormula | Invalid formula.
dropText | Example: ("Sum(Order_Count)" + "Sum(In_Stock)") * 250
dropTextMobile | Add fields and edit formula here.
dropAction | Calculated field cannot be place in any other region except value axis.
search | Search
close | Close
cancel | Cancel
delete | Delete
alert | Alert
warning | Warning
ok | OK
sum | Sum
average | Average
count | Count
min | Min
max | Max
allFields | All Fields
formula | Formula
fieldExist | A field already exists in this name. Please enter a different name.
confirmText | A calculation field already exists in this name. Do you want to replace it?
noMatches | No matches
format | Summaries values by
edit | Edit
clear | Clear
formulaField | Drag and drop fields to formula
dragField | Drag field to formula

### Loading Translations

To load translation object in an application, use [`load`](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) function of the [`L10n`](https://ej2.syncfusion.com/documentation/common/api-l10n.html) class.

The following example demonstrates the Pivot Table in `Deutsch` culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/pivot-table/globalization/localization/Localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/pivot-table/globalization/localization/Localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Right-to-left (RTL)

RTL provides an option to switch the text direction and layout of the Pivot Table component from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc...). To enable RTL Pivot Table, set the `enableRtl` property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RTL.cs" %}
{% include code-snippet/pivot-table/globalization/rtl/RTL.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RTL.cs" %}
{% include code-snippet/pivot-table/globalization/rtl/RTL.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

