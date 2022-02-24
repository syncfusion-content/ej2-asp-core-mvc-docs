---
layout: post
title: SummaryView in ##Platform_Name## QueryBuilder Component
description: Learn here all about Summary View in Syncfusion ##Platform_Name## QueryBuilder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Summary View
publishingplatform: ##Platform_Name##
documentation: ug
---

# Summary View

Summary view allows you to show or hide the filtered query. By default, the value is false. You can enable by setting the `summaryView` property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
