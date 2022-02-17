---
layout: post
title: Render Other Components In Column in ##Platform_Name## Grid Component
description: Learn here all about Render Other Components In Column in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Render Other Components In Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render other components in a column

You can render any component in a grid column using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Template) property.

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

Using the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event, you can render the DropDown component with the following code.

```typescript
    function dropdown(args) {
        let ele=args.cell.querySelector('select');
        let drop = new ej.dropdowns.DropDownList({popupHeight: 150, popupWidth: 150});
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

