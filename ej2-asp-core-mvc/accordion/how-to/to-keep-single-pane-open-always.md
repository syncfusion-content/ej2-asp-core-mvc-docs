---
layout: post
title: To Keep Single Pane Open Always in ##Platform_Name## Accordion Component
description: Learn here all about To Keep Single Pane Open Always in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: To Keep Single Pane Open Always
publishingplatform: ##Platform_Name##
documentation: ug
---


# To keep single pane open always

By default, all Accordion panels are collapsible. You can customize the Accordion to keep one panel as expanded state always. This is applicable for `Single` expand mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/openalways/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Openalways.cs" %}
{% include code-snippet/accordion/how-to/openalways/openalways.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/openalways/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Openalways.cs" %}
{% include code-snippet/accordion/how-to/openalways/openalways.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

