---
layout: post
title: Prevent to Persist in ##Platform_Name## Grid Component
description: Learn here all about Prevent to Persist in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Prevent to Persist
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent to Persist

## Prevent columns from persisting

When the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the Grid properties such as [Grouping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html), [Paging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html), [Filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html), [Sorting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html), and [Columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) will persist. You can use the `addOnPersist` method to prevent these Grid properties from persisting.

The following example demonstrates how to prevent Grid columns from persisting. In the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid, you can override the `addOnPersist` method and remove the columns from the key list given for persistence.

>**Note:** When the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the Grid properties such as column template, column formatter, header text, and value accessor will not persist.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-prevent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/grid/state-persist/column-prevent/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/state-persist/column-prevent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-prevent.cs" %}
{% include code-snippet/grid/state-persist/column-prevent/column-prevent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

