---
layout: post
title: Leaf Item in ##Platform_Name## Treemap Component
description: Learn here all about Leaf Item in Syncfusion ##Platform_Name## Treemap component and more.
platform: ej2-asp-core-mvc
control: Leaf Item
publishingplatform: ##Platform_Name##
documentation: ug
---

# Leaf Item

A leaf item defines a visualized data element and does not contain child nodes but contains parent node if the levels are specified in the TreeMap.

## Leaf label

Label is represented by item name or value. Label will be appeared by specifying the `labelPath` property and customize the label style using the `labelStyle` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/leaflabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Leaflabel.cs" %}
{% include code-snippet/treemap/leafitem/leaflabel/leaflabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/leaflabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Leaflabel.cs" %}
{% include code-snippet/treemap/leafitem/leaflabel/leaflabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with leaf item](images/LeafItem/LeafLabel.png)

<!-- markdownlint-disable MD036 -->

### Label position and format

Positioning the leaf item label using the `labelPosition` property and the text format can be customized by specifying data source properties name in the `labelFormat` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/treemap/leafitem/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/treemap/leafitem/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with label position and format](images/LeafItem/LabelFormat.png)

<!-- markdownlint-disable MD036 -->

### Label template and position

Specifies the template of leaf item label and position of the template to be customized using `labelTemplate` and `templatePosition` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/leafitem/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/treemap/leafitem/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TreeMap with leaf item template](images/LeafItem/TemplatePosition.png)

<!-- markdownlint-disable MD036 -->

## Item gap

The `gap` property is used to separate an item from another item. Each item rectangle is split into equal space with specified gap.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/gap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/treemap/leafitem/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treemap/leafitem/gap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/treemap/leafitem/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Gap in TreeMap item](images/LeafItem/itemgap.png)