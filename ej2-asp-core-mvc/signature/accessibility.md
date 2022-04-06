---
layout: post
title: Accessibility in ##Platform_Name## Signature Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Signature component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

## Keyboard interaction

The following list of keys can be used to interact with the Signature control.

| **Properties** | **Functionality** |
| --- | --- |
| <kbd>Ctrl + Z</kbd>  | Undo the last user action. |
| <kbd>Ctrl + Y</kbd>  | Redo the last user action. |
| <kbd>Ctrl + S</kbd>  | To save the signature. |
| <kbd>delete</kbd>  | Erases all the signature strokes signed by user. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/getting-started/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Signature Sample](./images/default.PNG)
