---
layout: post
title: Columns in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Columns in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns in gantt control

The column displays information from a bound data source, and you can edit the values of column to update the task details through TreeGrid. The operations such as sorting, filtering, and searching can be performed based on column definitions. To display a Gantt column, the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Field) property should be mapped from the data source to the column.

> If the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Field) is not specified in the data source, the column values will be empty.

The [`TreeColumnIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TreeColumnIndex) property is used to define the expander column in the Gantt control to expand and collapse the child rows.

## Defining columns

Using the [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Columns) property, you can define the columns in Gantt. If the columns are not defined, then the default columns will be rendered based on the mapped data source fields in the [`TaskFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) property. Refer to the following code example for defining the columns in Gantt along with their widths.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/definingColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/columns/definingColumns/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/definingColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefiningColumns.cs" %}
{% include code-snippet/gantt/columns/definingColumns/definingColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/definingColumns.png)

## Custom column header

The column header text can be defined using the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HeaderText) property, and you can customize the column headers using the [`HeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HeaderTemplate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/headerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplate.cs" %}
{% include code-snippet/gantt/columns/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/headerTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplate.cs" %}
{% include code-snippet/gantt/columns/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/headerTemplate.png)

## Format

To format the cell values based on a specific culture, use the [`Columns.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Format) property. The Gantt control uses the [`Internationalization`](../../common/internationalization/) library to format [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime) values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumn.cs" %}
{% include code-snippet/gantt/columns/formatColumn/formatColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumn.cs" %}
{% include code-snippet/gantt/columns/formatColumn/formatColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/formatColumn.png)

> By default, the [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime) values are formatted in `en-US` culture.

### Number formatting

The number or integer values can be formatted using the following format strings.

|Format |Description |Remarks|
|-----|-----|----|
|N | Denotes numeric type. | The numeric format is followed by an integer value like N2 or N3, which denotes the number of precisions to be allowed.|
|C | Denotes currency type. | The currency format is followed by an integer value like C2 or C3, which denotes the number of precisions to be allowed.|
|P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 100. For example, the cell value `0.2` is formatted as `20%`. The percentage format is followed by an integer value like P2, P3, which denotes the number of precisions to be allowed.|

### Date formatting

You can format date values either using the built-in date format string or a custom format string.

For the built-in date format, you can specify the [`Columns.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_Format) property as string (example: `yMd`).

You can also use the custom format string to format the date values. Some of the custom formats and the formatted date values are given in the following table.

|Format | Formatted value|
|-----|-----|
|{ type:'date', format:'dd/MM/yyyy' } | 04/07/2019|
|{ type:'date', format:'dd.MM.yyyy' } | 04.07.2019|
|{ type:'date', skeleton:'short' } | 7/4/19|
|{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/2019 12:00 AM|
|{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/2019 12:00:00 AM|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumns.cs" %}
{% include code-snippet/gantt/columns/formatColumns/formatColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/formatColumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FormatColumns.cs" %}
{% include code-snippet/gantt/columns/formatColumns/formatColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}