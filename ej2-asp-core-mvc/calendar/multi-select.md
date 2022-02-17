---
layout: post
title: Multi Select in ##Platform_Name## Calendar Component
description: Learn here all about Multi Select in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Multi Select
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multi Selection

Calendar provides an option to select **single** or **multiple dates** by using `isMultiSelection` and `values` properties. By default, `isMultiSelection` property will be in disabled state.

| API | Type | Description |
|------|------|----------------------|
| `isMultiSelection`| **Boolean**| Enables the multi-selection option in the Calendar control |
|`values`| **Date[]** | Gets or sets the date range values in multi-selection option |

The following example demonstrates the functionality of  `isMultiSelection` property and `values` properties in the Calendar control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/calendar/multi-select/multi/multi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/calendar/multi-select/multi/multi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

