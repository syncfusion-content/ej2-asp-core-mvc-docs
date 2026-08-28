---
layout: post
title: How to load a saved report in Pivot Table on startup | Syncfusion
description: Step-by-step example showing how to load a pre-defined report from a saved report collection on the initial render of the Pivot Table using the dataBound event.
platform: ej2-asp-core-mvc
control: Load desired report from the report list as default
documentation: ug
publishingplatform: ##Platform_Name##
---

<!-- markdownlint-disable MD009 -->

# Load a saved report in Pivot Table on startup in ASP.NET MVC

By default, the Pivot Table displays with the report configuration defined in the component initialization. To load a specific report from a previously saved report collection during the initial rendering process, configure the desired report name within the [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event. This approach allows the Pivot Table to automatically apply the selected report's configuration, including field arrangements, filters, and formatting settings, as soon as the component completes its data binding process.

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
