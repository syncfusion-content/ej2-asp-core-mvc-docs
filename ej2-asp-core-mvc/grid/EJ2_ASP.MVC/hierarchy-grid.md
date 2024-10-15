---
layout: post
title: Hierarchy grid in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Hierarchy grid in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hierarchy grid
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hierarchy grid in ASP.NET MVC Grid component

The Hierarchy Grid in an ASP.NET MVC Grid component is typically used when you need to display hierarchical data in a tabular format with expandable and collapsible rows. It allows you to represent parent and child relationships within the grid, making it easier for you to navigate and understand the data.

This feature can be enabled by utilizing the [ChildGrid](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ChildGrid) and [ChildGrid.QueryString](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryString) properties of the grid component.

To enable the Hierarchy Grid feature:

1. Define the `ChildGrid` property within the Grid component configuration. This property describes the options of the child grid.

2. Specify the `ChildGrid.QueryString` property to establish the relation between the parent and child grids and visualizes the data in a hierarchical structure. This property determines how the child records are fetched based on the parent record.

The following example demonstrates how to enable the hierarchy feature in the grid

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Hierarchy grid](../images/hierarchy-grid/hierarchy-grid.png)

> * Grid supports n level of child grids.
> * Hierarchical binding is not supported when [detail template](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/row/detail-template) is enabled.
> * In Syncfusion Grid component, searching operates independently for parent and child grids. Searching within the parent grid filters only parent records, and similarly, searching within the child grid filters only child records. The component does not support simultaneous searching across both parent and child grids.

## Bind hierarchy grid with different field

By default, the parent and child grids have the same field name to map and render a hierarchical grid. However, the component supports establishing a parent-child relationship between grids with different field names. This feature is beneficial when you want to create a parent-child relationship between grids but need to use distinct field names for mapping the data. As a result, you can easily establish the desired relationship between the parent and child grids, even with different field names for data mapping.

By default, the parent and child grid relation is maintained using the [QueryString](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryString) property, which requires the same field name for both grids. However, to achieve the parent and child relation with different fields, you need to modify the mapping value in the [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event of child grid. 

In the following example, the `Load` event is utilized to customize the mapping value for the child grid. By accessing the `parentDetails` property and its **parentKeyFieldValue**, you can set the desired mapping value. The `parentRowData` property contains the data of the parent row, and by using the **EmployeeID** field name, you can extract the corresponding value from the parent row data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid-different-field/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/hierarchy-grid-different-field/html.cs %}
{% endhighlight %}
{% endtabs %}

![Hierarchy grid](../images/hierarchy-grid/grid-with-different-field.png)

> Make sure to adjust the field name according to your specific scenario.

## Expand child grid initially

Expanding the child grid initially in the Syncfusion ASP.NET MVC Grid component is helpful when you want to display the child rows of the hierarchical grid expanded by default upon grid load. This can be beneficial in scenarios where you want to provide immediate visibility into the hierarchical data without requiring you to manually expand each child row.

To achieve this, you can use the `expand` method with the desired target index (number) in the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the grid. 

In the provided example, expand the third record of the grid by utilizing the `expand` method within the `DataBound` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/expand-child-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/expand-child-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Expand child grid initially](../images/hierarchy-grid/expand-child-grid.gif)

> Index values begin with **"0"**, allowing you to provide the desired target index to expand a specific child grid initially.

## Dynamically load child grid data

Dynamically load child grid data in Syncfusion ASP.NET MVC Grid helps improve performance, optimize data transmission, and enhance the your experience by providing on-demand access to relevant information. Additionally, it offers flexibility in data presentation, which helps improve the overall efficiency of your application.

To dynamically load the `DataSource` of a child grid in the Grid, you can utilize the [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event of parent grid. This event allows you to customize the loading behavior of the child grid based on the data of parent grid.

The following example demonstrates how to dynamically load child grid data using the `Load` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/dynamically-load-child-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/dynamically-load-child-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically load child grid](../images/hierarchy-grid/dynamically-load-child-grid.png)

## Dynamically bind data to child grid based on parent row data

Dynamically binding data to a child grid based on the parent row data in the Syncfusion ASP.NET MVC Grid component is useful when you want to display child grid data that is specific to each parent row. This feature allows for a dynamic and contextual representation of data within the child grid.

To dynamically bind data to the child grid based on the parent row data instead of using the [QueryString](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryString) property, you can utilize the [DetailDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event of the grid. This event is triggered when expanding the child grid.

In the `DetailDataBound` event handler, you can filter the child grid's dataSource based on the **EmployeeID** column value of the parent row data. This can be achieved by using the `DataManager` plugin and applying a filter to the child grid's dataSource. The filtered data can be assigned as the new dataSource for the child grid. This can be demonstrated by the following sample.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/dynamically-bind-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/dynamically-bind-data/html.cs %}
{% endhighlight %}
{% endtabs %}

![Dynamically bind data](../images/hierarchy-grid/dynamically-bind-data.png)

## Adding record in child grid

Adding a record in a child grid within the Syncfusion ASP.NET MVC Grid component is useful when you want to provide the ability to add new records to the child grid. This feature allows you to input and save additional data specific to each parent row.

To maintain the parent-child relationship in the Grid when adding a record to the child grid, you need to set the value for the `QueryString` in the added data. This can be done using the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event.

In the following example, the parent and child grids are related by the **EmployeeID** field. To add a new record in the child grid, the **EmployeeID** field needs to be set with the value of the parent record's `QueryString` in the `ActionBegin` event. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/add-record-child-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/add-record-child-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Add record in child grid](../images/hierarchy-grid/add-record-child-grid.png)

## Template column in child grid

A template column in a child grid within the Syncfusion ASP.NET MVC Grid component is valuable when you want to customize the appearance and functionality of specific columns in the child grid. It is useful for incorporating interactive elements, custom formatting, or complex data representation within specific columns of the child grid.

To achieve this, you can utilize the `Template` property of a column to display a custom element instead of a field value in the Grid.

The following example demonstrates, how to show a custom image in the **Employee Image** column of the child grid by utilizing the `Template` property of the column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/template-column-child-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/template-column-child-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Template column in child grid](../images/hierarchy-grid/template-column-child-grid.png)

## How to get parent detail in child grid

Getting parent details in a child grid in an ASP.NET MVC Grid component is useful when you want to display and utilize information from the parent row within the child grid. This can be beneficial in scenarios where you need to provide additional context or perform calculations based on the parent row's data

To achieve this, you can utilize the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. This event is triggered when the child grid is created and can be used to handle the child grid.

The following example demonstrates how to obtain parent details in a child grid using the `Created` event. Within the `Created` event, you can access the parent row data using `this.parentDetails.parentRowData` and display the desired details in the message.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/get-parent-grid-details/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/get-parent-grid-details/html.cs %}
{% endhighlight %}
{% endtabs %}

![Get parent detail in child grid](../images/hierarchy-grid/get-parent-grid-details.png)

## Render aggregates in child grid

The Aggregates feature in the Syncfusion ASP.NET MVC Grid component allows you to display aggregate values in the footer, group footer, and group caption of the child grid. With this feature, you can easily perform calculations on specific columns and show summary information. 

Rendering aggregates in a child grid involves displaying summary data at the footer or group caption of the grid. This can be particularly useful in hierarchical grids where each child grid represents detailed data that needs to be summarized.

The following example demonstrates how to render aggregates in a child grid to display the sum and maximum values of the **Freight** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/aggregates-child-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregates.cs" %}
{% include code-snippet/grid/hierarchy-grid/aggregates-child-grid/html.cs %}
{% endhighlight %}
{% endtabs %}

![Render aggregates in child grid](../images/hierarchy-grid/aggregates-child-grid.png)

## Expand all by external button

The Hierarchy Grid in the Syncfusion ASP.NET MVC Grid component allows you to expand all child grid rows using an external button. This feature provides you with a convenient overview of all the hierarchical data within the grid, eliminating the need to manually expand each row individually.

By default, Grid renders all child grid rows in collapsed state. To expand all child grid rows in the Grid using an external button, you can utilize the `expandAll` method provided by the DetailRow module. Similarly, to collapse all grid rows, you can use the `collapseAll` method. 

The following example demonstrates how to expand and collapse the hierarchy grid using an external button click function.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/expand-collapse-externally/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/expand-collapse-externally/html.cs %}
{% endhighlight %}
{% endtabs %}

![Expand all by external button](../images/hierarchy-grid/expand-collapse-externally.gif)

> The `expandAll` and `collapseAll` methods are not recommended for large datasets due to the considerable time it takes to update the changes in the UI.

## Hide the expand/collapse icon in parent row when no record in child grid

The Syncfusion ASP.NET MVC Grid allows you to hide the expand/collapse icon in the parent row when there are no records in the child grid. However, in certain scenarios, you may want to hide the expand/collapse icon for parent rows that do not have any child records, providing a cleaner and more intuitive interface by eliminating unnecessary icons in empty parent rows.

To achieve this, you can utilize the [RowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event to hide the icon when there are no records in the child grid.

To hide the expand/collapse icon in parent row when no records in child grid, follow the given steps:

1. **Create a CSS Class with Custom Style**: Define a CSS class that overrides the default appearance of the Grid. This class will be used to customize the background color of the parent row when it is selected and when hovering over rows.

```css
    .e-row[aria-selected="true"] .e-customizedexpandcell {
        background-color: #e0e0e0;
    }

    .e-grid.e-gridhover tr[role='row']:hover {
        background-color: #eee;
    }
```

2. **Implement the rowDataBound Event Handler:** This event is triggered for each row in the grid when data is bound, allowing you to customize the row's appearance and behavior. In the provided code, the handler checks if the current row has any child records associated with it. If not, it hides the content of the first element, which contains the expand/collapse icon, and applies a custom CSS class (e-customizedexpandcell) to modify its appearance.

```typescript
function rowDataBound(args){
    var ordersDataSource = @Html.Raw(JsonConvert.SerializeObject(ViewBag.DataSource));
    var parentData = (args.data)['EmployeeID'];
    var childRecord = new ej.data.DataManager(ordersDataSource).executeLocal(new ej.data.Query().where('EmployeeID', 'equal', parentData, true));
    if (childRecord.length === 0) {
        // Here hide which parent row has no child records
       var rowElement = args.row;
       var cellElement= rowElement.querySelector('td')
        cellElement.innerHTML = ' '; 
        cellElement.className = 'e-customizedexpandcell';
    }
}
```

The following example demonstrates how to hide the expand/collapse icon in the row with **EmployeeID** as **1**, which does not have record in child Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/hierarchy-grid/hide-expand-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/hierarchy-grid/hide-expand-icon/html.cs %}
{% endhighlight %}
{% endtabs %}

![Hide the expand or collapse icon](../images/hierarchy-grid/hide-expand-icon.png)

## Customize the child grid

The Syncfusion ASP.NET MVC Grid component offers various ways to customize the child grid appearance using both default CSS and custom themes. To access the child grid elements, you can use the **.e-detailcell** class selector, which targets the child grid.

### Header

You can customize the appearance of the header elements in the child grid using CSS. Here are examples of how to customize the child grid header, header cell, and header cell div element.

**Customizing the child grid header**

To customize the appearance of the child grid header root element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-headercontent{
    border: 2px solid green;
}
```
In this example, the **.e-detailcell** class targets the child grid and **.e-headercontent** targets its header root element. You can modify the `border` property to change the style of the header border. This customization allows you to override the thin line between the header and content of the child grid.

![Child header Grid in ASP.NET MVC.](../images/hierarchy-grid/grid-child-header.png)

**Customizing the child grid header cell**

To customize the appearance of the grid header cell elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-headercontent .e-headercell{
    color: #ffffff;
    background-color: #1ea8bd;
}
```
In this example, the **.e-headercell** class targets the header cell elements. You can modify the `color` and `background-color` properties to change the text color and background of the child grid's header cells.

![Customize the child Grid header cell in ASP.NET MVC.](../images/hierarchy-grid/grid-child-header-cell.png)

**Customizing the child grid header cell div element**

To customize the appearance of the child grid header cell div element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-headercelldiv {
    font-size: 15px;
    font-weight: bold;
    color: darkblue;
}
```
In this example, the **.e-headercelldiv** class targets the div element within the header cell of the child grid. You can modify the `font-size`, `font-weight`, `color` properties to change the font size, font-weight and color of the header text content.

![Child Grid header cell div element in ASP.NET MVC.](../images/hierarchy-grid/grid-child-header-cell-div-element.png)

### Paging

You can customize the appearance of the paging elements in the child grid using CSS. Here are examples of how to customize the pager root element, pager container element, pager navigation elements, pager page numeric link elements, and pager current page numeric element of the child grid.

**Customizing the child grid pager root element**

To customize the appearance of the child grid pager root element, you can use the following CSS code:

```css
.e-detailcell .e-grid  .e-gridpager {
    font-family: cursive;
    background-color: #deecf9;
}
```
In this example, the **.e-detailcell** class targets the child grid and the **.e-gridpager** class targets the pager root element. You can modify the `font-family` to change the font family and `background-color` property to change the background color of the pager.

![ASP.NET MVC Grid pager root element.](../images/hierarchy-grid/child-grid-pager-root-element.png)

**Customizing the child grid pager container element**

To customize the appearance of the child grid pager container element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-pagercontainer {
    border: 2px solid #00b5ff;
    font-family: cursive;
}
```

In this example, the **.e-pagercontainer** class targets the pager container element. You can modify the `border` property and `font-family` property to change the border color and font family of the pager container.

![ASP.NET MVC Grid pager container element.](../images/hierarchy-grid/grid-child-pager-container-element.png)

**Customizing the child grid pager navigation elements**

To customize the appearance of the child grid pager navigation elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-gridpager .e-prevpagedisabled,
.e-detailcell .e-grid .e-gridpager .e-prevpage,
.e-detailcell .e-grid .e-gridpager .e-nextpage,
.e-detailcell .e-grid .e-gridpager .e-nextpagedisabled,
.e-detailcell .e-grid .e-gridpager .e-lastpagedisabled,
.e-detailcell .e-grid .e-gridpager .e-lastpage,
.e-detailcell .e-grid .e-gridpager .e-firstpage,
.e-detailcell .e-grid .e-gridpager .e-firstpagedisabled {
    background-color: #deecf9;
}
```

In this example, the classes **.e-prevpagedisabled, .e-prevpage, .e-nextpage, .e-nextpagedisabled, .e-lastpagedisabled, .e-lastpage, .e-firstpage,** and **.e-firstpagedisabled** target the various pager navigation elements of the child grid. You can modify the `background-color` property to change the background color of these elements.

![ASP.NET MVC Grid pager navigation elements.](../images/hierarchy-grid/grid-child-pager-navigation-element.png)

**Customizing the child grid pager page numeric link elements**

To customize the appearance of the child grid pager current page numeric link elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-gridpager .e-numericitem {
    background-color: #5290cb;
    color: #ffffff;
    cursor: pointer;
}

.e-detailcell .e-grid .e-gridpager .e-numericitem:hover {
    background-color: white;
    color: #007bff;
}
```

In this example, the **.e-numericitem** class targets the page numeric link elements. You can modify the `background-color`, `color` properties to change the background color and text color of these elements.

![ASP.NET MVC Grid pager numeric link elements.](../images/hierarchy-grid/grid-child-page-numeric-link-elements.png)

**Customizing the child grid pager current page numeric element**

To customize the appearance of the child grid pager current page numeric element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-gridpager .e-currentitem {
    background-color: #0078d7;
    color: #fff;
}
```

In this example, the **.e-currentitem** class targets the current page numeric item. You can modify the `background-color` property to change the background color of this element and `color` property to change the text color.

![ASP.NET MVC Grid current pager numeric element.](../images/hierarchy-grid/grid-child-current-page-numeric-element.png)

### Sorting

You can customize the appearance of the sorting icons and multi sorting icons in the child grid using CSS.You can use the available Syncfusion [icons](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/icons#material) based on your theme. Here's how to do it:

**Customizing the child grid sorting icon**

To customize the sorting icon that appears in the child grid header when sorting is applied, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-icon-ascending::before {
    content: '\e7a3';
    /* Icon code for ascending order */
}

.e-detailcell .e-grid .e-icon-descending::before {
    content: '\e7b6';
    /* Icon code for descending order */
}
```
In this example, the **.e-detailcell** class targets the child grid and the **.e-icon-ascending::before** class targets the sorting icon for ascending order, and the **.e-icon-descending::before** class targets the sorting icon for descending order.

![ASP.NET MVC Grid sorting icon.](../images/hierarchy-grid/grid-child-sorting-icons.png)

**Customizing the child grid multi sorting icon**

To customize the multi sorting icon that appears in the child grid header when multiple columns are sorted, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-sortnumber {
    background-color: #deecf9;
    font-family: cursive;
}
```

In this example, the **.e-sortnumber** class targets the background color and font family of the multi sorting icon. You can modify the `background-color` and `font-family` properties to customize the appearance of the multi sorting icon.

![ASP.NET MVC Grid multi sorting icon.](../images/hierarchy-grid/grid-child-multi-sorting-icon.png)

### Filtering

You can customize the appearance of filtering elements in the child grid using CSS. Below are examples of how to customize various filtering elements, including filter bar cell elements, filter bar input elements, focus styles, clear icons, filter icons, filter dialog content, filter dialog footer, filter dialog input elements, filter dialog button elements, and Excel filter dialog number filters.

**Customizing the child grid filter bar cell element**

To customize the appearance of the filter bar cell element in the child grid header, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filterbar .e-filterbarcell {
  background-color: #045fb4;
}

```
In this example, the **.e-detailcell** class targets the child grid and the **.e-filterbarcell** class targets the filter bar cell element in the child grid header. You can modify the `background-color` property to change the color of the filter bar cell element.

![ASP.NET MVC Grid filter bar cell element.](../images/hierarchy-grid/grid-child-filter-bar-cell-element.png)

**Customizing the child grid filter bar input element**

To customize the appearance of the filter bar input element in the child grid header, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filterbarcell .e-input-group input.e-input{
    font-family: cursive;
}
```
In this example, the **.e-filterbarcell** class targets the filter bar cell element, and the **.e-input** class targets the input element within the cell. You can modify the `font-family` property to change the font of the filter bar input element.

![ASP.NET MVC Grid filter bar input element.](../images/hierarchy-grid/grid-child-filter-bar-input-element.png)

**Customizing the child grid filter bar input focus**

To customize the appearance of the child grid's filter bar input element's focus highlight, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filterbarcell .e-input-group.e-input-focus{
    background-color: #deecf9;
}
```
In this example, the **.e-filterbarcell** class targets the filter bar cell element, and the **.e-input-group.e-input-focus** class targets the focused input element. You can modify the `background-color` property to change the color of the focus highlight.

![ASP.NET MVC Grid filter bar input focus.](../images/hierarchy-grid/grid-child-filter-bar-input-element-focus.png)

**Customizing the child grid filter bar input clear icon**

To customize the appearance of the child grid's filter bar input element's clear icon, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filterbarcell .e-input-group .e-clear-icon::before {
    content: '\e72c';
}
```
In this example, the **.e-clear-icon** class targets the clear icon element within the input group. You can modify the `content` property to change the icon displayed.

![ASP.NET MVC Grid filter bar input clear icon.](../images/hierarchy-grid/child-grid-filter-bar-input-clear-icon.png)

**Customizing the child grid child grid filtering icon**

To customize the appearance of the filtering icon in the child grid header, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-icon-filter::before{
    content: '\e81e';
}
```
In this example, the **.e-icon-filter** class targets the filtering icon element. You can modify the `content` property to change the icon displayed.

![ASP.NET MVC Grid filtering icon.](../images/hierarchy-grid/grid-child-filtering-icon.png)

**Customizing the child grid filter dialog content**

To customize the appearance of the child grid's filter dialog's content element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filter-popup .e-dlg-content {
    background-color: #deecf9;
}
```
In this example, the **.e-filter-popup .e-dlg-content** classes target the content element within the filter dialog. You can modify the `background-color` property to change the color of the dialog's content.

![ASP.NET MVC Grid filter dialog content.](../images/hierarchy-grid/grid-child-filter-dialog-content.png)

**Customizing the child grid filter dialog footer**

To customize the appearance of the child grid's filter dialog's footer element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filter-popup .e-footer-content {
    background-color: #deecf9;
}
```
In this example, the **.e-filter-popup .e-footer-content** classes target the footer element within the filter dialog. You can modify the `background-color` property to change the color of the dialog's footer.

![ASP.NET MVC Grid filter dialog footer.](../images/hierarchy-grid/child-grid-filter-dialog-footer.png)

**Customizing the child grid filter dialog input element**

To customize the appearance of the child grid's filter dialog's input elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filter-popup .e-input-group input.e-input{
    font-family: cursive;
}
```
In this example, the **.e-filter-popup** class targets the filter dialog, and the **.e-input** class targets the input elements within the dialog. You can modify the `font-family` property to change the font of the input elements.

![ASP.NET MVC Grid filter dialog input element.](../images/hierarchy-grid/grid-child-filter-dialog-input-element.png)

**Customizing the child grid filter dialog button element**

To customize the appearance of the child grid's filter dialog's button elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filter-popup .e-btn{
    font-family: cursive;
}
```
In this example, the **.e-filter-popup** class targets the filter dialog, and the **.e-btn** class targets the button elements within the dialog. You can modify the `font-family` property to change the font of the button elements.

![ASP.NET MVC Grid filter dialog button element.](../images/hierarchy-grid/grid-child-filter-dialog-button-element.png)

**Customizing the child grid excel filter dialog number filters element**

To customize the appearance of the excel filter dialog's number filters in the child grid, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-filter-popup .e-contextmenu-wrapper ul{
    background-color: #deecf9;
}
```
In this example, the **.e-filter-popup .e-contextmenu-wrapper** ul classes target the number filter elements within the excel filter dialog. You can modify the `background-color` property to change the color of these elements.

![ASP.NET MVC Grid excel filter dialog number filters element.](../images/hierarchy-grid/grid-child-excel-filter-dialog-element.png)

### Grouping

You can customize the appearance of grouping elements in the child grid using CSS. Here are examples of how to customize the group header, group expand/collapse icons, group caption row, and grouping indent cell.

**Customizing the child grid group header**

To customize the appearance of the child grid's group header element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-groupdroparea {
    background-color: #132f49;
}
```
In this example, the **.e-detailcell** class targets the child grid and the **.e-groupdroparea** class targets the group header element. You can modify the `background-color` property to change the color of the group header.

![Child Grid group header in ASP.NET MVC.](../images/hierarchy-grid/grid-child-group-header.png)

**Customizing the child grid group expand or collapse icons**

To customize the appearance of the group expand/collapse icons in the child grid, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-icon-gdownarrow::before{
    content:'\e7c9'
}
.e-detailcell .e-grid .e-icon-grightarrow::before{
    content:'\e80f'
}
```

In this example, the **.e-icon-gdownarrow** and **.e-icon-grightarrow** classes target the expand and collapse icons, respectively. You can modify the `content` property to change the icon displayed. You can use the available Syncfusion icons based on your theme.

![Child Grid group expand or collapse icons in ASP.NET MVC.](../images/hierarchy-grid/grid-child-group-expand-or-collapse-icons.png)

**Customizing the child grid group caption row**

To customize the appearance of the child grid's group caption row and the icons indicating record expansion or collapse, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-groupcaption {
    background-color: #deecf9;
}

.e-detailcell .e-grid .e-recordplusexpand,
.e-detailcell .e-grid .e-recordpluscollapse {
    background-color: #deecf9;
}
```

In this example, the **.e-groupcaption** class targets the group caption row element, and the **.e-recordplusexpand** and **.e-recordpluscollapse** classes target the icons indicating record expansion or collapse. You can modify the `background-color` property to change the color of these elements.

![Child Grid group caption row in ASP.NET MVC.](../images/hierarchy-grid/child-grid-group-caption-row.png)

**Customizing the child grid grouping indent cell**

To customize the appearance of the child grid's grouping indent cell element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-indentcell {
    background-color: #deecf9;
}
```

In this example, the **.e-indentcell** class targets the grouping indent cell element. You can modify the `background-color` property to change the color of the indent cell.

![child Grid grouping indent cell in ASP.NET MVC.](../images/hierarchy-grid/child-grid-indent-cell.png)

### Toolbar

You can customize the appearance of the toolbar in the child grid using CSS. Here are examples of how to customize the toolbar root element and toolbar button element.

**Customizing the child grid toolbar root element**

To customize the appearance of the child grid's toolbar root element, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-toolbar-items {
    background-color: #deecf9;
}
```

In this example, the **.e-detailcell** class targets the child grid and the **.e-toolbar-items** class targets the background color of the toolbar root element. You can modify the `background-color` property to change the background color of the toolbar.

![Child Grid toolbar root element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-toolbar-root-element.png)

**Customizing the child grid toolbar button element**

To customize the appearance of the child grid's toolbar buttons, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-toolbar .e-btn {
    background-color: #deecf9;
}
```

In this example, the **.e-toolbar .e-btn** selector targets the background color of the toolbar button elements. You can modify the `background-color` property to change the background color of the toolbar buttons.

![Child Grid toolbar button element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-toolbar-button-element.png)

### Editing

You can customize the appearance of editing-related elements in the child grid using CSS. Below are examples of how to customize various editing-related elements.

**Customizing the child grid edited and added row element**

To customize the appearance of edited and added row table elements in the child grid, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-editedrow table, 
.e-detailcell .e-grid .e-addedrow table {
	background-color: #62b2eb;
}
```
In this example, the **.e-detailcell** class targets the child grid and the .**e-editedrow** class represents the edited row element, and the **.e-addedrow** class represents the added row element. You can modify the `background-color` property to change the color of these row table elements.

![Child Grid customizing the edited row element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-edited-row-element.png)
![Child Grid customizing the added row element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-added-row-element.png)

**Customizing the child grid edited row input element**

To customize the appearance of edited row input elements in the child grid, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-editedrow .e-input-group input.e-input{
  font-family: cursive;
  color:rgb(214, 33, 123)
}
```
In this example, the **.e-editedrow** class represents the edited row element, and the **.e-input** class represents the input elements within the form. You can modify the `font-family` property to change the font and `color` property  to change text color of the input elements.

![Child Grid customizing the edited row input element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-edited-row-input-element.png)

**Customizing the child grid edit dialog header element**

To customize the appearance of the edit dialog header element in the child grid, you can use the following CSS code:

```css
.e-edit-dialog .e-dlg-header-content {
    background-color: #deecf9;
}
```
In this example, the **.e-edit-dialog** class represents the edit dialog, and the **.e-dlg-header-content** class targets the header content within the dialog. You can modify the `background-color` property to change the color of the header element.

![Child Grid customizing the edit dialog header element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-edit-dialog-header-element.png)

**Customizing the child grid edited row input element in dialog edit mode**

To customize the appearance of the child grid's edited row input elements in dialog edit mode, you can use the following CSS code:

```css
.e-grid .e-gridform .e-rowcell .e-float-input .e-field {
    font-family: cursive;
}
```
In this example, the **.e-gridform** class represents the editing form, and the **.e-float-input** class targets the floating input elements within the form. You can modify the `font-family` property to change the font of the input elements.

![Child ASP.NET MVC Grid edited row input element in dialog.](../images/hierarchy-grid/child-grid-edited-row-input-element-in-dialog.png)

**Customizing the child grid command column buttons**

To customize the appearance of the child grid's command column buttons such as edit, delete, update, and cancel, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-delete::before ,.e-grid .e-cancel-icon::before{
    color: #f51717;
}
.e-detailcell .e-grid .e-edit::before, .e-grid .e-update::before {
    color: #077005;
}
```
In this example, the **.e-edit, .e-delete, .e-update, and .e-cancel-icon** classes represent the respective command column buttons. You can modify the `color` property to change the color of these buttons.

![Child Grid customize command column button in ASP.NET MVC.](../images/hierarchy-grid/child-grid-command-button.png)
![Child Grid customize command column button in ASP.NET MVC.](../images/hierarchy-grid/child-grid-next-command-button.png)

### Aggregate

You can customize the appearance of aggregate elements in the child grid using CSS. Below are examples of how to customize the aggregate root element and the aggregate cell elements.

**Customizing the child grid aggregate root element**

To customize the appearance of the child grid's aggregate root elements, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-gridfooter {
    font-family: cursive;
}
```

In this example, the **.e-detailcell** class targets the child grid and the **e-gridfooter** class represents the root element of the aggregate row in the grid footer. You can modify the `font-family` property to change the font of the aggregate root element.

![Child Grid customize aggregate root element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-aggregate-root-element.png)

**Customizing the child grid aggregate cell elements**

To customize the appearance of the child grid's aggregate cell elements (summary row cell elements), you can use the following CSS code:

```css
.e-detailcell .e-grid .e-summaryrow .e-summarycell {
    background-color: #deecf9;
}
```

In this example, the **e-summaryrow** class represents the summary row containing aggregate cells, and the **e-summarycell** class targets individual aggregate cells within the summary row. You can modify the `background-color` property to change the `color` of the aggregate cell elements.

![Child Grid customize aggregate cell element in ASP.NET MVC.](../images/hierarchy-grid/child-grid-aggregate-cell-element.png)

### Selection

You can customize the appearance of the selection in the child grid using CSS. Here are examples of how to customize the row selection background, cell selection background, and column selection background.

**Customizing the child grid row selection background**

To customize the appearance of the child grid's row selection, you can use the following CSS code:

```css
.e-detailcell .e-grid td.e-selectionbackground {
    background-color: #00b7ea;
}
```
In this example, the **.e-detailcell** class targets the child grid and the **.e-selectionbackground** class targets the background color of the row selection. You can modify the `background-color` property to change the background color of the selected rows.

![Child Grid row selection in ASP.NET MVC.](../images/hierarchy-grid/child-grid-row-selection.png)

**Customizing the child grid cell selection background**

To customize the appearance of the child grid's cell selection, you can use the following CSS code:

```css
.e-detailcell .e-grid td.e-cellselectionbackground {
    background-color: #00b7ea;
}
```

In this example, the **.e-cellselectionbackground** class targets the background color of the cell selection. You can modify the `background-color` property to change the background color of the selected cells.

![Child Grid cell selection in ASP.NET MVC.](../images/hierarchy-grid/child-grid-cell-selection.png)

**Customizing the child grid column selection background**

To customize the appearance of the child grid's column selection, you can use the following CSS code:

```css
.e-detailcell .e-grid .e-columnselection {
    background-color: #aec2ec;
}
```
In this example, the **.e-columnselection** class targets the background color of the column selection. You can modify the `background-color` property to change the background color of the selected columns.

![Child Grid cell selection in ASP.NET MVC.](../images/hierarchy-grid/child-grid-column-selection.png)