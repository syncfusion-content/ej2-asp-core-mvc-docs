---
layout: post
title: Tooltip Template in ##Platform_Name## Heatmap Chart Component
description: Learn here all about Tooltip Template in Syncfusion ##Platform_Name## Heatmap Chart component and more.
platform: ej2-asp-core-mvc
control: Tooltip Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing tooltip as a table

You can show a tooltip as a table using the `template` property in `TooltipSettings`.

The following steps describe how to show the table tooltip.

**Step 1**:

Initialize the tooltip template div as shown in the following html page.

**Step 2**:

Set the element id to the `template` property in `TooltipSettings` to show the tooltip template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/tooltip-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/how-to/tooltip-template/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/how-to/tooltip-template/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


