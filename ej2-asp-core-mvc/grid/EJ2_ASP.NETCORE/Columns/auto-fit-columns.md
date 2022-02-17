---
layout: post
title: Auto Fit Columns in ##Platform_Name## Grid Component
description: Learn here all about Auto Fit Columns in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Auto Fit Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# AutoFit Specific Columns

The **autoFitColumns** method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event.

To use the **autoFitColumns** method, inject the **Resize** module in the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can autofit all the columns by invoking the **autoFitColumns** method without column names.