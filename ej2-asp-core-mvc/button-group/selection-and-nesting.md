---
layout: post
title: Selection And Nesting in ##Platform_Name## Button Group Control | Syncfusion
description: Learn here all about Selection and Nesting in Syncfusion ##Platform_Name## Button Group control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection And Nesting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection and Nesting

## Selection

### Single selection

ButtonGroup supports radio type selection in which only one button can be selected. This can be achieved by adding input element along with `id` attribute with its corresponding label along with `for` attribute inside the target element. In this ButtonGroup, the type of the input element should be `radio` and `e-btn` is added to the `label` element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/radio/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/radio/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/radio/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Multiple selection

ButtonGroup supports checkbox type selection in which multiple button can be selected. This can be achieved by adding input element along with `id` attribute with its corresponding label along with `for` attribute inside the target element. In this ButtonGroup, the type of the input element should be `checkbox` and `e-btn` is added to the `label` element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/checkbox/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/checkbox/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/checkbox/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Nesting

Nesting with other components can be possible in ButtonGroup. The following components can be nested in ButtonGroup.
* DropDownButton
* SplitButton

### DropDownButton

To initialize DropDownButton component refer [DropDownButton Getting Started documentation](https://helpej2.syncfusion.com/aspnetcore/documentation/drop-down-button/getting-started).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/drop-down-button/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/drop-down-button/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/drop-down-button/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### SplitButton

To initialize SplitButton component refer [SplitButton Getting Started documentation](https://ej2.syncfusion.com/aspnetcore/documentation/split-button/getting-started).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/split-button/demo/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/split-button/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/split-button/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupUGSample).

## See also

* [Show ButtonGroup selected state on initial render](./how-to/show-buttongroup-selected-state-on-initial-render)
