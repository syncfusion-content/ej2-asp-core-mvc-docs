---
layout: post
title: Grouping in ##Platform_Name## Syncfusion Pivot Table Control | Syncfusion
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping in ##Platform_Name## Pivot Table Control

> This feature is applicable only for relational data source.

Grouping is the most-useful feature in pivot table and the component automatically groups date, time, number and string. For example, the date type can be formatted and displayed based on year, quarter, month, and more. Likewise, the number type can be grouped range-wise, such as 1-5, 6-10, etc. These group fields will act as individual fields and allows users to drag them between different axes such as columns, rows, values, and filters and create pivot table at runtime.

The grouping can be enabled by setting the [`allowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowGrouping) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**. To perform the grouping action via UI, right click on the pivot table's row or column header, select "**Group**", a dialog will appear in which fill the appropriate options to group the data. To ungroup,right click on the pivot table's row or column header, select "**Ungroup**".

The following are the three different types of grouping:

* Number Grouping
* Date Grouping
* Custom Grouping

> Similar to Excel, only one type of grouping can be applied for a field.

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

Number grouping allows users to organize data, which is in number format into different ranges, such as 1-5, 6-10, etc. Number grouping can be configured via UI, by right-clicking on the number based header in the pivot table.

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

The "**Starting at**" and "**Ending at**" options are used to set the number range depending on which the headers will be grouped. For example, if the "Product_ID" field holds the number from "1001" to "1010" and the user chooses to group the number range by setting "**1004**" to "**Starting at**" and "**1008**" to "**Ending at**" options on their own. Then the specified number range will be used for number grouping and the rest will be grouped as "**Out of Range**".

![Range options applied for number grouping](../pivot-table/images/number-group-settings-range-applied.png)

### Range interval

The "**Interval by**" option is used to separate the selected number data type field into range-wise such as 1-5, 6-10, etc.

For example, if the user wants to display the "Product_ID" data field with a group interval of "**2**" by setting the "**Interval by**" option on their own. The "Product_ID" field will then be grouped by the specified range of intervals, such as "**1004-1005**", "**1006-1007**",etc.

![Grouping settings options applied for number grouping](../pivot-table/images/number-group-settings-applied.png)
<br/>
![Applied grouping settings updated in pivot table for number grouping](../pivot-table/images/number-group-updated.png)

Number grouping can also be configured using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) tag through code-behind. The properties required are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Allows user to set the field name.
* [`rangeInterval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_RangeInterval): Allows user to set the interval between two numbers.
* [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt): Allows user to set the starting number.
* [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt): Allows user to set the ending number.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Allows user to set the group type. For number grouping, [**Number**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GroupType.html) is set.

> If starting and ending numbers specified in [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt) and [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt) properties are in-between the number range, then rest of the numbers will be grouped and placed in “Out of Range” section introduced specific to this feature.

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

By right-clicking the appropriate header and selecting "**Ungroup**" from the context menu in the pivot table component, users can ungroup the applied number grouping.

![output](../pivot-table/images/number-ungroup.png)

## Date Grouping

Date grouping allows users to organize data, which is in date format into different sections such as years, quarters, months, days, hours, minutes, and seconds. Date grouping can be configured via UI, by right-clicking on the date and time based header in the pivot table.

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

The "**Starting at**" and "**Ending at**" options are used to set the date range depending on which the headers will be grouped. For example, if the "Date" field holds the date from "01/01/2015" to "02/12/2018" and the user chooses to group the date range by setting "**01/07/2015**" to "**Starting at**" and "**31/07/2017**" to "**Ending at**" options on their own. Then the specified date range will be used for date grouping and the rest will be considered as "**Out of Range**".

![Range options applied for date grouping](../pivot-table/images/date-group-settings-range-applied.png)

### Group interval

The "**Interval by**" option is used to separate the selected date fields into years, quarters, months, days, hours, minutes and seconds. For example, if the user wants to display the "Date" field with group intervals as "**Years**" and "**Months**" by selecting the "**Interval by**" option on their own. The "Date" field will then be separated by the specified group intervals and created as two new fields, namely "**Years (Date)**" which holds the date years and "**Months (Date)**" which holds the date months. Such fields can be used for report manipulations in the pivot table at runtime.

> When none of the **Interval by** options are chosen, the **OK** button in the dialog will be disabled, meaning that at least one interval option should be selected in order to apply the date grouping.

![Group interval option applied for date grouping](../pivot-table/images/date-group-settings-interval-applied.png)
<br/>
![Grouping settings options applied for date grouping](../pivot-table/images/date-group-settings-applied.png)
<br/>
![Applied grouping settings updated in pivot table for date grouping](../pivot-table/images/date-group-updated.png)

Date grouping can also be configured using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) tag through code-behind. The properties required are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Allows user to set the field name.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Allows user to set the group type. For date grouping, [**Date**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GroupType.html) is set.
* [`startingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_StartingAt): Allows user to set starting date.
* [`endingAt`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_EndingAt): Allows user to set ending date.
* [`groupInterval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_GroupInterval): Allows user to set interval in year, quarter, month, day, hour, minute, or second pattern.

> From the date format "YYYY-DD-MM HH:MM:SS", if user wants to display only year and month, then the [`groupInterval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_GroupInterval) property should be set with **Years** and **Months** alone. Also, user can shuffle the order of year, quarter, month, day, hour, minute, or second based on their requirement and display the same in the pivot table.

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

![Date fields grouped and displayed under the Date folder](./images/treeview.png "Group fields under a separate folder displayed in the field list UI")

### Ungrouping the existing date groups

By right-clicking the appropriate header and selecting "**Ungroup**" from the context menu in the pivot table component, users can ungroup the applied date grouping.

![output](../pivot-table/images/date-ungroup.png)

## Custom Grouping

Custom grouping can group any data type, such as date, time, number and string, into a custom field based on the user's needs. It can be configured via the UI by right-clicking on any header in the pivot table.

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



In order to create custom grouping in the pivot table, a minimum of two headers belonging to a specific field should be chosen. To select more than one header, press and hold the CTRL key or hold the SHIFT key and click the appropriate row or column headers. Once selection is done, right-click and select "**Group**".

![Context-menu options for custom grouping](../pivot-table/images/custom-group-option.png)

In the dialog, the "**Field caption**" is the alias name of the new custom field that will be used to shown up in the pivot table component.

![Caption applied for custom grouping](../pivot-table/images/custom-group-settings-caption-applied.png)

The "**Group Name**" option helps to set the name of the header to hold the other selected headers. For example, if the user wants to group headers such as "**Gloves**", "**Jerseys**" and "**Shorts**" in the "Products" field by setting the top level name as "**Clothings**" to "**Group Name**" on their own. The selected headers are then grouped under the name "**Clothings**" in the pivot table.

![Grouping settings applied for custom grouping](../pivot-table/images/custom-group-settings-applied.png)
<br/>
![Applied grouping settings updated in pivot table for custom grouping](../pivot-table/images/custom-group-updated.png)

User can also apply new custom grouping options to an existing custom field by right-clicking on the custom group header in the pivot table. For example, if the user wants to create a new custom group for the current custom group headers such as "**Bottles and Cages**", "**Cleaners**" and "**Fenders**" by setting the top level name as "**Accessories**" to "**Group Name**" on their own. The selected headers will then be grouped in the pivot table under the name "**Accessories**" with a new custom field called "**Product category 1**".

![Context-menu options for nested custom grouping](../pivot-table/images/nested-custom-group-option.png)
<br/>
![Grouping settings applied for nested custom grouping](../pivot-table/images/nested-custom-group-settings-applied.png)
<br/>
![Applied grouping settings updated in pivot table for custom grouping](../pivot-table/images/nested-custom-group-updated.png)

Custom grouping can also be configured using the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) tag through code-behind. The properties required are:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Name): Allows user to set the field name.
* [`caption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Caption): Allows user to set the caption name for custom grouping field.
* [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html#Syncfusion_EJ2_PivotView_PivotViewGroupSetting_Type): Allows user to set the group type. For custom grouping, [**Custom**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GroupType.html) is set.

* Custom groups can be added using [`e-customGroups`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html) tag in the [`e-groupsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupSetting.html) tag through code-behind. The properties required are:

* [`groupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_GroupName): Allows user to set the group name (or title) for selected headers.
* [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_Items): It allows to set the headers which needs to be grouped from display.

> When the [`groupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_GroupName) with the headers listed in [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_Items) in the [`e-customGroups`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html) tag is grouped by the defined [`groupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCustomGroup.html#Syncfusion_EJ2_PivotView_PivotViewCustomGroup_GroupName) and the rest is grouped by its own name in the pivot table.

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

### Ungrouping the existing custom groups

By right-clicking the appropriate header and selecting "**Ungroup**" from the context menu in the pivot table component, users can ungroup the applied custom grouping.

> When a specific field is removed from the report after ungrouping, its custom group fields will also be removed from the pivot table.

![output](../pivot-table/images/custom-ungroup.png)