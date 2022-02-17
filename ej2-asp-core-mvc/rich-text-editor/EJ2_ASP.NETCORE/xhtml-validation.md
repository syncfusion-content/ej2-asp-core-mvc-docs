---
layout: post
title: Xhtml Validation in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Xhtml Validation in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Xhtml Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# XHTML validation

The editor provides an option to validate the source content of the Rich Text Editor against the XHTML standard using the 'enableXhtml' property. When you enter or modify content in the editor, it continuously checks the XHTML source content and removes elements and attributes that are not valid.

The editor checks the following settings on validation:

## Attributes

* Must be specified in lowercase.
* Proper use of quotation marks around the attributes.
* Must be valid attributes for corresponding HTML element.
* All the required attributes must be included in the HTML element.

## HTML Elements

* Must be in lowercase.
* All opening tags must be closed.
* Allows only the valid HTML elements.
* Elements must be properly nested.
* All elements must have one root element.
* Should not use inline elements inside the block elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/xhtml-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/xhtml-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/xhtml-validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/xhtml-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

