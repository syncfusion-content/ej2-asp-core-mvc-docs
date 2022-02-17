---
layout: post
title: Use Filter Bar Template In Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Use Filter Bar Template In Foreign Key Column in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Use Filter Bar Template In Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Use filter bar template in foreign key column

You can use the filter bar template in foreign key column by defining the [`filterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way to use filter bar template in foreign column.

In the following example, The **Employee Name** is a foreign key column. This column header shows the custom filter bar template and you can select filter value by using the `**DropDown** options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbar-temp-foreign.cs" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/filterbar-temp-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbar-temp-foreign.cs" %}
{% include code-snippet/grid/how-to/filterbar-temp-foreign/filterbar-temp-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


