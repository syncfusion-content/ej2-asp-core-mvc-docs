---
layout: post
title: Refresh Field List in ##Platform_Name## Pivot Table | Syncfusion
description: Learn how to refresh the ##Platform_Name## Pivot Table and its field list with a new data source dynamically at runtime by reassigning the data source and rebinding.
platform: ej2-asp-core-mvc
control: Refresh The Field List
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to refresh the field list in ##Platform_Name## Pivot Table

The ##Platform_Name## Pivot Table component allows dynamic data source updates, enabling you to refresh both the pivot table and field list with new data at runtime. This approach is especially useful in scenarios where data changes frequently or when switching between different datasets without reinitializing the entire component.

## Implementation

The following code example demonstrates how to refresh the Pivot Table and field list with new data using an external button click. The implementation involves clearing the existing field list cache by resetting the `fieldList` object and updating the data source with a new dataset. This approach ensures that the component recognizes structural changes in the data and rebuilds the field list accordingly.

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


