---
layout: post
title: Row Height in ##Platform_Name## Grid Component
description: Learn here all about Row Height in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Height
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Height

You can customize the row height of grid rows through the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property. The [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property is used to change the row height of entire grid rows.

In the below example, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) is set as 60px.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% include code-snippet/grid/row/row-height/row-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% include code-snippet/grid/row/row-height/row-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize row height for particular row

Grid row height for particular row can be customized using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event by setting the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) in arguments for each row based on the requirement.

In the below example, the row height for the row with OrderID as '10249' is set as '90px' using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowheight-particular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowheight-particular.cs" %}
{% include code-snippet/grid/row/rowheight-particular/rowheight-particular.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowheight-particular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowheight-particular.cs" %}
{% include code-snippet/grid/row/rowheight-particular/rowheight-particular.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> In virtual scrolling mode, it is not applicable to set the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.