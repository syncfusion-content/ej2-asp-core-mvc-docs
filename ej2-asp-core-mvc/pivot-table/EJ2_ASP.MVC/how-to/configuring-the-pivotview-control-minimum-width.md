---
layout: post
title: Configuring the minimum width in the Syncfusion ##Platform_Name## Pivot Table control
description: Learn all about configuring the minimum width in the Syncfusion ##Platform_Name## Pivot Table control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Configuring the minimum width in the Pivot Table control.
documentation: ug
publishingplatform: ##Platform_Name## 
---
# Configuring the minimum width in the ##Platform_Name## pivot table control

The pivot table control allows you to configure its minimum width using the `minWidth` property. This property is useful for ensuring the component maintains a consistent layout and responsiveness across different screen sizes.

> When the pivot table has the [Grouping Bar](https://ej2.syncfusion.com/aspnetmvc/documentation/pivot-table/grouping-bar) enabled, the `minWidth` property is set to **400** pixels by default to accommodate the grouping bar UI elements. Without the [Grouping Bar](https://ej2.syncfusion.com/aspnetmvc/documentation/pivot-table/grouping-bar), the `minWidth` property defaults to **310** pixels.

To customize the minimum width, set the `minWidth` property to your desired value (in pixels) as shown below:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/min-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinWidth.cs" %}
{% include code-snippet/pivot-table/min-width/MinWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/min-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinWidth.cs" %}
{% include code-snippet/pivot-table/min-width/MinWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Configuring the minimum width in the Pivot Table control](../images/min-width.png)