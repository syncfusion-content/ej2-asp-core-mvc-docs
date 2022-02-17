---
layout: post
title: Row in ##Platform_Name## Tree Grid Component
description: Learn here all about Row in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row

The row represents record details fetched from data source.

## Customize rows

You can customize the appearance of a row by using the [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event.
The [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event triggers for every row. In the event handler, you can get the
`args` which contains details of the row.

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

 You can change the treegrid's alternative rows' background color by overriding the `.e-altrow` class.

```css
.e-treegrid .e-altrow {
    background-color: #fafafa;
}
```

Please refer to the following example.

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



## Row height

You can customize the row height of treegrid rows through the [`RowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property. The `RowHeight` property is used to change the row height of entire treegrid rows.

In the below example, the `RowHeight` is set as '60px'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customize row height for particular row

Grid row height for particular row can be customized using the [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html)
event by setting the `RowHeight` in arguments for each row based on the requirement.

In the below example, the row height for the row with Task ID as '3' is set as '90px' using the `RowDataBound` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

