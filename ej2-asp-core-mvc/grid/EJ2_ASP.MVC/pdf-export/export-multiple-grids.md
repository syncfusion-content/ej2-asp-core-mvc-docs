---
layout: post
title: Export Multiple Grids in ##Platform_Name## Grid Component
description: Learn here all about Export Multiple Grids in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Multiple Grids
publishingplatform: ##Platform_Name##
documentation: ug
---


# Export Multiple Grids

The PDF export provides an option to export multiple grids to the same or different pages of a PDF file. Each grid is identified by its unique ID. You can specify which grid to export by listing their **IDs** in the `exportGrids` property.

## Same page

PDF exporting provides support for exporting multiple grids on the same page. To export the grids on the same page, define `multipleExport.type` as **AppendToPage** in `exportProperties`. It also has an option to provide blank space between the grids. This blank space can be defined by using **multipleExport.blankSpace** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/same-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="same-page.cs" %}
{% include code-snippet/grid/pdf-export/same-page/same-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/same-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="same-page.cs" %}
{% include code-snippet/grid/pdf-export/same-page/same-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## New page

PDF export functionality enables the exporting of multiple grids into separate pages (each grid on a new page) within the PDF file. To achieve this, you can specify `multipleExport.type` as **NewPage** in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/grid/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/grid/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}