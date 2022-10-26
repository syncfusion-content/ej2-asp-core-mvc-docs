---
layout: post
title: Events in ##Platform_Name## Floating Action Button Control | Syncfusion
description: Learn here all about Events in Syncfusion ##Platform_Name## Floating Action Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in Floating Action Button Control

This section explains the available events in Floating Action Button Control.

## Created

Event triggers after the creation of Floating Action Button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/created-event/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/created-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CreatedEvent.cs" %}
{% include code-snippet/floating-action-button/events/created-event/createdevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## OnClick

Event triggers when the Floating Action Button is clicked. Below example shows the Click event of the Floating Action Button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/onclick-event/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/floating-action-button/events/onclick-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OnClickEvent.cs" %}
{% include code-snippet/floating-action-button/events/onclick-event/onclickevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Asp.Net Core FAB Control with OnClick Event](images/CoreOnClickEvent.png)
![Asp.Net Core FAB Control with OnClick Event](images/CoreOnClickEvent1.png)