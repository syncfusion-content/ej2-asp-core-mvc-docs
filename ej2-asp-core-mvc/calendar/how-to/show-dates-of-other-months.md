---
layout: post
title: Show Dates of Other Months in ##Platform_Name## Calendar Control | Syncfusion
description: Learn here all about show dates of other months in ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show Dates of Other Months
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Dates of Other Months

The following example demonstrates how to show the hidden dates of other months using CSS styles.

```css
.e-calendar .e-content tr.e-month-hide,
.e-calendar .e-content td.e-other-month>span.e-day {
    display: block;
}

.e-calendar .e-content td.e-month-hide,
.e-calendar .e-content td.e-other-month {
    pointer-events: auto;
    touch-action: auto;
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/showdates/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Showdates.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/showdates/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showdates.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarHowToSample).