---
layout: post
title: Prioritize Resource Colors For Events in ##Platform_Name## Schedule Component
description: Learn here all about Prioritize Resource Colors For Events in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Prioritize Resource Colors For Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prioritize the Resource Color for Events

By default top level resource color will be applied for the events. If user wants to apply specific resource color to events irrespective of its parent resource color, it can be achieved by `resourceColorField` field within `eventSettings` property as shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/resource-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/resource-color/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/resource-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/resource-color/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The `resourceColorField` field value should be as same as the `name` field value given with in `resources` property.