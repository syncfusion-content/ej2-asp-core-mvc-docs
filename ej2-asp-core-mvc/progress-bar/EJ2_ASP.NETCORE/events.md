---
layout: post
title: Events in ##Platform_Name## Progress Bar Component
description: Learn here all about Events in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---


# Events

## ValueChanged

<!-- markdownlint-disable MD033 -->

This event is triggered when the progress value is changed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/events/value-changed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value-changed.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/events/value-changed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value-changed.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## ProgressCompleted

This event is triggered when the progress attains the Maximum value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/events/progress-completed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Progress-completed.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/events/progress-completed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Progress-completed.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

