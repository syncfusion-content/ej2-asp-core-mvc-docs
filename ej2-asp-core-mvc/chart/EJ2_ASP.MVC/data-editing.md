---
layout: post
title: Data Editing in ##Platform_Name## Chart Component
description: Learn here all about Data Editing in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Editing

## Enable Data Editing

Data editing allows users to modify chart data points interactively by dragging and dropping the rendered points.

Once enabled, the position or value of a data point can be changed dynamically based on its `y` value. To activate data editing, set the `Enable` property to **true** in the drag settings of the corresponding series.

In addition, the following properties can be used to customize the data editing behavior and appearance:

- Use the `Fill` property to set the color of the editable data points.
- Use the `MinY` and `MaxY` properties to define the minimum and maximum allowable range for editing the data points.

These options help control both the visual feedback and the valid value range while editing data directly on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/data-editing/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/data-editing/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/data-editing/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/data-editing/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

