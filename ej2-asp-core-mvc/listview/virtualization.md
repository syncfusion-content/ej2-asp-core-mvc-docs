---
layout: post
title: Virtualization in ##Platform_Name## Listview Component
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---


# UI Virtualization

UI virtualization loads only viewable list items in a view port, which will improve the ListView performance while loading a large number of data.

## Getting started

UI virtualization can be enabled in the ListView by setting the
[`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Lists.ListView.html#Syncfusion_EJ2_Lists_ListView_EnableVirtualization)
property to true.

It has two types of scrollers as follows:

**Window scroll**: This scroller is used in the ListView by default.

**Container scroll**: This scroller is used, when the height property of the ListView is set.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/flat-list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/flat-list/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/flat-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/flat-list/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Virtualization](./images/virtualization.png)

We can use `template` property to customize list items in UI virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/template/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/template/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Virtualization Template](./images/virtualization-template.png)

## Conditional rendering

The following conditional rendering support is provided for the template and groupTemplate.

| Name | Syntax |
| --- | --- | --- |
| conditional class | `<div class="${ $id % 2 === 0 ? 'even-list' : 'odd-list'}"></div>`  |
| conditional attribute | `<div id="${ $id % 2 === 0 ? 'even-list' : 'odd-list'}"></div>`  |
| conditional text content | `<div>${ $id % 2 === 0 ? 'even-list' : 'odd-list'}</div>`  |

In the following sample, the light blue is applied for the even list and light coral is applied for the odd list based on the conditional class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/conditional-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/conditional-ui/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/virtualization/conditional-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/virtualization/conditional-ui/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Virtualization Conditional](./images/virtualization-conditional.png)
