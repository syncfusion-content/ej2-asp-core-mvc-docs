---
layout: post
title: Auto Generated Columns in ##Platform_Name## Grid Component
description: Learn here all about Auto Generated Columns in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Auto Generated Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Auto Generated Columns

The [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) are automatically generated when
[`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) declaration is empty or undefined while initializing the grid. All the columns in the **DataSource** are bound as grid columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/grid/columns/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto.cs" %}
{% include code-snippet/grid/columns/auto/auto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> When columns are auto-generated, the column [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) will be determined from the first record of the **DataSource**.

## Set Primary key column for auto generated columns when editing is enabled

Primary key can be defined in the declaration of column object of the grid. If you did not declare the columns, the grid will generate the columns automatically. For these auto generated columns, you can set [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property of **e-grid-column** as true by using the following ways,

If Primary key "column index" is known then refer the following example

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/primary/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/grid/columns/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/primary/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/grid/columns/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If Primary key "column fieldname" is known then you can get the column by using `var column = grid.getColumnByField('OrderID')` and then set primary key by defining [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property as true in **e-grid-column** tag helper.

## Set column options to auto generated columns

You can set column options such as [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format), [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) to the auto generated columns by using [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the grid.

In the below example, [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) is set for **OrderID** column, **date** type is set for **OrderDate** column and **numeric** type is set for **Freight** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autocolumnformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autocolumnformat.cs" %}
{% include code-snippet/grid/columns/autocolumnformat/autocolumnformat.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autocolumnformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autocolumnformat.cs" %}
{% include code-snippet/grid/columns/autocolumnformat/autocolumnformat.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

