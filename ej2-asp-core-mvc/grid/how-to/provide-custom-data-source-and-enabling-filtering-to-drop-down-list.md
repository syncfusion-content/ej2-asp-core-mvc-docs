---
layout: post
title: Provide Custom Data Source And Enabling Filtering To Drop Down List in ##Platform_Name## Grid Component
description: Learn here all about Provide Custom Data Source And Enabling Filtering To Drop Down List in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Provide Custom Data Source And Enabling Filtering To Drop Down List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Provide custom data source and enabling filtering to DropDownList

You can provide data source to the DropDownList by using **params** property of [`Edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) in [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

While setting new data source using edit params, you must specify a new **query** property too for the DropDownList as follows,

```typescript
@{
    var DropDownList = new Syncfusion.EJ2.DropDowns.DropDownList() { DataSource = ViewBag.DropDownData, Query = "new ej.data.Query()", Fields = new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings() { Value = "Country", Text = "Country" }, AllowFiltering = true, ActionComplete="actionComplete" };
}
{
    col.Field("ShipName").HeaderText("ShipName").Width("150").EditType("dropdownedit").Edit(new { @params = DropDownList }).Add();
}
```

You can also enable filtering for the DropDownList by passing the **allowFiltering** as **true** to the edit params.

In the below demo, DropDownList is rendered with custom Datasource for the **ShipCountry** column and enabled filtering to search DropDownList items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/dropdown-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-dropdownlist.cs" %}
{% include code-snippet/grid/how-to/dropdown-edit/edit-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/dropdown-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-dropdownlist.cs" %}
{% include code-snippet/grid/how-to/dropdown-edit/edit-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


