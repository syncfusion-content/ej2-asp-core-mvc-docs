---
layout: post
title: Slider-Based Text Selection in Sycnfusion ##Platform_Name## Rich Text Editor Component
description: Learn here all about Slider-Based Text Selection in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Slider-Based Text Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Text Selection Using Slider in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor supports character range-based text selection using the **Syncfusion Slider** control. This feature allows users to select a specific range of characters (e.g., 33–45) within the editor content, which is then automatically highlighted.

This functionality is useful for scenarios where precise text selection is needed for operations such as copying, formatting, or analysis.

> **Note:** The example below assumes the Rich Text Editor contains plain text wrapped in a single `<p>` tag for simplicity.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/selection/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/selection/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
