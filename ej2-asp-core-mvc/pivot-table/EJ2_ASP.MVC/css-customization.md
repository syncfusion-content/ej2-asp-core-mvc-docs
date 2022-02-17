---
layout: post
title: Css Customization in ##Platform_Name## Pivot Table Component
description: Learn here all about Css Customization in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Css Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Style and Appearance

## Hiding Axis

The visibility of row, column, value and filter axis in Field List and Grouping Bar can be changed using custom CSS setting. To do so, please refer the code sample below:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-axis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-axis/axis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-axis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-axis/axis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text Alignment

The alignment of text inside row headers, column headers, value cells and summary cells can be changed using custom CSS setting. To do so, please refer the code sample below:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-align/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-align.cs" %}
{% include code-snippet/pivot-table/css-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-align.cs" %}
{% include code-snippet/pivot-table/css-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize header, value and summary cell style

The elements in pivot table like header cell, value cell and summary cell style can be customized using built-in CSS names. To do so, please refer the code sample below:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-pivot/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-pivot/axis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/css-pivot/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/pivot-table/css-pivot/axis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/pivottable-css.png)