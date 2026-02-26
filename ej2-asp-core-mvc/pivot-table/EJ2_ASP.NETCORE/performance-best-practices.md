---
layout: post
title: Performance tips for ##Platform_Name## Pivot Table component | Syncfusion
description: Checkout and learn here all about best practices to improve the performance of the Syncfusion ##Platform_Name## Pivot Table component and much more.
platform: ej2-asp-core-mvc
control: Performance best practices
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Best practices to improve the performance of the Pivot Table

Performance optimization is crucial when working with large datasets in the [ASP.NET Core Pivot Table](https://www.syncfusion.com/aspnet-core-ui-controls/pivot-table). This documentation provides some best practices to empower your data analysis and enhance the user experience.

## How do I improve the loading performance of the Pivot Table?

### Virtual scrolling

The virtual scrolling in the pivot table significantly improves performance, especially when handling large datasets, because it only renders the rows and columns related to the current viewport. The remaining data is loaded dynamically as you scroll, either vertically or horizontally. For more information on implementing virtual scrolling in the pivot table, you can refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/virtual-scrolling).

### Paging

If your browser's maximum pixel height limits you from using the pivot table with virtual scrolling, we recommend utilizing the paging option instead. Similar to virtual scrolling, the paging option allows you to load a large amount of data, which can be displayed in the pivot table page-by-page. For more information on implementing paging in the pivot table, please refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/paging).

### Server-side engine

Connecting your application to an external service for fetching a large dataset (referred to as input data), such as one million records for the pivot table, may take considerable time due to network bandwidth limitations when transmitting data from server-side to client-side.

Therefore, we highly recommend using our server-side engine for rendering the Pivot Table with a large amount of data instead of the built-in engine.

Typically, in this approach, the pivot table component and its report are defined and often modified on the client-side (browser), while the pivot engine is implied and hosted in a dedicated web service (Web API) known as the server-side engine. Here, the server-side engine can directly connect to your data source, swiftly collect the input data (referred to as input raw data), and, based on the provided report by the pivot table through UI interactions periodically, the server-side engine performs all pivot-oriented calculations internally. It then transmits only aggregated data for pivot table display to the client-side (browser). This approach minimizes network bandwidth usage and enhances pivot table rendering.

In case a large amount of aggregated data is sent to the client-side from the web service (Web API), the server-side engine offers the option to enable virtual scrolling or paging. This feature generates aggregated data exclusively for the current viewport of the Pivot Table, further optimizing network bandwidth and rendering performance.

Additionally, the cache concept is implemented in the server-side engine to hold the pivot engine's instance based on the end-user GUID. This allows for quick retrieval, calculation, and re-sending of modified pivot data to the Pivot Table viewport, based on the UI action performed.

For more information on implementing the server-side engine in the pivot table, please refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/server-side-pivot-engine).

## How can I enhance the performance of the Pivot Table through data operations?

### Data compression

If your input data (referred to as input raw data) contains a large number of repeated records, the data compression option becomes particularly useful.

In this approach, based on the pivot report defined in the data source settings and with the data compression option enabled, all the input data is initially iterated. Repetitive records are then summarized, reducing the overall input data for all further pivot calculations. For example, if there are 1000 records with 400 records being repeated, data compression will clean up and result in 600 unique records for every future pivot calculations. Now, consider the impact with one million records and how useful it will be.

The limitation here is that during the initial rendering of the Pivot Table alone, data compression will work by taking slightly extra time to summarize and reduce overall input data. However, for subsequent uses, it will be very quick, with reduced input data. Nevertheless, it is more advantageous since it's a one-time process.

Additionally, it works with the virtual scrolling or paging option enabled as well.

N> If your input data has very few repeated records, we would not suggest this option.

For more information on implementing the data compression in the pivot table, you can refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/data-compression).

### Defer layout update

The Defer Layout Update feature in the pivot table allows end-users to perform various operations, such as adding, removing, and rearranging fields, filtering, sorting, changing aggregation types, and more, without immediately updating the pivot table. The efficiency of this process lies in allowing end-users to complete their modifications. The final application of these changes occurs when end-users click the **Apply** button in the Field List UI. This action triggers the pivot table to update based on the last modified report. By deferring the layout update until precisely requested, the ASP.NET Core Pivot Table remains unchanged initially, ensuring minimal resource utilization and avoiding frequent re-rendering until the end-user explicitly applies the modifications.

For more information on defer layout updates, you can refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/defer-update).

### Sorting

During the initial rendering phase, applying sorting to fields other than the string data type, particularly those with a large number of members, may lead to increased processing time for the pivot engine due to internal calculations. To enhance performance without compromising the final outcome, it is advisable to refrain from using sorting options at this stage. Alternatively, load the input raw data into the data source settings in the desired order for display in the pivot table.

Once the input raw data is arranged as needed and the pivot table is rendered, it is recommended to restrict the use of sorting operations for runtime performance optimization. This approach ensures efficient processing and responsive performance while still achieving the desired presentation in the pivot table.

### Member filtering

When working with large datasets, it's beneficial to set a display limit for members in the filter dialog UI. This allows the filter dialog to quickly show members up to the specified limit without facing performance issues. If there are more members beyond this limit, a message displaying the count of remaining members will appear at the bottom of the filter dialog UI. End users can then access the remaining members using the search option provided in the filter dialog during runtime. For detailed instructions on implementing the node limit in the filter dialog UI, refer to the documentation linked [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/filtering#performance-tips).

### Grouping

Using the pivot table's built-in grouping feature to group date, number, and string data type fields is not often recommended.

Here is an example below of how the [e-groupsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) tag has been used to configure grouping for the available fields using code-behind. The date and number grouping have been set to the fields "TimeLine" and "Id", respectively.

It obviously impacts the overall performance during pivot table rendering because it always consumes the input raw data, splits, redefines, and provides modified input raw data based on the fields in the report that will be used for further pivot calculations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Performance-best-practices1.cs" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs1/Performance-best-practices1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Performance-best-practices1.cs" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs1/Performance-best-practices1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

To avoid this performance constraint, we recommend passing the input raw data along with pre-processed group field sets based on your grouping needs. For example, if your input raw data has a date field "TimeLine" with the value "15/AUG/2019 03:41 PM" and you want to display it as the year and month alone, split out the date field as "TimeLine_Year" = "15/AUG/2019" for the year and "TimeLine_Month" = "15/AUG/2019" for the month. Further use the [e-formatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) property to show these date fields with the chosen date format. Similarly, to group a number field, just alter its value based on your requirements (e.g., 1–5, 6–10).

Here's an example below of configuring grouping in your input raw data and assigning it to the pivot table's data source. In the code below, the fields "TimeLine_Year," "TimeLine_Month," and "Id" are created and updated in the provided input raw data and have been specified for the date and number grouping. Additionally, the date formatting has been applied to these specified date group fields using the [e-formatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Performance-best-practices2.cs" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs2/Performance-best-practices2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Performance-best-practices2.cs" %}
{% include code-snippet/pivot-table/performance-best-practices/performance-best-practices-cs2/Performance-best-practices2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Value filtering

The [value filtering](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/filtering#value-filtering) primarily operates on grand totals, meaning the filtering process considers entire rows and columns to match applied value conditions. For similar results with more flexibility and better performance, consider exploring our label filtering or member filtering options. These alternatives can yield comparable outcomes, particularly when dealing with large datasets. You can find more information on utilizing the [label filtering](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/filtering#label-filtering) or [member filtering](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/filtering#member-filtering) options in the documentation section dedicated to these features.

## How do I improve the scrolling performance of the Pivot Table?

### Virtual scrolling with single page mode

By default, the pivot table with virtual scrolling renders not only the current view page but also the previous and next pages. However, by using single-page mode along with virtual scrolling, only the rows and columns relevant to the current view page are rendered. This optimization significantly enhances the scrolling performance of the pivot table. For more information on implementing this feature, you can refer to the documentation [here](https://ej2.syncfusion.com/aspnetcore/documentation/pivot-table/virtual-scrolling#virtual-scrolling-with-single-page-mode).

### Limiting the component size

Each row and cell in the pivot table is treated as an individual Razor component. However, loading an extensive number of rows and columns into the current view can strain memory consumption and CPU processing. To avoid such performance impacts, load a smaller set of rows and columns in the pivot table by defining and limiting the pivot table using the [Height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) and [Width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Width) properties. For example, 600px * 1000px, respectively, with just the pivot table alone (that is, without the grouping bar, toolbar, and other additional UI elements).
       
N> Normally, pixel units are preferred, ensuring more accurate page calculations compared to using percentage units, which involve additional computations for determining page as well as row and column sizes.

