---
layout: post
title: Date Masking in ##Platform_Name## Datepicker Component
description: Learn here all about Date Masking in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Date Masking
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable the Masked Input

DatePicker has `enableMask` property that provides the option to enable the built-in date masking support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-input/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mask-input.cs" %}
{% include code-snippet/datepicker/mask-module/mask-input/mask-input.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mask-input.cs" %}
{% include code-snippet/datepicker/mask-module/mask-input/mask-input.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The mask pattern is defined based on the provided date format to the component. If the format is not specified, the mask pattern is formed based on the default format of the current culture.

| **Keys** | **Actions** |
| --- | --- |
| <kbd>Up / Down arrows</kbd> | To increment and decrement the selected portion of the date. |
| <kbd>Left / Right arrows and Tab</kbd> | To navigate the selection from one portion to next portion |

The following example demonstrates default and custom format of DatePicker component with mask.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/mask-module/mask-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-format.cs" %}
{% include code-snippet/datepicker/mask-module/mask-format/date-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure Mask Placeholder

You can change mask placeholder value through property `maskPlaceholder`. By default , it takes the full name of date and time co-ordinates such as `day`, `month`, `year`, `hour` etc.

While changing to a culture other than `English`, ensure that locale text for the concerned culture is loaded through load method of L10n class for mask placeholder values like below.

```typescript

//load the locale object to set the localized mask placeholder value
L10n.load({
'de': {
    'datepicker': { day: 'Tag' , month: 'Monat', year: 'Jahr' }
}
});

```

The following example demonstrates default and customized mask placeholder value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-placeholder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mask-placeholder.cs" %}
{% include code-snippet/datepicker/mask-module/mask-placeholder/mask-placeholder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/mask-module/mask-placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mask-placeholder.cs" %}
{% include code-snippet/datepicker/mask-module/mask-placeholder/mask-placeholder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


