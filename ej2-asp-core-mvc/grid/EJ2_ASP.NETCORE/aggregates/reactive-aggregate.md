---
layout: post
title: Reactive Aggregate in ##Platform_Name## Grid Component
description: Learn here all about Reactive Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Reactive Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---


# Reactive Aggregate

## Auto update aggregate value in batch editing

When using batch editing, the aggregate values will be refreshed on every cell save. The footer, group footer, and group caption aggregate values will be refreshed.

> Adding a new record to the grouped grid will not refresh the aggregate values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-batch-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-batch-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/reactive-agg-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Refresh aggregate values in inline editing

By default, reactive aggregate update is not supported by inline and dialog edit modes as it is not feasible to anticipate the value change event for every editor. But, you can refresh the aggregates manually in the inline edit mode using the refresh method of aggregate module.

In the following code, the input event for the Freight column editor has been registered and the aggregate value has been refreshed manually.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-inline-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reactive-agg-inline-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/reactive-agg-inline-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

