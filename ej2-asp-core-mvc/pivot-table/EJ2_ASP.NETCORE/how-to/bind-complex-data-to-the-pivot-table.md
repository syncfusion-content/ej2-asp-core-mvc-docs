---
layout: post
title: Complex JSON to flat JSON in ASP.NET Core Syncfusion
description: Learn to convert complex JSON to flat JSON and bind to Syncfusion ASP.NET Core Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Convert complex JSON to flat JSON and assign it to the pivot table 
documentation: ug
publishingplatform: ##Platform_Name## 
---

<!-- markdownlint-disable MD009 -->
# Convert complex JSON to flat JSON and assign it to pivot table

## Overview

The ASP.NET Core Pivot Table component requires data in flat JSON format for proper binding. This guide explains how to convert complex, nested JSON structures to flat JSON format and bind it to the pivot table.

## Understanding complex vs flat JSON

Complex JSON contains nested objects and arrays, making it difficult to directly bind to the pivot table. For example:

```json
{
  "CustomerID": "VINET",
  "Freight": 32.38,
  "OrderDetails": [
    {
      "OrderID": 10248,
      "OrderDate": "1996-07-04T10:10:00.000Z"
    }
  ],
  "ShipDetails": [
    {
      "ShipName": "Vins et alcools Chevalier",
      "ShipAddress": "59 rue de l'Abbaye",
      "ShipCity": "Reims",
      "ShipRegion": null,
      "ShipCountry": "France",
      "ShippedDate": "1996-07-16T12:20:00.000Z"
    }
  ]
}
```

Flat JSON has a simple key-value structure without nesting, which is suitable for pivot table binding:

```json
{
  "CustomerID": "VINET",
  "Freight": 32.38,
  "OrderID": 10248,
  "OrderDate": "1996-07-04T10:10:00.000Z",
  "ShipName": "Vins et alcools Chevalier",
  "ShipAddress": "59 rue de l'Abbaye",
  "ShipCity": "Reims",
  "ShipRegion": null,
  "ShipCountry": "France",
  "ShippedDate": "1996-07-16T12:20:00.000Z"
}
```

## Implementation

You can convert complex JSON to flat JSON programmatically and bind it to the pivot table using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property in the [`load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Load) event.

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