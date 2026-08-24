---
layout: post
title: CSS Customization in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how the ASP.NET MVC Pivot Table uses CSS to hide axes, align text in headers and value cells, and style the Field List and Grouping Bar UI elements.
platform: ej2-asp-core-mvc
control: Css Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# CSS Customization in ASP.NET MVC Pivot Table

The ASP.NET MVC Pivot Table component provides extensive CSS customization options, allowing users to modify the visual appearance and layout of various pivot table elements. This includes styling row headers, column headers, value cells, summary cells, Field List components, and Grouping Bar areas to match application themes and design requirements.

## Hiding axis

The visibility of the row, column, value, and filter axis areas in both the Field List dialog and Grouping Bar can be controlled using custom CSS styling. Each axis area has specific CSS classes that allow precise targeting for customization.

The following code example demonstrates how to hide the column axis in both the Grouping Bar and Field List within the Pivot Table. The CSS includes necessary height and spacing adjustments to prevent layout gaps and maintain visual consistency:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-axis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-axis/axis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-axis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-axis/axis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


**Note:** The CSS selectors above assume the Pivot Table component has the ID **PivotView**. Replace this with your actual component ID or use appropriate class-based selectors for your implementation.

The CSS selectors target the following Pivot Table elements:
- `.e-group-columns`: Hides the column axis in the Grouping Bar.
- `.e-group-filters`: Adjusts the height of the filter axis to compensate for the hidden column axis in the Grouping Bar.
- `.e-field-list-columns`: Hides the column axis in the Field List dialog.
- `.e-field-list-values`: Adjusts the layout of the value axis when the column section is hidden in the Field List dialog.

## Text alignment

The alignment of text inside row headers, column headers, value cells, and summary cells can be customized using CSS styling. The following example demonstrates how to center-align text in value cells (additional selectors for column headers, row headers, and summary cells are included as commented CSS in the sample):

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-align/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-align.cs" %}
{% include code-snippet/pivot-table/css-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-align.cs" %}
{% include code-snippet/pivot-table/css-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize header, value, and summary cell styles

Pivot Table elements such as header cells, value cells, and summary cells can be styled using built-in CSS class names. This enables comprehensive visual customization of the component's appearance to match application themes and design requirements.

The following code sample demonstrates how to apply custom background colors to different cell types:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-pivot/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-pivot/axis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-pivot/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-pivot/axis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Custom CSS applied to Pivot Table header](images/pivottable-css.png)

The CSS classes target the following Pivot Table elements:
- `.e-headercell`: Styles column header cells.
- `.e-rowsheader`: Styles row header cells.
- `.e-summary:not(.e-gtot)`: Styles subtotal summary cells (excluding grand totals).
- `.e-gtot`: Styles grand total cells.
