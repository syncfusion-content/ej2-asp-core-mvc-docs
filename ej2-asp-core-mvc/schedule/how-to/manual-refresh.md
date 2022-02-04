---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Manual Refresh of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Manual Refresh
publishingplatform: ##Platform_Name##
documentation: ug
---


# Refresh Layout

In Scheduler, we can able to refresh the layout manually without re-render the DOM element by using the `refreshLayout` public method.  The following example code explains to know how to use the refreshLayout method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/manual-refresh/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/manual-refresh/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/manual-refresh/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/manual-refresh/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


