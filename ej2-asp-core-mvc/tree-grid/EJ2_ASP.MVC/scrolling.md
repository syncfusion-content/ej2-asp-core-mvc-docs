---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Scrolling of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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

> The default value for [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) and [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) is **auto**.

## Set width and height

To specify the [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) and [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) of the scroller in the pixel, set the pixel value to a number.

{% aspTab template="tree-grid/scrolling/width-height", sourceFiles="width-height.cs" %}

{% endaspTab %}

## Responsive with parent container

Specify the [`Width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Width.html) and [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) as **100%** to make the treegrid element fill its parent container.
Setting the [`Height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Height.html) to **100%** requires the treegrid parent element to have explicit height.

{% aspTab template="tree-grid/scrolling/responsive", sourceFiles="responsive.cs" %}

{% endaspTab %}

## Scroll to selected row

You can scroll the treegrid content to the selected row position by using the [`RowSelected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowSelected.html) event.

{% aspTab template="tree-grid/scrolling/selected-row", sourceFiles="selected-row.cs" %}

{% endaspTab %}
