---
layout: post
title: Show Field List When Pivot Table Empty in ##Platform_Name## Pivot Table Component
description: Learn here all about Show Field List When Pivot Table Empty in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Show Field List When Pivot Table Empty
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show field list when pivot table is empty

When there are no fields in a pivot table's row, column, value, and filter axes, a field list can still be displayed. To do so, use the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event and call the `onShowFieldList` method as shown below.

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



![output](images/empty-report-all-axes.png)