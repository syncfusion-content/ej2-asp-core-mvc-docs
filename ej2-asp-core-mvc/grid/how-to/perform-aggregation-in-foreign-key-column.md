---
layout: post
title: Perform Aggregation In Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Perform Aggregation In Foreign Key Column in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Perform Aggregation In Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Perform aggregation in Foreign Key Column

Default aggregations are not supported in a foreign key column. You can achieve aggregation for the foreign key column by using the custom aggregates. The following example demonstrates the way to achieve aggregation in foreign key column.

In the following example, The `Employee Name` is a foreign key column and the aggregation for the foreign column was calculated in customAggregateFn.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/aggregate-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate-foreign.cs" %}
{% include code-snippet/grid/how-to/aggregate-foreign/aggregate-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/aggregate-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate-foreign.cs" %}
{% include code-snippet/grid/how-to/aggregate-foreign/aggregate-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


