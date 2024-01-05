---
layout: post
title: Responsive Columns in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Responsive Columns in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Responsive Columns in gantt control

You can toggle the column visibility based on media queries, which are defined in the [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia). The [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_HideAtMedia) accepts valid [Media Queries](http://cssmediaqueries.com/what-are-css-media-queries.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/hideAtMedia/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HideAtMedia.cs" %}
{% include code-snippet/gantt/columns/hideAtMedia/hideAtMedia.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
