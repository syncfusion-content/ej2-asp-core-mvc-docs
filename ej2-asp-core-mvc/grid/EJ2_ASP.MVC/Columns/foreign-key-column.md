---
layout: post
title: Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Foreign Key Column in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Foreign Key Column

Foreign key column can be enabled by using [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource), [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) and [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) properties of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

* [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DataSource) - Defines the foreign data.
* [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) - Defines the mapping column name to the foreign data.
* [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue) - Defines the display field from the foreign data.

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



> For remote data, the sorting and grouping is done based on [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) instead of [`ForeignKeyValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyValue).
> If [`ForeignKeyField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ForeignKeyField) is not defined, then the column uses [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumnBuilder-1.html#Syncfusion_EJ2_Grids_GridColumnBuilder_1_Field_System_String_).