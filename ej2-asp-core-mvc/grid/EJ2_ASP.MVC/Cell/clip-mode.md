---
layout: post
title: Clip Mode in ##Platform_Name## Grid Component
description: Learn here all about Clip Mode in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Clip Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Clip Mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) property in [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

There are three types of ClipMode. They are:

* **Clip**: Truncates the cell content when it overflows its area.
* **Ellipsis**: Displays ellipsis when the cell content overflows its area.
* **EllipsisWithTooltip**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/clipmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/grid/cell/clipmode/clipmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/clipmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/grid/cell/clipmode/clipmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) value is **Ellipsis**.