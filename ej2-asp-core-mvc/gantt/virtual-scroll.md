---
layout: post
title: Virtual Scroll in ##Platform_Name## Gantt Component
description: Learn here all about Virtual Scroll in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Virtual Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtual Scrolling

Virtual Scroll support in Gantt allows you to load large amount of data without performance degradation. To enable Virtual Scrolling, you need to inject `VirtualScroll` module in Gantt.

## Row Virtualization

Row virtualization allows you to load and render a large number of tasks in Gantt with effective performance. In this mode, all tasks are fetched initially from the datasource and rendered in the DOM within a compact viewport area.

The number of records displayed in the Gantt is determined by the height.

This mode can be enable by setting the `EnableVirtualization` property to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/virtual-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Virtual-scroll.cs" %}
{% include code-snippet/gantt/virtual-scroll/virtual-scroll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/virtual-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Virtual-scroll.cs" %}
{% include code-snippet/gantt/virtual-scroll/virtual-scroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/virtual-scroll.png)

## Limitations for Virtual Scroll

* Due to the element height limitation in browsers, the maximum number of records loaded is limited by the browser capacity.
* Cell selection will not be persisted.
* The number of records rendered will be determined by the `Height` property.
* It is necessary to mention the height of the Gantt in pixels when enabling Virtual Scrolling.
* Currently, we do not have support for Row Drag and Drop when virtualization is enabled.
* Virtual Scroll does not support Multi Taskbar support in Resource View.