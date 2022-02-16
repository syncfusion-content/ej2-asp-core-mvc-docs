---
layout: post
title: Data Editing in ##Platform_Name## Chart Component
description: Learn here all about Data Editing in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Data Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Editing

## Enable Data Editing

It provides drag and drop support to the rendered points. Now, we can change the location or value of the point based on its `y` value.  To enable the data editing, set the `Enable` property to true in the drag settings of the series. Also, we can set color using `Fill` property and set the data editing minimum and maximum range using `MinY` and `MaxY` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/data-editing/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/data-editing/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/data-editing/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/data-editing/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

