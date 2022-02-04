---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

startsWith |Checks whether a value begins with the specified value.
endsWith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notEqual |Checks for the values that are not equal to the specified value.

> By default, the [`SearchSettings.Operator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSearchSettings~Operator.html) value is `contains`.

### Search by external button

To search the Gantt records from an external button, invoke the `search` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/externalSearch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExternalSearch.cs" %}
{% include code-snippet/gantt/searching/externalSearch/externalSearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/externalSearch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExternalSearch.cs" %}
{% include code-snippet/gantt/searching/externalSearch/externalSearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Search specific columns

By default, the Gantt control searches all the columns. You can search specific columns by defining the specific column's field names in the [`SearchSettings.Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSearchSettings~Fields.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/specificColumnSearch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SpecificColumnSearch.cs" %}
{% include code-snippet/gantt/searching/specificColumnSearch/specificColumnSearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/specificColumnSearch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpecificColumnSearch.cs" %}
{% include code-snippet/gantt/searching/specificColumnSearch/specificColumnSearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> In above sample, you can search only `TaskName` and `Duration` column values.

### Clear search by external button

You can set [`searchSettings.key`](../api/gantt/searchSettings/#key) property as `empty` string, to clear the searched Gantt records from external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/clearSearch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClearSearch.cs" %}
{% include code-snippet/gantt/searching/clearSearch/clearSearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/searching/clearSearch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClearSearch.cs" %}
{% include code-snippet/gantt/searching/clearSearch/clearSearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

