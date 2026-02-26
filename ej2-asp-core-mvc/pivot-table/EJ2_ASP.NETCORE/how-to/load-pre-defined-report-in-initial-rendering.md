---
layout: post
title: Load desired report from the report list as default in ##Platform_Name## Pivot Table Component
description: Learn here all about Load desired report from the report list as default in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load desired report from the report list as default 
documentation: ug
publishingplatform: ##Platform_Name##
---

<!-- markdownlint-disable MD009 -->
# Load desired report from the report list as default in ##Platform_Name## Pivot Table Component

By default, the pivot table is displayed with the report bound at the code-behind. To load a desired report from the previously saved report collection during initial rendering, set the desired report name in the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event, along with the additional report-based customization code shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/load-pre-defined-report/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LoadPreDefinedReport.cs" %}
{% include code-snippet/pivot-table/load-pre-defined-report/LoadPreDefinedReport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/load-pre-defined-report/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LoadPreDefinedReport.cs" %}
{% include code-snippet/pivot-table/load-pre-defined-report/LoadPreDefinedReport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Load desired report from the report list as default](../images/load-pre-defined-report.png)