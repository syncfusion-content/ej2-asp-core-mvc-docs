---
layout: post
title: Adaptive in Syncfusion ##Platform_Name## Grid Component 
description: Learn here all about Adaptive in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adaptive
publishingplatform: ##Platform_Name##
documentation: ug
---

# Adaptive in ASP.NET Core Grid component

The Grid user interface (UI) was redesigned to provide an optimal viewing experience and improve usability on small screens. This interface will render the filter, sort, column chooser, column menu(supports only when the [rowRenderingMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode) as Horizontal) and edit dialogs adaptively and have an option to render the grid row elements in the vertical direction.

## Render adaptive dialogs

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid offers a valuable feature for rendering adaptive dialogs, specifically designed to enhance the user experience on smaller screens. This feature proves especially useful for optimizing the interface on devices with limited screen real estate. The functionality is achieved by enabling the [enableAdaptiveUI](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property, allowing the grid to render filter, sort, and edit dialogs in full-screen mode.

The following code example demonstrates how to enable and utilize adaptive dialogs in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/adaptive/adaptive-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/grid/adaptive/adaptive-dialog/adaptive.cs %}
{% endhighlight %}
{% endtabs %}

![Render adaptive dialogs](images/adaptive-view/render-adptive-dialog.png)

## Vertical row rendering

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid introduces the feature of vertical row rendering, allowing you to display row elements in a vertical order. This is particularly useful for scenarios where a vertical presentation enhances data visibility. This is achieved by setting the [rowRenderingMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode) property to the value **Vertical**.

>The default row rendering mode is **Horizontal**.

The following sample demonstrates how to dynamically change the row rendering mode between **Vertical** and **Horizontal** based on a DropDownList selection:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/adaptive/vertical-rendering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowrender.cs" %}
{% include code-snippet/grid/adaptive/vertical-rendering/rowrender.cs %}
{% endhighlight %}
{% endtabs %}

![Row rendering](images/adaptive-view/row-rendering-mode.gif)

> [enableAdaptiveUI](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property must be enabled for vertical row rendering.

### Supported features by vertical row rendering

The following features are only supported in vertical row rendering:

* Paging, including Page size dropdown
* Sorting
* Filtering
* Selection
* Dialog Editing
* Aggregate
* Infinite scroll
* Toolbar - Options like **Add**, **Filter**, **Sort**, **Edit**, **Delete**, **Search**, and **Toolbar template** are available when their respective features are enabled. The toolbar dynamically includes a three-dotted icon, containing additional features like **ColumnChooser**, **Print**, **PdfExport**, **ExcelExport**, or **CsvExport**, once these features are enabled. Please refer to the following snapshot.

![VerticalmodeColumnMenu](images/adaptive-view/vertical-column-menu.gif)

A snapshot of the adaptive grid displaying enabled paging along with a pager dropdown.

![AdaptivePagerDropdown](images/adaptive-view/pager-dropdown.gif)

> The Column Menu feature, which includes grouping, sorting, autofit, filter, and column chooser, is exclusively supported for the Grid in **Horizontal** [rowRenderingMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode).

## Rendering an adaptive layout for smaller screens alone

By default, adaptive UI layout is rendered in both mobile devices and desktop mode too while setting the [enableAdaptiveUI](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property as **true**. Now the DataGrid component has an option to render an adaptive layout only for mobile screen sizes. This can be achieved by specifying the `AdaptiveUIMode` property value as `Mobile`. The default value of the `AdaptiveUIMode` property is "Both".

> The [rowRenderingMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode) property is rendered on the adaptive layout based on the `AdaptiveUIMode` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/adaptive/small-screen-adaptive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smallscreen.cs" %}
{% include code-snippet/grid/adaptive/small-screen-adaptive/smallscreen.cs %}
{% endhighlight %}
{% endtabs %}

![Rendering an adaptive layout for smaller screens](images/adaptive-view/small-screen-adptive.png) 
