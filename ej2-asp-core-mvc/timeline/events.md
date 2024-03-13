---
layout: post
title: Events in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Events in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Timeline control

This section describes the Timeline events that will be triggered when an appropriate actions are performed. The following events are available in the Timeline control.


## created

The `created` event is triggered when the Timeline control is created and fully initialized.

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

## beforeItemRender

The `beforeItemRender` event is fired before each item is rendered in Timeline control. By utilizing this, you can modify the appearance or content of the items based on specific conditions.

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