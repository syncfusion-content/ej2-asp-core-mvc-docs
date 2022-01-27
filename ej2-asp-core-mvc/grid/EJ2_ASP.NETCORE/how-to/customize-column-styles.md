---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Column Styles of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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
<e-grid-column field="Freight" headerText="Freight" width="150"  customAttributes=@(new { @class="customcss" } )></e-grid-column>

```

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="custom-column-style" %}
{% include_relative code-snippet/how-to/custom-column-style/custom-column-style.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="custom-column-style" %}
{% include_relative code-snippet/how-to/custom-column-style/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="custom-column-style" %}
{% include_relative code-snippet/how-to/custom-column-style/custom-column-style.cs %}
{% endhighlight %}
{% highlight razor tabtitle="custom-column-style" %}
{% include_relative code-snippet/how-to/custom-column-style/razor %}
{% endhighlight %}
{% endtabs %}


