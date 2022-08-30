---
layout: post
title: Custom data source in Syncfuion ##Platform_Name## Gantt Component
description: Learn here all about Custom data source in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom data source

The excel export provides an option to define datasource dynamically before exporting. To export data dynamically, define the `dataSource` in `exportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/excel-export/customDataSource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomDataSource.cs" %}
{% include code-snippet/gantt/excel-export/customDataSource/customDataSource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}