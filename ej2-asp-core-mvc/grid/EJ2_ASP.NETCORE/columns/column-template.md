---
layout: post
title: Column Template in ##Platform_Name## Grid Component
description: Learn here all about Column Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Template in ASP.NET Core Grid Component

## Render image in a column

The column [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Grid actions such as editing, grouping, filtering and sorting etc. will depend upon the column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field). If the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) is not specified in the template column, the grid actions cannot be performed.



## Render other components in a column

You can render any component in a grid column using the [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) property.

To render other components in the grid, ensure the following steps:

**Step 1**:

Initialize the column template for your custom component.

```typescript
template:`<div>
            <select class="e-control e-dropdownlist">
                <option value="1" selected="selected">Order Placed</option>
                <option value="2">Processing</option>
                <option value="3">Delivered</option>
            </select>
        </div>`

```

**Step 2**:

Using the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event, you can render the DropDown component with the following code.

```typescript
    function dropdown(args) {
        var ele = args.cell.querySelector('select');
        var drop = new ej.dropdowns.DropDownList({popupHeight: 150, popupWidth: 150});
        drop.appendTo(ele);
    }

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/render-other-comp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Render-other-comp.cs" %}
{% include code-snippet/grid/how-to/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Render-other-comp.cs" %}
{% include code-snippet/grid/how-to/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/render-other-comp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Render-other-comp.cs" %}
{% include code-snippet/grid/how-to/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Render-other-comp.cs" %}
{% include code-snippet/grid/how-to/render-other-comp/render-other-comp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Discontinued** field value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/condition-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/condition-template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/condition-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/grid/columns/condition-template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## How to get the row object by clicking on the template element

You can get the row object without selecting the row and achieve it using the column template feature and the `getRowObjectFromUID` method of the Grid.

In the following sample, the button element is rendered in the Employee Data column. By clicking the button, you can get the row object using the `getRowObjectFromUID` method of the Grid and display it in the console.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/row-object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-object.cs" %}
{% include code-snippet/grid/columns/row-object/row-object.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/row-object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-object.cs" %}
{% include code-snippet/grid/columns/row-object/row-object.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Dynamically render the icon based on the value in data source](https://www.syncfusion.com/forums/174307/change-variable-icon-based-on-the-information-obtained-from-the-datasource)
