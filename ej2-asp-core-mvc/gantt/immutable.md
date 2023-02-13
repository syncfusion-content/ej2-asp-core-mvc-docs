---
layout: post
title: Immutable in ##Platform_Name## Gantt Component
description: Learn here all about Immutable in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Immutable 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Immutable in ##Platform_Name## Gantt component

The immutable mode optimizes the Gantt re-rendering performance by using the object reference and [deep compare](https://dmitripavlutin.com/how-to-compare-objects-in-javascript/#4-deep-equality) concept. When performing the Gantt actions, it will only re-render the modified or newly added rows and prevent the re-rendering of the unchanged rows.

To enable this feature, you have to set the [`enableImmutableMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableImmutableMode) property as **true**.

> This feature uses the primary key value for data comparison. So, you need to provide the `isPrimaryKey` column.

The following code example shows how to display the immutable mode in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/immutable/immutable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="immutable.cs" %}
{% include code-snippet/gantt/immutable/immutable/immutable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/immutable/immutable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="immutable.cs" %}
{% include code-snippet/gantt/immutable/immutable/immutable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Limitations

The following features are not supported in the immutable mode:

* Column reorder
* Virtualization
