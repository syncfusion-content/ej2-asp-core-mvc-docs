---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Globalization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Globalization
publishingplatform: ##Platform_Name##
documentation: ug
---

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

The code example demonstrates the DateRangePicker control in `Arabic` culture. It also explains how to set localized text to
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

