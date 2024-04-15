---
layout: post
title: Floating Label with ##Platform_Name## Textarea control | Syncfusion
description: Checkout and learn about Floating Label with ##Platform_Name## Textarea control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Floating Label
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Floating Label in ##Platform_Name## TextArea Control

The floating label functionality in the TextArea control allows the placeholder text to float above the TextArea while the user interacts with it, providing a more intuitive user experience. This feature can be achieved using the [FloatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextArea.html#Syncfusion_EJ2_Inputs_TextArea_FloatLabelType) API, which offers various options for defining the floating behavior:

| Type  | Description |
| -- | -- |
| Auto  | The label floats above the TextArea when it receives focus or input, returning to its initial position when the TextArea loses focus and contains no value. |
| Always | The label always remains floating above the TextArea, regardless of user interaction. |
| Never | The label never floats; it remains in its default position within the TextArea. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/label/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/label/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textarea](./images/textarea-float-label.png)

## Placeholder with localization

Localization library allows to localize the placeholder text of the TextArea to different cultures using the `Locale` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/localization1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/localization1/localization1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/localization1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/localization1/localization1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![textarea](./images/textarea-localization1.png)

To load translation object in an application use `load` function of `L10n` class.
In the below sample, `German` culture is loaded to the TextArea placeholder text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/localization2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/localization2/localization2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textarea/floating-label/localization2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear.cs" %}
{% include code-snippet/textarea/floating-label/localization2/localization2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
