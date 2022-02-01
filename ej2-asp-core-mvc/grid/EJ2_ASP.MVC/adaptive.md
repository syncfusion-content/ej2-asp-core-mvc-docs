---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Adaptive of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Adaptive
publishingplatform: ##Platform_Name##
documentation: ug
---


# Adaptive View

The Grid user interface (UI) was redesigned to provide an optimal viewing experience and improve usability on small screens. This interface will render the filter, sort, and edit dialogs adaptively and have an option to render the grid row elements in the vertical direction.

## Render adaptive dialogs

When we enable the [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property, the grid will render the filter, sort, and edit dialogs in full screen for a better user experience. This behavior is demonstrated in the below demo.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/adaptive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/adaptive/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/adaptive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/adaptive/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Vertical row rendering

The grid will render the row elements in vertical order while setting the [`rowRenderingMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowRenderingMode) property value as **Vertical**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/vertical-rendering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/vertical-rendering/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/vertical-rendering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default" %}
{% include code-snippet/grid/vertical-rendering/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAdaptiveUI) property must be enabled for vertical row rendering.

### Supported features by vertical row rendering

The following features are only supported in vertical row rendering:

* Paging
* Sorting
* Filtering
* Selection
* Dialog Editing
* Aggregate
* Infinite scroll
* Toolbar
