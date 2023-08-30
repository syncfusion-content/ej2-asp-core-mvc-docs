---
layout: post
title: Headers in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Headers in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Headers in ##Platform_Name## Tree Grid Component

## Header text

By default, column header title is displayed from column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) value. To override the default header title, you have to define the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> If both the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) and [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) are not defined in the column, the column renders with “empty” header text.

## Header template

You can customize the header element by using the [`HeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderTemplate.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Change header text dynamically

Sometimes, there may be a requirement to change the column [`HeaderText`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HeaderText) of the Tree Grid dynamically. This can be done using the following approach:

**Step 1**: In external button click, get the column object corresponding to the field name by using the [`getColumnByField`](https://ej2.syncfusion.com/documentation/api/treegrid/#getcolumnbyfield) method. Then, change the header text value.

```typescript
var column = treegrid.getColumnByField("Duration"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**: To reflect the changes in the Tree Grid header, invoke the [`refreshColumns`](https://ej2.syncfusion.com/documentation/api/treegrid/#refreshcolumns) method.

```typescript
treegrid.refreshColumns();

```
Refer to the below complete code example about how to change header text dynamically through button click 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="ChangeHeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/column-header-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeHeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-header-text/column-header-text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Change the orientation of header Text

The orientation of the header text can be changed by using [`CustomAttributes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_CustomAttributes) property.

To change the orientation, carry out the following steps:

**Step 1**: Create a CSS class with orientation style for the tree grid header cell.

```css
.orientationcss .e-headercelldiv {
    transform: rotate(90deg);
}

```

**Step 2**: Apply the custom CSS class to a specific column by using the `CustomAttributes` property.

```typescript
     col.Field("Duration").HeaderText("Duration").CustomAttributes(new { @class = "orientationcss" }).TextAlign(TextAlign.Center).Width(90).Add();

```

**Step 3**: Now by using [`Created`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Created) event update the height CSS of header cells to accommodate the vertically oriented text content.

```typescript
function setHeaderHeight(args) {
    var textWidth = document.querySelector(".orientationcss > div").scrollWidth;//Obtain the width of the headerText content.
    var headerCell = document.querySelectorAll(".e-headercell");
    for(var i = 0; i < headerCell.length; i++) {
        headerCell.item(i).style.height = textWidth + 'px'; //Assign the obtained textWidth as the height of the headerCell.
    }
}

```
Refer to the below complete code example about how to change the orientation of header Text

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/tree-grid/columns-mvc/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/tree-grid/columns-mvc/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
