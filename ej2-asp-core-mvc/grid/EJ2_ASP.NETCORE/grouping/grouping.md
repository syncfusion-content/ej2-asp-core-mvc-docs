---
layout: post
title: Grouping in ##Platform_Name## Grid Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping

The Grid has options to group records by dragging and dropping the column header to the group drop area. When grouping is applied, grid records are organized into a hierarchical structure to facilitate easier expansion and collapse of records.

To enable grouping in the grid, set the [`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) as true. Grouping options can be configured through the [`e-grid-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GroupSettings) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/grid/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/grid/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * You can group and ungroup columns by using the **groupColumn** and **ungroupColumn** methods.
> * To disable grouping for a particular column, set the [`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) to false in **e-grid-column** tag helper.

## Initial group

To apply group at initial rendering, set the column field name in the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_Columns) property of **e-grid-groupsettings** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/initial-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-group.cs" %}
{% include code-snippet/grid/grouping/initial-group/initial-group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/initial-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-group.cs" %}
{% include code-snippet/grid/grouping/initial-group/initial-group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hide drop area

To avoid ungrouping or further grouping of a column after initial column grouping, define the [`showDropArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowDropArea) of **e-grid-groupsettings**  as false.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/hide-drop-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-drop-area.cs" %}
{% include code-snippet/grid/grouping/hide-drop-area/hide-drop-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/hide-drop-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-drop-area.cs" %}
{% include code-snippet/grid/grouping/hide-drop-area/hide-drop-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group with paging

On grouping columns with paging feature, the aggregated information and total items are displayed based on the current page. The grid does not consider aggregated information and total items from other pages. To get additional details (aggregated information and total items) from other pages, set the [`disablePageWiseAggregates`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) property of **e-grid-groupsettings** to false.

> If remote data is bound to grid dataSource, two requests will be sent when performing grouping action; one for getting the grouped data and another for getting aggregate details and total items count.

## Group by format

By default, a column will be grouped by the data or value present for the particular row. To group the numeric or datetime column based on the mentioned format, you have to enable the [`enableGroupByFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EnableGroupByFormat) property of the corresponding grid columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-format.cs" %}
{% include code-snippet/grid/grouping/group-format/group-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-format.cs" %}
{% include code-snippet/grid/grouping/group-format/group-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grouping events

During the group action, the grid component triggers two events. The [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event triggers before the group action starts and the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event triggers after the group action is completed. Using these events you can perform any action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/grouping-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping-events.cs" %}
{% include code-snippet/grid/grouping/grouping-events/grouping-events.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/grouping-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping-events.cs" %}
{% include code-snippet/grid/grouping/grouping-events/grouping-events.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The `args.requestType` is based on the current action name. For example, when grouping, the `args.requestType` value will be 'grouping'.

## Collapse by external button

You can collapse the selected group from an external button by invoking the **expandCollapseRows** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/collapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/grid/grouping/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/collapse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/grid/grouping/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Exporting grouped records](../../EJ2_ASP.NETCORE/excel-export/excel-exporting#Exporting-grouped-records)