---
layout: post
title: Copypasterecords in ##Platform_Name## Gantt Component
description: Learn here all about Copypasterecords in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Copypasterecords
publishingplatform: ##Platform_Name##
documentation: ug
---


# Copy and Paste records in Gantt

You can copy and paste a record in the Gantt chart by using the `addRecord` method and `custom context menu`. It is also possible to copy and paste the parent record with multiple hierarchical child records on the required position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/copypasterecords/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Copypasterecords.cs" %}
{% include code-snippet/gantt/how-to/copypasterecords/copypasterecords.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/copypasterecords/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Copypasterecords.cs" %}
{% include code-snippet/gantt/how-to/copypasterecords/copypasterecords.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

