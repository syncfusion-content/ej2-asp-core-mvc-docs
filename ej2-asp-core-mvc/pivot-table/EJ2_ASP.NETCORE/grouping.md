---
layout: post
title: Grouping in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table groups date, number, and string fields into categories such as years, quarters, and value ranges for easier analysis.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping in ASP.NET Core Pivot Table

> This feature is applicable only for the relational data source.

Grouping is one of the most useful features in the Pivot Table component, automatically organizing date, time, number, and string data types into meaningful categories. For example, date fields can be formatted and displayed based on year, quarter, month, and other time periods. Similarly, number fields can be grouped into ranges, such as 1-5, 6-10, and so on. These grouped fields function as individual fields, allowing users to drag them between different axes including columns, rows, values, and filters to create dynamic Pivot Tables at runtime.

The grouping feature can be enabled by setting the [`AllowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowGrouping) property to `true` in the Pivot Table component. The default value is `false`.

To perform grouping actions through the user interface, right-click on the Pivot Table's row or column header and select **Group**. A dialog will appear where you can configure the appropriate options to group the data. To ungroup data, right-click on the Pivot Table's row or column header and select **Ungroup**.

To use the grouping feature, you need to inject the `Grouping` module in the Pivot Table component. The component supports three different types of grouping:

* Number Grouping
* Date Grouping
* Custom Grouping

> Similar to Excel, only one type of grouping can be applied to a field at a time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/group-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/group-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Number Grouping

Number grouping allows users to organize numerical data into different ranges, such as 1–5, 6–10, and so on. This can be configured via the UI by right-clicking a number-based header in the Pivot Table and selecting the **Group** option from the context menu.

> The selected field must contain numeric data; otherwise, the **Group** option is not available in the context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/number-group-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/number-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/number-group-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/number-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Context-menu options for number grouping](../pivot-table/images/number-group-option.png)

### Range selection

The "**Starting at**" and "**Ending at**" options are used to set the number range on which the headers will be grouped. For example, if the "Product_ID" field holds the numbers from "1001" to "1010" and the user chooses to group the number range by setting "**1004**" as "**Starting at**" and "**1008**" as "**Ending at**", then the specified number range is used for number grouping and the rest are grouped as "**Out of Range**".

![Range options applied for number grouping](../pivot-table/images/number-group-settings-range-applied.png)

### Range interval

The "**Interval by**" option is used to separate the selected number data type field into ranges such as 1-5, 6-10, etc. For example, if the user wants to display the "Product_ID" data field with a group interval of "**2**" by setting the "**Interval by**" option, the "Product_ID" field is then grouped by the specified range of intervals, such as "**1004-1005**", "**1006-1007**", and so on.

![Grouping settings options applied for number grouping](../pivot-table/images/number-group-settings-applied.png)
<br/>
![Applied grouping settings updated in pivot table for number grouping](../pivot-table/images/number-group-updated.png)

### Configuring Number Grouping Programmatically

You can configure number grouping programmatically using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) property. This allows you to define how numbers are grouped without relying on the UI. Below are the key settings you need:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Sets the field name.
* [`rangeInterval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_RangeInterval): Sets the interval between two numbers.
* [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt): Sets the starting number.
* [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt): Sets the ending number.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Sets the group type. For number grouping, [**Number**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GroupType.html) is set.

> If the starting and ending numbers specified in [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt) and [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt) are within the number range, the rest of the numbers are grouped and placed in the “Out of Range” section introduced specifically for this feature.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/number-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/number-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/number-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/number-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Applied grouping settings updated in pivot table for number grouping](../pivot-table/images/number-group-updated.png)

### Ungrouping the existing number groups

To remove an applied number grouping, right-click on the grouped header in the Pivot Table and select **Ungroup** from the context menu. This action breaks apart the grouped ranges and displays the original, ungrouped values in the table.

![Number ungroup option](../pivot-table/images/number-ungroup.png)

## Date Grouping

Date grouping organizes date and time data into hierarchical segments, such as years, quarters, months, days, hours, minutes, or seconds. Users can configure date grouping through the UI by right-clicking a date- or time-based header in the Pivot Table and selecting the **Group** option from the context menu. A dialog will appear, allowing users to choose the desired grouping intervals.

> The selected field must contain date or time data; otherwise, the **Group** option is not available in the context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/date-group-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/date-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/date-group-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/date-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Context-menu options for date grouping](../pivot-table/images/date-group-option.png)

### Range selection

The **Starting at** and **Ending at** options allow users to define the date range for grouping headers. For example, if the "Date" field contains data from "01/01/2015" to "02/12/2018" and the user sets **Starting at** to "**01/07/2015**" and **Ending at** to "**31/07/2017**", only records within this range are grouped according to the selected settings. Dates outside this range are labeled as **Out of Range**.

![Range options applied for date grouping](../pivot-table/images/date-group-settings-range-applied.png)

### Group Interval

The **Interval by** option allows users to split date fields into years, quarters, months, days, hours, minutes, or seconds. For example, selecting **Years** and **Months** as intervals for the "Date" field results in two new fields: **Years (Date)**, containing the year values, and **Months (Date)**, containing the month values. These grouped fields can be used for report manipulations in the Pivot Table at runtime.

> If no options are selected in the **Interval by** section, the **OK** button in the dialog remains disabled. At least one interval must be chosen to enable date grouping.

![Group interval option applied for date grouping](../pivot-table/images/date-group-settings-interval-applied.png)
<br/>

![Grouping settings options applied for date grouping](../pivot-table/images/date-group-settings-applied.png)
<br/>

![Applied grouping settings updated in pivot table for date grouping](../pivot-table/images/date-group-updated.png)

### Configuring Date Grouping Programmatically

You can configure date grouping programmatically using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) property. This allows you to define how dates are grouped without using the UI. The key settings are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Sets the field name.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Sets the group type. For date grouping, **Date** is set.
* [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt): Sets the starting date.
* [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt): Sets the ending date.
* [`groupInterval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_GroupInterval): Sets the interval in year, quarter, month, day, hour, minute, or second pattern.

> For example, if your date format is "YYYY-DD-MM HH:MM:SS" and you want to group only by year and month, set the `groupInterval` property with just **Years** and **Months**. You can also rearrange the order of the intervals (Year, Quarter, Month, Day, etc.) as needed—this order is reflected in the Pivot Table display.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/date-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/date-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/date-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/date-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Furthermore, in the field list UI, these date group fields **Years (Date)**, **Quarters (Date)**, **Months (Date)**, etc... will be automatically grouped and displayed under the **Date** folder name.

![Date fields are grouped and displayed under a folder named Date](images/treeview.png)

### Ungrouping the existing date groups

To remove a previously applied date grouping, right-click the relevant date-based header within the Pivot Table and select the **Ungroup** option from the context menu. This action reverts the grouped dates back to their original, ungrouped state, allowing you to view and analyze the raw date values in the Pivot Table component.

![Date ungroup option](../pivot-table/images/date-ungroup.png)

## Custom Grouping

Custom grouping is an option that enables users to group data types (date, time, number, or string) into custom fields based on specific requirements. This functionality can be accessed through the user interface by right-clicking a header in the Pivot Table.

> The selection settings must have `Mode` set to `Cell` and `Type` set to `Multiple` for the **Group** option to appear in the context menu. See the [Limitations](#limitations) section below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/custom-group-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/custom-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/custom-group-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/custom-group-ui/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Creating a Custom Group

To create a custom group in the Pivot Table, select at least two headers from the same field. Hold the **CTRL** key to select multiple headers individually, or hold the **SHIFT** key to select a range of headers. Then, right-click and choose **Group** from the context menu.

![Context-menu options for custom grouping](../pivot-table/images/custom-group-option.png)

In the dialog box:
- **Field Caption**: Set an alias name for the new custom field, which will appear in the Pivot Table.
- **Group Name**: Define the top-level name for the group that will contain the selected headers.

For example, to group the headers "Gloves," "Jerseys," and "Shorts" in the "Products" field under a single group, set the **Group Name** to "Clothings." The selected headers will then appear under "Clothings" in the Pivot Table.

![Caption applied for custom grouping](../pivot-table/images/custom-group-settings-caption-applied.png)
<br/>

![Grouping settings applied for custom grouping](../pivot-table/images/custom-group-settings-applied.png)
<br/>

![Applied grouping settings updated in pivot table for custom grouping](../pivot-table/images/custom-group-updated.png)

### Nested Custom Grouping

Users can also apply new custom grouping options to an existing custom field by right-clicking the custom group header in the Pivot Table. For example, if the user wants to create a new custom group for the current custom group headers such as "**Bottles and Cages**", "**Cleaners**", and "**Fenders**" by setting the top-level name as "**Accessories**" in "**Group Name**", the selected headers are then grouped in the Pivot Table under the name "**Accessories**" with a new custom field called "**Product category 1**".

![Context-menu options for nested custom grouping](../pivot-table/images/nested-custom-group-option.png)
<br/>

![Grouping settings applied for nested custom grouping](../pivot-table/images/nested-custom-group-settings-applied.png)
<br/>

![Applied grouping settings updated in pivot table for custom grouping](../pivot-table/images/nested-custom-group-updated.png)

### Configuring Custom Grouping Programmatically

You can configure custom grouping programmatically using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) property in the Pivot Table component. This property allows you to define how fields are grouped in the Pivot Table without using the UI. The available properties are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Sets the field name.
* [`caption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Caption): Sets the caption name for custom grouping field.
* [`e-customGroups`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html): Sets the custom groups.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Sets the group type. For custom grouping, **Custom** is set.

The [`e-customGroups`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html) property includes:

*[`groupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_GroupName): Sets the group name (or title) for selected headers.
* [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_Items): Sets the headers that need to be grouped together for display.

> Headers listed in [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_Items) are grouped under the specified[`groupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_GroupName) in the Pivot Table. Headers not included in [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_Items) are displayed under their original names.

Here’s an example of configuring custom grouping programmatically:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/custom-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/custom-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping/custom-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/pivot-table/grouping/custom-group/Grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Applied grouping settings updated in pivot table for custom grouping](../pivot-table/images/custom-group-updated.png)

### Ungrouping Existing Custom Groups

To remove a custom group in the Pivot Table, right-click on the grouped header and select the **Ungroup** option from the context menu. This action separates the grouped items back into their individual headers within the Pivot Table.

> After ungrouping, if you remove the related field from the report, any custom group fields associated with it are also removed from the Pivot Table.

![Custom ungroup option](../pivot-table/images/custom-ungroup.png)

## Limitations

The grouping feature relies on the following `selectionSettings`: selection `mode` set to **Cell**, selection `type` set to **Multiple**, and `cellSelectionMode` set to **Box** by default. When using the `selection` and grouping features together, cell selection is limited to row or column headers with these settings. Other settings, such as selection `mode` set to **Row** or **Column**, selection `type` set to **Single**, or `cellSelectionMode` set to **Flow**, are incompatible with grouping in the Pivot Table.
