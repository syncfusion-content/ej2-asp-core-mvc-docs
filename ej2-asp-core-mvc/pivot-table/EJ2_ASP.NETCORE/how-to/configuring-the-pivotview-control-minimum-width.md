---
layout: post
title: Configuring minimum width in the ASP.NET Core | Syncfusion
description: Learn all about configuring the minimum width in the Syncfusion ##Platform_Name## Pivot Table control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Configuring the minimum width in the Pivot Table control.
documentation: ug
publishingplatform: ##Platform_Name## 
---
# Configuring minimum width in the ASP.NET Core Pivot Table control

The ASP.NET Core Pivot Table component provides the `minWidth` property to define the minimum width threshold for the component. This configuration ensures the pivot table maintains optimal usability and prevents layout issues when the container size decreases below the specified minimum width value.

## Default minimum width behavior

The pivot table automatically sets appropriate default minimum width values based on its current configuration:

| Configuration | Default Minimum Width | Purpose |
|---------------|----------------------|---------|
| With [Grouping Bar](../grouping-bar) enabled | 400 pixels | Accommodates grouping bar UI elements and drag-drop functionality |
| Without [Grouping Bar](../grouping-bar) | 310 pixels | Provides sufficient space for basic pivot table operations |

## Setting custom minimum width

To customize the minimum width according to specific layout requirements, configure the `minWidth` property with the desired pixel value:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/min-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinWidth.cs" %}
{% include code-snippet/pivot-table/min-width/MinWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/min-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinWidth.cs" %}
{% include code-snippet/pivot-table/min-width/MinWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Configuring the minimum width in the Pivot Table control](../images/min-width.png)