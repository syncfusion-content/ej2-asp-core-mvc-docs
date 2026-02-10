---
layout: post
title: Data Binding in ASP.NET MVC Syncfusion Pivot Table
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Binding in ##Platform_Name## PivotView Component

## JSON

The Pivot Table supports JSON data binding by setting the `type` property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to `JSON`. Since JSON is the default data type, you can bind JSON data without setting this property.

### Binding JSON data via local

You can bind local JSON data to the Pivot Table by assigning a local variable containing the JSON data to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-data/localdata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-data/localdata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

You can also bind JSON data using the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) with `JsonAdaptor`. In this approach, assign the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) instance containing JSON data to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). Using [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) is optional for local JSON data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-json-datamanager/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localjsondatamanager.cs" %}
{% include code-snippet/pivot-table/data-binding/local-json-datamanager/localjsondatamanager.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-json-datamanager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localjsondatamanager.cs" %}
{% include code-snippet/pivot-table/data-binding/local-json-datamanager/localjsondatamanager.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/local-json-datamanager.png)

You can also load JSON data from a local *.json file using the file uploader option. After uploading the file, convert the resulting string to JSON data and assign it to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). The following code example demonstrates this approach.


```html
@using Syncfusion.EJ2.PivotView
@Html.EJS().Uploader("fileupload").Render()
@Html.EJS().PivotView("pivotview").Render()

<script>
    // Step 1: Initiate the file uploader
    var uploadObj = new.Uploader({});
    uploadObj.appendTo('#fileupload');
    var input = document.querySelector('input[type="file"]');
    // Step 2: Add the event listener which fires when the *.JSON file is uploaded.
    input.addEventListener('change', function (e) {
        // Step 3: Initiate the file reader
        var reader = new FileReader();
        reader.onload = function () {
            // Step 4: Getting the string output which is to be parsed as JSON.
            var result = JSON.parse(reader.result);
            var pivotObj = document.getElementById('pivotview');
            pivotObj.dataSourceSettings = {
                // Step 5: The JSON result to be bound as data source.
                dataSource: result
                // Step 6: The appropriate report needs to be provided here.
            }
        }
        reader.readAsText(input.files[0]);
    });
</script>
```

### Binding JSON data via remote

To bind remote JSON data to the Pivot Table, set the endpoint [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) in the [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property. The [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property accepts both direct downloadable JSON files (*.json) and web service URLs.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-json-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotejsondata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-json-data/remotejsondata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-json-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotejsondata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-json-data/remotejsondata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/remote-json-data.png)

## CSV

To bind CSV data, set the `type` property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to `CSV`.

> The CSV format is more compact than JSON, using approximately half the size. This reduces bandwidth usage when transferring data to the browser.

### Binding CSV data via local

To bind local CSV data to the Pivot Table, convert the data into a string array and assign it directly to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-csv-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localcsvdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-csv-data/localcsvdata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/local-csv-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localcsvdata.cs" %}
{% include code-snippet/pivot-table/data-binding/local-csv-data/localcsvdata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/local-csv-data.png)

You can also connect CSV data from a local *.csv file to the Pivot Table using the file uploader option. After uploading the file, convert the resulting string to a string array and assign it to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). The following code example shows how to implement this:


```html
@using Syncfusion.EJ2.PivotView
@Html.EJS().Uploader("fileupload").Render()
@Html.EJS().PivotView("pivotview").Render()

<script>
    // Step 1: Initiate the file uploader
    var uploadObj = new Uploader({});
    uploadObj.appendTo('#fileupload');
    var input = document.querySelector('input[type="file"]');
    // Step 2: Add the event listener which fires when the *.CSV file is uploaded.
    input.addEventListener('change', function (e) {
        // Step 3: Initiate the file reader
        var reader = new FileReader();
        reader.onload = function () {
            // Step 4: Getting the string output which is to be converted as string[][]
            var result = reader.result.split('\n').map(function (line) {
                return line.split(',');
            });
            var pivotObj = document.getElementById('pivotview');
            pivotObj.dataSourceSettings = {
                // Step 5: The string[][] result to be bound as data source
                dataSource: result,
                type: 'CSV'
                // Step 6: The appropriate report needs to be provided here.
            }
        };
        reader.readAsText(input.files[0]);
    });
</script>
```

### Binding CSV data via remote

Remote CSV data binding allows you to load data directly from external sources without storing large datasets locally, which improves application performance and reduces memory usage.

To bind remote CSV data, set the [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to point to your data source endpoint. The [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property accepts both direct downloadable CSV files (*.csv) and web service URLs that return CSV data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-csv-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotecsvdata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-csv-data/remotecsvdata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-csv-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotecsvdata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-csv-data/remotecsvdata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/remote-csv-data.png)

## Remote Data Binding

Remote data binding allows you to connect your Pivot Table component to data sources that are hosted on remote servers, enabling you to work with data from web services, databases, and other external sources.

To bind remote data, specify the endpoint `url` within [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) along with the appropriate `adaptor`. By default, `DataManager` uses `ODataAdaptor` for remote data binding.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Remotedata.cs" %}
{% include code-snippet/pivot-table/data-binding/remote-data/remotedata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Binding with OData services

OData (Open Data Protocol) is a web-based protocol that provides a standard way to create and consume data APIs. You can easily connect your Pivot Table to OData services using the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager), which handles the communication and data retrieval automatically.

The following example demonstrates how to bind the Pivot Table to an OData service:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/pivot-table/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odata.cs" %}
{% include code-snippet/pivot-table/data-binding/odata/odata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Binding with OData V4 services

OData V4 services provide enhanced query capabilities and improved performance for data retrieval operations. The OData V4 is an improved version of OData protocols, and the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) can retrieve and consume OData V4 services. For more details on OData V4 services, refer to the [OData documentation](https://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData V4 service, use the `ODataV4Adaptor`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odatav4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/pivot-table/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/odatav4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Odatav4.cs" %}
{% include code-snippet/pivot-table/data-binding/odatav4/odatav4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Web API

Web API binding allows you to connect the Pivot Table directly to RESTful web services for dynamic data loading. Users can use `WebApiAdaptor` to bind the Pivot Table with Web API created using OData endpoint.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/webapi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Web-api.cs" %}
{% include code-snippet/pivot-table/data-binding/webapi/web-api.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/webapi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Web-api.cs" %}
{% include code-snippet/pivot-table/data-binding/webapi/web-api.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Querying in Data Manager

By default, the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) fetches all records from the data source you have configured. However, you can customize this behavior by applying your own query using the `defaultQuery` property in the Data Manager instance.

The query can include operations such as filtering records based on specific conditions, sorting data in ascending or descending order, or limiting the number of records through paging. When you define these queries, the [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager) processes them at the data source level, ensuring that only the required data is retrieved and displayed in the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/ODataAdaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ODataAdaptor.cs" %}
{% include code-snippet/pivot-table/data-binding/ODataAdaptor/ODataAdaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/ODataAdaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ODataAdaptor.cs" %}
{% include code-snippet/pivot-table/data-binding/ODataAdaptor/ODataAdaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Mapping

Field mapping allows you to customize how fields appear and behave in the Pivot Table without changing the original data source. You can define field properties such as display names, data types, aggregation methods, and visibility settings using the [`FieldMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping) property within [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).

The following options are available for field mapping:

**Field identification and display**

* [`Name`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_Name_System_String_) - Specifies the field name from your data source.
* [`Caption`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_Caption_System_String_) - Sets a user-friendly display name for the field. This display name will appear in the Pivot Table UI instead of the original field name..
* [`GroupName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_GroupName_System_String_) - Groups related fields under a folder name in the field list UI for better organization.
* [`DataType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_DataType_System_String_) - It is to specify the type of the field like 'string', 'number', 'datetime', 'date', and 'boolean'.

**Aggregation and calculation**

* [`type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_Type_Syncfusion_EJ2_PivotView_SummaryTypes_) - Defines how values are aggregated in the Pivot Table, such as sum, product, count, average, minimum, or maximum. The default value is **sum**. This option applies only to relational data sources.
* [`BaseField`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_BaseField_System_String_) - Specifies a comparison field for aggregate types like "DifferenceFrom", "PercentageOfDifferenceFrom", or "PercentageOfParentTotal".
* [`BaseItem`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_BaseItem_System_String_) - Specifies a comparison member within a field for aggregate types like "DifferenceFrom", "PercentageOfDifferenceFrom", or "PercentageOfParentTotal".

**Field positioning and behavior**

* [`Axis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_Axis_System_String_) - Determines where the field appears in the Pivot Table (row, column, value, or filter axis).
* [`ShowNoDataItems`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowNoDataItems_System_Boolean_) - Shows all field members in the Pivot Table, even when no data exists at row and column intersections. The default value is **false**. This option applies only to relational data sources.
*  [`ExpandAll`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ExpandAll_System_Boolean_) - Expands or collapses all headers for the field in row and column axes. The default value is **false**.
* [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowSubTotals_System_Boolean_) - Controls the visibility of subtotals for the field in row and column axes. The default value is **true**.

**OLAP-specific options**

* [`IsNamedSet`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_IsNamedSet_System_Boolean_) - It is to set whether the specified field is named set or not. In general, the named set is a set of dimension members or a set expression (MDX query) to be created as a dimension in the SSAS OLAP cube itself. The default value is **false** and this option is applicable only for OLAP data source.
* [`IsCalculatedField`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_IsCalculatedField_System_Boolean_) - It is to set whether the specified field is a calculated field or not. In general, a calculated field is created from the bound data source or using simple formula with basic arithmetic operators in the Pivot Table. The default value is **false** and this option is applicable only for OLAP data source.

**UI interaction controls**

* [`ShowFilterIcon`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowFilterIcon_System_Boolean_) - Controls the visibility of the filter icon on field buttons in the grouping bar and field list. Users can filter field members at runtime using this icon. The default value is **true**.
* [`ShowSortIcon`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowSortIcon_System_Boolean_) - Controls the visibility of the sort icon on field buttons in the grouping bar and field list. Users can sort field members in ascending or descending order at runtime. The default value is **true**.
* [`ShowRemoveIcon`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowRemoveIcon_System_Boolean_) - Controls the visibility of the remove icon on field buttons in the grouping bar and field list. Users can remove fields from the report at runtime. The default value is **true**.
* [`ShowValueTypeIcon`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowValueTypeIcon_System_Boolean_) - Controls the visibility of the value type icon on field buttons in the grouping bar and field list. Users can change the aggregation type for value fields at runtime. The default value is **true**.
* [`ShowEditIcon`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_ShowEditIcon_System_Boolean_) - Controls the visibility of the edit icon on field buttons in the grouping bar and field list. Users can modify the caption, formula, and format of calculated fields at runtime. The default value is **true**.
* [`AllowDragAndDrop`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FieldMappingFieldListDataSourceBuilder.html#Syncfusion_EJ2_PivotView_FieldMappingFieldListDataSourceBuilder_AllowDragAndDrop_System_Boolean_) - Controls whether field buttons can be dragged in the grouping bar and field list UI. Setting this to **false** prevents users from modifying the current report structure. The default value is **true**.

Field mapping is particularly useful for configuring fields that are not part of your initial pivot report. When a field appears in both the initial report and field mapping, the initial report settings take priority.

> This option applies only to relational data sources.

The following code sample demonstrates how to configure the visibility of field button icons:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/field-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldmapping.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/field-mapping/fieldmapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/field-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldmapping.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/field-mapping/fieldmapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/field-mapping.png)

## Values in row axis

You can display value fields in the row axis of the Pivot Table to make your data analysis clear and more accessible. By default, value fields appear in the column axis. To display these fields in the row axis, set the [`valueAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ValueAxis) property to **row**. The default value is **column**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valuesinrow.cs" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/valuesinrow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valuesinrow.cs" %}
{% include code-snippet/pivot-table/data-binding/values-in-row/valuesinrow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/valueaxis.png)

## Values at different positions

Positioning value fields at specific locations helps create more meaningful data layouts and improves the readability of your Pivot Table. By default, value fields appear at the end of the row or column axis. To place value fields at different positions, use the [`valueIndex`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_valueindex) property and set it to the desired index position. The default value is **-1**, which places fields at the last position. The [`valueIndex`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_valueindex) property works together with the [`valueAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ValueAxis) property.

> This option is available only for relational data sources. To enable users to rearrange value fields through the interface, set the [`showValuesButton`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowValuesButton) property to **true** in both the grouping bar and field list UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/measureatdifferentposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Measureatdifferentposition.cs" %}
{% include code-snippet/pivot-table/data-binding/measureatdifferentposition/measureatdifferentposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/measureatdifferentposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Measureatdifferentposition.cs" %}
{% include code-snippet/pivot-table/data-binding/measureatdifferentposition/measureatdifferentposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![output](images/measureatdifferentposition.png)

## Show 'no data' items

Display all field items in your Pivot Table, even when they lack data in certain row and column combinations, for a complete view of your data structure. By default, the Pivot Table displays field items only when they contain data in their respective row or column combinations. However, you can show all items, including those without data, by setting the [`ShowNoDataItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowNoDataItems) property to **true** for the desired fields.

In the following example, the "Country" and "State" field rows are displayed even when they don't have data in all combinations with the "Date" column field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/no-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodata.cs" %}
{% include code-snippet/pivot-table/data-binding/no-data/nodata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/no-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodata.cs" %}
{% include code-snippet/pivot-table/data-binding/no-data/nodata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/nodata.png)

## Show value headers always

Ensure value headers remain visible in your Pivot Table at all times, providing consistent column identification even with single value scenarios. The Pivot Table typically hides value headers when displaying only one value. To maintain consistent header visibility regardless of the number of values, set the [`AlwaysShowValueHeader`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AlwaysShowValueHeader) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Single-calculation-header.cs" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/single-calculation-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Single-calculation-header.cs" %}
{% include code-snippet/pivot-table/data-binding/single-calculation-header/single-calculation-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/valuesheader.png)

## Customize empty value cells

Show custom text in cells that contain no data to make your Pivot Table more informative and user-friendly. By default, empty value cells appear blank in the Pivot Table. However, you can display meaningful text in these cells using the [`EmptyCellsTextContent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EmptyCellsTextContent)  property within the [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). Since this property accepts string values, you can fill empty cells with any text such as "0", "-", "*", "(blank)", or other meaningful indicators. This setting applies to all value fields and can be configured in your code behind.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-cells.cs" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/empty-cells.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-cells.cs" %}
{% include code-snippet/pivot-table/data-binding/empty-cells/empty-cells.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/emptyvalues.png)

## Event

The Pivot Table component provides essential events that help you monitor and control the data binding process. These events give you access to the underlying data and allow you to customize how the pivot engine handles your data.

### Load

The [`load`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Load) event fires before the Pivot Table begins rendering and provides access to key parameters that you can use to customize your data source configuration, apply filters, or modify field settings before the table displays.

**Event Parameters**

The load event provides the following parameters:

- `dataSourceSettings` filters.
- `defaultFieldListOrder`: Defines the default field list order that determines how fields appear in the field list panel.
- `fieldsType`: Defines the type of specific fields, such as whether they should be treated as numbers, dates, or text.
- `pivotview`: Defines the Pivot Table instance object that provides access to all component methods and properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/load/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Load.cs" %}
{% include code-snippet/pivot-table/data-binding/load/load.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/load/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Load.cs" %}
{% include code-snippet/pivot-table/data-binding/load/load.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### EnginePopulated

The [`enginePopulated`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnginePopulated) event helps users monitor when the Pivot Table engine has finished processing the data. This allows you to access important details about the table, such as report settings, field list, and processed values, and perform further actions if needed.

When this event triggers, it provides the following parameters:

- `dataSourceSettings`: Contains information about the structure and options applied to the Pivot Table’s data.
- [`pivotFieldList`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotFieldList.html): Lists all available fields in the Pivot Table, including those used in rows, columns, values, and filters.
- [`pivotValues`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PivotValues): Presents the aggregated values and results displayed in the table.

Below is an example showing how the [`enginePopulated`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnginePopulated) event can be used in a ASP.NET MVC Pivot Table. The code demonstrates how to set up the event and access its details for custom logic.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/engine-populated/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enginepopulated.cs" %}
{% include code-snippet/pivot-table/data-binding/engine-populated/enginepopulated.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/engine-populated/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enginepopulated.cs" %}
{% include code-snippet/pivot-table/data-binding/engine-populated/enginepopulated.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### EnginePopulating

The [`enginePopulating`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnginePopulating) event lets you update the [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) before the Pivot Table's engine processes the data. This allows you to modify how your data appears by changing field captions, formatting options, or report configurations right before the table renders. For example, you can adjust column captions or show a message for empty cells. This helps users control how the data will appear in the Pivot Table in a straightforward way.

The [`enginePopulating`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnginePopulating) event provides an argument that contains the `dataSourceSettings` property. You can directly edit this property to update fields, labels, or other `dataSourceSettings` options, ensuring your Pivot Table displays data exactly how you need it. Below is an example showing how to use the `enginePopulating` event in a ASP.NET MVC Pivot Table:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/engine-populating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enginepopulating.cs" %}
{% include code-snippet/pivot-table/data-binding/engine-populating/enginepopulating.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/data-binding/engine-populating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enginepopulating.cs" %}
{% include code-snippet/pivot-table/data-binding/engine-populating/enginepopulating.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Aggregation](./aggregation)
* [Show/Hide Totals](./summary-customization)
* [Customize number, date, and time values](./how-to/customize-number-date-and-time-values)
* [Server Side Engine (Optional)](./server-side-pivot-engine)