---
layout: post
title: Add Params For Filtering in ##Platform_Name## Grid Component
description: Learn here all about Add Params For Filtering in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/add-params-for-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/how-to/add-params-for-filtering/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/add-params-for-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/how-to/add-params-for-filtering/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

