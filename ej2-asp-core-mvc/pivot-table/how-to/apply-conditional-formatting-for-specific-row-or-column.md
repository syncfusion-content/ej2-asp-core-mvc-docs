---
layout: post
title: Apply Conditional Formatting For Specific Row Or Column in ##Platform_Name## Pivot Table Component
description: Learn here all about Apply Conditional Formatting For Specific Row Or Column in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Apply Conditional Formatting For Specific Row Or Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Apply conditional formatting for specific row or column

You can apply conditional formatting for specific row or column using `label` option in the pivot table. It can be configured using the `conditionalFormatSettings` option through code behind, during initial rendering. The required settings are:

* `label`: Specifies the header name to apply conditions for row or column.
* `condition`: Specifies the operator type such as equals, greater than, less than, etc.
* `value1`: Specifies the start value.
* `value2`: Specifies the end value.
* `style`: Specifies the style for the cell.

To use the conditional formatting feature, You need to inject the `ConditionalFormatting` module in pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelFormatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/label/LabelFormatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelFormatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/label/LabelFormatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


