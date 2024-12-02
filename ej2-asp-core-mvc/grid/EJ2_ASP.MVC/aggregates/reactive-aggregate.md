---
layout: post
title: Reactive Aggregate in ##Platform_Name## Grid Component
description: Learn here all about Reactive Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Reactive Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reactive aggregate in ASP.Net MVC Grid component

The Syncfusion ASP.Net MVC Grid component provides support for reactive aggregates, which allow you to update the aggregate values dynamically as the data changes. Reactive aggregates automatically recalculate their values when there are changes in the underlying data, providing real-time updates to the aggregate values in the grid.

## Auto update aggregate value in batch editing

When the grid is in batch editing mode, the aggregate values in the footer, group footer, and group caption are automatically refreshed every time a cell is saved. This ensures that the aggregate values accurately reflect the edited data.

Here's an example code snippet demonstrating how to auto update aggregate value in batch editing:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="reactive-aggregate-batch-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-batch-edit/reactive-aggregate-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}

![Auto update aggregate value in batch editing](../images/aggregates/aggregate-batch.gif)

> Adding a new record to the grouped grid will not refresh the aggregate values.

## Refresh aggregate values in inline editing

By default, reactive aggregate update is not supported by inline and dialog edit modes as it is not feasible to anticipate the value change event for every editor. But, you can refresh the aggregates manually in the inline edit mode using the refresh method of aggregate module.

In the following code, the input event for the Freight column editor has been registered and the aggregate value has been refreshed manually.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="reactive-aggregate-inline-edit.cs" %}
{% include code-snippet/grid/aggregate/reactive-agg-inline-edit/reactive-aggregate-inline-edit.cs %}
{% endhighlight %}
{% endtabs %}

![Group footer aggregates](../images/aggregates/inline.gif)


