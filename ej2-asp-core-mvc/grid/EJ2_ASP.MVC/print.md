---
layout: post
title: Print in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Print in ASP.NET MVC Grid component

The printing feature in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid allows you to easily generate and print a representation of the grid's content for better offline accessibility and documentation. You can enable this feature using either the grid's toolbar or the programmatically available `print` method.

To add the printing option to the grid's toolbar, simply include the [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property in your grid configuration and add the **Print** as toolbar item. This will allow you to directly initiate the printing process while click on the Print item from the toolbar.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="print.cs" %}
{% include code-snippet/grid/print/print/print.cs %}
{% endhighlight %}
{% endtabs %}

![Print](images/print/print.png)

## Page setup

When printing a webpage, some print options, such as layout, paper size, and margin settings, cannot be configured through JavaScript code. Instead, you need to customize these settings using the browser's page setup dialog. Below are links to the page setup guides for popular web browsers:

* [Chrome](https://support.google.com/chrome/answer/1069693?hl=en&visit_id=1-636335333734668335-3165046395&rd=1)
* [Firefox](https://support.mozilla.org/en-US/kb/how-print-web-pages-firefox)
* [Safari](http://www.mintprintables.com/print-tips/adjust-margins-osx/)
* [IE](http://www.helpteaching.com/help/print/index.htm)

## Print by external button

You can print the grid's content using an external button by utilizing the `print` method. This method allows you to trigger the printing process programmatically.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/external-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="External-btn.cs" %}
{% include code-snippet/grid/print/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}

![Print by external button](images/print/print-external.png)

## Print visible Page

By default, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid prints all the pages of the grid. The [PrintMode](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_PrintMode) property within the grid grants you control over the printing process. However, if you want to print only the current visible page, you can achieve this by setting the `PrintMode` property to **CurrentPage**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/current-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Current-page.cs" %}
{% include code-snippet/grid/print/current-page/current-page.cs %}
{% endhighlight %}
{% endtabs %}

![Print visible Page](images/print/print-current.png)

## Print only selected records

By default, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid prints all the data bound to its dataSource. However, there might be cases where you want to print only the selected records from the grid. The ASP.NET MVC Grid provides an option to achieve this by binding to the [BeforePrint](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_BeforePrint) event, where you can replace the rows of the printing grid with the selected rows.

Below is an example code that demonstrates how to print only the selected records from the ASP.NET MVC Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print-select/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/grid/print/print-select/print.cs %}
{% endhighlight %}
{% endtabs %}

![Print only selected records](images/print/print-select.png)

## Print the hierarchy grid

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid allows you to print hierarchy grids, which consist of a parent grid and its child grids. By default, when you print a hierarchy grid, it includes the parent grid and expanded child grids only. However, you can customize the print behavior using the [HierarchyPrintMode](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_HierarchyPrintMode) property.

The `HierarchyPrintMode` property in the ASP.NET MVC Grid lets you control the printing behavior for hierarchy grids. You can choose from three options:

| Mode     | Behavior                                                                        |
| -------- | ------------------------------------------------------------------------------- |
| Expanded | Prints the parent grid with expanded child grids.                               |
| All      | Prints the parent grid with all the child grids, whether expanded or collapsed. |
| None     | Prints the parent grid alone.                                                   |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/hierarchyprint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/print/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}

![Print the hierarchy grid](images/print/print-hierachy.png)

## Print the master detail grid

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid provides the option to visualize details of a record in another grid in a master-detail manner. By default, when you print a master-detail grid, only the master grid is included in the print output. However, you can customize the print behavior to include both the master and detail grids using the `BeforePrint` event of the grid.

The [BeforePrint](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_BeforePrint)event in the ASP.NET MVC Grid is triggered before the actual printing process begins. You can handle this event to customize the print output. By adding the detail grid to the `element` argument of the `BeforePrint` event, you can ensure that both the master and detail grids are printed on the page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/masterdetailgrid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Master-Detail.cs" %}
{% include code-snippet/grid/print/masterdetailgrid/masterdetailgrid.cs %}
{% endhighlight %}
{% endtabs %}

![Print the master detail grid](images/print/print-master.png)

## Print large number of columns

When printing a grid with a large number of columns, the browser's default page size (usually A4) might not be sufficient to display all the columns properly. As a result, the browser's print preview may automatically hide the overflowed content, leading to a cut-off appearance.

To show a large number of columns when printing, you can adjust the scale option from the print option panel based on your content size. This will allow you to fit the entire grid content within the printable area.

![Scale Option Setting](images/print-preview.png)

## Show or hide columns while printing

In the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid, you have the flexibility to control the visibility of columns during the printing process. You can dynamically show or hide specific columns using the [ToolbarClick](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [PrintComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_PrintComplete) events while printing. This capability enhances your control over which columns are included in the printed output, allowing you to tailor the printed grid to your specific needs.

In the `ToolbarClick` event, you can show or hide columns by setting `Column.Visible` property to **true** or **false** respectively.

In the `PrintComplete` event, the column visibility state is reset back to its original configuration.

Here's a code example that demonstrates how to show a hidden column (CustomerID) and hide a visible column (ShipCity) during printing and then reset their visibility after printing:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/show-hide-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/print/show-hide-columns/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide columns while printing](images/print/print-hide.png)

## Limitations of printing large data

Printing a large volume of data all at once in the grid can have certain limitations due to potential browser performance issues. Rendering numerous DOM elements on a single page can lead to browser slowdowns or even hang the browser. The grid offers a solution to manage extensive datasets through virtualization. However, it's important to note that virtualization for both rows and columns is not feasible during the printing process.

If printing all the data remains a requirement, an alternative approach is recommended. Exporting the grid data to formats like [Excel](https://ej2.syncfusion.com/aspnetcore/documentation/grid/excel-export/excel-exporting) or [CSV](https://ej2.syncfusion.com/aspnetcore/documentation/grid/excel-export/excel-exporting) or [Pdf](https://ej2.syncfusion.com/aspnetcore/documentation/grid/pdf-export/pdf-export) is advised. This exported data can then be printed using non-web-based applications, mitigating the potential performance challenges associated with printing large datasets directly from the browser.

## Retain grid styles while printing

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid provides a [BeforePrint](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_BeforePrint) event that allows you to customize the appearance and styles of the grid before it is sent to the printer. By handling this event, you can ensure that the grid retains its styles and appearance while printing.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="print.cs" %}
{% include code-snippet/grid/print/print-style/print.cs %}
{% endhighlight %}
{% endtabs %}

![Retain grid styles while printing](images/print/print-style.png)

## Print grid along with other components

To print the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid along with another component, such as a chart, you can use the [BeforePrint](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_BeforePrint) event of the grid. In this event, you can clone the content of the other component and append it to the print document.

Here is an example of how to print grid along with chart component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="print.cs" %}
{% include code-snippet/grid/print/print-custom/print.cs %}
{% endhighlight %}
{% endtabs %}

![Print grid along with other components](images/print/print-custom.png)