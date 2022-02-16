---
layout: post
title: Row Spanning in ##Platform_Name## Grid Component
description: Learn here all about Row Spanning in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Row Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Spanning

The grid has option to span row cells. To achieve this, You need to define the **rowSpan** attribute to span cells in the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.

In the following demo, **Davolio** cell is spanned to two rows in the **EmployeeName** column.

Also Grid supports the spanning of rows and columns for same cells. **Lunch Break** cell is spanned to two rows and three columns in the **1:00** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowspanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowspanning.cs" %}
{% include code-snippet/grid/row/rowspanning/rowspanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowspanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowspanning.cs" %}
{% include code-snippet/grid/row/rowspanning/rowspanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * To disable the spanning for particular grid page, we need to use **requestType** from [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event argument.