---
layout: post
title: Customize Placeholder Style in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Customize Placeholder Style in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Customize Placeholder Style
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the placeholder style

By using `e-rte-placeholder` class, you can customize the placeholder style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/placeholder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/placeholder/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/placeholder/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

