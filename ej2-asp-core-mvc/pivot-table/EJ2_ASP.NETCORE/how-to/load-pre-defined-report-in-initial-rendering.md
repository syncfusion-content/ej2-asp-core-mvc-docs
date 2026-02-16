---
layout: post
title: Load desired report from report list in ASP.NET Core Syncfusion
description: Learn here all about Load desired report from the report list as default in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load desired report from the report list as default 
documentation: ug
publishingplatform: ##Platform_Name##
---

<!-- markdownlint-disable MD009 -->
# Load desired report from list as default in ASP.NET Core Pivot Table

By default, the Pivot Table displays with the report configuration defined in the component initialization. To load a specific report from a previously saved report collection during the initial rendering process, configure the desired report name within the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event. This approach allows the Pivot Table to automatically apply the selected report's configuration, including field arrangements, filters, and formatting settings, as soon as the component completes its data binding process.

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