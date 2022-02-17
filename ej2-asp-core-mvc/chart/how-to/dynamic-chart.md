---
layout: post
title: Dynamic Chart in ##Platform_Name## Chart Component
description: Learn here all about Dynamic Chart in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Dynamic Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# To add chart dynamically

By using html button, you can add the chart dynamically when click the button.

To add the chart dynamically through button click, follow the given steps:

**Step 1**:

Initially create the html button.

Then create chart inside of button `onClick` function. Now click the button charts will render based on click count.

The following code sample demonstrates the output.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/dynamic-chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-chart.cs" %}
{% include code-snippet/chart/series/column/dynamic-chart/dynamic-chart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column/dynamic-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic-chart.cs" %}
{% include code-snippet/chart/series/column/dynamic-chart/dynamic-chart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

