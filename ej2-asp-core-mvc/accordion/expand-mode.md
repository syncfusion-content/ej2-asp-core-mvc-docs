---
layout: post
title: Expand Mode in ##Platform_Name## Accordion Control | Syncfusion
description: Learn here all about how to expand mode in Syncfusion ##Platform_Name## Accordion control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Expand Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Expand Mode in ##Platform_Name## Accordion Control

 The Accordion supports the two listed types of expand modes while expanding or collapsing the item.

* Single
* Multiple

## Single

The property enables to expand only one Accordion item at a time. If you expand any new item, the previously expanded one is collapsed and new item changed to expanded state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/expandMode/single/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/expandMode/single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Single.cs" %}
{% include code-snippet/accordion/expandMode/single/single.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Accordion Control with expand mode of single type](images/single.PNG)

## Multiple

Default expand mode of the Accordion is `Multiple`. It enables you to expand more than one Accordion item at a time. Expand or collapse action can also be toggled by clicking on it again. For example, expanded item is collapsed when you click on it again.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/expandMode/multiple/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/expandMode/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/accordion/expandMode/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Accordion Control with expand mode of multiple type](images/multiple.PNG)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Accordion/AccordionUGSamples).

## See also

* [How to keep single pane open always](./how-to/to-keep-single-pane-open-always)