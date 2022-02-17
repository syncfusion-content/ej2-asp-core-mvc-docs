---
layout: post
title: Refresh The Field List in ##Platform_Name## Pivot Table Component
description: Learn here all about Refresh The Field List in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Refresh The Field List
publishingplatform: ##Platform_Name##
documentation: ug
---

# Refresh the field list while change the data source

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


