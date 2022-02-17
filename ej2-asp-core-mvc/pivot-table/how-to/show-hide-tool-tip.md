---
layout: post
title: Show Hide Tool Tip in ##Platform_Name## Pivot Table Component
description: Learn here all about Show Hide Tool Tip in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Show Hide Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show/hide tooltip

You can set the visibility of tooltip using `showTooltip` in the pivot table.

> By Default, tooltip enabled in the pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ToolTip.cs" %}
{% include code-snippet/pivot-table/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolTip.cs" %}
{% include code-snippet/pivot-table/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


