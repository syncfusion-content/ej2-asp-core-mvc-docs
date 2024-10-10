---
layout: post
title: Row in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row in ASP.NET MVC Grid Control

Each row typically represents a single record or item from a data source. Rows in a grid are used to present data in a tabular format. Each row displays a set of values representing the fields of an individual data record. Rows allow users to interact with the data in the grid. Users can select rows, edit cell values, perform sorting or filtering operations, and trigger events based on actions.

## Customize row styles 

Customizing the styles of rows in a Syncfusion Grid allows you to modify the appearance of rows to meet your design requirements. This feature is useful when you want to highlight certain rows or change the font style, background color, and other properties of the row to enhance the visual appeal of the grid. To customize the row styles in the grid, you can use CSS, properties, methods, or event support provided by the Syncfusion ASP.NET MVC Grid component.

### Using event

You can customize the appearance of the rows by using the [RowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event. This event triggers for every row when it is bound to the data source. In the event handler, you can get the `RowDataBoundEventArgs` object, which contains details of the row. You can use this object to modify the row's appearance, add custom elements, or perform any other customization.

Here's an example of how you can use the `rowDataBound` event to customize the styles of rows based on the value of the **Freight** column. This example involves checking the value of the Freight column for each row and adding a CSS class to the row based on the value. The CSS classes **below-30**, **below-80**, and **above-80** can then be defined in your stylesheet to apply the desired styles to the rows.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-style-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style.cs" %}
{% include code-snippet/grid/row/row-style-event/event-style.cs %}
{% endhighlight %}
{% endtabs %}

![Row style using event](../../images/row/style-using-event.png)

> The [QueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event can also be used to customize cells and is triggered for every cell in the grid. It can be useful when you need to customize cells based on certain conditions or criteria.

### Using CSS

You can apply styles to the rows using CSS selectors. The Grid provides a class name for each row element, which you can use to apply styles to that specific row. 

**Customize alternate rows**

You can customize the appearance of the alternate rows using CSS. This can be useful for improving the readability of the data and making it easier to distinguish between rows. By default, Syncfusion Grid provides the CSS class **.e-altrow** to style the alternate rows. You can customize this default style by overriding the **.e-altrow** class with your custom CSS styles. 

To change the background color of the alternate rows, you can add the following CSS code to your application's stylesheet:

```css
.e-grid .e-altrow {
    background-color: #fafafa;
}
```

Here's an example of how to use the **.e-altrow** class to style alternate rows:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/style-alt-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style-alt-row.cs" %}
{% include code-snippet/grid/row/style-alt-row/style-alt-row.cs %}
{% endhighlight %}
{% endtabs %}

### Using CSS customize selected row

The background color of the selected row can be changed by overriding the following CSS style.

```css
.e-grid td.e-active {
    background-color: #f9920b;
}
```

This is demonstrated in the following sample:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/select-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row.cs" %}
{% include code-snippet/grid/row/select-row/select-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/select-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row.cs" %}
{% include code-snippet/grid/row/select-row/select-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Adding a new row programmatically

The Grid can add a new row between the existing rows using the `addRecord` method of the Grid.

This is demonstrated in the following sample:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/add-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-row.cs" %}
{% include code-snippet/grid/row/add-row/add-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/add-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-row.cs" %}
{% include code-snippet/grid/row/add-row/add-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


N> When working with remote data, it is impossible to add a new row between the existing rows.

## How to get the row information when hovering over the cell

It is possible to get the row information when hovering over the specific cell. This can be achieved by using the [RowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event and `getRowInfo` method of the Grid.

In the following sample, the `mouseover` event is bound to a grid row in the `RowDataBound` event, and when hovering over the specific cell, using the `getRowInfo` method, row information will be retrieved and displayed in the console.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-info/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-Info.cs" %}
{% include code-snippet/grid/row/row-info/row-info.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-info/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-Info.cs" %}
{% include code-snippet/grid/row/row-info/row-info.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## See Also

* [How to set textbox and Grid in one row in ASP.NET MVC Grid](https://www.syncfusion.com/forums/164975/how-to-set-textbox-and-grid-in-one-row-in-asp-net-mvc-grid)