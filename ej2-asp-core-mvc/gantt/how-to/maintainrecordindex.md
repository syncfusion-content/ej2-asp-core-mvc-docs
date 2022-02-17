---
layout: post
title: Maintainrecordindex in ##Platform_Name## Gantt Component
description: Learn here all about Maintainrecordindex in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Maintainrecordindex
publishingplatform: ##Platform_Name##
documentation: ug
---


# Updating row drag and dropped index position on server side

Row dropped record's index position can be maintained in the Gantt chart by changing the database table index position using the `rowDrop` event. In this event, the `fromIndex` and `dropIndex` values can be passed to the server side using Ajax request. On the server side, the `insert` and `insertAtTop` methods are used to update the row index position. The following code snippets explain the solution.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainrecordindex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainrecordindex.cs" %}
{% include code-snippet/gantt/how-to/maintainrecordindex/maintainrecordindex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainrecordindex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainrecordindex.cs" %}
{% include code-snippet/gantt/how-to/maintainrecordindex/maintainrecordindex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

