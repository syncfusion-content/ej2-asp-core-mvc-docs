---
layout: post
title: Value Filtering in ##Platform_Name## Pivot Table Component
description: Learn here all about Value Filtering in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Value Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Value filtering

Value filtering allows you to perform filtering operation to be performed based on the aggregate values. For example, to show the data where the total sum of units sold for each country exceeds 2000, apply a value filter **2000** with filter operator **GreaterThan** on the country field.

Value filtering can be enabled by setting the `allowValueFilter` property to **true**.

## Value filtering through UI

Value filtering can also be performed through the UI option available in the [`grouping bar`](./grouping-bar) and [`field list`](./field-list) at runtime.

## Value filtering through code

It can be configured using the `filterSettings` option through the code-behind. The settings required to filter at initial rendering are:

* `name`: Sets the normal field name.
* `type`: Sets the filter type as **Value** to the field.
* `measure`: Sets the value field name.
* `condition`: Sets the operator type such as equals, greater than, less than, etc.
* `value1`: Sets the start value.
* `value2`: Sets the end value. It is applicable only for the operator such as 'Between' and 'NotBetween'.

Operators that can be used in label filtering are:

| Operator | Description |
|------|-------------|
| Equals| Displays the pivot table that matches with the value.|
| DoesNotEquals| Displays the pivot table that does not match with the given value.|
| GreaterThan| Displays the pivot table when the value is greater.|
| GreaterThanOrEqualTo| Displays the pivot table when the value is greater than or equal.|
| LessThan| Displays the pivot table when the value is lesser.|
| LessThanOrEqualTo| Displays the pivot table when the value is lesser than or equal.|
| Between| Displays the pivot table that records between start and end values.|
| NotBetween| Displays the pivot table that does not record between start and end values.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Member Filtering](./member-filtering)
* [Label Filtering](./label-filtering)