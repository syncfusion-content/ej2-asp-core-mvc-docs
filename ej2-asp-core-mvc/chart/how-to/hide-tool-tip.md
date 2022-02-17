---
layout: post
title: Hide Tool Tip in ##Platform_Name## Chart Component
description: Learn here all about Hide Tool Tip in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Hide Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Hide the tooltip for unselected series

By using the [`tooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TooltipRender) event,
you can cancel the tooltip for unselected series in the chart.

To hide the tooltip value in unselected series, follow the given steps:

**Step 1**:

By using the [`tooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TooltipRender) event,
you can get the series elements in the arguments. By using this argument we can compare whether seriesElementclasslist is deselected container or not.
If it is true then we cancel the tooltip by setting the value for `args.cancel` as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/hide-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-tooltip.cs" %}
{% include code-snippet/chart/series/column/hide-tooltip/hide-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/hide-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-tooltip.cs" %}
{% include code-snippet/chart/series/column/hide-tooltip/hide-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

