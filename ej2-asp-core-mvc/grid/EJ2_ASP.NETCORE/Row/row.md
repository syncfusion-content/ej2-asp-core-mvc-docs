---
layout: post
title: Row in ##Platform_Name## Grid Component
description: Learn here all about Row in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row

The row represents record details fetched from data source.

## Row Customization

### Using event

You can customize the appearance of a row by using the [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.
The [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event triggers for every row. In the event handler, you can get the
**rowDataBoundEventArgs** that contains details of the row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-rows.cs" %}
{% include code-snippet/grid/row/custom-rows/custom-rows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-rows.cs" %}
{% include code-snippet/grid/row/custom-rows/custom-rows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Using CSS customize alternate rows

 You can change the grid's alternative rows' background color by overriding the **.e-altrow** class.

```css
.e-grid .e-altrow {
    background-color: #fafafa;
}
```

Please refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/style-alt-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Style-alt-row.cs" %}
{% include code-snippet/grid/row/style-alt-row/style-alt-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/style-alt-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style-alt-row.cs" %}
{% include code-snippet/grid/row/style-alt-row/style-alt-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

