---
layout: post
title: Adornments in ##Platform_Name## MaskedTextBox control | Syncfusion
description: Learn here all about Adornments in Syncfusion ##Platform_Name## MaskedTextBox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Adornments
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Adornments in ##Platform_Name## MaskedTextBox control

This example highlights adornment support in the Syncfusion MaskedTextBox. Adornments let you place custom elements before or after the masked input by using the `prependTemplate` and `appendTemplate` properties—such as prefixes, suffix labels, or action icons—to provide context, guide entry, and offer quick actions, while preserving mask validation and float label behavior.

## Overview

Adornments are useful for:
- **Entry Guidance**: Add icons/text to hint the expected input (e.g., user icon for username/login)
- **Quick Actions**: Include buttons to submit, clear, or copy the masked value
- **Context Labels**: Add static prefixes/suffixes like country code, domain, or unit suffix
- **Visual Feedback**: Show status indicators without interfering with the mask
- **Float Label Compatibility**: Works seamlessly with `floatLabelType` set to Auto, Always, or Never

## Add adornments to masked textbox

Use [prependTemplate](../api/maskedtextbox/#prependtemplate) and [appendTemplate](../api/maskedtextbox/#appendtemplate) to inject HTML content before and after the masked input respectively. These templates do not alter mask behavior and support any inline HTML or icon.

- **Prepend (Prefix)**: Renders before the masked input.
- **Append (Suffix)**: Renders after the masked input.

## Basic implementation

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/adornments/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/adornments/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![MaskedTextBox](./images/adornments.png)