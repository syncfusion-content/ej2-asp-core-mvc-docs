---
layout: post
title: Orientations in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Orientations in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Orientations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Orientations in ##Platform_Name## Timeline control

The `orientation` property in the Timeline control allows you to specify the layout direction of the Timeline.

## Horizontal

The Timeline items can be arranged along a horizontal axis, with each item positioned sequentially from left to right by setting the `orientation` property to `Horizontal`.

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

## Vertical

By setting the `orientation` property to `Vertical`, the timeline items can be arranged from top to bottom manner. By default, the Timeline items are displayed in `vertical` orientation.

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
