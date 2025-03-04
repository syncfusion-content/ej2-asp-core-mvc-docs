---
layout: post
title: Integrating Syncfusion Rich Text Editor in Tab in ##Platform_Name## Rich Text Editor Control
description: Integrating Rich Text Editor in Tab in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integrating Rich Text Editor in Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrating Rich Text Editor in Tab Control

Integrating a Rich Text Editor within Tab control provides a versatile and organized user interface for text formatting and content creation across multiple tabs.  Each tab instance includes a dedicated editor instance configured with extensive toolbar options, enabling users to effortlessly manipulate text styles, apply formatting, insert media, and manage content layout.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/richtexteditor-inside-tab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/richtexteditor-inside-tab/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/richtexteditor-inside-tab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/richtexteditor-inside-tab/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}