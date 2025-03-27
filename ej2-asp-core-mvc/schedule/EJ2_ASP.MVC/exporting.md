---
layout: post
title: Exporting in ##Platform_Name## Syncfusion Schedule Component
description: Learn here all about Exporting in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting in ##Platform_Name## Schedule Component

The Scheduler supports exporting all its appointments both to an Excel or ICS extension file at client-side. It offers different client-side methods to export its appointments in an Excel or ICal format file. Let's look onto the ways on how to implement the exporting functionality in Scheduler.

## Excel Exporting

The Scheduler allows you to export all its events into an Excel format file by using the [`exportToExcel`] client-side method. By default, it exports all the default fields of Scheduler mapped through [`EventSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_EventSettings) property.

N> Before you start with excel exporting functionality, you need to import and inject the `ExcelExport` module from the `'@syncfusion/ej2-schedule'` package using the `Inject` method of Scheduler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/default-exporting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/default-exporting/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/default-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/default-exporting/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exporting with custom fields

By default, Scheduler exports all the default event fields that are mapped to it through the [`EventSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_EventSettings) property. To limit the number of fields on the exported excel file, it provides an option to export only the custom fields of the event data. To export such custom fields alone, define the required `fields` and pass it as argument to the `exportToExcel` method as shown in the following example. For example: `['Id', 'Subject', 'StartTime', 'EndTime', 'Location']`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/custom-fields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/custom-fields/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/custom-fields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/custom-fields/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exporting individual occurrences of a recurring series

By default, the Scheduler exports recurring events as a single data by exporting only its parent record into the excel file. If you want to export each individual occurrences of a recurring series appointment as separate records in an Excel file, define the `includeOccurrences` option as `true` and pass it as argument to the `exportToExcel` method. By default, the `includeOccurrences` option is set to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/occurrence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/occurrence/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/occurrence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/occurrence/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exporting custom event data

By default, the whole event collection bound to the Scheduler gets exported as an excel file. To export only specific events of Scheduler or some custom event collection, you need to pass those custom data collection as a parameter to the `exportToExcel` method as shown in this following example, through the `customData` option.

N> By default, the event data are taken from Scheduler dataSource.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/custom-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/custom-data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/custom-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/custom-data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export with custom file name

By default, the Scheduler allows you to download the exported Excel file with a name `Schedule.xlsx`. It also provides an option to export the excel file with a custom file name, define the desired `fileName` and passing it as an argument to the `exportToExcel` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/filename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/filename/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/filename/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Excel file formats

By default, the Scheduler exports event data to an excel file in the `.xlsx` format. You can also export the Scheduler data in either of the file type such as `.xlsx` or `csv` formats, by defining the `exportType` option as either `csv` or `xlsx`. By default, the `exportType` is set to `xlsx`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/format/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/format/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Custom separator in CSV

The Scheduler exports the event data to CSV format with `,` as separator. You can change separator by setting `separator` property in `ExportOptions`.



{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/csv-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/csv-format/data.cs %}
{% endhighlight %}
{% endtabs %}

### How to customize the excel sheet on before exporting

Customizing an Excel sheet before export is made easy with the `excelExport` API. This API provides users with robust flexibility to tailor the exported data, format it according to specific needs, and include additional elements for enhanced presentation.

With the `excelExport` API, you can:

- **Adjust the formatting:** Apply specific styles such as font type, size, color, and cell formatting to make the output visually appealing and consistent with your requirements.

- **Customize headers and footers:** Personalize the Excel sheet by modifying the header and footer content, offering more control over the exported document.

- **Cancel the export:** The API supports cancellation of the export process by setting the `cancel` property to `true`. This feature ensures you can prevent export based on specific conditions, offering you full control over the Excel export workflow.

Here’s an example of how you can add a custom header and footer to an Excel sheet before exporting using the `excelExport` API:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/excel-export/excel-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/excel-export/excel-customize/data.cs %}
{% endhighlight %}
{% endtabs %}


## Exporting calendar events as ICS file

You can export the Scheduler events to a calendar (.ics) file format, and open it on any of the other default calendars such as Google or Outlook.

The following code example shows how the Scheduler events are exported to a calendar (.ics) file by making use of the `exportToICalendar` public method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/default-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/default-export/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/default-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/default-export/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customizing column header with custom fields exporting

Using fields property, we can only export the defined fields into excel without customizing the header. Now we can provide the alternate support to customize the header of custom fields exporting using the `fieldsInfo` option through the `ExportFieldInfo` interface and pass it as an argument to the `exportToExcel` method as shown in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-column-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-column-header/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-column-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-column-header/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Exporting calendar with custom file name

By default, the calendar is exported with a file name `Calendar.ics`. To change this file name on export, pass the custom string value as `fileName` to the method argument so as to get the file downloaded with this provided name.

The following example downloads the iCal file with a name `ScheduleEvents.ics`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-filename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-filename/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-filename/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Import events from other calendars

The events from external calendars (ICS files) can be imported into Scheduler by using the `importICalendar` method. This method accepts the `blob object` of an .ics file to be imported, as a mandatory argument.

The following example shows how to import an ICS file into Scheduler, using the `importICalendar` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/calendar-import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/calendar-import/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/calendar-import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/calendar-import/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to print the Scheduler element

The Scheduler allows you to print the Scheduler element by using the `print` client-side method. The print method works in two ways. You can find it below.

* Using print method without options.
* Using a print method with options.

### Using print method without options

You can print the Schedule element with the current view by using the `print` method without passing the options. The following example shows how to print the Scheduler using the `print` method without passing options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/default-print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/default-print/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/default-print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/default-print/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Using a print method with options

You can print the Schedule element based on your needs using the `print` method by passing the print options used in this example with its values. The following example shows how to print the Scheduler using the `print` method by passing the options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/print-options/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/print-options/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/print-options/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/print-options/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### How to customize the print layout

The `beforePrint` event enables users to customize the print layout of the Scheduler control without altering the actual schedule layout or data. This event returns the HTML element used for printing, which can be tailored based on specific requirements before the print operation is triggered. Additionally, users can prevent the print action by setting the `cancel` property to `true`, giving them full control over when and how the print operation takes place.

Key customization options include:

- **Customizing the header and footer:** Add custom header and footer content of the print layout to include additional information.
- **Controlling print output:** Fine-tune the layout to ensure that only the necessary details are printed, ensuring a clean and structured printout.

Here’s an example of how you can add a custom header and footer to the print layout using the `beforePrint` event :

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-print/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/calendar-export/custom-print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/calendar-export/custom-print/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.
