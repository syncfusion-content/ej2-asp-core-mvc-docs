---
layout: post
title: How to Refresh the Field List while Change the Data Source in ##Platform_Name## Pivot Table | Syncfusion
description: Learn how to refresh the ##Platform_Name## Pivot Table and its field list with a new data source dynamically at runtime by reassigning the data source and rebinding.
platform: ej2-asp-core-mvc
control: Refresh The Field List
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Refresh the Field List while Change the Data Source in ##Platform_Name## Pivot Table

You can refresh pivot table and field list with new data source dynamically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/refresh/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh.cs" %}
{% include code-snippet/pivot-table/field-list/refresh/Refresh.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/refresh/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh.cs" %}
{% include code-snippet/pivot-table/field-list/refresh/Refresh.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


