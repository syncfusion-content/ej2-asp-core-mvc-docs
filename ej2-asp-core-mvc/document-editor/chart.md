---
layout: post
title: Chart in ##Platform_Name## Document Editor Component
description: Learn here all about Chart in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chart

Document Editor provides chart preservation support. Using Document Editor, you can see the chart reports from your Word document.

The following example shows chart preservation in Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/chart/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/chart/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Supported Chart Types

The following chart types are supported in document editor
* Scatter_Markers
* Bubble
* Area
* Area_Stacked
* Area_Stacked_100
* Bar_Clustered
* Bar_Stacked
* Bar_Stacked_100
* Column_Clustered
* Column_Stacked
* Column_Stacked_100
* Pie
* Doughnut
* Line
* Line_Markers
* Line_Markers_Stacked
* Line_Markers_Stacked_100
* Line_Stacked
* Line_Stacked_100