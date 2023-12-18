---
layout: post
title: Multiple gantt exporting in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Multiple gantt exporting in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple exporting action in gantt control

PDF export provides an option for exporting multiple Gantt to same file. In this exported document, each Gantt will be exported to a new page of the document in same file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

