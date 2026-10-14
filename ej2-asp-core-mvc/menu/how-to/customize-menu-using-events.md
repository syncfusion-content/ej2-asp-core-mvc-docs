---
layout: post
title: How to customize ##Platform_Name## Menu using events | Syncfusion
description: Customize Syncfusion ##Platform_Name## Menu items using the beforeItemRender, beforeOpen, beforeClose, and select events to change labels and behavior.
platform: ej2-asp-core-mvc
control: Customize Menu Using Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize ##Platform_Name## Menu using events

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


