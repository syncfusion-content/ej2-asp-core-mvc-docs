---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Add Params For Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Add Params For Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing Filter Dialog by using an additional Parameter

You can customize the default settings of the components which are used in Menu filter by using params of filter property in column definition.
In the below sample, OrderID and Freight Columns are numeric columns, while open the filter dialog then you can see that NumericTextBox with spin button is displayed to change/set the filter value. Now using the params option we hide the spin button in NumericTextBox for OrderID Column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="excelfilter" %}
{% include_relative code-snippet/how-to/add-params-for-filtering/excelfilter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/add-params-for-filtering/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="excelfilter" %}
{% include_relative code-snippet/how-to/add-params-for-filtering/excelfilter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/add-params-for-filtering/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

