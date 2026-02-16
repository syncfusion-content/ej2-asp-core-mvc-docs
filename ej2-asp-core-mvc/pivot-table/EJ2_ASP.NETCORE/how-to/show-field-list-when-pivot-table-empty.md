---
layout: post
title: Show Field List When ASP.NET Core Pivot Table Empty | Syncfusion
description: Learn here all about Show Field List When Pivot Table Empty in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Show Field List When Pivot Table Empty
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show field list when pivot table is empty

When there are no fields configured in a pivot table's row, column, value, and filter axes, the field list can be automatically displayed to help users configure the pivot table. This is particularly useful in scenarios where users start with an empty pivot configuration and need immediate access to available fields for setup. To achieve this functionality, use the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event and call the `onShowFieldList` method as demonstrated below.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/EditType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/EditType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Show field list when pivot table is empty](../images/empty-report-all-axes.png)