---
layout: post
title: Accessibility in ##Platform_Name## Toast Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The Toast control has been designed with [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications in mind by applying the prompt WAI-ARIA roles, states, and properties with the keyboard support. It helps users who use assistive WAI-ARIA accessibility support, which is achieved using attributes.

It provides information about the elements in a document for assistive technology.

The Toast control implements the keyboard navigation support by using the following [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and is tested in major screen readers.

## ARIA attributes

<!-- markdownlint-disable MD033 -->

| Class | Description |
| -------- | -------- |
| role | <b>alert:</b> <br/>   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Identifies the element as a container when alert content will be added or updated. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/accessibility/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

