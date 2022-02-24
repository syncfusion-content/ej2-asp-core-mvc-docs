---
layout: post
title: Exporting Hierarchy Grid in ##Platform_Name## Grid Component
description: Learn here all about Exporting Hierarchy Grid in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Exporting Hierarchy Grid
publishingplatform: aspnet-core
documentation: ug
---


# Exporting Hierarchy Grid

The grid have an option to export the hierarchy grid to pdf document. By default, grid will exports the master grid with expanded child grids alone. you can change the exporting option by using the **PdfExportProperties.hierarchyExportMode** property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the master grid with expanded child grids. |
| All      | Exports the master grid with all the child grids. |
| None     | Exports the master grid alone. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/hierarchy/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/pdf-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/hierarchy/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/pdf-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

