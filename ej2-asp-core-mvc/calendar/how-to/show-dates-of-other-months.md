---
layout: post
title: Show Dates Of Other Months in ##Platform_Name## Calendar Component
description: Learn here all about Show Dates Of Other Months in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Show Dates Of Other Months
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show dates of other months

The following example demonstrates how to show dates of other months.

Using the styles below, you can bring the dates of other months to visibility from its hidden state.

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

