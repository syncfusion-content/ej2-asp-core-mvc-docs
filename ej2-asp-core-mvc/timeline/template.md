---
layout: post
title: Template in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Template in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ##Platform_Name## Timeline control

The Timeline control allows you to customize the look and information displayed for each item, providing a unique experience for users. This customization is achieved using the `template` property, where you can define the content you want to show within each timeline item.

The template receives two pieces of information within its context:

| Type | Purpose |
| --- | --- |
| `item` | Represents the data specific to the particular timeline item. |
| `currentItem` | Indicates the current index of the timeline item. |

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