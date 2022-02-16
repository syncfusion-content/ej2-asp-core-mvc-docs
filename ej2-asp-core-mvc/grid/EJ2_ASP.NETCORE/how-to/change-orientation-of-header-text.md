---
layout: post
title: Change Orientation Of Header Text in ##Platform_Name## Grid Component
description: Learn here all about Change Orientation Of Header Text in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Change Orientation Of Header Text
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the Orientation of Header Text

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


