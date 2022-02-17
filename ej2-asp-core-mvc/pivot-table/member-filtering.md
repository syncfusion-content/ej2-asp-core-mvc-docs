---
layout: post
title: Member Filtering in ##Platform_Name## Pivot Table Component
description: Learn here all about Member Filtering in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Member Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Member filtering

Member filtering allows you to view pivot table with particular records based on filter criteria. You can disable the member filter by setting the `allowMemberFilter` property to **false**. By default, this property is set as **true**.

## Filtering through UI

Filtering can also be performed through UI option available in [`grouping bar`](./grouping-bar) and [`field list`](./field-list) at run time.

## Filtering through code

It can be configured using the `filterSettings` option through code-behind. The settings required to filter at initial rendering are:
* `name`: It allows to set field name.
* `type`: It allows to set filter type as either "Include" or "Exclude" to the field.
* `items`: It allows to set the filter members of the field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Label Filtering](./label-filtering)
* [Value Filtering](./value-filtering)