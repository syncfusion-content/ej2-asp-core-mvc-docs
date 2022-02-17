---
layout: post
title: Drill Down in ##Platform_Name## Maps Component
description: Learn here all about Drill Down in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Drill Down
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drill-down

By clicking a continent, all the countries available in that continent can be viewed using the drill-down feature. For example, the countries in the `Africa` continent have been showcased here. To showcase all the countries in `Africa` continent by clicking the `ShapeSelected` event as mentioned in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/drilldown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drilldown.cs" %}
{% include code-snippet/maps/drilldown/drilldown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/drilldown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drilldown.cs" %}
{% include code-snippet/maps/drilldown/drilldown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Drill-down](../images/How-to/drilldown.PNG)