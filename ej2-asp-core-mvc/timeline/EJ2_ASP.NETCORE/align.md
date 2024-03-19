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

You can display the Timeline content `Before`, `After`, `Alternate` and `AlternateReverse` by using the [align](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Align) property. The oppositeContent will be displayed parallel to the content when configured in the `TimelineItemModel`.

## Before

In `Before` alignment, for `horizontal` orientation the item content is placed at the top and oppositeContent at the bottom whereas in `vertical`, the content to the left and oppositeContent to the right.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/before/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/before/before.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/before/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/before/before.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Before Alignment](images/align-before.png)

## After

In `After` alignment, for `horizontal` orientation the item content is placed at the bottom and oppositeContent at the top whereas in `vertical`, the content to the right and oppositeContent to the left.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/after/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/after/after.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/after/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/after/after.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![After Alignment](images/align-after.png)

## Alternate

In `Alternate` alignment, the item content are arranged alternatively regardless of the Timeline orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/alternate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/alternate/alternate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/alternate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/alternate/alternate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Alternate Alignment](images/align-alternate.png)

## Alternate reverse

In `AlternateReverse` alignment, the item content are arranged in reverse alternate regardless of the Timeline orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/alternate-reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/alternate-reverse/alternatereverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/align/alternate-reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/align/alternate-reverse/alternatereverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AlternateReverse Alignment](images/align-alternate-reverse.png)
