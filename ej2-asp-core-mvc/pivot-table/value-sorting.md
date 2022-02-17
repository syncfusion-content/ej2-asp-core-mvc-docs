---
layout: post
title: Value Sorting in ##Platform_Name## Pivot Table Component
description: Learn here all about Value Sorting in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Value Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Value sorting

Value sorting allows you to sort individual column based on it's values either in ascending or descending order. It can been enabled by setting the `enableValueSorting` property to **true**. You can sort the column values by clicking the column header.

Value sorting can be configured using the `valueSortSettings` option through code behind. The settings required to sort value fields at initial rendering are:
* `headerText`: It allows to set the column header names with delimiters, that is used for value sorting.
* `headerDelimiter`: It allows to set the delimiters string to separate the given header text.
* `sortOrder`: It allows to set the sort direction of the value field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/value-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueSorting.cs" %}
{% include code-snippet/pivot-table/value-sorting/ValueSorting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/value-sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueSorting.cs" %}
{% include code-snippet/pivot-table/value-sorting/ValueSorting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Sorting](./sorting)