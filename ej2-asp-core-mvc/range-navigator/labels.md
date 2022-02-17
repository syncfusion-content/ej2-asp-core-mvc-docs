---
layout: post
title: Labels in ##Platform_Name## Range Navigator Component
description: Learn here all about Labels in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Labels

## Multilevel labels

The multi-level labels for the Range Selector can be enabled by setting the `enableGrouping` property to **true**. This is restricted to the DateTime axis alone.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/multi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/range-navigator/label/multi/multi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/multi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi.cs" %}
{% include code-snippet/range-navigator/label/multi/multi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Multilevel labels](images/labels/multi.png)

## Grouping

The multi-level labels can be grouped using the `groupBy` property with the following interval types:

* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes
* Seconds

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/range-navigator/label/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/range-navigator/label/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Grouping](images/labels/group.png)

## Smart labels

The `labelIntersectAction` property is used to avoid overlapping of labels. The following code sample shows the setting of `labelIntersectAction` property to **Hide**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/smart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smart.cs" %}
{% include code-snippet/range-navigator/label/smart/smart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/smart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smart.cs" %}
{% include code-snippet/range-navigator/label/smart/smart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Smart labels](images/labels/smart.png)

## Label positioning

By default, the labels can be placed outside the Range Selector. It can also be placed inside the Range Selector using the `labelPosition` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/range-navigator/label/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/range-navigator/label/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Label positioning](images/labels/position.png)

## Labels customization

The font size, color, family, etc. can be customized using the `labelStyle` setting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/range-navigator/label/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/label/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/range-navigator/label/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Labels Customization](images/labels/custom.png)