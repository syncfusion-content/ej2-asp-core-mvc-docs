---
layout: post
title: AutoFit Columns in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about AutoFit Columns in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: AutoFit Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# AutoFit Columns in ASP.NET MVC Grid Component

The Grid has a feature that allows it to automatically adjust column widths based on the maximum content width of each column when you double-click on the resizer symbol located in a specific column header.  This feature ensures that all data in the grid rows is displayed without wrapping. To use this feature, you need to enable the resizer symbol in the column header by setting the [AllowResizing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property to true in the grid.

## Resizing a Column to fit its content using autoFit method

The [autoFitColumns](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the `autoFitColumns` method in [DataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> You can autofit all the columns by invoking the `autoFitColumns` method without specifying column names.

## AutoFit columns with empty space

The Autofit feature is utilized to display columns in a grid based on the defined width specified in the columns declaration. If the total width of the columns is less than the width of the grid, this means that white space will be displayed in the grid instead of the columns auto-adjusting to fill the entire grid width.

You can enable this feature by setting the [AutoFit](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AutoFit)property set to true. This feature ensures that the column width is rendered only as defined in the Grid column definition.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFit.cs" %}
{% include code-snippet/grid/columns/autofit-column/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFit.cs" %}
{% include code-snippet/grid/columns/autofit-column/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>If any one of the column width is undefined, then the particular column will automatically adjust to fill the entire width of the grid table, even if you have enabled the `AutoFit` property of grid.

## AutoFit columns with specific rows

To adjust the column widths of a specific range of rows based on their content, you can use the [autoFitColumns](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method by simply passing the second and third parameters (optional) as the start and end index for the column you want to fit. You can autofit specific columns at initial rendering by invoking the `autoFitColumns` method in [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

This feature will calculate the appropriate width based on the maximum content width of the specified range of rows or the header text width. Subsequently, the maximum width of the content of the specified rows or header text will be applied to the entire column of the grid.

Here is an example of how to autofit columns with specific rows. The first parameter is an array containing the specific column field names, such as  **Inventor**, **Number of INPADOC patents** and **Main fields of invention**  is passed to apply the autofit functionality to these columns. After, the second parameter are start index is set to **1** and third parameter are end index is set to **3**. When specifying these start and end index, the autofit operation is applied only to the range of rows from 1 to 3 for column width adjustment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFitSpecificColumn.cs" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/autofitspecificcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFitSpecificColumn.cs" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/autofitspecificcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}