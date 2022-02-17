---
layout: post
title: Data Binding in ##Platform_Name## Pivot Table Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Binding

## JSON

For JSON data binding, the `type` property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) needs to be set as `JSON`. By default, the default value is assumed as `JSON`.

### Binding JSON data via local

In-order to bind local JSON data to the pivot table user can assign the local variable holding the JSON data to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).

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



Using local variable, the JSON data can also be bound to the pivot table using [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager/) option with the help of `JsonAdaptor`. Here the instance of [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager/) holding JSON data is assigned to [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). The use of [`DataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager/) is optional here.

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

In the meantime, the JSON data from the local *.json file type can also be connected to the pivot table via the file uploader option. Here, the resulting string after uploading the file needs to be converted to JSON data that can be assigned to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). The following code example illustrates the same.

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

In-order to bind remote JSON data, mention the endpoint [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property. The [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property supports both direct downloadable file (*.json) and web service URL.

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

For CSV data binding, the `type` property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) needs to be set as `CSV` mandatorily.

> The CSV format is considered to be the most compact format compared to JSON since it is half the size of JSON. This helps to reduce the bandwidth while transferring to the browser.

### Binding CSV data via local

In-order to bind local CSV data to the pivot table, user needs to convert it as string array and then directly assign it to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html).

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

In the meantime, the CSV data from the local *.csv file type can also be connected to the pivot table via the file uploader option. Here, the resulting string after uploading the file needs to be converted to string array that can be assigned to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_DataSource_System_Action_Syncfusion_EJ2_DataManagerBuilder__) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html). The following code example illustrates the same.

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

In-order to bind remote CSV data, mention the endpoint [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) property. The [`URL`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_Url) property supports both direct downloadable file (*.csv) and web service URL.

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

To interact with remote data source, provide the endpoint `Url` within `DataManager`. By default, `DataManager` uses `ODataAdaptor` for remote data-binding.

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

OData is a standardized protocol for creating and consuming data. User can retrieve data from OData service using the `DataManager` class. Refer to the following code example for remote data binding using OData service.

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

The OData V4 is an improved version of OData protocols, and the `DataManager` class can be used to retrieve and consume OData V4 services. For more details on OData V4 services, refer to the [OData documentation](http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/part1-protocol/odata-v4.0-errata03-os-part1-protocol-complete.html#_Toc453752197). To bind OData V4 service, use the [`ODataV4Adaptor`](https://ej2.syncfusion.com/documentation/data/adaptors/#odatav4-adaptor).

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

User can use `WebApiAdaptor` to bind pivot table with Web API created using OData endpoint.

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



## Mapping

One can define field information like alias name (caption), data type, aggregation type, show and hide subtotals etc. using the [`FieldMapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html). The available options are,

* `name` - It is to specify the appropriate field name.
* `caption` - It is to set the alias name (caption) to the specific field. Instead of actual field name, the alias name (caption) will be set in the UI of the pivot table.
* `type` - It is to display values in the pivot table with appropriate aggregation such as sum, product, count, average, minimum, maximum, etc. Its default value is **sum**. This option is applicable only for relational data source.
* `axis` - It will help to display the field in specified axis such as row/column/value/filter axis of the pivot table.
* `showNoDataItems` - It is to show all the members of a specific field to the pivot table, even if there are no data in the intersection of the row and column. The default value is **false**. This option is applicable only for relational data source.
* `baseField` - For the aggregate types like "DifferenceFrom" or "PercentageOfDifferenceFrom" or "PercentageOfParentTotal", selective field is assigned for comparison via this property.
* `baseItem` For the aggregate types like "DifferenceFrom" or "PercentageOfDifferenceFrom" or "PercentageOfParentTotal", selective member in a field is assigned for comparison via this property.
*`showSubTotals` - It is to show or hide sub-totals of a specific field in row and column axis of the pivot table. The default value is **true**.
* `isNamedSet` - It is to set whether the specified field is named set or not. In general, the named set is a set of dimension members or a set expression (MDX query) to be created as a dimension in the SSAS OLAP cube itself. The default value is **false** and this option is applicable only for OLAP data source.
* `isCalculatedField` - It is to set whether the specified field is a calculated field or not. In general, a calculated field is created from the bound data source or using simple formula with basic arithmetic operators in the pivot table. The default value is **false** and this option is applicable only for OLAP data source.

* `showFilterIcon` - It is to show or hide the filter icon of a specific field which will be displayed on the button of the grouping bar and field list UI. This filter icon is used to filter the members of a specified field at runtime in the pivot table. The default value is **true**.
* `showSortIcon` - It is to show or hide the sort icon of a specific field which will be displayed on the button of the grouping bar and field list UI. This sort icon is used to order members of a specified field either in ascending or descending at runtime. The default value is **true**.
* `showRemoveIcon` - It is to show or hide the remove icon of a specific field which will be displayed on the button of the grouping bar and field list UI. This remove icon is used to remove the specified field during runtime. The default value is **true**.
* `showValueTypeIcon` - It is to show or hide the value type icon of a specific field which will be displayed on the button of the grouping bar and field list UI. This value type icon helps to select the appropriate aggregation type to specified value field at runtime. The default value is **true**.
* `showEditIcon` - It is to show or hide the edit icon of a specific field which will be displayed on the button of the grouping bar and field list UI. This edit icon is used to modify caption, formula, and format of a specified calculated field at runtime. The default value is **true**.
* `allowDragAndDrop` - It is to restrict specific field's button from being dragged on runtime in the grouping bar and field list UI. This will prevent from altering the current report. The default value is **true**.
* `dataType` - It is to specify the type of the field like 'string', 'number', 'datetime', 'date', and 'boolean'.

The main purpose of these mapping options is to configure each field that is not part of the initial pivot report. Even if any field that is part of this mapping is defined here, the value set in the initial report will have the highest preceding.  
  
> This option is applicable only for relational data source.
In the below code sample, visibility of the field button icons are configured.

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

By default, the value fields are plotted in column axis. To plot those fields in row axis, use the `valueAxis` property by setting its value as `row`. By default, it holds the value `column`.

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

By default, the value fields are placed at the end of the row or column axis. To place those value fields in different positions, use the [`valueIndex`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_valueindex) property and set the value to an appropriate index position. Its default value is **-1**, which denotes the last position. The `valueIndex` property is dependent on the [`valueAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_valueAxis) property.

> This support is only available for relational data sources. Also, enable the [`showValuesButton`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowValuesButton) property in the grouping bar and field list UI to **true** to re-arrange the values fields at different positions via user interaction.

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

By default, the pivot table only shows the field item if it has data in its row or column combination. To show all items that do not have data in row and column combination in the pivot table, use the [`ShowNoDataItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowNoDataItems) property by settings its value to **true** for the desired fields. In the following code sample, rows of the "Country" and "Products" fields do not have data in all combination with "Year" and "Quarter" column field.

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

## Always shows the value headers

To show the value header always in pivot table even it holds a single value, use the [`AlwaysShowValueHeader`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AlwaysShowValueHeader) property by settings its value as **true**.

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

User can show custom string in empty value cells using the [`EmptyCellsTextContent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EmptyCellsTextContent) property in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class of the pivot table. Since the property is of string data type, user can fill empty value cells with any value like "0", "-", "*", "(blank)", etc. Its common for all value fields and can be configured through code behind.

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

## Events

### Load

The event `Load` fires before initiate rendering of pivot table. In this event user can customize data source settings before initiating pivot table render module. It holds following parameters like `dataSourceSettings`, `fieldsType` and `pivotView`.

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

The event `EnginePopulated` is triggered after engine is populated. It has following parameters - `dataSourceSettings`, `pivotFieldList` and `pivotValues`.

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

The event `EnginePopulating` triggers  before the pivot engine starts to populate and allows to customize the pivot datasource settings. It has following parameter `dataSourceSettings`.

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