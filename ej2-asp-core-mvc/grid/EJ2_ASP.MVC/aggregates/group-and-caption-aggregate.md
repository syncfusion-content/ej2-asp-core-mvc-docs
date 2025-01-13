---
layout: post
title: Group and Caption Aggregate in ##Platform_Name## Grid Component
description: Learn here all about Group and Caption Aggregate in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Group and Caption Aggregate
publishingplatform: ##Platform_Name##
documentation: ug
---

# Group and caption aggregate in ASP.Net MVC Grid component

Group footer and caption aggregates in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Net MVC Grid component allow you to calculate aggregate values based on the current group items. These aggregate values can be displayed in the group footer cells and group caption cells, respectively. To achieve this, you can use the `GroupFooterTemplate` and `GroupCaptionTemplate` properties of the `AggregateColumn`.

> When working with group aggregates in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid, it is important to set the property [AllowGrouping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) of the `Column` to **true**. 
> To maintain grouped columns in the grid after grouping, set [ShowGroupedColumn](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowGroupedColumn) to **true**.

## Group footer aggregates

Group footer aggregates are displayed in the footer cells of each group. These cells appear at the bottom of each group and provide aggregate values based on the grouped data. To display group footer aggregates, you need to provide a template using the `GroupFooterTemplate` property. The template will be used to render the aggregate values in the group footer cells.

Here's an example that demonstrates how to use group footer aggregates in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Net MVC Grid component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-footer-aggregates/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group-footer.cs" %}
{% include code-snippet/grid/aggregate/group-footer-aggregates/group-footer.cs %}
{% endhighlight %}
{% endtabs %}

![Group footer aggregates](../images/aggregates/group-footer-aggregates.png)

> * Use the template reference variable name as **GroupFooterTemplate** to specify the group footer template and as **GroupCaptionTemplate** to specify the group caption template.
> * The aggregate values must be accessed inside the template using their corresponding `Type` name.

## Group caption aggregates

Group caption aggregates are displayed in the caption cells of each group. These cells appear at the top of each group and provide a summary of the grouped data. To display group caption aggregates, you can use the `GroupCaptionTemplate` property. This property allows you to define a template that will be used to display the aggregate values in the group caption cells.

Here's an example that demonstrates how to use group and caption aggregates in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Net MVC Grid component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-caption-aggregates/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-caption-aggregates/group-caption.cs %}
{% endhighlight %}
{% endtabs %}

![Group caption aggregates](../images/aggregates/group-caption-aggregates.png)

> The group total summary in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid is calculated based on the current page records for each group by default.
> If you require aggregates for all the data in the grid, you can enable the [DisablePageWiseAggregates](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) property.

## Disable page wise aggregates for grouping

In some cases, you may want to disable the page-wise aggregates for grouping in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Net MVC Grid component. By default, when grouping is enabled with paging, the grid calculates the aggregates for each page separately. However, you can choose to disable this behavior and calculate aggregates for the entire grouped data instead. This can be achieved by setting the [DisablePageWiseAggregates](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) property to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/group-disable-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group-caption.cs" %}
{% include code-snippet/grid/aggregate/group-disable-page/group-caption.cs %}
{% endhighlight %}
{% endtabs %}

![Disable page wise aggregates for grouping](../images/aggregates/group-disable-page.gif)

## Customize the background color of group caption and footer aggregates based on a condition

The Syncfusion Grid control allows dynamically applying background colors to group caption and footer aggregate cells based on specific conditions. This can be achieved by customizing the [dataBound](../api/grid/#databound) event.

Within the `dataBound` event handler, group caption and footer cells are selected using **querySelectorAll** and assigned to arrays for processing. Conditional logic is then applied to set the background color of these cells. In this example, the background color of group caption cells is set to **red** if the value is less than **100**, and **green** otherwise. For group footer cells, the background color is set to **blue** if the value is less than **50**, and **orange** otherwise.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/aggregate/aggregates-background-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="aggregates-background-color.cs" %}
{% include code-snippet/grid/aggregate/aggregates-background-color/aggregates-background-color.cs %}
{% endhighlight %}
{% endtabs %}

![Customize the background color of group caption and footer aggregates](../images/aggregates/aggregates-background-color.png)