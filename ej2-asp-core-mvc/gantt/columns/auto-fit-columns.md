---
layout: post
title: Autofit Columns in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Autofit Columns in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Autofit Column in gantt control

The [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method resizes the column to fit the widest cell's content without wrapping. To enable column resizing, set the  [`allowResizing`](../api/gantt/column/#allowResizing) property to true. You can autofit a specific column at initial rendering by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method in [`dataBound`](../api/gantt/column/#dataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/autofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="autofit.cs" %}
{% include code-snippet/gantt/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/columns/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="autofit.cs" %}
{% include code-snippet/gantt/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


> You can autofit all columns, by invoking [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method without column name.