---
layout: post
title: Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Foreign Key Column in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Foreign Key Column

Foreign key column can be enabled by using [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource), [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) and [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) properties of **e-grid-column** tag helper.

* [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource) - Defines the foreign data.
* [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) - Defines the mapping column name to the foreign data.
* [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) - Defines the display field from the foreign data.

In the following example, **Employee Name** is a foreign column which shows **FirstName** column from foreign data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeView.cs" %}
{% include code-snippet/grid/columns/foreign/employeeView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EmployeeView.cs" %}
{% include code-snippet/grid/columns/foreign/employeeView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * For remote data, the sorting and grouping is done based on [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) instead of [`foreignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue).
> * If [`foreignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) is not defined, then the column uses [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) property of **e-grid-column** tag helper.



## Use edit template in foreignkey column

By default, foreign key column uses dropdown component for editing. You can render other than the dropdown by using the [`edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way of using edit template in foreign column.

In the following example, The **Employee Name** is a foreign key column and while editing, AutoComplete component is rendered instead of DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-template-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-template-foreign.cs" %}
{% include code-snippet/grid/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-template-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-template-foreign.cs" %}
{% include code-snippet/grid/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize filter UI in foreignkey column

You can create your own filtering UI by using [`filter`](https://helpsyncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Grids.GridColumn~Filter.html) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way to create a custom filtering UI in the foreign column.

In the following example, The **Employee Name** is a foreign key column. DropDownList is rendered using Filter UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-ui-foreign.cs" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-ui-foreign.cs" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Use filter bar template in foreignkey column

You can use the filter bar template in foreign key column by defining the [`filterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way to use filter bar template in foreign column.

In the following example, The **Employee Name** is a foreign key column. This column header shows the custom filter bar template and you can select filter value by using the `**DropDown** options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbar-temp-foreign.cs" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/filterbar-temp-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbar-temp-foreign.cs" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/filterbar-temp-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Perform aggregation in foreignkey column

Default aggregations are not supported in a foreign key column. You can achieve aggregation for the foreign key column by using the custom aggregates. The following example demonstrates the way to achieve aggregation in foreign key column.

In the following example, The **Employee Name** is a foreign key column and the aggregation for the foreign column was calculated in customAggregateFn.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/aggregate-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate-foreign.cs" %}
{% include code-snippet/grid/how-to/aggregate-foreign/aggregate-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/aggregate-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregate-foreign.cs" %}
{% include code-snippet/grid/how-to/aggregate-foreign/aggregate-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Bind data on foreign key columns with UrlAdaptor

You can bind the data on foreign key columns using `UrlAdaptor`. In the following example, **EmployeeID** is designated as a [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField), and **ShipName** is designated as a [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue).

To communicate with a specific DataSource, DataManager uses the adaptor idea. UrlAdaptor is used to interact with remote data services and to bind data on foreign key columns.

<!-- We attach data from datasource UserEditingSpeciesSiteLinksQuery to a foreign key column with using url adaptor. -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/binding-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="binding.cs" %}
{% include code-snippet/grid/how-to/binding-data/binding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/binding-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="binding.cs" %}
{% include code-snippet/grid/how-to/binding-data/binding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}