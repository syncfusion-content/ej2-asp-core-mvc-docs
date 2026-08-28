---
layout: post
title: Multi Selection in ##Platform_Name## Calendar Control | Syncfusion
description: Learn here all about Multi Selection in Syncfusion ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Multi Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Multi Selection in Calendar Control

Calendar provides an option to select **single** or **multiple dates** by using the `isMultiSelection` and `values` properties. By default, the `isMultiSelection` property is disabled.

| API | Type | Description |
|------|------|----------------------|
| `isMultiSelection` | **Boolean** | Enables the multi-selection option in the Calendar control |
| `values` | **Date[]** | Gets or sets the selected dates in multi-selection mode |

The following example demonstrates the `isMultiSelection` and `values` properties of the Calendar control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/multi-select/multi/tagHelper %}
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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarUGSample).