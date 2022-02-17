---
layout: post
title: Levels in ##Platform_Name## Treemap Component
description: Learn here all about Levels in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Levels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Levels

TreeMap supports **n** number of levels and each level is separated by using the `groupPath` property.

<!-- markdownlint-disable MD036 -->

## Group path

The `groupPath` property is used to separate each level of the TreeMap by specifying the property from the data source.

In the following example, three levels are added and each level is configured using the `groupPath` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/group-path/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group_path.cs" %}
{% include code-snippet/treemap/levels/group-path/group-path.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/group-path/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group_path.cs" %}
{% include code-snippet/treemap/levels/group-path/group-path.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with multiple levels](images/Levels/grouppath.png)

<!-- markdownlint-disable MD036 -->

## Group gap

The `groupGap` property is used to separate an item from each group or another item to differentiate the levels mentioned in the TreeMap.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/group-gap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group_gap.cs" %}
{% include code-snippet/treemap/levels/group-gap/group-gap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/group-gap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group_gap.cs" %}
{% include code-snippet/treemap/levels/group-gap/group-gap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap levels with group gap](images/Levels/groupgap.png)

<!-- markdownlint-disable MD036 -->

## Header format and Alignment

Customize header using the `headerFormat` property in which fields are mapping from the dataSource and align header using the `headerAlignment` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/header-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header_format.cs" %}
{% include code-snippet/treemap/levels/header-format/header-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/header-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header_format.cs" %}
{% include code-snippet/treemap/levels/header-format/header-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header height and style

Customize the font color, family, weight, opacity and size using the `headerStyle`. Based on the font settings, the header height is given using the `headerHeight` property in `levels`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/header-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header_height.cs" %}
{% include code-snippet/treemap/levels/header-height/header-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/header-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header_height.cs" %}
{% include code-snippet/treemap/levels/header-height/header-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header template and position

The TreeMap header supports to customize header of each item using the `headerTemplate` property. It uses Essential JS2 Template engine to render the elements. You can position the template using the `templatePosition` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/levels/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/levels/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/levels/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with customized header](images/Levels/headeralignment.png)