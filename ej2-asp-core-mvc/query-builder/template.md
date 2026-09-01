---
layout: post
title: Templates in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to customize the Query Builder user interface in ##Platform_Name## using templates such as the header template.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates in ##Platform_Name## Query Builder

## Header Template

The Header Template allows you to define your own user interface for the header, which includes creating or deleting rules and groups and customizing the AND/OR condition and NOT condition options. To implement a header template in the Query Builder, you can create the user interface using the `headerTemplate` property and assign the values when `requestType` is `header-template-create` in the `actionBegin` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/header-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/header-template/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/header-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/header-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

