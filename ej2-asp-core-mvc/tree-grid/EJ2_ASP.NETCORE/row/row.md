---
layout: post
title: Rows Customization in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about rows customization in Syncfusion ##Platform_Name## Tree Grid component and much more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rows in ##Platform_Name## Tree Grid Component

The row represents record details fetched from data source.

## Customize rows

You can customize the appearance of a row by using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event. The [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event triggers for every row. In the event handler, you can get the **args** which contains details of the row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/tree-grid/row/customize-rows/CustomizeRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/tree-grid/row/customize-rows/CustomizeRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Styling alternate rows

 You can change the treegrid's alternative rows' background color by overriding the **.e-altrow** class.

```css
.e-treegrid .e-altrow {
    background-color: #ffd800;
}
```

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/alternate-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AlternateRows.cs" %}
{% include code-snippet/tree-grid/row/alternate-rows/alternateRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/alternate-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AlternateRows.cs" %}
{% include code-snippet/tree-grid/row/alternate-rows/alternateRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to learn how to present and manipulate data.