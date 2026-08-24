---
layout: post
title:  ##Platform_Name## TreeGrid Adaptive UI | Syncfusion
description: Learn how to enable adaptive UI in ##Platform_Name## TreeGrid for optimized mobile, tablet, and small-screen user experiences.
platform: ej2-asp-core-mvc
control: Adaptive
publishingplatform: ##Platform_Name##
documentation: ug
---


# Adaptive UI in ##Platform_Name## TreeGrid

The Tree Grid user interface (UI) was redesigned to provide an optimal viewing experience and improve usability on small screens. This interface will render the filter, sort, and edit dialogs adaptively.

## Render adaptive dialogs

When you enable the [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableAdaptiveUI) property, the tree grid will render the filter, sort, and edit dialogs in full screen for a better user experience. The following demo demonstrates this behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/adaptive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/adaptive/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/adaptive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/adaptive/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


N> Refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to learn how to present and manipulate data.