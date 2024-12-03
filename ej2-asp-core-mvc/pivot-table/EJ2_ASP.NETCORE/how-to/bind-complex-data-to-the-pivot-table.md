---
layout: post
title: Convert complex JSON to flat JSON in ##Platform_Name## pivot table | Syncfusion
description: Learn here all about how to convert complex JSON to flat JSON and assign it to the pivot table in ##Platform_Name## component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Convert complex JSON to flat JSON and assign it to the pivot table 
documentation: ug
publishingplatform: ##Platform_Name## 
---

<!-- markdownlint-disable MD009 -->
# Convert complex JSON to flat JSON in ##Platform_Name## pivot table

By default, flat JSON can only bind to the pivot table. However, you can connect complex JSON to the pivot table by converting it to flat JSON via code-behind and binding it to the pivot table using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property in the [`load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Load) event.

In the following example, the **complexToFlatJson()** method is used to convert complex JSON to flat JSON and bind it to the pivot table using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property, then modifying the field names in the [`Rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Rows) and [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Columns) based on the converted flat JSON under [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) in the [`load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Load) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/complex-to-flat-json/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ComplexToFlatJson.cs" %}
{% include code-snippet/pivot-table/complex-to-flat-json/ComplexToFlatJson.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/complex-to-flat-json/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ComplexToFlatJson.cs" %}
{% include code-snippet/pivot-table/complex-to-flat-json/ComplexToFlatJson.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Convert complex JSON to flat JSON and assign it to the pivot table](../images/complex-to-flat-json.png)