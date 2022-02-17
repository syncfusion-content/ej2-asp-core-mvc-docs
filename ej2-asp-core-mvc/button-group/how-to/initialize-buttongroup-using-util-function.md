---
layout: post
title: Initialize Buttongroup Using Util Function in ##Platform_Name## Button Group Component
description: Learn here all about Initialize Buttongroup Using Util Function in Syncfusion ##Platform_Name## Button Group component and more.
platform: ej2-asp-core-mvc
control: Initialize Buttongroup Using Util Function
publishingplatform: ##Platform_Name##
documentation: ug
---


# Initialize ButtonGroup using util function

Though, it is a CSS component for easy initialization of ButtonGroup `createButtonGroup` util function can be used.

Using `createButtonGroup` method, the Button options, selector, and cssClass is passed and the corresponding classes is added to the
elements.

## Create basic ButtonGroup

To create a basic ButtonGroup, the target element along with the button elements should be created.

## Create radio type ButtonGroup

To create a radio type ButtonGroup, the target element along with the input elements should be created with type `radio`.

## Create checkbox type ButtonGroup

Checkbox type ButtonGroup creation is similar to radio type ButtonGroup, instead the type of the input elements should be `checkbox`.

The following example illustrates how to create ButtonGroup using `createButtonGroup` method for basic, checkbox, and radio
type behaviors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/basic-util/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/basic-util/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/basic-util/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/basic-util/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If null value is passed in button options, then that particular button will be skipped from processing in `createButtonGroup` util function.