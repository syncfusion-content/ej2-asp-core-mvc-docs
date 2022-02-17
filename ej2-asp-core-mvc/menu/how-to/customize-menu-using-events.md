---
layout: post
title: Customize Menu Using Events in ##Platform_Name## Menu Component
description: Learn here all about Customize Menu Using Events in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Customize Menu Using Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize menu using events

The Menu provides a set of `events` to enable users to customize it.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/handle-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HandleEvents.cs" %}
{% include code-snippet/menu/how-to/handle-events/HandleEvents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/handle-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HandleEvents.cs" %}
{% include code-snippet/menu/how-to/handle-events/HandleEvents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


