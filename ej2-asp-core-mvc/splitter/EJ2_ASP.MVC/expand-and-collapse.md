---
layout: post
title: Expand And Collapse in ##Platform_Name## Splitter Component
description: Learn here all about Expand And Collapse in Syncfusion ##Platform_Name## Splitter component and more.
platform: ej2-asp-core-mvc
control: Expand And Collapse
publishingplatform: ##Platform_Name##
documentation: ug
---


# Expand and Collapse

## Collapsible panes

The Splitter panes can be configured with built-in expand and collapse functionalities. By default, the `Collapsible` behavior is disabled. Enable the `Collapsible` behavior in the [`PaneSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) property to show or hide the expand or collapse icons in the panes. You can dynamically expand and collapse the panes by the corresponding icons.

The following code shows how to enable collapsible behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/expand-collapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/expand-collapse/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/expand-collapse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/expand-collapse/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Execution of above code's output will be as given below,

![Expand Collaspe](./images/expand-collapse.png)

## Programmatically control the expand and collapse action

The Splitter provides public method to control the expand and collapse behavior programmatically using the `expand` and `collapse` methods. Refer to the following code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/expand-collapse-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/expand-collapse-method/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/expand-collapse-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/expand-collapse-method/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Specify initial state to panes

You can render specific panes with collapsed state on page load. Specify a Boolean value to the [`collapsed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) property to control this behavior. The following code explains how to collapse panes on rendering (the second panes renders with collapsed state).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/collapsed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/collapsed/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/collapsed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/collapsed/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Execution of above code's output will be as given below,

![Collapsed](./images/collapsed.png)

## See Also

* [Resizable split panes](./resizing)