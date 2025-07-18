---
layout: post
title: Scrolling in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Scrolling in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling

The scrollbar will be displayed in the treegrid when content exceeds the element [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) or [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html). The vertical and horizontal scrollbars will be displayed based on the following criteria:

The vertical scrollbar appears when the total height of rows present in the treegrid exceeds its element height.
The horizontal scrollbar appears when the sum of columns width exceeds the treegrid element width.
The [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) and [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) are used to set the treegrid height and width, respectively.

N> The default value for [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) and [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) is **auto**.

## Set width and height

To specify the [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) and [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) of the scroller in the pixel, set the pixel value to a number.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/width-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/tree-grid/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/width-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/tree-grid/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive with parent container

Specify the [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) and [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) as **100%** to make the treegrid element fill its parent container.
Setting the [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) to **100%** requires the treegrid parent element to have explicit height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/responsive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/scrolling/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/responsive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/scrolling/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Sticky header

The Syncfusion ASP.NET MVC TreeGrid provides a useful feature to keep the column headers fixed (sticky) while scrolling through large datasets. This ensures that the headers remain visible at all times, enhancing user experience by making it easier to understand the context of the data displayed, especially when dealing with wide or long hierarchical data.

For example, in a project management application, users often need to scroll through a detailed list of tasks and subtasks. When the dataset is large, scrolling down can cause confusion if the column headers scroll out of view, making it difficult to remember what each column represents. By enabling sticky headers, the column headers remain visible even while scrolling, allowing users to easily keep track of the data context.

To enable sticky headers in the TreeGrid, you can simply set the `EnableStickyHeader` property to **true**. This makes the column headers stick to the top of the TreeGrid container or its parent scrolling container when you scroll vertically.

The following sample demonstrates how to enable or disable the sticky header in the TreeGrid using a [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) and its [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/scrolling-sticky-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="sticky-header.cs" %}
{% include code-snippet/tree-grid/scrolling/scrolling-sticky-header/sticky-header.cs%}
{% endhighlight %}
{% endtabs %}

## Scroll to selected row

You can scroll the treegrid content to the selected row position by using the [`RowSelected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowSelected.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/selected-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row.cs" %}
{% include code-snippet/tree-grid/scrolling/selected-row/selected-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/selected-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row.cs" %}
{% include code-snippet/tree-grid/scrolling/selected-row/selected-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


