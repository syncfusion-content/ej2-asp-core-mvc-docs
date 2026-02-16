---
layout: post
title: Display string value to pivot table values in ##Platform_Name## Pivot Table Component
description: Learn here all about Display string value to pivot table values in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Display string value to pivot table values
documentation: ug
publishingplatform: ##Platform_Name## 
---
# Display string value to pivot table values

# Display string values in ##Platform_Name## Pivot Table cells

The Pivot Table allows users to display custom string values in value cells by using the [`AggregateCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event. This is useful when you need to format numeric values into readable strings, such as converting seconds to time format or applying custom formatting rules.

## Converting numeric values to time format

The following example demonstrates how to convert numeric values in the **Sold** field to time format (HH:MM:SS) using the [`AggregateCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event. The event provides access to cell data through `args.cellSets`, allowing you to customize the display value based on the underlying data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/display-string-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayStringValue.cs" %}
{% include code-snippet/pivot-table/display-string-value/DisplayStringValue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/display-string-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayStringValue.cs" %}
{% include code-snippet/pivot-table/display-string-value/DisplayStringValue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Display string value to pivot table values](../images/display-string-value.png)
