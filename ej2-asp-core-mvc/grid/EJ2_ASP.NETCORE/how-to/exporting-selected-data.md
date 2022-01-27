---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Exporting Selected Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Exporting Selected Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting the Selected Records

You can export the selected records data by passing it to **exportProperties.dataSource** Property in the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

In the below exporting demo, We can get the selected records using **getSelectedRecords** method and pass the selected data to **PdfExport** or **excelExport** property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="selected-data" %}
{% include_relative code-snippet/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/export-selected-data/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="selected-data" %}
{% include_relative code-snippet/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/export-selected-data/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

