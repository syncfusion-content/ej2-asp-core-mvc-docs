---
title: "Exporting and importing of events"
component: "Scheduler"
description: "Learn how to export Scheduler events to an excel/ICS file and import events from ICS."
---

# Exporting

The Scheduler supports exporting all its appointments both to an Excel or ICS extension file at client-side. It offers different client-side methods to export its appointments in an Excel or ICal format file. Let's look onto the ways on how to implement the exporting functionality in Scheduler.

## Excel Exporting

The Scheduler allows you to export all its events into an Excel format file by using the [`exportToExcel`] client-side method. By default, it exports all the default fields of Scheduler mapped through `<e-schedule-eventsettings>` property.

{% aspTab template="schedule/excel-export/default-exporting", sourceFiles="data.cs"  %}

{% endaspTab %}

### Exporting with custom fields

By default, Scheduler exports all the default event fields that are mapped to it through the `<e-schedule-eventsettings>` property. To limit the number of fields on the exported excel file, it provides an option to export only the custom fields of the event data. To export such custom fields alone, define the required `fields` and pass it as argument to the `exportToExcel` method as shown in the following example. For example: `['Id', 'Subject', 'StartTime', 'EndTime', 'Location']`.

{% aspTab template="schedule/excel-export/custom-fields", sourceFiles="data.cs"  %}

{% endaspTab %}

### Exporting individual occurrences of a recurring series

By default, the Scheduler exports recurring events as a single data by exporting only its parent record into the excel file. If you want to export each individual occurrences of a recurring series appointment as separate records in an Excel file, define the `includeOccurrences` option as `true` and pass it as argument to the `exportToExcel` method. By default, the `includeOccurrences` option is set to `false`.

{% aspTab template="schedule/excel-export/occurrence", sourceFiles="data.cs"  %}

{% endaspTab %}

### Exporting custom event data

By default, the whole event collection bound to the Scheduler gets exported as an excel file. To export only specific events of Scheduler or some custom event collection, you need to pass those custom data collection as a parameter to the `exportToExcel` method as shown in this following example, through the `customData` option.

> By default, the event data are taken from Scheduler dataSource.

{% aspTab template="schedule/excel-export/custom-data", sourceFiles="data.cs"  %}

{% endaspTab %}

### Export with custom file name

By default, the Scheduler allows you to download the exported Excel file with a name `Schedule.xlsx`. It also provides an option to export the excel file with a custom file name, define the desired `fileName` and passing it as an argument to the `exportToExcel` method.

{% aspTab template="schedule/excel-export/filename", sourceFiles="data.cs"  %}

{% endaspTab %}

### Excel file formats

By default, the Scheduler exports event data to an excel file in the `.xlsx` format. You can also export the Scheduler data in either of the file type such as `.xlsx` or `csv` formats, by defining the `exportType` option as either `csv` or `xlsx`. By default, the `exportType` is set to `xlsx`.

{% aspTab template="schedule/excel-export/format", sourceFiles="data.cs"  %}

{% endaspTab %}

## Exporting calendar events as ICS file

You can export the Scheduler events to a calendar (.ics) file format, and open it on any of the other default calendars such as Google or Outlook.

The following code example shows how the Scheduler events are exported to a calendar (.ics) file by making use of the `exportToICalendar` public method.

{% aspTab template="schedule/calendar-export/default-export", sourceFiles="data.cs"  %}

{% endaspTab %}

### Customizing column header with custom fields exporting

Using fields property, we can only export the defined fields into excel without customizing the header. Now we can provide the alternate support to customize the header of custom fields exporting using the `fieldsInfo` option through the `ExportFieldInfo` interface and pass it as an argument to the `exportToExcel` method as shown in the following example.

{% aspTab template="schedule/calendar-export/custom-column-header", sourceFiles="data.cs"  %}

{% endaspTab %}

### Exporting calendar with custom file name

By default, the calendar is exported with a file name `Calendar.ics`. To change this file name on export, pass the custom string value as `fileName` to the method argument so as to get the file downloaded with this provided name.

The following example downloads the iCal file with a name `ScheduleEvents.ics`.

{% aspTab template="schedule/calendar-export/custom-filename", sourceFiles="data.cs"  %}

{% endaspTab %}

## Import events from other calendars

The events from external calendars (ICS files) can be imported into Scheduler by using the `importICalendar` method. This method accepts the `blob object` of an .ics file to be imported, as a mandatory argument.

The following example shows how to import an ICS file into Scheduler, using the `importICalendar` method.

{% aspTab template="schedule/calendar-export/calendar-import", sourceFiles="data.cs"  %}

{% endaspTab %}

## How to print the Scheduler element

The Scheduler allows you to print the Scheduler element by using the `print` client-side method. The print method works in two ways. You can find it below.

* Using print method without options.
* Using a print method with options.

### Using print method without options

You can print the Schedule element with the current view by using the `print` method without passing the options. The following example shows how to print the Scheduler using the `print` method without passing options.

{% aspTab template="schedule/calendar-export/default-print", sourceFiles="data.cs"  %}

{% endaspTab %}

### Using a print method with options

You can print the Schedule element based on your needs using the `print` method by passing the print options used in this example with its values. The following example shows how to print the Scheduler using the `print` method by passing the options.

{% aspTab template="schedule/calendar-export/print-options", sourceFiles="data.cs"  %}

{% endaspTab %}

> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
