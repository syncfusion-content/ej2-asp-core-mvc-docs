---
layout: post
title: Print in ##Platform_Name## Grid Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Print

To print the Grid, use the `print` method from grid instance. The print option can be displayed on the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Toolbar_System_Object_) by adding the `Print` toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/grid/print/print/print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/print/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/grid/print/print/print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Page setup

Some of the print options cannot be configured through JavaScript code. So, you have to customize the layout, paper size, and margin options using the browser page setup dialog. Please refer to the following links to know more about the browser page setup:

* [`Chrome`](https://support.google.com/chrome/answer/1069693?hl=en&visit_id=1-636335333734668335-3165046395&rd=1)
* [`Firefox`](https://support.mozilla.org/en-US/kb/how-print-web-pages-firefox)
* [`Safari`](http://www.mintprintables.com/print-tips/adjust-margins-osx/)
* [`IE`](http://www.helpteaching.com/help/print/index.htm)

## Print using an external button

To print the grid from an external button, invoke the `print` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/external-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="External-btn.cs" %}
{% include code-snippet/grid/print/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/print/external-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="External-btn.cs" %}
{% include code-snippet/grid/print/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Print the visible page

By default, the grid prints all the pages. To print the current page alone, set the [`PrintMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_PrintMode_Syncfusion_EJ2_Grids_PrintMode_) to `CurrentPage`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/current-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Current-page.cs" %}
{% include code-snippet/grid/print/current-page/current-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/print/current-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Current-page.cs" %}
{% include code-snippet/grid/print/current-page/current-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Print the hierarchy grid

By default, the grid will be print the master and expanded child grids alone. you can change the print option by using the [`hierarchyPrintMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HierarchyPrintMode) property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Prints the master grid with expanded child grids. |
| All      | Prints the master grid with all the child grids. |
| None     | Prints the master grid alone. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtlm tabtitle="CSHTML" %}
{% include code-snippet/grid/print/hierarchyprint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/print/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/print/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/print/hierarchyprint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/print/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchyprint.cs" %}
{% include code-snippet/grid/print/hierarchyprint/hierarchyprint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the hierarchy grid prints the expanded child grids from the visible page only. Refer [To Print the expanded state grid from all pages](./how-to.html#print-the-expanded-state-from-other-pages)

## Print large number of columns

By default, the browser uses A4 as page size option to print pages and to adapt the size of the page the browser print preview will auto-hide the overflowed contents. Hence grid with large number of columns will cut off to adapt the print page.

To show large number of columns when printing, adjust the scale option from print option panel based on your content size.

![Scale Option Setting](./images/print-preview.png)

## Show or Hide columns while Printing

You can show a hidden column or hide a visible column while printing the grid using [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) and [`printComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PrintComplete) events.

In the `toolbarClick` event, based on `args.item.id` as `grid_print`. We can show or hide columns by setting `column.visible` property to `true` or `false` respectively.

In the printComplete event, We have reversed the state back to the previous state.

In the below example, we have `CustomerID` as a hidden column in the grid. While printing, we have changed `CustomerID` to visible column and `ShipCity` as hidden column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/print/show-hide-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/print/show-hide-columns/show-hide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/print/show-hide-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-hide.cs" %}
{% include code-snippet/grid/print/show-hide-columns/show-hide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations of Printing Large Data

When grid contains large number of data, printing all the data at once is not a best option for the browser performance. Because to render all the DOM elements in one page will produce performance issues in the browser. It leads to browser slow down or browser hang. Grid have option to handle large number of data by Virtualization. However while printing, it is not possible to use virtualization for rows and columns.

If printing of all the data is still needed, we suggest to Export the grid to `Excel` or `CSV` or `Pdf` and then print it from another non-web based application.

## See Also

* [How to Print the expanded state grid from all pages](./how-to/print-the-expanded-state-from-other-pages)
