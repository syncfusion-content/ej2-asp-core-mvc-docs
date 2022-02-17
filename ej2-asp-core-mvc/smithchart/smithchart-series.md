---
layout: post
title: Smithchart Series in ##Platform_Name## Smithchart Component
description: Learn here all about Smithchart Series in Syncfusion ##Platform_Name## Smithchart component and more.
platform: ej2-asp-core-mvc
control: Smithchart Series
publishingplatform: ##Platform_Name##
documentation: ug
---


# Series

You can add any number of series to the smithchart as per your requirement. You can use series setting to either add or customize the data. For the points or datasource added in the series, line is drawn. You can customize the each series as per your requirement with marker, datalabel, animation, opacity and so on.

## points or datasource

For adding values in the smithchart, you can use either points or datasource in the series. Points and datasource both should be array of object which should contain the field names resistance and rectangle.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/series/series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/smithchart/series/series/series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/series/series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series.cs" %}
{% include code-snippet/smithchart/series/series/series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

Using following options in series settings, you can customize each series in smithchart as per your requirement.

* [`fill`] - Used to customize the fill color for the series.
* [`enableSmartLabels`] - Used to place the data labels on the smithchart without overlapping with each other.
* [`visibility`] - Used to handle the visibility of the series.
* [`opacity`] - Used to control the opacity of the series line.
* [`width`] - Used to customize the width of the series line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/series/custom-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-series.cs" %}
{% include code-snippet/smithchart/series/custom-series/custom-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/series/custom-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-series.cs" %}
{% include code-snippet/smithchart/series/custom-series/custom-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

