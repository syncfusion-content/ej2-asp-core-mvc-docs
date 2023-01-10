---
layout: post
title: Drill Down in ##Platform_Name## Pivot Table Control | Syncfusion
description: Learn here all about Drill Down in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drill Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drill Down in ##Platform_Name## Syncfusion Pivot Table Control

## Drill down and drill up

The drill down and drill up action helps to view the bound data in detailed and abstract view respectively. By default, if member(s) has children, then expand and collapse icon will be displayed in the respective row/column header. On clicking the icon, expand or collapse action will be performed automatically through built-in source code. Meanwhile, leaf member(s) does not contain expand and collapse icon.

![output](images/drill.png)

## Drill position

Allows to drill only the current position of the selected member and exclude the drilled data of selected member in other positions. For example, if "FY 2015" and "FY 2016" have "Q1" member as child in next level, and when end user attempts to drill "Q1" under "FY 2016", only it will be expanded and not "Q1" under "FY 2015".

N> This feature is built-in and occurs every time when expand or collapse action is done for better performance.

![output](images/drill_position.png)

## Expand all

N> This property is applicable only for the relational data source.

Allows to either expand or collapse all headers that are displayed in row and column axes. To display all headers in expanded state, set the property [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) to **true** and to collapse all headers, set the property [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) to **false**. By default, [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) property is set to **false**.

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



![output](images/expandall.png)

## Expand all headers for specific fields

N> This property is applicable only for the relational data source.
Allows to expand or collapse all headers for specific fields (only) in row and column axes. To expand headers for a specific field in row or column axis, set the property [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping_expandAll) in [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) to **true**. By default, [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_FieldMapping_expandAll) property in [`rows`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) is set to **false**.

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



![output](images/expandall.png)

## Expand all except specific member(s)

N> This option is applicable only for the relational data source.

In addition to the previous topic, there is an enhancement to expand all headers expect specific header(s) and similarly to collapse all headers except specific header(s). To achieve this, [`e-drilledmember`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) tag is used. The required properties of the [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) tag are explained below:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name): It allows to set the field name whose member(s) needs to be specifically drilled.
* [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): It allows to set the exact member(s) which needs to be drilled.

N> The [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) option always works in vice-versa with respect to the property [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) in pivot table. For example, if [`expandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) is set to **true**, then the member(s) added in [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items) collection alone will be in collapsed state.

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



![output](images/expandall_except.png)

## Expand specific member(s)

End user can also manually expand or collapse specific member(s) in each fields under row and column axes using the [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) tag from code behind. The required properties of the [`e-drilledmembers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) tag are explained below:

* [`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name): It allows to set the field name whose member(s) needs to be specifically drilled.
* [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): It allows to set the exact member(s) which needs to be drilled.
* [`delimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Delimiter): It allows to separate next level of member from its parent member.

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



![output](images/drill_position_code.png)

## Event

### Drill

The event `drill` triggers every time when a field is expanded or collapsed. For instance using this event user can alter delimiter and drill action for the respective item. It has the following parameters:

* `drillInfo` - It holds the current drilled item information.
* `pivotview` - It holds pivot table instance.

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

The event [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) triggers when the UI actions such as drill down and drill up begin. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action began. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Expand`](./drill-down/#Drill-down-and-drill-up)| Drill down|
| [`Collapse`](./drill-down/#Drill-down-and-drill-up)| Drill up|

* `cancel`: It allows user to restrict the current action.

In the below sample, drill down and drill up action can be restricted by setting the **args.cancel** option to **true** in the `actionBegin` event.

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
| [`Expand`](./drill-down/#Drill-down-and-drill-up)| Drill down|
| [`Collapse`](./drill-down/#Drill-down-and-drill-up)| Drill up|

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

The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) triggers when the current UI action fails to achieve the desired result. It has the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Expand`](./drill-down/#Drill-down-and-drill-up)| Drill down|
| [`Collapse`](./drill-down/#Drill-down-and-drill-up)| Drill up|

* `errorInfo`: It holds the error information of the current UI action.

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

