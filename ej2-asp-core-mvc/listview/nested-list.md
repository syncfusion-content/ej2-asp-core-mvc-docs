---
layout: post
title: Nested List in ##Platform_Name## Listview Component
description: Learn here all about Nested List in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Nested List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Nested List

The ListView component supports Nested list. For that, the child property should be defined for the nested list in the array of JSON.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/nested-list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/nested-list/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/nested-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/nested-list/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Nested List](./images/nestedlist.png)
