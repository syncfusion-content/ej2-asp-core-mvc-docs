---
layout: post
title: Data Label in ##Platform_Name## Treemap Component
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Label

Data Labels are used to identify the name of items or groups in the TreeMap component. Data Labels will be shown by specifying the data source properties in the `labelPath` of the `leafItemSettings`.

## Format

Customize the labels for each item using the `labelFormat` property in the `leafItemSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/treemap/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/treemap/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with data label format](images/datalabel/Format.png)

## Template

The template supports customizing labels of each leaf node using the `labelTemplate` property. It uses Essential JS2 template engine to render elements and the position of templates can be customize using the `templatePosition` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap label with template](images/datalabel/Template.png)

## InterSectAction

When the label size in each item exceeds the actual size, use the `interSectAction` property in the `leafItemSettings` to customise the labels.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/intersectaction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Intersectaction.cs" %}
{% include code-snippet/treemap/datalabel/intersectaction/intersectaction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/datalabel/intersectaction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Intersectaction.cs" %}
{% include code-snippet/treemap/datalabel/intersectaction/intersectaction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap label with intersect options](images/datalabel/IntersectAction.png)