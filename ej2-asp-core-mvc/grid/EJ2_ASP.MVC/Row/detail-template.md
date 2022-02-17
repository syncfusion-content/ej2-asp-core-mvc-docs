---
layout: post
title: Detail Template in ##Platform_Name## Grid Component
description: Learn here all about Detail Template in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Detail Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Detail Template

The detail template provides additional information about a particular row by expanding or collapsing detail content. The [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) property accepts either
the template string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/detail-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-temp.cs" %}
{% include code-snippet/grid/row/detail-temp/detail-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/detail-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-temp.cs" %}
{% include code-snippet/grid/row/detail-temp/detail-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rendering custom component

To render the custom component inside the detail row, define the template in the [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) and render the
component in the [`DetailDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event.

For example, to render grid inside the detail row, place an HTML div element as the [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) and render the DIV element as grid component in the [`DetailDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-component/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-component.cs" %}
{% include code-snippet/grid/row/custom-component/custom-component.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-component.cs" %}
{% include code-snippet/grid/row/custom-component/custom-component.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Expand by external button

By default, detail rows render in collapsed state. You can expand a detail row by invoking the **expand** method using the external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-external/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Expand-external.cs" %}
{% include code-snippet/grid/row/expand-external/expand-external.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-external/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Expand-external.cs" %}
{% include code-snippet/grid/row/expand-external/expand-external.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can expand all the rows by using **expandAll** method.
> If you want to expand all the rows at initial Grid rendering, then use **expandAll** method in [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid.