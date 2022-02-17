---
layout: post
title: Working With Data in ##Platform_Name## Smithchart Component
description: Learn here all about Working With Data in Syncfusion ##Platform_Name## Smithchart component and more.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Data

Smithchart can visualise the data bound from local data. The data you bind for the smithchart, should be an array of object and that should contain the field resistance and rectangle. This should be bind to points or datasource in the smithchart.

## Data Binding

You can bind simple JSON data to smithchart using point property in series. JSON data should contain [`resistance`] and [`reactance`] fields. This JSON data should be bind to points or datasource in the smithchart. You can any number of JSON for points or datasource as per your requirement.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/data/working-with-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Working-with-data.cs" %}
{% include code-snippet/smithchart/data/working-with-data/working-with-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/data/working-with-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Working-with-data.cs" %}
{% include code-snippet/smithchart/data/working-with-data/working-with-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

