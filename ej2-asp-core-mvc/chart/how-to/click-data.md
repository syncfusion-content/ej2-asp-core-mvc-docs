---
layout: post
title: Click Data in ##Platform_Name## Chart Component
description: Learn here all about Click Data in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Click Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Get the data of clicked area in accumulation chart

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the chart data of clicked area.

To show the clicked area data from pie, follow the given steps:

**Step 1**:

By using the [`pointClick`](../../api/accumulation-chart#pointclick) event, you can get the `args.point.x` and `args.point.y` values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/click-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Click-data.cs" %}
{% include code-snippet/chart/series/column/click-data/click-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/click-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Click-data.cs" %}
{% include code-snippet/chart/series/column/click-data/click-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

