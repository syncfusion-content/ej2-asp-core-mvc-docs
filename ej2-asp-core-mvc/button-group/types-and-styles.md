---
layout: post
title: Types And Styles in ##Platform_Name## Button Group Control | Syncfusion
description: Learn here all about Types and Styles in Syncfusion ##Platform_Name## Button Group control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Types And Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Types and Styles in Button Group Control

This section explains about different types and styles of ButtonGroup.

## ButtonGroup types

### Outline ButtonGroup

An Outline ButtonGroup has a border with transparent background. To create Outline ButtonGroup, `e-outline` class should be added to the target element and to each button elements using `CssClass` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/types/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/types/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/types/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> ButtonGroup does not have support for `flat` and `round` types.

## ButtonGroup styles

The Essential JS 2 ButtonGroup has the following predefined styles. This can be achieved by adding corresponding class name in each button elements using `CssClass` property.

| Class | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-success | Used to represent a positive action. |
| e-info | Used to represent an informative action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/styles/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/styles/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/styles/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Predefined ButtonGroup styles provide only the visual indication. So, ButtonGroup content should define the ButtonGroup style for the users of assistive technologies such as screen readers.

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupUGSample).

## See also

* [ButtonGroup with icons](./how-to/create-buttongroup-with-icons)
* [Create ButtonGroup with rounded corner](./how-to/create-buttongroup-with-rounded-corner)