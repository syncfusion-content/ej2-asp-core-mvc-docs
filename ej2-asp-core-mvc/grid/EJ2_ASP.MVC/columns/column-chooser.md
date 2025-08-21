---
layout: post
title: Column Chooser in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Column Chooser in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Chooser
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column chooser in ASP.NET MVC Grid component

The column chooser feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid component allows you to dynamically show or hide columns. This feature can be enabled by defining the [ShowColumnChooser](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) property as **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Column chooser](../images/column-chooser/Colum-chooser.png)

> The column chooser dialog displays the header text of each column by default. If the header text is not defined for a column, the corresponding column field name is displayed instead.

## Hide column in column chooser dialog

You can hide the column names in column chooser by defining the `Columns.ShowInColumnChooser` as **false**. This feature is useful when working with a large number of columns or when you want to limit the number of columns that are available for selection in the column chooser dialog.

In this example, the `Columns.ShowInColumnChooser` property is set to **false** for the **Order ID** column. As a result, the **Order ID** column will not be displayed in the column chooser dialog.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-hide/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Hide column in column chooser dialog](../images/column-chooser/Colum-chooser-hide.png)

>The `Columns.ShowInColumnChooser` property is applied to each column element individually. By setting it to **false**, you can hide specific columns from the column chooser dialog.

## Open column chooser by externally

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid provides the flexibility to open the column chooser dialog on a web page using an external button. By default, the column chooser button is displayed in the right corner of the grid component, and clicking the button opens the column chooser dialog below it. However, you can programmatically open the column chooser dialog at specific **X** and **Y** axis positions by using the `openColumnChooser` method.

Here's an example of how to open the column chooser in the Grid using an external button:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-external/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-external/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Open column chooser by externally](../images/column-chooser/Colum-chooser-external.png)

## Customize column chooser dialog size
	
The column chooser dialog in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid comes with default size, but you can modify its height and width as per your specific needs using CSS styles.
To customize the column chooser dialog size, you can use the following CSS styles:

```css
.e-grid .e-dialog.e-ccdlg {
    height: 500px;
    width: 200px;
}
.e-grid .e-ccdlg .e-cc-contentdiv {
    height: 200px;
    width: 230px;
}
```

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-size/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Customize column chooser dialog size](../images/column-chooser/Colum-chooser-size.png)

## Customizing the order of columns in the column chooser

The Syncfusion ASP.NET MVC Grid makes it easy to customize the order of columns in the column chooser, without affecting their actual order in the Grid.

By default, the column chooser displayed columns in the same order as they appeared in the Grid. With the introduction of customization options, the column list in the chooser can now be rearranged.

### Sorting columns in the column chooser

The Syncfusion Grid allows to sort the list of columns displayed in the column chooser dialog.

You can control the sorting behavior by specifying the `SortDirection` in the event argument of the `BeforeOpenColumnChooser` event. The available sorting options are:

Option     | Description
---------- | ---------------------------------------------------------------
None       | No sorting is applied to the column list.
Ascending  | Columns are sorted in ascending alphabetical order (A → Z).
Descending | Columns are sorted in descending alphabetical order (Z → A).

Here is an example of how to sort the column chooser list based on sort direction:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-chooser-sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/column-chooser-sorting/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Sorting columns in the columnchooser](../images/column-chooser/column-chooser-sorting.png)

### Displaying specific columns in the column chooser

The Grid also supports displaying only selected columns in the column chooser. This is helpful when only specific columns need to be shown in the column chooser, making it easier to focus on the most important ones.

To achieve this, you can specify which columns should appear in the column chooser by setting `SelectedColumns` in the event argument of the `BeforeOpenColumnChooser` event.

Here is an example of how to show only specific columns in the column chooser:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/specific-columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/specific-columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Display specific columns in the column chooser](../images/column-chooser/specific-columnchooser.png)

## Change default search operator of the column chooser 

The column chooser dialog in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid provides a search box that allows you to search for column names. By default, the search functionality uses the "startsWith" operator to match columns and display the results in the column chooser dialog. However, there might be cases where you need to change the default search operator to achieve more precise data matching.

To change the default search operator of the column chooser in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid, you need to use the [Operator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumnChooserSettings.html#Syncfusion_EJ2_Grids_GridColumnChooserSettings_Operator) property of the columnChooserSettings.

Here's an example of how to change the default search operator of the column chooser to **contains** in the ASP.NET MVC Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-contains/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-contains/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Change default search operator of the column chooser ](../images/column-chooser/Colum-chooser-contains.png)

## Diacritics searching in column chooser

By default, the grid ignores diacritic characters when performing a search in the column chooser. However, in some cases, you may want to include diacritic characters in the search. To enable this behavior, you can set the [ColumnChooserSettings.IgnoreAccent](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumnChooserSettings.html#Syncfusion_EJ2_Grids_GridColumnChooserSettings_IgnoreAccent) property to **true**.

Here is an example that demonstrates the usage of the `IgnoreAccent` property to include diacritic characters for searching in the column chooser:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-diacritics/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

## Column Chooser Template in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Grid

The Column Chooser Template feature allows full customization of the column chooser’s header, content, and footer, making it easier to manage column visibility. To enable the column chooser, set [ShowColumnChooser](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) to **true** and add **ColumnChooser** to the [Toolbar](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property.

To implement a custom column chooser template in the Grid, use the following properties:

* **ColumnChooserSettings.HeaderTemplate** - Defines the header template of the column chooser.

* **ColumnChooserSettings.Template**- Defines the content template.

* **ColumnChooserSettings.FooterTemplate** - Defines the footer template.

* **ColumnChooserSettings.RenderCustomColumnChooser** -  Allows you to override the default column chooser UI with a fully customized layout.

In this example, a Syncfusion TreeView component is rendered inside the column chooser. To use the TreeView component, install the Syncfusion TreeView package as described in the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/treeview/getting-started). The `ColumnChooserSettings.Template` property defines a element with the `id` set to **tree-view-list**, providing as a container for the TreeView component. The `ColumnChooserSettings.RenderCustomColumnChooser` method initializes the TreeView with checkboxes and appends it to this template. Checkbox selection is handled using the [NodeClicked](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_NodeClicked) and [KeyPress](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.navigations.treeview.html#Syncfusion_EJ2_Navigations_TreeView_KeyPress) events, which organize columns into **Order Details**, **Shipping Details**, and **Delivery Status**.

The column chooser footer is customized using `ColumnChooserSettings.FooterTemplate`, replacing the default buttons with customized **Apply** and **Close** buttons. The **Apply** button updates column visibility based on selection, while the **Close** button closes the column chooser via the `onClick` event. Additionally, the header is customized using `ColumnChooserSettings.HeaderTemplate` to include a title and an icon.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-chooser-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/column-chooser-template/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

## Enable and disable search option

By default, the search option in the column chooser allows filtering specific columns from the Grid's column list.

The search option is enabled by default in the column chooser. However, you can disable it by setting the `columnChooserSettings.enableSearching` property to **false**.

The following example demonstrates how to enable or disable the search option dynamically using a [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) and its [change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event in the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-enable-disable/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}