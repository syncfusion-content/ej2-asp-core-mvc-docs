---
layout: post
title: Scroll To Date in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Scroll To Date in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scroll To Date
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scroll To Date method

In the Gantt control, When We use the [`scrollToDate`](https://ej2.syncfusion.com/documentation/api/gantt/#scrolltodate) method, it will scroll the timeline horizontally to the date that we specified in the method's argument.

The following code examples show how the scroll To Date method works in Gantt:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/scrollToDate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="scrollToDate.cs" %}
{% include code-snippet/gantt/how-to/scrollToDate/scrollToDate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/scrollToDate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="scrollToDate.cs" %}
{% include code-snippet/gantt/how-to/scrollToDate/scrollToDate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](../images/setScrollTop.png)