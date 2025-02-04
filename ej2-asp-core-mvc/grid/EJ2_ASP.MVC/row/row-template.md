---
layout: post
title: Row Template in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row template in ASP.NET MVC Grid component

The row template feature in Grid allows you to customize the appearance and layout of rows in the grid. This feature is useful when you want to display custom content, such as images, buttons, or other controls, within the rows.

To enable the row template feature, you need to set the [RowTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property of the Grid component. This property accepts a custom HTML template that defines the layout for each row. 

In the following example, Employee Information with Employee Photo is presented in the first column and employee details like Name, Address, etc., are presented in the second column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}

![Row Template](../images/row/row-template.png)

## Row template with formatting

The row template feature in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid allows you to customize the layout of rows in the grid. This is useful when you want to display images, buttons, or other custom content within the rows of a grid.

By default, Syncfusion<sup style="font-size:70%">&reg;</sup> Grid provides the `Columns.Format` property to format the values displayed in each column. However, when using the [RowTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate), the `Columns.Format` property cannot be directly applied to format the values inside the template.

To format the values within the row template, you can define a global function that handles the formatting logic. This function can be invoked inside the template to format the corresponding values.

Here is an example of how to define a global formatting function for a date column and use it inside a `RowTemplate`:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/format-row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/row/format-row-template/format.cs %}
{% endhighlight %}
{% endtabs %}

![Row Template](../images/row/format-row-template.png)

> When using the `RowTemplate` feature in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid, keep in mind that any formatting applied to columns using the `Columns.Format` property will not work inside the template.

## Render syncfusion<sup style="font-size:70%">&reg;</sup> control in row template

The Grid allows you to render custom Syncfusion<sup style="font-size:70%">&reg;</sup> controls within the rows of the grid. This feature is helpful as it enables you to display interactive Syncfusion<sup style="font-size:70%">&reg;</sup> controls instead of field values in the grid.

To enable a Syncfusion<sup style="font-size:70%">&reg;</sup> control in a row template, you need to set the [RowTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property of the Grid component. This property accepts a custom HTML template that defines the layout for each row. 

Here is an example that demonstrates rendering Syncfusion<sup style="font-size:70%">&reg;</sup> controls within a row template :

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/row/row-template-component/template.cs %}
{% endhighlight %}
{% endtabs %}

![Row Template](../images/row/row-template-component.png)

## Render syncfusion<sup style="font-size:70%">&reg;</sup> chart control in row template

The Syncfusion<sup style="font-size:70%">&reg;</sup> Grid component provides the flexibility to include custom controls, such as charts, within the rows of the grid. This feature enhances the grid interactivity by enabling you to display visual data representations by displaying graphical representations of data instead of plain text.

To render a Syncfusion<sup style="font-size:70%">&reg;</sup> chart within a row template of the Grid, you can utilize the [RowTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property. This property accepts a custom HTML template that specifies the layout for each row, allowing for rich data visualization.

Here is an example that demonstrates rendering Syncfusion chart control within a row template :

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/row/row-template-chart/template.cs %}
{% endhighlight %}
{% endtabs %}

![Row Template](../images/row/row-template-chart.png)

## Limitations

Row template feature is not compatible with all the features which are available in the grid, and it has limited features support. The features that are incompatible with the row template feature are listed below.

* Filtering
* Paging
* Sorting
* Searching
* Rtl
* Export
* Context Menu
* State Persistence
* Selection
* Grouping
* Editing
* Frozen rows & columns
* Virtual & Infinite scrolling
* Column chooser
* Column menu
* Detail Row
* Foreignkey column
* Resizing
* Reordering
* Aggregates
* Clipboard
* Adaptive view