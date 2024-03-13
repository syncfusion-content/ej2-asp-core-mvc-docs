---
layout: post
title: Alignment in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Alignment in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Alignment
publishingplatform: ##Platform_Name##
documentation: ug
---

# Alignment in ##Platform_Name## Timeline control

The `align` property in the Timeline control determines how item content is positioned relative to each other within the timeline. The available values are `Before`, `After`, `Alternate` and `AlternateReverse`.

## Before

The `Before` alignment places item content at the top and opposite content at the bottom in `horizontal` orientation whereas in `vertical`, it positions content to the left and opposite content to the right.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## After

The `After` alignment places item content at the bottom and opposite content at the top in `horizontal` orientation whereas in `vertical`, it positions content to the right and opposite content to the left.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Alternate

The `Alternate` option positions item content in an alternating manner where items are arranged in a back-and-forth pattern, regardless of the Timeline's orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Alternate reverse

The `AlternateReverse` option organizes item content in a reverse alternating style providing an alternative method for displaying timeline items, regardless of the Timeline's orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}