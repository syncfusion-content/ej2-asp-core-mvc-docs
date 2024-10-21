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

The column chooser feature in the Syncfusion ASP.NET MVC Grid component allows you to dynamically show or hide columns. This feature can be enabled by defining the [ShowColumnChooser](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) property as **true**.

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

The Syncfusion ASP.NET MVC Grid provides the flexibility to open the column chooser dialog on a web page using an external button. By default, the column chooser button is displayed in the right corner of the grid component, and clicking the button opens the column chooser dialog below it. However, you can programmatically open the column chooser dialog at specific **X** and **Y** axis positions by using the `openColumnChooser` method.

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
	
The column chooser dialog in Syncfusion ASP.NET MVC Grid comes with default size, but you can modify its height and width as per your specific needs using CSS styles.
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

## Change default search operator of the column chooser 

The column chooser dialog in the Syncfusion ASP.NET MVC Grid provides a search box that allows you to search for column names. By default, the search functionality uses the "startsWith" operator to match columns and display the results in the column chooser dialog. However, there might be cases where you need to change the default search operator to achieve more precise data matching.

To change the default search operator of the column chooser in Syncfusion Grid, you need to use the [operator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumnChooserSettings.html#Syncfusion_EJ2_Grids_GridColumnChooserSettings_Operator) property of the columnChooserSettings.

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

By default, the grid ignores diacritic characters when performing a search in the column chooser. However, in some cases, you may want to include diacritic characters in the search. To enable this behavior, you can set the [Columnchoosersettings.IgnoreAccent](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumnChooserSettings.html#Syncfusion_EJ2_Grids_GridColumnChooserSettings_IgnoreAccent) property to **true**.

Here is an example that demonstrates the usage of the `IgnoreAccent` property to include diacritic characters for searching in the column chooser:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnchooser-diacritics/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/grid/columns/columnchooser-diacritics/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

![Diacritics searching in column chooser](../images/columns/Column-headertext.png)
