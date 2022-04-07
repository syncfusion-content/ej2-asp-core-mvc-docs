---
layout: post
title: Accessibility in ##Platform_Name## Radio Button Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Radio Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. RadioButton provides built-in compliance with `WAI-ARIA` specifications. `WAI-ARIA` support is achieved through the attributes like `aria-checked` and `aria-disabled`. It helps the people with disabilities by providing information about the widget for assistive technology in the screen readers. RadioButton component contains the `radiobutton` role.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | Indicates the type of input element. |
| aria-disabled | Indicates that the element is perceivable but disabled, so it is not editable or otherwise operable. |


## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Up/Left arrow</kbd></td><td>
Move and select the previous options.</td></tr>
<tr>
<td>
<kbd>Down/Right arrow</kbd></td><td>
Move and select the next options.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/state/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/radio-button/getting-started/state/state.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/state/razor %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/radio-button/getting-started/state/state.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


