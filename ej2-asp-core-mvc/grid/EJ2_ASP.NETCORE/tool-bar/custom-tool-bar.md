---
layout: post
title: Custom Toolbar in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Custom Toolbar in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Toolbar in ASP.Net Core Grid Component

Custom Toolbar is used to customize the whole toolbar. It can be added by defining `toolbarTemplate`. Actions for this toolbar template items are defined in the `clicked` event in toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-Toolbar.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/custom-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-Toolbar.cs" %}
{% include code-snippet/grid/toolbar/custom-toolbar/custom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
