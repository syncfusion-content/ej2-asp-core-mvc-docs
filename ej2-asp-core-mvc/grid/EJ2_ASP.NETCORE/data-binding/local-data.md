---
layout: post
title: Local Data in ##Platform_Name## Grid Component
description: Learn here all about Local Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Local Data
publishingplatform: aspnet-core
documentation: ug
---


# Local Data

## List binding

To bind list binding to the grid, you can assign a IEnumerable object to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the `DataManager`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, `DataManager` uses `JsonAdaptor` for list data-binding.

## Refresh the data source

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the **refresh** method.

To refresh the data source:

**Step 1**:

Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**:

Refresh the grid after the data source change by using the **refresh** method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/refresh-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh-datasource.cs" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/refresh-datasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Refresh-datasource.cs" %}
{% include code-snippet/grid/how-to/refresh-datasource/refresh-datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

