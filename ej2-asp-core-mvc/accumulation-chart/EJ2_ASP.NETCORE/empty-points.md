---
layout: post
title: Empty Points in ##Platform_Name## Accumulation Chart Component | Syncfusion
description: Learn here all about Empty Points in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Empty Points
publishingplatform: ##Platform_Name##
documentation: ug
---


# Empty Points in ##Platform_Name## Accumulation Chart Component

The data points those uses the `null` or `undefined` as value are considered as empty points. The empty data points are ignored and not plotted in the chart. You can customize those points, using the `emptyPointSettings` property in series. The default mode of the empty point is `Gap`. Other supported modes are `Average` and `Zero`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/empty-points/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class EmptyPointsChartData
{
    public string xValue;
    public Nullable<double> yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/empty-points/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/accumulation-charts/empty-points/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Specific color for an empty point can be set by using the `fill` property in `emptyPointSettings` and the border for an empty point can be set by using the `border` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/empty-points/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class EmptyPointsChartData
{
    public string xValue;
    public Nullable<double> yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/empty-points/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/empty-points/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Handling when no data is available

{% if page.publishingplatform == "aspnet-core" %}

When no data is available to render in the chart, the `noDataTemplate` property can be used to display a custom layout within the chart area. This layout may include a message indicating the absence of data, a relevant image, or a button to initiate data loading. Styled text, images, or interactive elements can be incorporated to maintain design consistency and improve user guidance. Once data becomes available, the chart automatically updates to display the appropriate visualization.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/no-data-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/no-data-template/no-data-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When no data is available to render in the chart, the `NoDataTemplate` property can be used to display a custom layout within the chart area. This layout may include a message indicating the absence of data, a relevant image, or a button to initiate data loading. Styled text, images, or interactive elements can be incorporated to maintain design consistency and improve user guidance. Once data becomes available, the chart automatically updates to display the appropriate visualization.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/no-data-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="No-data-template.cs" %}
{% include code-snippet/chart/accumulation-charts/dynamic-update/no-data-template/No-data-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
