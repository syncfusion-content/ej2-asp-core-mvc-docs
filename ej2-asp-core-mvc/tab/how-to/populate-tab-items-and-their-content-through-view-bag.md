---
layout: post
title: Populate Tabs Through ViewBag in ##Platform_Name## | Syncfusion
description: Populate Syncfusion ##Platform_Name## Tabs items and content in the controller, return them as ViewBag, and map them to chart, grid, and calendar content.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to populate tabs through view bag in ##Platform_Name## Tabs

For the Tabs control, the Tab items can be rendered in the controller and can be returned as ViewBag to bind as items. You can also map the content to other contents using the mapping id in controller to return as ViewBag. Refer to the below sample, which takes [chart](../../chart), [grid](../../grid), [calender](../../calendar) as its content through viewBag content id mapped in view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/viewbag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Viewbag.cs" %}
{% include code-snippet/tab/viewbag/viewbag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/viewbag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Viewbag.cs" %}
{% include code-snippet/tab/viewbag/viewbag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![content template](../images/viewbag.PNG)
