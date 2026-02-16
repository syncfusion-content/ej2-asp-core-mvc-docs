---
layout: post
title: Drill Through Grid Cell Edit Type in ##Platform_Name## Pivot Table Component
description: Learn here all about Drill Through Grid Cell Edit Type in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drill Through Grid Cell Edit Type
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drill-through grid's cell edit type

The drill-through feature in the Pivot Table allows users to view the raw data behind aggregated values by opening a detailed grid dialog. When this dialog appears, you can customize the edit behavior of specific columns to provide appropriate input controls based on their data types.

Using the [`DrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DrillThrough) event in the Pivot Table, you can define the edit type for any column in the drill-through grid. This is accomplished by checking the column name within the event handler and setting the appropriate edit type using the [`GridColumn.EditType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) event argument.

## Edit type options

The following edit types are available for different data types:

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



![Drill Through Grid Cell Edit Type](../images/edit-type.png)