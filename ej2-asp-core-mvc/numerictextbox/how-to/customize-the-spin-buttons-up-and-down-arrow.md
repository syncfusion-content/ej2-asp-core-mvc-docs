---
layout: post
title: Customize The Spin Buttons Up And Down Arrow in ##Platform_Name## Numerictextbox Component
description: Learn here all about Customize The Spin Buttons Up And Down Arrow in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Customize The Spin Buttons Up And Down Arrow
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the spin button’s up and down arrow

This section explains about how to change/customize spin up and down icons. You can customize spin button icons using `e-spin-up` and `e-spin-down`
classes of those buttons.

You can override the default icons of `e-spin-up` and `e-spin-down` classes using the following CSS code snippets.

```css
  .e-numeric .e-input-group-icon.e-spin-up:before {
    content: "\e823";
    color: rgba(0, 0, 0, 0.54);
  }
  .e-numeric .e-input-group-icon.e-spin-down:before {
    content: "\e934";
    color: rgba(0, 0, 0, 0.54);
  }
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/buttons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buttons.cs" %}
{% include code-snippet/numeric-textbox/how-to/buttons/buttons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/buttons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buttons.cs" %}
{% include code-snippet/numeric-textbox/how-to/buttons/buttons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/buttons.png)