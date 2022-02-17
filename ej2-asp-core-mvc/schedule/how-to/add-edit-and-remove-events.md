---
layout: post
title: Add Edit And Remove Events in ##Platform_Name## Schedule Component
description: Learn here all about Add Edit And Remove Events in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Add Edit And Remove Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dynamically Add, Edit and Remove Events

CRUD actions can be manually performed on appointments using `addEvent`, `saveEvent` and `deleteEvent` methods as shown below.

## Normal event

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Recurrence event

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-recurrence-appointments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-recurrence-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-recurrence-appointments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-recurrence-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> When a single occurrence of the recurrence appointment is edited, `recurrenceID` field will be added which holds the `id` value of its parent recurrence appointment. It is applicable only for the edited occurrence appointments. Therefore the collection passing to the `saveEvent` with action as **EditOccurrence** should have `RecurrenceID` field as shown above.