---
layout: post
title: Hide The Expand Collapse Icon In Parent Row in ##Platform_Name## Grid Component
description: Learn here all about Hide The Expand Collapse Icon In Parent Row in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Hide The Expand Collapse Icon In Parent Row
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide the expand/collapse icon in parent row with no record in child grid

By default, the expand/collapse icon will be visible even if the child grid is empty.

You can use [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event to hide the icon when there are no records in child grid.

To hide the expand/collapse icon in parent row when no records in child grid, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
    .e-row[aria-selected="true"] .e-customizedExpandcell {
        background-color: #e0e0e0;
    }

    .e-grid.e-gridhover tr[role='row']:hover {
        background-color: #eee;
    }

```

**Step 2**:

Add the CSS class to the Grid in the [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event handler of Grid.

```typescript

    function rowDataBound(args) {
        var filter = args.data.EmployeeID;
        var data = new ej.data.DataManager(this.childGrid.dataSource).executeLocal(new ej.data.Query().where("EmployeeID", "equal", parseInt(filter), true));
        if (data.length == 0) {
            //here hide which parent row has no child records
            args.row.querySelector('td').innerHTML = " ";
            args.row.querySelector('td').className = "e-customizedExpandcell";
        }
    }

```

In the below demo, the expand/collapse icon in the row with **EmployeeID** as **1** is hidden as it does not have record in child Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/hidearrow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidearrow.cs" %}
{% include code-snippet/grid/how-to/hidearrow/hidearrow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/hidearrow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hidearrow.cs" %}
{% include code-snippet/grid/how-to/hidearrow/hidearrow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


