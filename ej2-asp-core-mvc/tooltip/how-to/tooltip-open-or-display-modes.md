---
layout: post
title: Tooltip Open Or Display Modes in ##Platform_Name## Tooltip Component
description: Learn here all about Tooltip Open Or Display Modes in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Tooltip Open Or Display Modes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip open or display modes

The open mode property of tooltip can be defined on a target that is hovering, focusing, or clicking.
Tooltip component have the following types of open mode:

* Auto
* Hover
* Click
* Focus
* Custom

## Auto

Tooltip appears when you hover over the target or when the target element receives the focus.

## Hover

Tooltip appears when you hover over the target.

## Click

Tooltip appears when you click a target element.

## Focus

Tooltip appears when you focus (say through tab key) on a target element.

## Custom

Tooltip is not triggered by any default action. So, bind your own events and use either open or close public methods.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/open-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Open-custom.cs" %}
{% include code-snippet/tooltip/open-custom/open-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/open-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Open-custom.cs" %}
{% include code-snippet/tooltip/open-custom/open-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

