---
layout: post
title: Apply Condition Based Hyper Link For Specific Row Or Column in ##Platform_Name## Pivot Table Component
description: Learn here all about Apply Condition Based Hyper Link For Specific Row Or Column in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Apply Condition Based Hyper Link For Specific Row Or Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Apply condition based hyperlink for specific row or column

You can apply conditions for specific row or column using `label` option to show hyperlink option in the pivot table. It can be configured using the `conditionalSettings` option through code behind, during initial rendering. The required settings are:

* `label`: Specifies the header name to get visibility of hyperlink option for row or column.
* `condition`: Specifies the operator type such as equals, greater than, less than, etc.
* `value1`: Specifies the start value.
* `value2`: Specifies the end value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/label-conditions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelConditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/label-conditions/LabelConditions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hyper-link/label-conditions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelConditions.cs" %}
{% include code-snippet/pivot-table/hyper-link/label-conditions/LabelConditions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


