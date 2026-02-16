---
layout: post
title: Configure Data Grid Options On Editing Mode in ##Platform_Name## Pivot Table Component
description: Learn here all about Configure Data Grid Options On Editing Mode in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Configure Data Grid Options On Editing Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Configure data grid options on editing mode

The ASP.NET MVC Pivot Table component provides the ability to configure various data grid options when working with drill-through functionality in editing mode. When users double-click on value cells (cells containing aggregated data), the component displays the underlying raw data in a drill-through grid popup. The [`BeginDrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeginDrillThrough) event allows users to access and configure grid features such as sorting, grouping, and filtering before displaying the drill-through grid popup.

## Implementation

The [`BeginDrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeginDrillThrough) event occurs when users double-click on any value cell in the pivot table. This event provides access to the grid instance and its configuration options before displaying the drill-through popup, enabling users to customize the grid behavior according to their requirements.

> Grid features are segregated into individual feature-wise modules. For example, to use the sorting feature, the `Sort` module must be injected using the `Grid.Inject(Sort)` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


