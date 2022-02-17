---
layout: post
title: Restrict Collapse Chart Rows in ##Platform_Name## Gantt Component
description: Learn here all about Restrict Collapse Chart Rows in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Restrict Collapse Chart Rows
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open add/edit dialog dynamically

Restriction of collapsing the records when clicking on gantt chart rows can be performed by using the [`collapsing`](../../api/gantt/#collapsing) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/restrictcollapsechartrows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Restrictcollapsechartrows.cs" %}
{% include code-snippet/gantt/how-to/restrictcollapsechartrows/restrictcollapsechartrows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/restrictcollapsechartrows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Restrictcollapsechartrows.cs" %}
{% include code-snippet/gantt/how-to/restrictcollapsechartrows/restrictcollapsechartrows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


