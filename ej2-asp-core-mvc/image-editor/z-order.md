---
layout: post
title: Z-order in Image Editor control | Syncfusion
description: Learn here all about Z-order in Syncfusion Image Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Z-order
documentation: ug
domainurl: ##DomainURL##
---

# Z-order in the ##Platform_Name## Image Editor control

We are excited to introduce `z-order` support in the Image Editor. It's a powerful tool that allows users to adjust the positioning of annotations. This feature is particularly useful for designing personalized templates like greeting cards or posters, where managing the layering of multiple annotations is crucial for a polished final product.

Types of adjustment in the Image Editor `z-order` support.

* Sent Backward - Switch the selected annotation with the annotation one layer behind it.

* Send to Back - Move the selected annotation to behind all other annotations.

* Bring to Front - Move the selected annotation to ahead of all other annotations.

* Bring forward - Switch the selected annotation with the annotation one layer ahead of it.

In the following example, you can use the `z-order` support.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/z-order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/z-order/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/z-order/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/z-order/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](images/z-order.png)
