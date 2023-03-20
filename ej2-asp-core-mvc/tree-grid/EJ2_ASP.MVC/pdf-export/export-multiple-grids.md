---
layout: post
title: Export Multiple Tree Grids in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Export Multiple Tree Grids in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Export Multiple Tree Grids
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export Multiple Tree Grids

PDF export provides an option for exporting multiple Tree grids to same file. In this exported document, each Tree grid will be exported to new page of document in same file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/tree-grid/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/tree-grid/pdf-export/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
