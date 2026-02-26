---
layout: post
title: Display string value to pivot table values in ##Platform_Name## Pivot Table Component
description: Learn here all about Display string value to pivot table values in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Display string value to pivot table values
documentation: ug
publishingplatform: ##Platform_Name## 
---
# Display string value to pivot table values

End user can display string value to the pivot table's value cell by using the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event.

In the following example, each cell value of the **Sold** field's actual value has been assigned from its combination data sets obtained from the `args.cellSets` in the [`aggregateCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateCellInfo) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/display-string-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayStringValue.cs" %}
{% include code-snippet/pivot-table/display-string-value/DisplayStringValue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/display-string-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayStringValue.cs" %}
{% include code-snippet/pivot-table/display-string-value/DisplayStringValue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Display string value to pivot table values](../images/display-string-value.png)
