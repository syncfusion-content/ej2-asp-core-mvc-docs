---
layout: post
title: Drill Down in ##Platform_Name## Pivot Table Control | Syncfusion
description: Learn here all about Drill Down in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drill Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drill down in ASP.NET Core Pivot Table component

## Drill down and drill up

The drill-down and drill-up features in the Pivot Table component allow users to expand or collapse hierarchical data for detailed or summarized views. When a field member(s) contains child items, expand and collapse icons automatically appear in the corresponding row or column header. Clicking these icons expands the selected item to display its child members or collapses it to show a summarized view. If a field member(s) does not have any further levels to display, the icons will not appear.

![Drill down and drill up](images/drill.png)

## Drill position

The drill-down and drill-up features allow you to expand or collapse data for a specific member in the Pivot Table without affecting the same member in other positions. For example, if both "FY 2015" and "FY 2016" have "Quarter 1" as a child in the next level, drilling down into "Quarter 1" under "FY 2015" will expand only that specific instance. The "Quarter 1" under "FY 2016" will remain unchanged.

> This feature is built-in and works automatically every time you expand or collapse data, making the pivot table faster and more efficient.

![Drill at specific position](images/drill_position.png)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Expand All

> This property is applicable only for the relational data source.

The Pivot Table component allows users to interactively expand or collapse all field members displayed in the row and column axes. To display all hierarchical members in an expanded state, set the [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) property of [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html) to **true**. To collapse all headers, set this property to **false**. By default, [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) is set to **false**, so only the top-level field members are shown until the user expands them manually.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![All headers expanded](images/expandall.png)

## Expand all headers for specific fields

> This property is applicable only for the relational data source.

The Pivot Table provides an option to expand or collapse all headers for specific fields in the [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or  [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) axis. To expand all headers for a particular field, set the [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping_expandAll) property to **true** in the [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or  [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) axis. By default, the [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping_expandAll) property is set to **false**, meaning the headers are collapsed.

The following code demonstrates how to configure a Pivot Table with the [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping_expandAll) property enabled for specific fields. In this example, all headers for the **Year** field in the columns and the **Country** field in the rows are expanded.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all-headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all-headers/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-all-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandAll.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-all-headers/ExpandAll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![All headers expanded](images/expandall.png)

## Expand all except specific member(s)

> This option is applicable only for the relational data source.

The Pivot Table component supports expanding or collapsing all headers except for specific field members. This functionality allows users to selectively control which members in the fields are expanded or collapsed, making it easier to focus analysis on relevant data in the Pivot Table. The [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) property is used to configure this behavior. Its key properties include:

- [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name) Specifies the field name whose members should remain expanded or collapsed.
- [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): Lists the exact field members to expand or collapse.

The following example demonstrates how to configure a Pivot Table where all headers are expanded except for the **France** member in the **Country** field, which remains collapsed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/drilled-members/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrilledMembers.cs" %}
{% include code-snippet/pivot-table/drill-down/drilled-members/DrilledMembers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/drilled-members/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrilledMembers.cs" %}
{% include code-snippet/pivot-table/drill-down/drilled-members/DrilledMembers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![All expanded except one member](images/expandall_except.png)

## Expand or Collapse Specific Members

The Pivot Table component enables users to programmatically expand or collapse specific members in any field placed under the row or column axes. This can be achieved using the [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) property. The following properties of [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) are described below:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name) Specifies the field name whose members should be expanded or collapsed.
* [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): Defines the exact members to be expanded or collapsed within the specified field.
* [`delimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Delimiter): Sets the character used to separate a child member from its parent when specifying hierarchical members.

The following code demonstrates how to configure the Pivot Table to expand specific members using the [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) property. In this example, only the **FY 2015** and **FY 2016** members in the **Year** field, and the **Q1** member under **FY 2015** in the **Quarter** field are expanded, while other members remain collapsed. The [`delimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Delimiter) property is used for the **Quarter** field to specify the separator (`~~`) for hierarchical member items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrilledMembers.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-specific/DrilledMembers.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/expand-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrilledMembers.cs" %}
{% include code-snippet/pivot-table/drill-down/expand-specific/DrilledMembers.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Specific members expanded](images/drill_position_code.png)

## Event

### Drill

The [`drill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Drill) event is triggered each time a field member in the Pivot Table is expanded or collapsed. This event allows customization of drill actions, such as modifying the delimiter or changing the behavior for specific items. The event provides the following parameters:

* `drillInfo`: Contains information about the currently drilled field member.
* `pivotview`: A reference to the Pivot Table component instance.
* `cancel`: Specifies whether to prevent the current drill operation. Set this property to true in the event handler to cancel the action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/drill-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrillEvent.cs" %}
{% include code-snippet/pivot-table/drill-down/drill-event/DrillEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-down/drill-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrillEvent.cs" %}
{% include code-snippet/pivot-table/drill-down/drill-event/DrillEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionBegin

The [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event triggers when a user starts a UI action, such as drilling down (expanding) or drilling up (collapsing) data in the pivot table. This event helps you track the action being performed and customize its behavior. It includes the following parameters:

- `dataSourceSettings`: Contains the current pivot table report settings, including the data source, rows, columns, values, filters, and format settings.
- `actionName`: Indicates the name of the action being performed. The table below lists the UI actions and their corresponding names:

| Action   | Action Name |
|----------|-------------|
| **Expand**   | Drill down  |
| **Collapse** | Drill up    |

- `cancel`: Allows you to block the current action by setting it to `true`.

In the below sample, drill down and drill up action can be restricted by setting the **args.cancel** option to **true** in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-drill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-drill/actionBegin-drill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-drill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-drill/actionBegin-drill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionComplete

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) triggers when a UI action such as drill down or drill up, is completed. This allows user to identify the current UI actions being completed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| **Expand** | Drill down|
| **Collapse** | Drill up|

* `actionInfo`: It holds the unique information about the current UI action. For example, if drill down action is completed, the event argument contains information such as field name and the drill information.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-drill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-drill/actionComplete-drill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-drill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-drill/actionComplete-drill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### ActionFailure

The 
The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) event is triggered when a UI action does not produce the expected result. It provides details about the failure through the following parameters:

* `actionName`: The name of the action that failed. The table below lists the UI actions and their corresponding names:

| Action | Action Name|
|------|-------------|
| **Expand** | Drill down|
| **Collapse** | Drill up|

* `errorInfo`: Contains details about the error that caused the action to fail.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-drill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-drill/actionFailure-drill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-drill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-drill.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-drill/actionFailure-drill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}