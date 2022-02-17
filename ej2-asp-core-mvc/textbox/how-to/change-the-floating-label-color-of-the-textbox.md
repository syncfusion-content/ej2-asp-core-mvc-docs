---
layout: post
title: Change The Floating Label Color Of The Textbox in ##Platform_Name## Textbox Component
description: Learn here all about Change The Floating Label Color Of The Textbox in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Change The Floating Label Color Of The Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the floating label color of the TextBox

You can change the floating label color of the TextBox for both `success` and `warning` validation states by applying the following CSS styles.

```CSS

    /* For Success state */
    .e-float-input.e-success label.e-float-text,
    .e-float-input.e-success input:focus ~ label.e-float-text,
    .e-float-input.e-success input:valid ~ label.e-float-text {
        color: #22b24b;
    }

    /* For Warning state */
    .e-float-input.e-warning label.e-float-text,
    .e-float-input.e-warning input:focus ~ label.e-float-text,
    .e-float-input.e-warning input:valid ~ label.e-float-text {
        color: #ffca1c;
    }

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/validation-state/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Validation-state.cs" %}
{% include code-snippet/textbox/how-to/validation-state/validation-state.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/validation-state/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Validation-state.cs" %}
{% include code-snippet/textbox/how-to/validation-state/validation-state.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![textbox](../images/textbox-success.png)