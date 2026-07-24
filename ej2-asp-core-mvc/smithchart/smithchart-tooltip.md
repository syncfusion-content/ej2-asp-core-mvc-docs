---
layout: post
title: Smithchart Tooltip in ##Platform_Name## Smithchart Control | Syncfusion
description: Learn here all about Smithchart Tooltip in Syncfusion ##Platform_Name## Smithchart control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Smithchart Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip in Smith Chart

The Smith Chart displays the details of each point via a tooltip when the mouse hovers over it. By default, the tooltip is disabled. To enable the tooltip, add the `<e-smithchartseries-tooltip>` child element to each series and set its `visible` attribute to `true`. You can customize the tooltip's visibility and appearance for each series individually.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/tooltip/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/smithchart/tooltip/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/tooltip/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/smithchart/tooltip/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}