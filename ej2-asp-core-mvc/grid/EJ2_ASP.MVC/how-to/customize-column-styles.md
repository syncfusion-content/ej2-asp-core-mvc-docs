---
layout: post
title: Customize Column Styles in ##Platform_Name## Grid Component
description: Learn here all about Customize Column Styles in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Customize Column Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Column Styles

You can customize the appearance of the header and content of a particular column using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

To customize the grid column, follow the given steps:

**Step 1**:

Create a CSS class with custom style to override the default style for rowcell and headercell.

```css
.e-grid .e-rowcell.customcss{
    background-color: #ecedee;
    color: 'red';
    font-family: 'Bell MT';
    font-size: 20px;
}

.e-grid .e-headercell.customcss{
    background-color: #2382c3;
    color: white;
    font-family: 'Bell MT';
    font-size: 20px;
}

```

**Step 2**:

Add the custom CSS class to the specified column by using the [`customAttributes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property.

```typescript
col.Field("Freight").HeaderText("Freight").Width("120").Format("C2").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).CustomAttributes(new { @class = "customcss" }).Add();

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-column-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-column-style.cs" %}
{% include code-snippet/grid/how-to/custom-column-style/custom-column-style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/custom-column-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-column-style.cs" %}
{% include code-snippet/grid/how-to/custom-column-style/custom-column-style.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


