---
layout: post
title: Drill Down in ##Platform_Name## Pivot Table Component
description: Learn here all about Drill Down in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Drill Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# Drill Down

## Drill down and drill up

The drill down and drill up action helps to view the bound data in detailed and abstract view respectively. By default, if member(s) has children, then expand and collapse icon will be displayed in the respective row/column header. On clicking the icon, expand or collapse action will be performed automatically through built-in source code. Meanwhile, leaf member(s) does not contain expand and collapse icon.

![output](images/drill.png)

## Drill position

Allows to drill only the current position of the selected member and exclude the drilled data of selected member in other positions. For example, if "FY 2015" and "FY 2016" have "Quarter 1" member as child in next level, and when end user attempts to drill "Quarter 1" under "FY 2016", only it will be expanded and not "Quarter 1" under "FY 2015".

> This feature is built-in and occurs every time when expand or collapse action is done for better performance.

![output](images/drill_position.png)

## Expand all

Allows to either expand or collapse all headers that are displayed in row and column axes. To display all headers in expanded state, set the property [`ExpandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) to **true** and to collapse all
headers, set the property [`ExpandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) to **false**. By default, [`ExpandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) property is set to **false**.

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

## Expand all except specific member(s)

In addition to the previous topic, there is an enhancement to expand all headers expect specific header(s) and similarly to collapse all headers except specific header(s). To achieve this, [`PivotViewDrilledMember`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) class is used. The required properties of the [`PivotViewDrilledMember`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) class are explained below:

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name): It allows to set the field name whose member(s) needs to be specifically drilled.
* [`Items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): It allows to set the exact member(s) which needs to be drilled.

> The [`PivotViewDrilledMember`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) option always works in vice-versa with respect to the property [`ExpandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) in pivot table. For example, if [`ExpandAll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExpandAll) is set to **true**, then the member(s) added in [`Items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items) collection alone will be in collapsed state.

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

End user can also manually expand or collapse specific member(s) in each fields under row and column axes using the [`PivotViewDrilledMember`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) class from code behind. The required properties of the [`PivotViewDrilledMember`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html) class are explained below:

* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Name): It allows to set the field name whose member(s) needs to be specifically drilled.
* [`Items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Items): It allows to set the exact member(s) which needs to be drilled.
* [`Delimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDrilledMember.html#Syncfusion_EJ2_PivotView_PivotViewDrilledMember_Delimiter): It allows to separate next level of member from its parent member.

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