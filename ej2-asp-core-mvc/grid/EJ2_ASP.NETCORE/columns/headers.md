---
layout: post
title: Headers in ##Platform_Name## Grid Component
description: Learn here all about Headers in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Headers

## Header text

By default, column header title is displayed from column [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) value. To override the default header title, you have to define the **headerText** value in the [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext/headertext.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertext/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertext.cs" %}
{% include code-snippet/grid/columns/headertext/headertext.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * If both the [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) and [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) are not defined in the column, the column renders with “empty” header text.

## Header template

You can customize the header element by using the [`headerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderTemplate) property of **e-grid-column** tag helper. In this demo, the custom element is rendered for both EmployeeID and BirthDate column headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/grid/columns/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/grid/columns/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Change header text dynamically

You can change the column [`headerText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) dynamically through an external button.

Follow the given steps to change the header text dynamically:

**Step 1**:

Get the column object corresponding to the field name by using the **getColumnByField** method.
Then, change the header text value.

```typescript
var column = grid.getColumnByField("ShipCity"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**:

To reflect the changes in the grid header, invoke the **refreshHeader** method.

```typescript
grid.refreshHeader();

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/column-header-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-header-text.cs" %}
{% include code-snippet/grid/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/column-header-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-header-text.cs" %}
{% include code-snippet/grid/how-to/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the orientation of header text

You can change the orientation of the header text by using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

Ensure the following steps:

**Step 1**:

Create a CSS class with orientation style for the grid header cell.

```css
.orientationcss .e-headercelldiv {
    transform: rotate(90deg);
}

```

**Step 2**:

Add the custom CSS class to a particular column by using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

```typescript
    <e-grid-column field="ShipCity" headerText="Ship City" width="150" customAttributes="@(new { @class="orientationcss" })"></e-grid-column>

```

**Step 3**:

Resize the header cell height by using the following code.

```typescript
function setHeaderHeight(args) {
    var textWidth = document.querySelector(".orientationcss > div").scrollWidth;//Obtain the width of the headerText content.
    var headerCell = document.querySelectorAll(".e-headercell");
    for(var i = 0; i < headerCell.length; i++) {
        headerCell.item(i).style.height = textWidth + 'px'; //Assign the obtained textWidth as the height of the headerCell.
    }
}

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/grid/how-to/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/grid/how-to/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
