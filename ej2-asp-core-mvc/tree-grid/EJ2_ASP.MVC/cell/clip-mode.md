---
layout: post
title: Clip Mode in ##Platform_Name## TreeGrid Component | Syncfusion
description: Learn here all about Clip Mode in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Clip Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Clip Mode in ##Platform_Name## Tree Grid Component

The clip mode provides options to display its overflow cell content and it can be defined by the [`ClipMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ClipMode) property in [`Column`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

There are three types of ClipMode. They are:

* **Clip**: Truncates the cell content when it overflows its area.
* **Ellipsis**: Displays ellipsis when the cell content overflows its area.
* **EllipsisWithTooltip**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/clip-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/tree-grid/cell/clip-mode/clipMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/clip-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/tree-grid/cell/clip-mode/clipMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> By default, [`ClipMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ClipMode) value is **Ellipsis**.
