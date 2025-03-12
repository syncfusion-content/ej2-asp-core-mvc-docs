---
layout: post
title: Datamatrixgenerator in ##Platform_Name## Barcode Control | Syncfusion
description: Learn here all about Datamatrixgenerator in Syncfusion ##Platform_Name## Barcode control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Datamatrixgenerator
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Matrix generator

## Data Matrix

DataMatrix Barcode is a two dimensional barcode that consists of a grid of dark and light dots or blocks forming square or rectangular symbol. The data encoded in the barcode can either be numbers or alphanumeric. They are widely used in printed media such as labels and letters. You can read it easily with the help of a barcode reader and mobile phones.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/datamatrixgenerator/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/datamatrixgenerator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datamatrixgenerator.cs" %}
{% include code-snippet/barcode/datamatrixgenerator/datamatrixgenerator/datamatrixgenerator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the DataMatrix color

A page or printed media with DataMatrix often appears colorful in the background and surrounding region with other contents. In such cases, the DataMatrix can also be customized to suit the needs. You can achieve this by using the forecolor property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/barcode/datamatrixgenerator/color/color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the DataMatrix dimension

The dimension of the DataMatrix can be changed using the height and width property of the DataMatrix Generator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/dimension/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/dimension/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dimension.cs" %}
{% include code-snippet/barcode/datamatrixgenerator/dimension/dimension.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing the text

In DataMatrix generators, you can customize the DataMatrix text by using the display text property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/text/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/barcode/datamatrixgenerator/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/barcode/datamatrixgenerator/text/text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Barcode/QRCodeandDataMatrixSample).