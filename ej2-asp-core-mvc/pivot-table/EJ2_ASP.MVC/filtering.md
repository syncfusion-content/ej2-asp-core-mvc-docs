---
layout: post
title: Filtering in ##Platform_Name## SyncfusionPivot Table Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering in ##Platform_Name## Pivot Table component

Filtering helps you focus on specific data by showing only the records you need in the Pivot Table. This allows you to analyze relevant information more effectively by including or excluding specific members through the user interface or programmatically.

The Pivot Table offers three types of filtering options:

* Member filtering
* Label filtering
* Value filtering

> When all filtering options are disabled programmatically, the filter icon will not appear in the field list or grouping bar interface.

## Member filtering

This filtering option displays the Pivot Table with selective records based on the members you choose to include or exclude in each field. By default, member filtering is enabled through the [`AllowMemberFilter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AllowMemberFilter) property in the `dataSourceSettings`. 

Users can apply member filters at runtime by clicking the filter icon next to any field in the row, column, and filter axes, available in both the field list and grouping bar interfaces.

![Member filter icon in field list](images/fieldlist_filtericon.png)
<br/>

![Member filter icon in grouping bar](images/filter_icon_gb.png)
<br/>

![Member filter dialog with checked and unchecked members](images/filter_dialog_gb.png)
<br/>

![Resultant pivot table on member filter](images/filter_grid_gb.png)

You can also configure filtering programmatically using the [`PivotViewFilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) property during the initial rendering of the component. The essential settings required to add filter criteria are:

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Name): Sets the appropriate field name for filtering.
* [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Type): Specifies the filter type as [**FilterType.Include**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html) or [**FilterType.Exclude**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html) to include or exclude field members respectively.
* [`Items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Items): Defines the members that need to be either included or excluded from the display.
* [`LevelCount`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_LevelCount): Sets the level count of the field to fetch data from the cube. **Note: This property is applicable only for OLAP data sources.**

> When you specify unavailable or inappropriate members in the include or exclude filter items collection, they will be ignored.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Member filtering applied in pivot table](images/member-filtering.png)

### Option to select and unselect all members

This option lets you quickly manage all members at once, saving time when working with large datasets. The member filter dialog includes an **All** option that provides a convenient way to select or deselect all available members with a single click.

When you check the **All** option, it selects all members in the list. When you uncheck it, all members become deselected. If you manually select some members while others remain unselected, the **All** option displays an intermediate state (partially checked) to show that the list contains both selected and unselected members.

![Intermediate state of All option](images/editor_inter.png)

> **Note:** When all members are deselected, the **OK** button becomes disabled. You must select at least one member to apply the filter and display data in the Pivot Table.

![All members unchecked state](images/editor_alluncheck.png)

### Provision to search specific member(s)

This option helps you quickly locate specific members without scrolling through long lists. The member filter dialog includes a built-in search box that allows you to find members by typing part of their name.

Simply enter the starting characters of the member name you want to find, and the list will automatically filter to show only matching members. This makes it easy to locate and select specific members, especially when dealing with large datasets.

![Search functionality in member filter](images/search.png)

### Option to sort members

This option allows you to organize members in a logical order for easier selection and review. The member filter dialog provides built-in sort icons that let you arrange members in ascending or descending order.

You can click the ascending sort icon to arrange members from A to Z (or lowest to highest for numerical values), or click the descending sort icon to arrange them from Z to A (or highest to lowest). When neither sorting option is selected, members appear in their original order as retrieved from the data source.

![Member sorting options](images/member-sort.png)

### Performance tips

The member filter dialog improves loading performance when working with large datasets by limiting the number of members displayed initially. This helps you work with extensive data without experiencing delays while the member list loads.

You can control how many members are displayed in the member filter dialog using the [`MaxNodeLimitInMemberEditor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MaxNodeLimitInMemberEditor) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class. By default, this property is set to **1000**. When your data contains more members than this limit, only the specified number will be shown initially, and a message will indicate how many additional members are available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/max-node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/max-node/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/max-node/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/max-node/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Member filter dialog with max node limit applied](images/maxnodelimit.png)

When the member count exceeds your set limit, you can use the search option to find specific members beyond the displayed range. For example, if your data contains 5000 members named "Node 1", "Node 2", "Node 3", and so on, and you set the [`MaxNodeLimitInMemberEditor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MaxNodeLimitInMemberEditor) property to **500**, only the first 500 members will appear by default. The dialog will show a message like "4500 more items. Search to refine further." To access members 501 to 5000, type the starting characters in the search box to locate the desired members. Once the members appear in the list, you can select or deselect them to apply your filtering preferences.

### Loading members on-demand

> This option is applicable only for OLAP data sources.

This option improves the performance of the member editor by loading members only when needed, rather than loading all members at once. You can enable this by setting the [`LoadOnDemandInMemberEditor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_LoadOnDemandInMemberEditor) property to **true**. When enabled, only the first level members are loaded initially from the OLAP cube, allowing the member editor to open quickly without performance delays.

By default, this property is set to **true** and search operations will only apply to the currently loaded level members. You can load additional level members using either of the following methods:

* **Expand individual members**: Click the expander button next to any member to load only its child members.
* **Load by level selection**: Choose a specific level from the dropdown list to load all members up to that selected level from the cube.

This approach prevents performance issues when working with hierarchies that contain large numbers of members. Once level members are loaded, they remain available for all subsequent operations (such as reopening the dialog or drag-and-drop actions) and persist until you refresh the web page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-member-load/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-member-load/filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-member-load/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-member-load/filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Loading members on-demand](images/ondemand_member.png)

In the example above, the "Customer Geography" dimension loads with only the first level (Country) initially. Search operations will apply only to the "Country" level members. You can then load the next level members (State-Province) on-demand in two ways:

* **Expand specific countries**: When you expand "Australia", the "State-Province" members load only for Australia.
* **Load all states by level**: When you select "State-Province" from the dropdown list, all "State-Province" members load across all countries (Australia, Canada, France, etc.).

Once loaded, these members are stored internally and remain available until you refresh the page.

When the [`LoadOnDemandInMemberEditor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_LoadOnDemandInMemberEditor) property is set to **false**, all members from all levels are loaded during the initial setup. This approach executes a single query to retrieve all members at once. While this may cause slower performance when opening the member editor due to the large number of members being fetched, expand and search operations will be faster since all members are already available.

![Loading all members initially](images/initial_member.png)

### Loading members based on level number

> This property is applicable only for OLAP data sources.

This option enables you to control the depth of member loading by specifying how many levels should be loaded initially. By setting the 
Allows user to load the members on the basis of the level number set in the [`LevelCount`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_LevelCount) property in the [`PivotViewFilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html), you can improve performance and focus filtering operations on specific hierarchy levels.

The [`LevelCount`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_LevelCount) property is set to **1** by default, which means only the first level members are loaded initially. When you apply filters or search operations, they will only affect the members within the loaded levels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-level-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-level-count/filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-level-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-level-count/filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Loading members based on level number](images/level-count.png)

In the above example, the [`LevelCount`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_LevelCount) is set to **2** for the "Customer Geography" dimension in [`PivotViewFilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html). This loads both the "Country" and "State-Province" levels during the initial loading process. Any search or filter operations will be applied only to the members within these two levels. To access members from deeper levels like "City", you can either expand the respective "State-Province" node or select the "City" level from the dropdown list.

## Label filtering

Label filtering allows you to display only the data with specific header text across row and column fields, making it easier to focus on relevant information in your Pivot Table. This filtering works with three types of data:

* String data type
* Number data type
* Date data type

To enable label filtering, set the [`AllowLabelFilter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AllowLabelFilter) property to **true** in the `DataSourceSettings`. Once enabled, you can access the filtering options by clicking the filter icon next to any field in the row or column axis of the field list or grouping bar. This opens the filtering dialog where you can navigate to the "Label" tab to apply your label filtering criteria.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/filtering-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/filtering-ui/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/filtering-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/filtering-ui/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Filter icon in field list](images/labelfiltering_fl_icon.png)
<br/>

![Filter icon in grouping bar](images/labelfiltering_gb_icon.png)
<br/>

![Label filter tab in member editor dialog](images/labelfiltering_dialog.png)
<br/>

![Resultant pivot table on label filter](images/labelfiltering_grid.png)

> In label filtering UI, based on the field chosen, it’s member data type is automatically recognized and filtering operation will be carried out. Where as in code behind, user need to define the data type through a property and it has been explained in the immediate section below.

### Filtering string data type through code

String-based label filtering enables you to programmatically show only data that matches specific text values in your row and column fields, making it easier to focus on the exact information you need.

This filtering approach is specifically designed for fields containing string data type members. You can configure the filtering through the [`PivotViewFilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) property in your code. The following properties are required for label filtering:

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Name): Specifies the field name to apply the filter.
* [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Type): Sets the filter type as [**FilterType.Label**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html) for the specified field.
* [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition): Defines the operator type such as [**Operators.Equals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html), [**Operators.GreaterThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html), [**Operators.LessThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html), and others.
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1): Sets the primary value for comparison.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value2): Sets the secondary value for comparison. This property is only applicable for operators like [**Operators.Between**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html) and [**Operators.NotBetween**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html).
*[`SelectedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_SelectedField): Specifies the level name of a dimension where the filter should be applied. **NOTE: This property is applicable only for OLAP data sources.**

For example, to display only countries containing "United" in their name from a "Country" field, set the [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1) property to "United" and the [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition) property to [**Operators.Contains**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html).

The following table shows all available [**Operators**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html) for label filtering:

| Operator | Description |
|------|-------------|
| Equals| Shows records that exactly match the specified text.|
| DoesNotEquals| Shows records that do not match the specified text.|
| BeginWith| Shows records that start with the specified text.|
| DoesNotBeginWith| Shows records that do not start with the specified text.|
| EndsWith| Shows records that end with the specified text.|
| DoesNotEndsWith| Shows records that do not end with the specified text.|
| Contains| Shows records that contain the specified text anywhere.|
| DoesNotContains| Shows records that do not contain the specified text.|
| GreaterThan| Shows records where the text value is alphabetically greater.|
| GreaterThanOrEqualTo| Shows records where the text value is alphabetically greater than or equal.|
| LessThan| Shows records where the text value is alphabetically less.|
| LessThanOrEqualTo| Shows records where the text value is alphabetically less than or equal.|
| Between| Shows records with text values that fall between two specified values.|
| NotBetween| Shows records with text values that do not fall between two specified values.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/text-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/text-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/text-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/text-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Label filtering applied](images/labelfiltering_code.png)

### Filtering number data type through code

Filter numeric data programmatically to display only values that meet specific numeric conditions, helping you analyze data patterns and ranges more effectively. This filtering approach is specifically designed for fields containing numeric data types and follows the same configuration method as string data filtering, with one key difference: set the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Type) property to [**FilterType.Number**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html) enumeration instead of [**FilterType.Label**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html).

To filter numeric values, specify the filtering criteria using the following properties:
- [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1): The primary value for comparison
- [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition): The comparison operator
- [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value2) and [**Operators.NotBetween**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html) conditions

For example, to display only sales data where the "Sold" field values are less than 40000, set [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1) to "40000" and [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition) to [**Operators.LessThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html).

<!-- markdownlint-disable MD028 -->
> The following operators are supported for number data type: [**Operators.Equals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Equals), [**Operators.DoesNotEquals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_DoesNotEquals), [**Operators.GreaterThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_GreaterThan), [**Operators.GreaterThanOrEqualTo**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_GreaterThanOrEqualTo), [**Operators.LessThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_LessThan), [**Operators.LessThanOrEqualTo**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_LessThanOrEqualTo), [**Operators.Between**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Between), and [**Operators.NotBetween**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Between).

> Number filtering is available only when the field contains numeric data format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/number-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/number-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/number-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/number-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Number filtering applied](images/numberfiltering.png)

### Filtering date data type through code

This filtering option makes it simple to filter data based on date values in your fields, helping you quickly focus on records from specific time periods. This type of filtering is only available for fields that contain date data types and can be configured programmatically using the same approach as explained in the previous section "Filtering string data type through code", with one key difference: set the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Type) property to [**FilterType.Date**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html).

To apply date filtering, specify your filtering criteria using the [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1) and [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition) properties. For example, if you have a "Delivery Date" field and want to show delivery records from before a specific date like "2019-01-07", set the [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1) property to "2019-01-07" and the [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition) property to [**Operators.Before**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Before). This will display only the records with delivery dates before January 7, 2019 in your Pivot Table.

> You can use the following operators with date data type filtering: [**Operators.Equals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Equals), [**Operators.DoesNotEquals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_DoesNotEquals), [**Operators.Before**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Before), [**Operators.BeforeOrEqualTo**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_BeforeOrEqualTo), [**Operators.After**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_After), [**Operators.AfterOrEqualTo**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_AfterOrEqualTo), [**Operators.Between**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Between), and [**Operators.NotBetween**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_NotBetween).

> Date filtering is available only when the field has date type [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html) configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/date-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/date-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/label-filtering/date-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/label-filtering/date-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Date filtering applied](images/datefiltering.png)

### Clearing the existing label filter

Users can clear the applied label filter by clicking the **Clear** option at the bottom of the filter dialog. This option is located under the **Label** tab for string and number type filtering, and under the **Date** tab for date type filtering.

![Clear filter option in dialog](images/clearfilter.png)

## Value filtering

Value filtering allows you to filter data based on aggregated values from measure fields, helping you focus on specific data ranges that meet your criteria.

You can enable value filtering by setting the [`AllowValueFilter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_AllowValueFilter) property in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class to **true**. Once enabled, click the filter icon next to any field in the row or column axis within the field list or grouping bar. A filtering dialog will appear where you can navigate to the "Value" tab to perform value filtering operations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering-ui/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering-ui/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

 {% previewsample "page.domainurl/code-snippet/pivot-table/default-cs103" %}

![Filter icon in field list](images/labelfiltering_fl_icon.png)
<br/>

![Filter icon in grouping bar](images/labelfiltering_gb_icon.png)
<br/>

![Value filter tab in member editor dialog](images/valuefiltering_dialog.png)
<br/>

![Resultant pivot table on value filter](images/valuefiltering_grid.png)

You can also configure value filtering programmatically using the [`PivotViewFilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) property. The following properties are required for value filtering:

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Name): Specifies the field name to which the filter applies.
* [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Type): Sets the filter type as [**FilterType.Value**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.FilterType.html).
* [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Measure): Specifies the value field name used for filtering.
* [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition): Defines the comparison operator such as [**Operators.Equals**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Equals), [**Operators.GreaterThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_GreaterThan), [**Operators.LessThan**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_LessThan).
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1): Sets the comparison value or the start value for range operations.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value2): Sets the end value, applicable only for [**Operators.Between**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_Between) and [**Operators.NotBetween**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.Operators.html#Syncfusion_EJ2_PivotView_Operators_NotBetween) operators.
* [`SelectedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_SelectedField): Specifies the dimension level name where filter settings apply. **Note: This property is only applicable for OLAP data sources.**

For example, to display data where the total sum of units sold for each country exceeds 1500, set the [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Value1) to "1500" and [`Condition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html#Syncfusion_EJ2_PivotView_PivotViewFilterSetting_Condition) to **GreaterThan** for the "Country" field.

The following table shows the available operators for value filtering:

| Operator | Description |
|------|-------------|
| Equals| Shows records that match the specified value.|
| DoesNotEquals| Shows records that do not match the specified value.|
| GreaterThan| Shows records where the value is greater than the specified value.|
| GreaterThanOrEqualTo| Shows records where the value is greater than or equal to the specified value.|
| LessThan| Shows records where the value is less than the specified value.|
| LessThanOrEqualTo| Shows records where the value is less than or equal to the specified value.|
| Between| Shows records with values between the specified start and end values.|
| NotBetween| Shows records with values outside the specified start and end values.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/value-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/value-filtering/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Value filtering applied](images/valuefiltering_grid.png)

### Clearing the existing value filter

You can clear the applied value filter by clicking the "Clear" option at the bottom of the filter dialog under the "Value" tab.

![Clearing the existing value filter](images/clearvaluefilter.png)

## Event

### MemberFiltering

The [`MemberFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MemberFiltering) event gives you complete control over filter operations by triggering before any filter is applied through the filter dialog. This event activates specifically when you click the **"OK"** button in the filter dialog, allowing you to review, modify, or cancel the filtering process based on your requirements.

This event provides access to the current filter settings, enabling you to customize filter behavior programmatically. You can examine the filter items, modify filter types and conditions, or prevent the filter from being applied entirely.

The event includes the following parameters:

* `cancel` - A boolean property that stops the filter from being applied when set to **true**.
* `filterSettings` - Contains the current [`FilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) including filter items, types, and conditions.
* `dataSourceSettings` - Holds the updated `dataSourceSettings` after the filter is applied.

For example, you can use the [`MemberFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MemberFiltering) event to block the filter action by setting `args.cancel` parameter to **true**. This is shown below:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering-event/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/member-filtering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/member-filtering-event/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### MemberEditorOpen

When you open the Member Editor dialog, the [`MemberEditorOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MemberEditorOpen) event is triggered. With this event, you can decide which field members are shown, making it easier to include or exclude specific items. The event provides the following options:

- `fieldName`: The name of the field for which the Member Editor dialog opens.
- `fieldMembers`: The list of all members in the selected field.
- `cancel`: If you set this property to `true`, the Member Editor dialog will not open.
- [`FilterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) - Contains the current [`filterSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFilterSetting.html) including filter items, types, and conditions.

Here’s an example. In the Pivot Table below, only the selected member for the "Country" field appears in the Member Editor dialog:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/memberEditorOpen-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/memberEditorOpen-event/Filtering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/filtering/memberEditorOpen-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/pivot-table/filtering/memberEditorOpen-event/Filtering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionBegin

The [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event is triggered when a user clicks the filter icon on a field button in either the grouping bar or the field list, allowing users to monitor and control actions in the Pivot Table. The event argument includes the following properties:

- `dataSourceSettings`: Contains the current data source configuration, including input data, rows, columns, values, filters, format settings, and other report settings.
- `actionName`: Indicates the name of the action being initiated, such as **Filter field** for filtering.
- `fieldInfo`: Provides information about the selected field for the action.

> **Note**: The `fieldInfo` property is available only when the action involves a specific field, such as filtering, sorting, removing a field from the grouping bar, editing, or changing the aggregation type.

- `cancel`: A boolean property that allows you to prevent the current action from completing. Set this to **true** to stop the action.

In the example below, you can prevent a filter action by setting **args.cancel** to **true** in the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-filter/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-filter/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionComplete

The [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) event triggers when filtering actions are completed through the field button in both the grouping bar and field list UI. You can use this event to monitor current UI actions and implement custom logic based on the completed operations.

The event provides the following parameters:

- `dataSourceSettings`: Contains the current data source configuration, including input data source, rows, columns, values, filters, format settings, and other report settings.

- `actionName`: Specifies the name of the completed action. For filtering operations, the action name appears as **Field filtered**.

- `fieldInfo`: Contains information about the selected field that was involved in the action.

> **Note**: This parameter is available only when the action involves a specific field, such as filtering, sorting, removing a field from the grouping bar, editing, or changing the aggregation type.

- `actionInfo`: Provides detailed information about the current UI action. For filtering operations, this includes filter members, field name, and other relevant details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-filter/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-filter/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionFailure

The [`ActionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) event is triggered when a UI action fails to produce the expected result. This event provides detailed information about the failure through the following parameters:

* `actionName`: It holds the name of the current action failed. For example, if the action fails while filtering, the action name will be shown as **Filter field**.

* `errorInfo`: It holds the error information of the current UI action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-filter/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-filter/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}